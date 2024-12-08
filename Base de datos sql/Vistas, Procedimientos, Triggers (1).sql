--Vistas*********************************************************************************************************
--Calcula las ganancias que se pueden obtener de los eventos:*

CREATE VIEW TotalEventosNoFinalizadosMesActual AS
SELECT 
    ISNULL(SUM(Costo_total), 0) AS MontoTotalPendiente
FROM Eventos
WHERE MONTH(Fecha_inicio) = MONTH(GETDATE())    -- Mes del evento es el mes actual
  AND YEAR(Fecha_inicio) = YEAR(GETDATE())     -- Año del evento es el año actual
  AND Fecha_inicio >= GETDATE();               -- Evento no ha finalizado

--Muestre el mes en que se demanda mas eventos*
CREATE VIEW vw_ReservacionesPorMes AS
SELECT TOP 100 PERCENT
    MONTH(Fecha_reserva) AS Mes, 
    YEAR(Fecha_reserva) AS Año, 
    COUNT(*) AS Cantidad_Reservas
FROM 
    Eventos
GROUP BY 
    YEAR(Fecha_reserva),
    MONTH(Fecha_reserva)
ORDER BY 
    YEAR(Fecha_reserva),
    MONTH(Fecha_reserva);
GO


--Muestra q mes gnera mas resrevas en terminos de dinero*
ALTER VIEW vw_IngresosFinalizadosPorMes AS
SELECT 
    YEAR(E.Fecha_reserva) AS Año,
    MONTH(E.Fecha_reserva) AS Mes,
    SUM(E.Costo_total) AS IngresosMensuales
FROM 
    Eventos E
JOIN 
    (SELECT Id_evento, SUM(Monto) AS TotalPagado 
     FROM Pagos 
     GROUP BY Id_evento
     HAVING SUM(Monto) = (SELECT Costo_total FROM Eventos WHERE Id_evento = Pagos.Id_evento)) P
ON E.Id_evento = P.Id_evento
WHERE 
    E.Estado = 'Finalizado'
GROUP BY 
    YEAR(E.Fecha_reserva), 
    MONTH(E.Fecha_reserva);
GO


--Ver q empleados estan dicponibles*
ALTER VIEW vw_EmpleadosDisponibles AS
SELECT 
    E.Id_empleado,
    E.Nombre,
    E.Apellido,
    E.Telefono,
    E.Email
FROM 
    Empleados E
JOIN 
    Estado_Empleado EE ON E.Estado_Empleado = EE.Id_estado
WHERE 
    EE.Tipo_estado = 'Disponible';
GO

--Funciones*************************************************************************************************************
--Calcula el pago restante de cada evento
CREATE FUNCTION dbo.CalcularPagoRestante (
    @IdEvento INT
)
RETURNS MONEY
AS
BEGIN
    DECLARE @CostoTotal MONEY;
    DECLARE @TotalPagos MONEY;

    -- Obtener el costo total del evento
    SELECT @CostoTotal = Costo_total
    FROM Eventos
    WHERE Id_evento = @IdEvento;

    -- Sumar todos los pagos realizados para el evento
    SELECT @TotalPagos = ISNULL(SUM(Monto), 0)
    FROM Pagos
    WHERE Id_evento = @IdEvento;

    -- Calcular y devolver el pago restante
    RETURN ISNULL(@CostoTotal, 0) - ISNULL(@TotalPagos, 0);
END;

--Consultar el paqute mas demnadado en el mes actual
CREATE FUNCTION fn_PaquetesMasDemandados ()
RETURNS TABLE
AS
RETURN
(
    SELECT 
        P.Nombre_paquete,
        COUNT(E.Id_evento) AS Cantidad_Reservas
    FROM 
        Paquetes P
    JOIN 
        Eventos E ON P.Id_paquete = E.Id_paquete
    WHERE 
        MONTH(E.Fecha_reserva) = MONTH(GETDATE())
        AND YEAR(E.Fecha_reserva) = YEAR(GETDATE())
    GROUP BY 
        P.Nombre_paquete
);
GO

--Procesos Almacenados******************************************************************************************
--Asigna Empleados Disponibles a un Evento
ALTER PROCEDURE asignar_empleado_disponible 
    @p_evento_id INT,        -- ID del evento al que se asignará el empleado
    @p_empleado_id INT,      -- ID del empleado que se quiere asignar
    @p_rol_id INT            -- ID del rol que desempeñará el empleado
AS
BEGIN
    -- Manejo de errores
    BEGIN TRY
        DECLARE @empleado_disponible BIT;

        -- Verificar si el empleado está disponible (no tiene eventos en el futuro o en curso)
        SELECT 
            @empleado_disponible = CASE 
                WHEN EXISTS (
                    SELECT 1
                    FROM Rol_Empleado_Evento RE
                    JOIN Eventos E ON RE.Id_evento = E.Id_evento
                    WHERE RE.Id_empleado = @p_empleado_id
                      AND E.Fecha_inicio >= CAST(GETDATE() AS DATE) -- Eventos en el futuro o en curso
                ) THEN 0
                ELSE 1
            END;

        -- Si está disponible, asignar al empleado al evento
        IF @empleado_disponible = 1
        BEGIN
            INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
            VALUES (@p_evento_id, @p_empleado_id, @p_rol_id);
        END
        ELSE
        BEGIN
            -- Lanza un error si el empleado no está disponible
            RAISERROR ('El empleado no está disponible porque tiene eventos futuros o en curso.', 16, 1);
        END
    END TRY
    BEGIN CATCH
        -- Manejo de errores en caso de fallo
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR (@ErrorMessage, 16, 1);
    END CATCH
END;
GO

--Triggers------------------------------------------------------------------------------------------------------
--Evitar asignar a un empelado que ya tiene evento el mismo dia
CREATE TRIGGER prevent_same_day_employee_assignment
ON Rol_Empleado_Evento
INSTEAD OF INSERT
AS
BEGIN
    -- Verificar si el empleado ya tiene asignado un evento el mismo día
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN Eventos E ON i.Id_evento = E.Id_evento
        JOIN Rol_Empleado_Evento RE ON RE.Id_evento = E.Id_evento
        WHERE RE.Id_empleado = i.Id_empleado
          AND E.Fecha_inicio = (SELECT Fecha_inicio FROM Eventos WHERE Id_evento = i.Id_evento)
    )
    BEGIN
        -- Generar un error para evitar la inserción
        RAISERROR ('El empleado ya está asignado a otro evento en el mismo día.', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        -- Realizar la inserción si no hay conflictos
        INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
        SELECT Id_evento, Id_empleado, Id_rol
        FROM inserted;
    END
END;

--Actualiza los paquetes para su disponibilidad------------------------
--Cuanbdo se usa un paquete-------
CREATE TRIGGER trg_RestarCantidadPaquete
ON Eventos
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Id_paquete INT;

    -- Obtener el Id_paquete de la tabla inserted
    SELECT @Id_paquete = Id_paquete
    FROM inserted;

    -- Verificar que el Id_paquete no sea nulo
    IF @Id_paquete IS NOT NULL
    BEGIN
        -- Restar 1 a la cantidad del paquete
        UPDATE Paquetes
        SET Cantidad = Cantidad - 1
        WHERE Id_paquete = @Id_paquete;

        -- Actualizar la disponibilidad si la cantidad es 0
        UPDATE Paquetes
        SET Disponibilidad = 0
        WHERE Id_paquete = @Id_paquete AND Cantidad = 0;
    END
END;
GO

--Cuando se deja de usar el paquete
ALTER TRIGGER trg_AumentarCantidadPaquete
ON Eventos
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Id_paquete INT, @Estado NVARCHAR(20);

    -- Obtener el Id_paquete y el Estado del evento actualizado
    SELECT @Id_paquete = Id_paquete, @Estado = Estado
    FROM inserted;

    -- Verificar que el Id_paquete no sea nulo y que el estado sea 'Finalizado' o 'Cancelado'
    IF @Id_paquete IS NOT NULL AND (@Estado = 'Finalizado' OR @Estado = 'Cancelado')
    BEGIN
        -- Aumentar 1 a la cantidad del paquete
        UPDATE Paquetes
        SET Cantidad = Cantidad + 1
        WHERE Id_paquete = @Id_paquete;

        -- Actualizar la disponibilidad si la cantidad es mayor a 0
        UPDATE Paquetes
        SET Disponibilidad = 1
        WHERE Id_paquete = @Id_paquete AND Cantidad > 0;
    END
END;
GO


-- Actualizar el estado del evento relacionado al pago recién insertado
ALTER TRIGGER trg_ActualizarEstadoEvento
ON Pagos
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar el estado del evento relacionado al pago recién insertado o modificado
    UPDATE Eventos
    SET Estado = 
        CASE 
            -- Si el monto total pagado es menor al 50% del costo total y no se cumplió el plazo de reserva, sigue como Pendiente
            WHEN ISNULL(SumaPagos, 0) < (0.5 * Costo_total) AND GETDATE() <= DATEADD(DAY, 7, Fecha_reserva) THEN 'Pendiente'

            -- Si se alcanza el 50% del pago dentro de la semana después de la reserva, marcar como Reservado
            WHEN ISNULL(SumaPagos, 0) >= (0.5 * Costo_total) AND GETDATE() <= DATEADD(DAY, 7, Fecha_reserva) THEN 'Reservado'

            -- Si no se ha alcanzado el monto total y se está en el plazo (un día antes del evento), sigue como Incompleto
            WHEN ISNULL(SumaPagos, 0) < Costo_total AND GETDATE() < DATEADD(DAY, -1, Fecha_inicio) THEN 'Incompleto'

            -- Si se paga el monto total antes del evento, marcar como Saldado
            WHEN ISNULL(SumaPagos, 0) = Costo_total AND GETDATE() <= DATEADD(DAY, -1, Fecha_inicio) THEN 'Saldado'

            -- Si el evento ya pasó y el monto no está completo, sigue siendo Incompleto
            WHEN ISNULL(SumaPagos, 0) < Costo_total AND GETDATE() > Fecha_inicio THEN 'Incompleto'

            -- Si el evento ya pasó y el monto total fue pagado, marcar como Finalizado
            WHEN ISNULL(SumaPagos, 0) = Costo_total AND GETDATE() > Fecha_inicio THEN 'Finalizado'

            -- Estado por defecto si ninguna condición se cumple
            ELSE Estado
        END
    FROM Eventos e
    INNER JOIN (
        -- Sumar los pagos relacionados al evento
        SELECT 
            Id_evento, 
            SUM(Monto) AS SumaPagos
        FROM Pagos
        GROUP BY Id_evento
    ) p ON e.Id_evento = p.Id_evento
    INNER JOIN Inserted i ON i.Id_evento = e.Id_evento;

END;
GO

--Cancelat eventos que no han sido abonados en nada para resrevar
ALTER TRIGGER TRG_ActualizarEstadoEventosPendientes
ON Pagos
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Definir la fecha límite para el corte de pagos
        DECLARE @FechaCorte DATE = DATEADD(DAY, -7, GETDATE());

        -- Actualizar el estado de todos los eventos que cumplan con las condiciones para ser cancelados
        UPDATE Eventos
        SET Estado = 'Cancelado'
        WHERE Estado = 'Pendiente'  -- Solo eventos en estado pendiente
          AND Fecha_reserva <= @FechaCorte -- Que hayan pasado la fecha límite de reserva
          AND NOT EXISTS (
              SELECT 1
              FROM Pagos
              WHERE Pagos.Id_evento = Eventos.Id_evento
                AND Pagos.Monto >= 0.5 * Eventos.Costo_total -- Que no hayan recibido al menos el 50% del costo
          );

        COMMIT TRANSACTION;

    END TRY
    BEGIN CATCH
        -- Manejo de errores: Revertir la transacción en caso de fallo
        ROLLBACK TRANSACTION;
        PRINT 'Error al actualizar el estado de los eventos.';
        THROW; -- Relanzar el error para facilitar la depuración
    END CATCH;
END;
GO

-- Crear Trigger para cambiar el estado del empleado a 'En evento' cuando se asigne a un evento
ALTER TRIGGER trg_AsignarEmpleadoEnEvento
ON Rol_Empleado_Evento
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar el estado del empleado a 'En evento'
    UPDATE Empleados
    SET Estado_Empleado = (SELECT Id_estado FROM Estado_Empleado WHERE Tipo_estado = 'En evento')
    FROM Empleados E
    JOIN inserted I ON E.Id_empleado = I.Id_empleado;
END;
GO

-- Crear Trigger para cambiar el estado del empleado a 'Disponible' cuando el evento finaliza o se cancela
ALTER TRIGGER trg_EventoFinalizadoOCancelado
ON Eventos
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(Estado)
    BEGIN
        -- Actualizar el estado del empleado a 'Disponible' si el evento se finaliza o cancela
        UPDATE Empleados
        SET Estado_Empleado = (SELECT Id_estado FROM Estado_Empleado WHERE Tipo_estado = 'Disponible')
        FROM Empleados E
        JOIN Rol_Empleado_Evento REE ON E.Id_empleado = REE.Id_empleado
        JOIN inserted I ON REE.Id_evento = I.Id_evento
        WHERE I.Estado IN ('Finalizado', 'Cancelado');
    END
END;
GO