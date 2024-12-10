CREATE DATABASE DB_TeamSmile_ShowInfantil;

USE DB_TeamSmile_ShowInfantil;

-- Entidades

-- 1. Tabla Clientes
-- Almacena información de cada cliente que realiza una reservación.
CREATE TABLE Clientes (
    Id_cliente INT IDENTITY(1,1) PRIMARY KEY,          -- Identificador único de cada cliente.
    Nombre VARCHAR(100) NOT NULL,                      -- Nombre del cliente.
    Apellido VARCHAR(100) Not Null,                    -- Apellido del cliente.
    Telefono VARCHAR(20) Not Null,                     -- Teléfono de contacto del cliente.
    Correo_electronico VARCHAR(100),                   -- Correo electrónico del cliente.
	CONSTRAINT UC_Correo UNIQUE (Correo_electronico),  -- Restringe correos duplicados.
	CONSTRAINT UC_Telefono UNIQUE (Telefono)           -- Restringe telefonos duplicados.
);

-- 2. Tabla Paquetes
-- Define los distintos paquetes de servicios que se pueden ofrecer para eventos.
CREATE TABLE Paquetes (
    Id_paquete INT IDENTITY(1,1) PRIMARY KEY,          -- Identificador único del paquete.
    Nombre_paquete VARCHAR(100) NOT NULL,              -- Nombre descriptivo del paquete.
    Descripcion VARCHAR(MAX),                                  -- Detalles del paquete.
	Cantidad Int,									   --Detalla la cantidad de veces que se puede oferta un mismo paquetes de manera simultanea
    Disponibilidad BIT NOT NULL,                       -- Disponibilidad (1 = Disponible, 0 = No disponible).
    Costo DECIMAL(18, 2) NOT NULL,                     -- Costo total del paquete.
	CONSTRAINT CHK_Cantidad CHECK (Cantidad >= 0),     --Asegura que un paquete no tenga cantidades negativas
	CONSTRAINT CHK_Costo CHECK (Costo > 0)             --Asegura que un paquete no tenga cantidades negativas
);

-- 3. Tabla Eventos
-- Representa los eventos reservados, que pueden incluir un paquete y otros servicios.
CREATE TABLE Eventos (
    Id_evento INT IDENTITY(1,1) PRIMARY KEY,           -- Identificador único del evento.
	Id_paquete INT,                                    -- Relación con un paquete opcional.
    Id_cliente INT NOT NULL,                           -- Relación con el cliente que organiza el evento.
	Fecha_reserva DATE NOT NULL,                       -- Fecha en que se realiza la reservación.
    Fecha_inicio DATE NOT NULL,                        -- Fecha de inicio del evento.
    Hora_inicio TIME NOT NULL,                         -- Hora de inicio del evento.
    Hora_fin TIME NOT NULL,                            -- Hora de finalización del evento.
    Ubicacion VARCHAR(255) Not Null,                   -- Ubicación o lugar donde se realiza el evento.(Departamento)
    Direccion VARCHAR(MAX) Not Null,                           -- Dirección completa de la ubicación.
    Cantidad_de_asistentes INT Not Null,               -- Número de asistentes al evento.
    Detalles_adicionales VARCHAR(MAX),                         -- Descripción adicional del evento.
    Costo_total DECIMAL(18, 2) NOT NULL,               -- Costo total de la reservación.
	Estado Varchar(20) Not Null DEFAULT 'Pendiente',   --Detalla el estado de evento. (Cancelado, Incompleto, Reservado, Pendiente, Finalizado)
	CONSTRAINT CHK_Fecha_Hora_Evento CHECK (Fecha_inicio > Fecha_reserva AND Hora_fin > Hora_inicio), -- Asegura que la fecha de inicio sea posterior a la de reserva y que la hora de fin sea posterior a la de inicio
	CONSTRAINT CHK_Cantidad_Asistentes CHECK (Cantidad_de_asistentes > 0),  --Asegura que la cantidad de asistentes no sea 0
	CONSTRAINT CHK_Precio_del_Paquete CHECK (Costo_total > 0),   --Asegura que el costo del paqute no sea 0
	CONSTRAINT FK_Eventos_Clientes FOREIGN KEY (Id_cliente) REFERENCES Clientes(Id_cliente),
    CONSTRAINT FK_Evento_Paquete FOREIGN KEY (Id_paquete) REFERENCES Paquetes(Id_paquete)
);

-- 4. Tabla Servicios
-- Almacena los servicios individuales que se pueden incluir en paquetes o eventos personalizados.
CREATE TABLE Servicios (
    Id_servicio INT IDENTITY(1,1) PRIMARY KEY,         -- Identificador único del servicio.
    Nombre_servicio VARCHAR(100) NOT NULL,             -- Nombre del servicio.
    Descripcion VARCHAR(MAX),                                  -- Descripción del servicio.
    Costo DECIMAL(18, 2) NOT NULL                      -- Costo unitario del servicio.
	CONSTRAINT CHK_Costo_Servicio CHECK (Costo > 0),      --Asegura que el costo del servicio no sea 0
);

-- 5. Tabla Pagos
-- Almacena los pagos realizados para cada reservación.
CREATE TABLE Pagos (
    Id_pago INT IDENTITY(1,1) PRIMARY KEY,             -- Identificador único del pago.
    Id_evento INT NOT NULL,                            -- Relación con la reservación a la cual pertenece el pago.
    Monto DECIMAL(18, 2) NOT NULL,                     -- Monto del pago realizado.
    Fecha_pago DATE NOT NULL,                          -- Fecha en que se realizó el pago.
    Metodo_pago VARCHAR(50) Not null,                  -- Método de pago (Tarjeta, Transferencia, Efectivo).
    CONSTRAINT CHK_Costo_total CHECK (Monto > 0),      --Asegura que los pagos no sea 0
    CONSTRAINT FK_Pagos_ReservacionEvento FOREIGN KEY (Id_evento) REFERENCES Eventos(Id_evento)
);

--6.1 Tabla Estados del Empleado
--Muestra los posibes estado del empelado en la empresa siempre cuando este activo
CREATE TABLE Estado_Empleado (
    Id_estado INT IDENTITY(1,1) PRIMARY KEY,       -- Identificador único del estado del empleado.
    Tipo_estado VARCHAR(50) NOT NULL               -- Tipo de estado (por ejemplo: En evento, Incapacidad laboral, Disponible, No disponible).
);


-- 6. Tabla Empleados
-- Registra a los empleados que participan en los eventos.
CREATE TABLE Empleados (
    Id_empleado INT IDENTITY(1,1) PRIMARY KEY,         -- Identificador único del empleado.
    Nombre VARCHAR(100) NOT NULL,                      -- Nombre del empleado.
    Apellido VARCHAR(100) NOT NULL,                    -- Apellido del empleado.
    Telefono VARCHAR(20)  Not Null,                    -- Teléfono de contacto del empleado.
    Email VARCHAR(100) Not null,                       -- Correo electrónico del empleado.
    Estado_Empleado INT NOT NULL DEFAULT 1,
	CONSTRAINT UC_Email UNIQUE (Email),                -- Restringe correos duplicados.
	CONSTRAINT UC_telefono_Empleado UNIQUE (Telefono),  -- Restringe telefonos duplicados.
    CONSTRAINT FK_Empleados_Estado_Empleado FOREIGN KEY (Estado_Empleado) REFERENCES Estado_Empleado(Id_estado)
);




-- 7. Tabla Cargos
-- Define la accebilidad que tiene el usuario al programa.
CREATE TABLE Cargos (
    Id_cargo INT IDENTITY(1,1) PRIMARY KEY,              -- Identificador único del rol.
    Nombre_cargo VARCHAR(100) NOT NULL,                  -- Nombre del rol (Administrador, Gerente, Empleado).
	Descripción VARCHAR(MAX)						 --Indica la accesibilidad que tiene el usuario al programa(1 = Tiene Acceso, 0= No tiene Acceso)
);

-- 8.Tabla Usuarios
-- Almacena la información de acceso al sistema para empleados u otros usuarios.
CREATE TABLE Usuarios (
    Id_usuario INT IDENTITY(1,1) PRIMARY KEY,       -- Identificador único del usuario.
    Id_empleado INT NOT NULL,                       -- Relación con la tabla de empleados.
	Id_Cargo Int Not null,							--Cargo Administrativo que posee el usuario para determinar su accesibilidad al programa
    Nombre_usuario VARCHAR(50) NOT NULL,            -- Nombre de usuario para inicio de sesión.
    Contraseña VARCHAR(255) NOT NULL,               -- Contraseña del usuario (encriptada).
    Estado BIT NOT NULL DEFAULT 1,                  -- Indica si el usuario está activo (1 = Activo, 0 = Inactivo).
    CONSTRAINT UC_NombreUsuario UNIQUE (Nombre_usuario), -- Evita duplicidad de nombres de usuario.
    CONSTRAINT FK_Usuarios_Empleados FOREIGN KEY (Id_empleado) REFERENCES Empleados(Id_empleado),
    CONSTRAINT FK_Usuarios_Cargos FOREIGN KEY (Id_Cargo) REFERENCES Cargos(Id_cargo)
);

-- 9. Tabla Utileria
-- Almacena los elementos de utilería disponibles para los eventos.
CREATE TABLE Utileria (
    Id_utileria INT IDENTITY(1,1) PRIMARY KEY,         -- Identificador único de la utilería.
    Nombre VARCHAR(100) Not Null,                      -- Nombre de la utilería (por ejemplo, "Globos").
    Cantidad INT,                                      -- Cantidad disponible de cada tipo de utilería.
	CONSTRAINT CHK_Cantidad_Positive CHECK (Cantidad >= 0) -- Restricción que asegura cantidades no negativas.
);

-- 10. Tabla Roles
-- Define los roles desempeñados por los empleados en los eventos.
CREATE TABLE Roles (
    Id_rol INT IDENTITY(1,1) PRIMARY KEY,              -- Identificador único del rol.
    Nombre_rol VARCHAR(100) NOT NULL,                  -- Nombre del rol (por ejemplo, "Decorador").
    Descripcion VARCHAR(MAX)                                   -- Descripción del rol.
);

-- Relaciones

-- 11. Tabla intermedia Evento_Servicios para relación muchos a muchos entre Eventos y Servicios
-- Asocia servicios específicos a eventos personalizados.
CREATE TABLE Evento_Servicios (
	Id_evento_servicios INT IDENTITY(1,1) PRIMARY KEY, -- Identificador único de la relación evento-servicio.
    Id_evento INT NOT NULL,                            -- Relación con el evento.
    Id_servicio INT NOT NULL,                          -- Relación con el servicio.tan lindo usted
    CONSTRAINT FK_Evento_Servicios_Eventos FOREIGN KEY (Id_evento) REFERENCES Eventos(Id_evento),
    CONSTRAINT FK_Evento_Servicios_Servicios FOREIGN KEY (Id_servicio) REFERENCES Servicios(Id_servicio)
);

-- 12. Tabla intermedia Paquete_Servicios para relación muchos a muchos entre Paquetes y Servicios
-- Asocia servicios específicos a paquetes de eventos.
CREATE TABLE Paquete_Servicios (
    Id_paquete_servicios INT IDENTITY(1,1) PRIMARY KEY, -- Identificador único de la relación paquete-servicio.
    Id_paquete INT NOT NULL,                            -- Relación con el paquete.
    Id_servicio INT NOT NULL,                           -- Relación con el servicio.
    CONSTRAINT FK_Paquete_Servicios_Paquetes FOREIGN KEY (Id_paquete) REFERENCES Paquetes(Id_paquete),
    CONSTRAINT FK_Paquete_Servicios_Servicios FOREIGN KEY (Id_servicio) REFERENCES Servicios(Id_servicio)
);

-- 13. Tabla Servicio_Utileria para relación entre Servicios y Utileria
-- Asocia los elementos de utilería con los servicios que los requieren.
CREATE TABLE Servicio_Utileria (
    Id_servicio_utileria INT IDENTITY(1,1) PRIMARY KEY, -- Identificador único de la relación servicio-utilería.
    Id_servicio INT NOT NULL,                           -- Relación con el servicio.
    Id_utileria INT NOT NULL,                           -- Relación con la utilería.
    CONSTRAINT FK_Servicio_Utileria_Servicio FOREIGN KEY (Id_servicio) REFERENCES Servicios(Id_servicio),
    CONSTRAINT FK_Servicio_Utileria_Utileria FOREIGN KEY (Id_utileria) REFERENCES Utileria(Id_utileria)
);

-- 14. Tabla intermedia Rol_Empleado_Evento para relación muchos a muchos entre Empleados y Eventos
-- Asocia empleados con sus roles específicos en cada evento.
CREATE TABLE Rol_Empleado_Evento (
    Id_rol_empleado_evento INT IDENTITY(1,1) PRIMARY KEY, -- Identificador único de la relación rol-empleado-evento.
    Id_evento INT NOT NULL,                               -- Relación con el evento.
    Id_empleado INT NOT NULL,                             -- Relación con el empleado.
    Id_rol INT NOT NULL,                                  -- Relación con el rol del empleado en el evento.
    CONSTRAINT FK_Rol_Empleado_Evento_Eventos FOREIGN KEY (Id_evento) REFERENCES Eventos(Id_evento),
    CONSTRAINT FK_Rol_Empleado_Evento_Empleados FOREIGN KEY (Id_empleado) REFERENCES Empleados(Id_empleado),
    CONSTRAINT FK_Rol_Empleado_Evento_Roles FOREIGN KEY (Id_rol) REFERENCES Roles(Id_rol)
);

---------------------------------------------------------------------------------------------------------------------------------------------------------------
