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

-- 6. Tabla Empleados
-- Registra a los empleados que participan en los eventos.
CREATE TABLE Empleados (
    Id_empleado INT IDENTITY(1,1) PRIMARY KEY,         -- Identificador único del empleado.
    Nombre VARCHAR(100) NOT NULL,                      -- Nombre del empleado.
    Apellido VARCHAR(100) NOT NULL,                    -- Apellido del empleado.
    Telefono VARCHAR(20)  Not Null,                    -- Teléfono de contacto del empleado.
    Email VARCHAR(100) Not null,                       -- Correo electrónico del empleado.
    Estado_Empleado INT NOT NULL DEFAULT 3,
	CONSTRAINT UC_Email UNIQUE (Email),                -- Restringe correos duplicados.
	CONSTRAINT UC_telefono_Empleado UNIQUE (Telefono),  -- Restringe telefonos duplicados.
    CONSTRAINT FK_Empleados_Estado_Empleado FOREIGN KEY (Estado_Empleado) REFERENCES Estado_Empleado(Id_estado)
);

--6.1 Tabla Estados del Empleado
--Muestra los posibes estado del empelado en la empresa siempre cuando este activo
CREATE TABLE Estado_Empleado (
    Id_estado INT IDENTITY(1,1) PRIMARY KEY,       -- Identificador único del estado del empleado.
    Tipo_estado VARCHAR(50) NOT NULL               -- Tipo de estado (por ejemplo: En evento, Incapacidad laboral, Disponible, No disponible).
);

-- Insertar los tipos de estado iniciales
INSERT INTO Estado_Empleado (Tipo_estado) VALUES ('En evento');
INSERT INTO Estado_Empleado (Tipo_estado) VALUES ('Incapacidad laboral');
INSERT INTO Estado_Empleado (Tipo_estado) VALUES ('Disponible');
INSERT INTO Estado_Empleado (Tipo_estado) VALUES ('No disponible');

-- 7. Tabla Cargos
-- Define la accebilidad que tiene el usuario al programa.
CREATE TABLE Cargos (
    Id_cargo INT IDENTITY(1,1) PRIMARY KEY,              -- Identificador único del rol.
    Nombre_cargo VARCHAR(100) NOT NULL,                  -- Nombre del rol (Administrador, Gerente, Empleado).
	Accesibilidad Bit Not Null							 --Indica la accesibilidad que tiene el usuario al programa(1 = Tiene Acceso, 0= No tiene Acceso)
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

SELECT * FROM Eventos WHERE Detalles_adicionales='si'
INSERT INTO Pagos (Id_evento, Monto, Fecha_pago, Metodo_pago) VALUES (15, 100,GETDATE(), 'SI')
SELECT * FROM PAGOS


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
--Insercciones de Prueba
-- Inserción de empleados:*
INSERT INTO Empleados (Nombre, Apellido, Telefono, Email)
VALUES 
('Juan', 'Pérez', '5551234567', 'juan.perez@ejemplo.com'),
('María', 'Gómez', '5552345678', 'maria.gomez@ejemplo.com'),
('Carlos', 'Ramírez', '5553456789', 'carlos.ramirez@ejemplo.com'),
('Ana', 'Martínez', '5554567890', 'ana.martinez@ejemplo.com'),
('Luis', 'Hernández', '5555678901', 'luis.hernandez@ejemplo.com'),
('Sofía', 'Lopez', '5556789012', 'sofia.lopez@ejemplo.com'),
('Miguel', 'Díaz', '5557890123', 'miguel.diaz@ejemplo.com'),
('Elena', 'Fernández', '5558901234', 'elena.fernandez@ejemplo.com'),
('Diego', 'Torres', '5559012345', 'diego.torres@ejemplo.com'),
('Valeria', 'Ortiz', '5550123456', 'valeria.ortiz@ejemplo.com');

-- Inserción de nuevos empleados:*
INSERT INTO Empleados (Nombre, Apellido, Telefono, Email)
VALUES 
('Fernando', 'Castillo', '5559876543', 'fernando.castillo@ejemplo.com'),
('Isabel', 'Vega', '5558765432', 'isabel.vega@ejemplo.com'),
('Andrés', 'Moreno', '5557654321', 'andres.moreno@ejemplo.com'),
('Rosa', 'Jiménez', '5556543210', 'rosa.jimenez@ejemplo.com'),
('Santiago', 'Domínguez', '5555432109', 'santiago.dominguez@ejemplo.com'),
('Clara', 'Fuentes', '5554321098', 'clara.fuentes@ejemplo.com'),
('Javier', 'Ríos', '5553210987', 'javier.rios@ejemplo.com'),
('Natalia', 'Campos', '5552109876', 'natalia.campos@ejemplo.com'),
('Emilio', 'García', '5551098765', 'emilio.garcia@ejemplo.com'),
('Patricia', 'Soto', '5550987654', 'patricia.soto@ejemplo.com');

--Insertar Cargos:*
INSERT INTO Cargos (Nombre_cargo, Accesibilidad)
VALUES
('Administrador', 1),  -- Tiene acceso completo al sistema
('Gerente', 1),        -- Tiene acceso limitado según sus responsabilidades
('Empleado', 0);       -- No tiene acceso al sistema

-- Insertar usuarios para los empleados existentes con cargos asignados:*
INSERT INTO Usuarios (Id_empleado, Id_Cargo, Nombre_usuario, Contraseña, Estado)
VALUES
-- Administradores
(1, 1, 'juan.perez', 'password1', 1),
(4, 1, 'ana.martinez', 'password4', 1),
(6, 1, 'sofia.lopez', 'password6', 1),
(10, 1, 'valeria.ortiz', 'password10', 1),
-- Gerente
(2, 2, 'maria.gomez', 'password2', 1),
-- Empleados
(3, 3, 'carlos.ramirez', 'password3', 1),
(5, 3, 'luis.hernandez', 'password5', 1),
(7, 3, 'miguel.diaz', 'password7', 1),
(8, 3, 'elena.fernandez', 'password8', 1),
(9, 3, 'diego.torres', 'password9', 1),
(11, 3, 'fernando.castillo', 'password11', 1),
(12, 3, 'isabel.vega', 'password12', 1),
(13, 3, 'andres.moreno', 'password13', 1),
(14, 3, 'rosa.jimenez', 'password14', 1),
(15, 3, 'santiago.dominguez', 'password15', 1),
(16, 3, 'clara.fuentes', 'password16', 1),
(17, 3, 'javier.rios', 'password17', 1),
(18, 3, 'natalia.campos', 'password18', 1),
(19, 3, 'emilio.garcia', 'password19', 1),
(20, 3, 'patricia.soto', 'password20', 1);

-- Insertar roles para los empleados a desempeñar en los eventos:*
INSERT INTO Roles (Nombre_rol, Descripcion)
VALUES
('Decorador', 'Encargado de diseñar y montar la decoración temática del evento.'),
('Especialista en Iluminación', 'Configura y supervisa las luces y efectos visuales del evento.'),
('DJ o Músico', 'Encargado de la música y el entretenimiento durante el evento.'),
('Fotógrafo/Videógrafo', 'Documenta el evento a través de fotos y videos.'),
('Encargado de Catering', 'Supervisa la preparación y el servicio de alimentos y bebidas.'),
('Técnico de Sonido', 'Configura y opera los sistemas de audio para el evento.'),
('Animadores', 'Encargados de entretener a los invitados con actividades temáticas y juegos.'),
('Botargueros', 'Personas que usan botargas o disfraces para animar eventos y captar la atención de los asistentes.'),
('Administrador', 'Supervisa el funcionamiento general de la empresa y la gestión de los eventos.');


-- Insertar paquetes temáticos:*
INSERT INTO Paquetes (Nombre_paquete, Descripcion, Cantidad, Disponibilidad, Costo)
VALUES
('Paquete_Barney', 'Un show temático de Barney con música, decoración y animación.', 3, 1, 5000),
('Paquete_PeppaPig', 'Espectáculo basado en Peppa Pig con juegos, decoración y animación.',3, 1, 4500),
('Paquete_Backyardigans', 'Fiesta con temática de Backyardigans y actividades interactivas.',3, 1, 4700),
('Paquete_Miraculous', 'Evento temático de Ladybug y Cat Noir con juegos y música.',3, 1, 5200),
('Paquete_PawPatrol', 'Celebración con temática de Paw Patrol, personajes y animación.',3, 1, 4800),
('Paquete_Frozen', 'Show temático de Frozen con canciones y decoración invernal.',3, 1, 5500),
('Paquete_ScoobyDoo', 'Fiesta con temática de Scooby-Doo, misterios y diversión.',3, 1, 4900),
('Paquete_Cars', 'Celebración inspirada en Cars, con juegos y decoración automovilística.',3, 1, 4600),
('Paquete_MickeyMouse', 'Espectáculo basado en Mickey Mouse y sus amigos.',3, 1, 5100),
('Paquete_Minion', 'Fiesta con temática de Minions, juegos y disfraces.',3, 1, 4800),
('Paquete_SpongeBob', 'Evento temático de Bob Esponja con actividades acuáticas y animación.',3, 1, 5300),
('Paquete_SesameStreet', 'Celebración con personajes de Plaza Sésamo, decoración y actividades.',3, 1, 4700),
('Paquete_ToyStory', 'Fiesta con Woody, Buzz y más personajes de Toy Story.',3, 1, 5400),
('Paquete_SuperMario', 'Evento con temática de Mario Bros, juegos y desafíos interactivos.',3, 1, 5000),
('Paquete_Pokemon', 'Celebración temática de Pokémon, con animación y juegos creativos.',3, 1, 5200);

-- Insertar servicios de animación relacionados con los paquetes:*
INSERT INTO Servicios (Nombre_servicio, Descripcion, Costo)
VALUES
-- Servicios de animación relacionados con los paquetes
('Animacion_Barney', 'Animación temática con el personaje de Barney.', 1500),
('Animacion_PeppaPig', 'Animación temática con el personaje de Peppa Pig.', 1400),
('Animacion_Backyardigans', 'Animación temática con los personajes de Backyardigans.', 1450),
('Animacion_Miraculous', 'Animación temática con Ladybug y Cat Noir.', 1600),
('Animacion_PawPatrol', 'Animación temática con los cachorros de Paw Patrol.', 1500),
('Animacion_Frozen', 'Animación temática con Elsa, Anna y Olaf.', 1700),
('Animacion_ScoobyDoo', 'Animación temática con Scooby-Doo y sus amigos.', 1550),
('Animacion_Cars', 'Animación temática con los personajes de Cars.', 1400),
('Animacion_MickeyMouse', 'Animación temática con Mickey Mouse y sus amigos.', 1500),
('Animacion_Minion', 'Animación temática con los Minions.', 1400),
('Animacion_SpongeBob', 'Animación temática con Bob Esponja y sus amigos.', 1500),
('Animacion_SesameStreet', 'Animación temática con los personajes de Plaza Sésamo.', 1450),
('Animacion_ToyStory', 'Animación temática con Woody, Buzz y amigos.', 1600),
('Animacion_SuperMario', 'Animación temática con Mario, Luigi y compañía.', 1550),
('Animacion_Pokemon', 'Animación temática con Ash, Pikachu y amigos.', 1500),
-- Servicios generales para todos los paquetes
('Servicio_Sonido', 'Equipo de sonido para música y presentaciones.', 2000),
('Servicio_Sillas', 'Renta de sillas decoradas según la temática.', 1000),
('Servicio_Mesas', 'Renta de mesas decoradas para la ocasión.', 1200),
('Servicio_Alimentos', 'Servicio de alimentos y bebidas temáticos.', 3000),
('Servicio_Iluminacion', 'Iluminación especial según la temática.', 1800);

-- Insertar trajes relacionados con los servicios de animación:*
INSERT INTO Utileria (Nombre, Cantidad)
VALUES
-- Utilería para Barney
('Traje de Barney', 3),
('Traje de Baby Bop', 3),
('Traje de BJ', 3),
-- Utilería para Peppa Pig
('Traje de Peppa Pig', 3),
('Traje de George Pig', 3),
('Traje de Mamá Pig', 3),
-- Utilería para Backyardigans
('Traje de Pablo', 3),
('Traje de Tyrone', 3),
('Traje de Uniqua', 3),
-- Utilería para Miraculous
('Traje de Ladybug', 3),
('Traje de Cat Noir', 3),
('Traje de Hawk Moth', 3),
-- Utilería para Paw Patrol
('Traje de Chase', 3),
('Traje de Marshall', 3),
('Traje de Skye', 3),
-- Utilería para Frozen
('Traje de Elsa', 3),
('Traje de Anna', 3),
('Traje de Olaf', 3),
-- Utilería para Scooby-Doo
('Traje de Scooby-Doo', 3),
('Traje de Shaggy', 3),
('Traje de Daphne', 3),
-- Utilería para Cars
('Traje de Rayo McQueen', 3),
('Traje de Mate', 3),
('Traje de Sally', 3),
-- Utilería para Mickey Mouse
('Traje de Mickey Mouse', 3),
('Traje de Minnie Mouse', 3),
('Traje de Donald Duck', 3),
-- Utilería para Minions
('Traje de Kevin', 3),
('Traje de Stuart', 3),
('Traje de Bob', 3),
-- Utilería para Bob Esponja
('Traje de Bob Esponja', 3),
('Traje de Patricio', 3),
('Traje de Calamardo', 3),
-- Utilería para Plaza Sésamo
('Traje de Elmo', 3),
('Traje de Cookie Monster', 3),
('Traje de Big Bird', 3),
-- Utilería para Toy Story
('Traje de Woody', 3),
('Traje de Buzz Lightyear', 3),
('Traje de Jessie', 3),
-- Utilería para Super Mario
('Traje de Mario', 3),
('Traje de Luigi', 3),
('Traje de Bowser', 3),
-- Utilería para Pokémon
('Traje de Pikachu', 3),
('Traje de Ash', 3),
('Traje de Misty', 3);

-- Insertar utilería asociada a servicios generales:*
INSERT INTO Utileria (Nombre, Cantidad)
VALUES
-- Utilería para Servicio de Sonido
('Altavoz', 10),               -- Aumentamos a 10 para cubrir múltiples eventos
('Micrófono', 10),             -- Incrementamos para permitir mayor flexibilidad
('Mesa de mezclas', 3),        -- Una reserva adicional en caso de alta demanda
('Cables de audio', 30),       -- Incrementamos para soporte simultáneo
-- Utilería para Servicio de Sillas
('Silla plegable decorada', 200),  -- Supone que se necesitarán para varios paquetes
('Fundas de sillas', 200),         -- Una por cada silla
('Cintas decorativas', 200),       -- Para decorar todas las sillas disponibles
('Cojines adicionales', 50),       -- Un número extra para confort
-- Utilería para Servicio de Mesas
('Mesa redonda', 40),              -- Considera eventos grandes o múltiples eventos
('Mantel temático', 40),           -- Un mantel por mesa
('Centros de mesa temáticos', 40), -- Decoración por mesa
('Cubiertos y platos', 200),       -- Pensando en una fiesta con hasta 200 invitados
-- Utilería para Servicio de Alimentos
('Calentadores de alimentos', 10), -- Para mantener múltiples comidas calientes
('Bandejas para servir', 30),      -- Varias bandejas para rotación
('Jarras de bebidas', 30),         -- Para garantizar suficiente capacidad
('Cucharones y pinzas', 20),       -- Herramientas adicionales para servicio
-- Utilería para Servicio de Iluminación
('Luces LED', 30),                 -- Varias luces para decoraciones grandes
('Reflectores', 10),               -- Soporte para espectáculos grandes
('Panel de control de iluminación', 2), -- Para asegurar respaldo
('Soportes de luces', 15);         -- Suficiente para manejar la iluminación extendida

-- Relacionar utilería con servicios de animación:*
INSERT INTO Servicio_Utileria (Id_servicio, Id_utileria)
VALUES
-- Barney
(1, 1), (1, 2), (1, 3),
-- Peppa Pig
(2, 4), (2, 5), (2, 6),
-- Backyardigans
(3, 7), (3, 8), (3, 9),
-- Miraculous
(4, 10), (4, 11), (4, 12),
-- Paw Patrol
(5, 13), (5, 14), (5, 15),
-- Frozen
(6, 16), (6, 17), (6, 18),
-- Scooby-Doo
(7, 19), (7, 20), (7, 21),
-- Cars
(8, 22), (8, 23), (8, 24),
-- Mickey Mouse
(9, 25), (9, 26), (9, 27),
-- Minions
(10, 28), (10, 29), (10, 30),
-- SpongeBob
(11, 31), (11, 32), (11, 33),
-- Plaza Sésamo
(12, 34), (12, 35), (12, 36),
-- Toy Story
(13, 37), (13, 38), (13, 39),
-- Super Mario
(14, 40), (14, 41), (14, 42),
-- Pokémon
(15, 43), (15, 44), (15, 45);

-- Relacionar servicios de animación con paquetes:*
INSERT INTO Paquete_Servicios (Id_paquete, Id_servicio)
VALUES
(1, 1), -- Paquete_Barney
(2, 2), -- Paquete_PeppaPig
(3, 3), -- Paquete_Backyardigans
(4, 4), -- Paquete_Miraculous
(5, 5), -- Paquete_PawPatrol
(6, 6), -- Paquete_Frozen
(7, 7), -- Paquete_ScoobyDoo
(8, 8), -- Paquete_Cars
(9, 9), -- Paquete_MickeyMouse
(10, 10), -- Paquete_Minion
(11, 11), -- Paquete_SpongeBob
(12, 12), -- Paquete_SesameStreet
(13, 13), -- Paquete_ToyStory
(14, 14), -- Paquete_SuperMario
(15, 15); -- Paquete_Pokemon

-- Relacionar utilería con servicios generales:*
INSERT INTO Servicio_Utileria (Id_servicio, Id_utileria)
VALUES
-- Servicio de Sonido
(16, 46), (16, 47), (16, 48), (16, 49),
-- Servicio de Sillas
(17, 50), (17, 51), (17, 52), (17, 53),
-- Servicio de Mesas
(18, 54), (18, 55), (18, 56), (18, 57),
-- Servicio de Alimentos
(19, 58), (19, 59), (19, 60), (19, 61),
-- Servicio de Iluminación
(20, 62), (20, 63), (20, 64), (20, 65);

-- Relacionar servicios generales con todos los paquetes:*
INSERT INTO Paquete_Servicios (Id_paquete, Id_servicio)
VALUES
-- Servicio de Sonido
(1, 16), (2, 16), (3, 16), (4, 16), (5, 16), (6, 16), (7, 16), (8, 16), (9, 16), (10, 16), (11, 16), (12, 16), (13, 16), (14, 16), (15, 16),
-- Servicio de Sillas
(1, 17), (2, 17), (3, 17), (4, 17), (5, 17), (6, 17), (7, 17), (8, 17), (9, 17), (10, 17), (11, 17), (12, 17), (13, 17), (14, 17), (15, 17),
-- Servicio de Mesas
(1, 18), (2, 18), (3, 18), (4, 18), (5, 18), (6, 18), (7, 18), (8, 18), (9, 18), (10, 18), (11, 18), (12, 18), (13, 18), (14, 18), (15, 18),
-- Servicio de Alimentos
(1, 19), (2, 19), (3, 19), (4, 19), (5, 19), (6, 19), (7, 19), (8, 19), (9, 19), (10, 19), (11, 19), (12, 19), (13, 19), (14, 19), (15, 19),
-- Servicio de Iluminación
(1, 20), (2, 20), (3, 20), (4, 20), (5, 20), (6, 20), (7, 20), (8, 20), (9, 20), (10, 20), (11, 20), (12, 20), (13, 20), (14, 20), (15, 20);

-- Insertar 10 clientes en la tabla Clientes:*
INSERT INTO Clientes (Nombre, Apellido, Telefono, Correo_electronico)
VALUES 
('Juan', 'Pérez', '555-0101', 'juan.perez@mail.com'),
('Ana', 'López', '555-0102', 'ana.lopez@mail.com'),
('Carlos', 'Martínez', '555-0103', 'carlos.martinez@mail.com'),
('María', 'González', '555-0104', 'maria.gonzalez@mail.com'),
('Pedro', 'Hernández', '555-0105', 'pedro.hernandez@mail.com'),
('Lucía', 'Rodríguez', '555-0106', 'lucia.rodriguez@mail.com'),
('Jorge', 'Sánchez', '555-0107', 'jorge.sanchez@mail.com'),
('Laura', 'Ramírez', '555-0108', 'laura.ramirez@mail.com'),
('David', 'Torres', '555-0109', 'david.torres@mail.com'),
('Elena', 'Vázquez', '555-0110', 'elena.vazquez@mail.com');

-- Insertar eventos en la tabla Eventos
INSERT INTO Eventos 
(Id_paquete, Id_cliente, Fecha_reserva, Fecha_inicio, Hora_inicio, Hora_fin, Ubicacion, Direccion, 
Cantidad_de_asistentes, Detalles_adicionales, Costo_total, Estado)
VALUES 
(1, 1, '2024-11-18', '2024-12-05', '18:00:00', '22:00:00', 'Managua', 'Calle principal #1, Barrio central, Managua', 
70, 'Detalles del evento #1', 5000.00, 'Pendiente'),
(8, 6, '2024-11-29', '2024-12-13', '08:00:00', '12:00:00', 'Rivas', 'Calle principal #2, Barrio central, Rivas', 
41, 'Detalles del evento #2', 4600.00, 'Pendiente'),
(8, 4, '2024-11-27', '2024-12-15', '08:00:00', '12:00:00', 'Jinotega', 'Calle principal #3, Barrio central, Jinotega', 
56, 'Detalles del evento #3', 4600.00, 'Pendiente'),
(9, 10, '2024-11-28', '2024-12-11', '11:00:00', '15:00:00', 'Madriz', 'Calle principal #4, Barrio central, Madriz', 
78, 'Detalles del evento #4', 5100.00, 'Pendiente'),
(2, 5, '2024-11-16', '2024-12-04', '20:00:00', '23:00:00', 'Río San Juan', 'Calle principal #5, Barrio central, Río San Juan', 
58, 'Detalles del evento #5', 4500.00, 'Pendiente'),
(2, 4, '2024-11-19', '2024-11-29', '20:00:00', '22:00:00', 'Boaco', 'Calle principal #6, Barrio central, Boaco', 
59, 'Detalles del evento #6', 4500.00, 'Pendiente'),
(14, 6, '2024-11-09', '2024-11-27', '14:00:00', '18:00:00', 'Río San Juan', 'Calle principal #7, Barrio central, Río San Juan', 
57, 'Detalles del evento #7', 5000.00, 'Pendiente'),
(13, 10, '2024-11-16', '2024-12-01', '18:00:00', '22:00:00', 'Madriz', 'Calle principal #8, Barrio central, Madriz', 
23, 'Detalles del evento #8', 5400.00, 'Pendiente'),
(7, 6, '2024-11-28', '2024-12-15', '19:00:00', '23:00:00', 'Rivas', 'Calle principal #9, Barrio central, Rivas', 
73, 'Detalles del evento #9', 4900.00, 'Pendiente'),
(4, 8, '2024-11-29', '2024-12-17', '09:00:00', '13:00:00', 'Estelí', 'Calle principal #10, Barrio central, Estelí', 
28, 'Detalles del evento #10', 5200.00, 'Pendiente'),
(1, 2, '2024-11-11', '2024-11-27', '20:00:00', '22:00:00', 'Madriz', 'Calle principal #11, Barrio central, Madriz', 
53, 'Detalles del evento #11', 5000.00, 'Pendiente'),
(12, 1, '2024-11-30', '2024-12-12', '10:00:00', '14:00:00', 'Chinandega', 'Calle principal #12, Barrio central, Chinandega', 
82, 'Detalles del evento #12', 4700.00, 'Pendiente');

--*******************************************************************
-- Asignaciones de empleados a servicios para cada evento:*
-- Evento 1: Paquete_Barney (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(1, 3, 6), -- Técnico de Sonido (Carlos Ramírez)
(1, 7, 2), -- Especialista en Iluminación (Miguel Díaz)
(1, 9, 5), -- Encargado de Catering (Diego Torres)
-- Servicio de Animación (3 empleados para los personajes de Barney)
(1, 11, 7), -- Animador (Fernando Castillo)
(1, 12, 7), -- Animador (Isabel Vega)
(1, 13, 7); -- Animador (Andrés Moreno)

-- Evento 2: Paquete_Cars (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(2, 14, 6), -- Técnico de Sonido (Rosa Jiménez)
(2, 15, 2), -- Especialista en Iluminación (Santiago Domínguez)
(2, 16, 5), -- Encargado de Catering (Clara Fuentes)
-- Servicio de Animación (3 empleados para los personajes de Cars)
(2, 17, 7), -- Animador (Javier Ríos)
(2, 18, 7), -- Animador (Natalia Campos)
(2, 19, 7); -- Animador (Emilio García)

-- Evento 3: Paquete_MickeyMouse (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(3, 5, 6), -- Técnico de Sonido (Luis Hernández)
(3, 6, 2), -- Especialista en Iluminación (Sofía López)
(3, 8, 5), -- Encargado de Catering (Elena Fernández)
-- Servicio de Animación (3 empleados para los personajes de Mickey Mouse)
(3, 4, 7), -- Animador (Ana Martínez)
(3, 10, 7), -- Animador (Valeria Ortiz)
(3, 1, 7); -- Animador (Juan Pérez)

-- Evento 4: Paquete_PeppaPig (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(4, 2, 6), -- Técnico de Sonido (María Gómez)
(4, 17, 2), -- Especialista en Iluminación (Javier Ríos)
(4, 18, 5), -- Encargado de Catering (Natalia Campos)
-- Servicio de Animación (3 empleados para los personajes de Peppa Pig)
(4, 19, 7), -- Animador (Emilio García)
(4, 20, 7), -- Animador (Patricia Soto)
(4, 3, 7); -- Animador (Carlos Ramírez)

-- Evento 5: Paquete_ToyStory (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(5, 1, 6), -- Técnico de Sonido (Juan Pérez)
(5, 4, 2), -- Especialista en Iluminación (Ana Martínez)
(5, 14, 5), -- Encargado de Catering (Rosa Jiménez)
-- Servicio de Animación (3 empleados para los personajes de Toy Story)
(5, 15, 7), -- Animador (Santiago Domínguez)
(5, 16, 7), -- Animador (Clara Fuentes)
(5, 7, 7); -- Animador (Miguel Díaz)

-- Evento 6: Paquete_Frozen (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(6, 5, 6), -- Técnico de Sonido (Luis Hernández)
(6, 8, 2), -- Especialista en Iluminación (Elena Fernández)
(6, 9, 5), -- Encargado de Catering (Diego Torres)
-- Servicio de Animación (3 empleados para los personajes de Frozen)
(6, 10, 7), -- Animador (Valeria Ortiz)
(6, 11, 7), -- Animador (Fernando Castillo)
(6, 13, 7); -- Animador (Andrés Moreno)

-- Evento 7: Paquete_ScoobyDoo (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(7, 3, 6), -- Técnico de Sonido (Carlos Ramírez)
(7, 5, 2), -- Especialista en Iluminación (Luis Hernández)
(7, 7, 5), -- Encargado de Catering (Miguel Díaz)
-- Servicio de Animación (3 empleados para los personajes de Scooby-Doo)
(7, 12, 7), -- Animador (Elmo)
(7, 13, 7), -- Animador (Shaggy)
(7, 14, 7); -- Animador (Daphne)

-- Evento 8: Paquete_SuperMario (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(8, 9, 6), -- Técnico de Sonido (Diego Torres)
(8, 10, 2), -- Especialista en Iluminación (Valeria Ortiz)
(8, 11, 5), -- Encargado de Catering (Fernando Castillo)
-- Servicio de Animación (3 empleados para los personajes de Super Mario)
(8, 15, 7), -- Animador (Santiago Domínguez)
(8, 16, 7), -- Animador (Clara Fuentes)
(8, 17, 7); -- Animador (Javier Ríos)

-- Evento 9: Paquete_Frozen (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(9, 2, 6), -- Técnico de Sonido (María Gómez)
(9, 4, 2), -- Especialista en Iluminación (Ana Martínez)
(9, 6, 5), -- Encargado de Catering (Sofía López)
-- Servicio de Animación (3 empleados para los personajes de Frozen)
(9, 7, 7), -- Animador (Miguel Díaz)
(9, 8, 7), -- Animador (Elena Fernández)
(9, 11, 7); -- Animador (Fernando Castillo)

-- Evento 10: Paquete_ToyStory (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(10, 13, 6), -- Técnico de Sonido (Andrés Moreno)
(10, 14, 2), -- Especialista en Iluminación (Rosa Jiménez)
(10, 15, 5), -- Encargado de Catering (Santiago Domínguez)
-- Servicio de Animación (3 empleados para los personajes de Toy Story)
(10, 16, 7), -- Animador (Clara Fuentes)
(10, 17, 7), -- Animador (Javier Ríos)
(10, 18, 7); -- Animador (Natalia Campos)

-- Evento 11: Paquete_PeppaPig (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(11, 1, 6), -- Técnico de Sonido (Juan Pérez)
(11, 3, 2), -- Especialista en Iluminación (Carlos Ramírez)
(11, 9, 5), -- Encargado de Catering (Diego Torres)
-- Servicio de Animación (3 empleados para los personajes de Peppa Pig)
(11, 10, 7), -- Animador (Valeria Ortiz)
(11, 11, 7), -- Animador (Fernando Castillo)
(11, 12, 7); -- Animador (Isabel Vega)

-- Evento 12: Paquete_SesameStreet (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(12, 4, 6), -- Técnico de Sonido (Ana Martínez)
(12, 7, 2), -- Especialista en Iluminación (Miguel Díaz)
(12, 8, 5), -- Encargado de Catering (Elena Fernández)
-- Servicio de Animación (3 empleados para los personajes de Sesame Street)
(12, 13, 7), -- Animador (Andrés Moreno)
(12, 14, 7), -- Animador (Rosa Jiménez)
(12, 15, 7); -- Animador (Santiago Domínguez)

--*******************************************************************