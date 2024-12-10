--Insercciones de Prueba

-- Insertar los tipos de estado iniciales
INSERT INTO Estado_Empleado (Tipo_estado) VALUES ('Disponible');
INSERT INTO Estado_Empleado (Tipo_estado) VALUES ('En evento');
INSERT INTO Estado_Empleado (Tipo_estado) VALUES ('Incapacidad laboral');
INSERT INTO Estado_Empleado (Tipo_estado) VALUES ('No disponible');



-- Inserción de empleados:*
INSERT INTO Empleados (Nombre, Apellido, Telefono, Email,Estado_Empleado)
VALUES 
('Juan', 'Pérez', '5551234567', 'juan.perez@ejemplo.com',1),
('María', 'Gómez', '5552345678', 'maria.gomez@ejemplo.com',1),
('Carlos', 'Ramírez', '5553456789', 'carlos.ramirez@ejemplo.com',1),
('Ana', 'Martínez', '5554567890', 'ana.martinez@ejemplo.com',1),
('Luis', 'Hernández', '5555678901', 'luis.hernandez@ejemplo.com',1),
('Sofía', 'Lopez', '5556789012', 'sofia.lopez@ejemplo.com',1),
('Miguel', 'Díaz', '5557890123', 'miguel.diaz@ejemplo.com',1),
('Elena', 'Fernández', '5558901234', 'elena.fernandez@ejemplo.com',1),
('Diego', 'Torres', '5559012345', 'diego.torres@ejemplo.com',1),
('Valeria', 'Ortiz', '5550123456', 'valeria.ortiz@ejemplo.com',1),
('Fernando', 'Castillo', '5559876543', 'fernando.castillo@ejemplo.com',1),
('Isabel', 'Vega', '5558765432', 'isabel.vega@ejemplo.com',1),
('Andrés', 'Moreno', '5557654321', 'andres.moreno@ejemplo.com',1),
('Rosa', 'Jiménez', '5556543210', 'rosa.jimenez@ejemplo.com',1),
('Santiago', 'Domínguez', '5555432109', 'santiago.dominguez@ejemplo.com',1),
('Clara', 'Fuentes', '5554321098', 'clara.fuentes@ejemplo.com',1),
('Javier', 'Ríos', '5553210987', 'javier.rios@ejemplo.com',1),
('Natalia', 'Campos', '5552109876', 'natalia.campos@ejemplo.com',1),
('Emilio', 'García', '5551098765', 'emilio.garcia@ejemplo.com',1),
('Patricia', 'Soto', '5550987654', 'patricia.soto@ejemplo.com',1);

--Insertar Cargos:*
INSERT INTO Cargos (Nombre_cargo, Descripción)
VALUES 
('Gerente', 'Acceso completo al sistema.'),
('Bodeguero', 'Acceso solo a administrar la utilería.'),
('Empleado', 'Solo puede hacer registros de eventos, pagos y asignar empleados a eventos.'),
('Recursos Humanos', 'Acceso a administrar clientes y empleados.');

-- Insertar usuarios para los empleados existentes con cargos asignados:*
INSERT INTO Usuarios (Id_empleado, Id_Cargo, Nombre_usuario, Contraseña, Estado)
VALUES
(1, 1, 'juan.perez', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password1'), 2), 1),
(4, 1, 'ana.martinez', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password4'), 2), 1),
(6, 1, 'sofia.lopez', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password6'), 2), 1),
(10, 1, 'valeria.ortiz', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password10'), 2), 1),
(2, 2, 'maria.gomez', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password2'), 2), 1),
(3, 2, 'carlos.ramirez', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password3'), 2), 1),
(5, 2, 'luis.hernandez', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password5'), 2), 1),
(7, 2, 'miguel.diaz', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password7'), 2), 1),
(8, 2, 'elena.fernandez', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password8'), 2), 1),
(9, 2, 'diego.torres', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password9'), 2), 1),
(11, 3, 'fernando.castillo', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password11'), 2), 1),
(12, 3, 'isabel.vega', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password12'), 2), 1),
(13, 3, 'andres.moreno', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password13'), 2), 1),
(14, 3, 'rosa.jimenez', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password14'), 2), 1),
(15, 4, 'santiago.dominguez', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password15'), 2), 1),
(16, 4, 'clara.fuentes', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password16'), 2), 1),
(17, 4, 'javier.rios', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password17'), 2), 1),
(18, 4, 'natalia.campos', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password18'), 2), 1),
(19, 4, 'emilio.garcia', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password19'), 2), 1),
(20, 4, 'patricia.soto', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'password20'), 2), 1);


INSERT INTO Usuarios (Id_empleado, Id_Cargo, Nombre_usuario, Contraseña, Estado)
VALUES
(20, 1, 'Admin', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', '12345678'), 2), 1);

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
('Traje de Misty', 3),
('Altavoz', 10),              
('Micrófono', 10),             
('Mesa de mezclas', 3),      
('Cables de audio', 30),      
-- Utilería para Servicio de Sillas
('Silla plegable decorada', 200), 
('Fundas de sillas', 200),       
('Cintas decorativas', 200),     
('Cojines adicionales', 50),       
-- Utilería para Servicio de Mesas
('Mesa redonda', 40),            
('Mantel temático', 40),         
('Centros de mesa temáticos', 40),
('Cubiertos y platos', 200),       
-- Utilería para Servicio de Alimentos
('Calentadores de alimentos', 10),
('Bandejas para servir', 30),     
('Jarras de bebidas', 30),       
('Cucharones y pinzas', 20),     
-- Utilería para Servicio de Iluminación
('Luces LED', 30),                 
('Reflectores', 10),              
('Panel de control de iluminación', 2), 
('Soportes de luces', 15);      

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
(15, 43), (15, 44), (15, 45),
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
(15, 15),
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
('Juan', 'Pérez', '70894567', 'juan.perez@mail.com'),
('Ana', 'López', '71923456', 'ana.lopez@mail.com'),
('Carlos', 'Martínez', '72567890', 'carlos.martinez@mail.com'),
('María', 'González', '73561234', 'maria.gonzalez@mail.com'),
('Pedro', 'Hernández', '74890123', 'pedro.hernandez@mail.com'),
('Lucía', 'Rodríguez', '75834012', 'lucia.rodriguez@mail.com'),
('Jorge', 'Sánchez', '76981234', 'jorge.sanchez@mail.com'),
('Laura', 'Ramírez', '77895432', 'laura.ramirez@mail.com'),
('David', 'Torres', '88567812', 'david.torres@mail.com'),
('Elena', 'Vázquez', '89912345', 'elena.vazquez@mail.com');

-- Insertar eventos con fechas dinámicas basadas en la fecha actual

INSERT INTO Eventos 
(Id_paquete, Id_cliente, Fecha_reserva, Fecha_inicio, Hora_inicio, Hora_fin, Ubicacion, Direccion, 
Cantidad_de_asistentes, Detalles_adicionales, Costo_total, Estado)
VALUES 
(1, 1, GETDATE(), DATEADD(DAY, 30, GETDATE()), '18:00:00', '22:00:00', 'Managua', 'Calle principal #1, Barrio central, Managua', 
70, 'Detalles del evento #1', 5000.00, 'Pendiente'),  -- Fecha de reserva es la actual, fecha de inicio es 30 días después
(8, 6, DATEADD(DAY, 3, GETDATE()), DATEADD(DAY, 33, GETDATE()), '08:00:00', '12:00:00', 'Rivas', 'Calle principal #2, Barrio central, Rivas', 
41, 'Detalles del evento #2', 4600.00, 'Pendiente'),
(8, 4, DATEADD(DAY, 5, GETDATE()), DATEADD(DAY, 35, GETDATE()), '08:00:00', '12:00:00', 'Jinotega', 'Calle principal #3, Barrio central, Jinotega', 
56, 'Detalles del evento #3', 4600.00, 'Pendiente'),
(9, 10, DATEADD(DAY, 7, GETDATE()), DATEADD(DAY, 37, GETDATE()), '11:00:00', '15:00:00', 'Madriz', 'Calle principal #4, Barrio central, Madriz', 
78, 'Detalles del evento #4', 5100.00, 'Pendiente'),
(2, 5, GETDATE(), DATEADD(DAY, 30, GETDATE()), '20:00:00', '23:00:00', 'Río San Juan', 'Calle principal #5, Barrio central, Río San Juan', 
58, 'Detalles del evento #5', 4500.00, 'Pendiente'),
(2, 4, DATEADD(DAY, 2, GETDATE()), DATEADD(DAY, 32, GETDATE()), '20:00:00', '22:00:00', 'Boaco', 'Calle principal #6, Barrio central, Boaco', 
59, 'Detalles del evento #6', 4500.00, 'Pendiente'),
(14, 6, DATEADD(DAY, -3, GETDATE()), DATEADD(DAY, 27, GETDATE()), '14:00:00', '18:00:00', 'Río San Juan', 'Calle principal #7, Barrio central, Río San Juan', 
57, 'Detalles del evento #7', 5000.00, 'Pendiente'),
(13, 10, GETDATE(), DATEADD(DAY, 30, GETDATE()), '18:00:00', '22:00:00', 'Madriz', 'Calle principal #8, Barrio central, Madriz', 
23, 'Detalles del evento #8', 5400.00, 'Pendiente'),
(7, 6, DATEADD(DAY, 6, GETDATE()), DATEADD(DAY, 36, GETDATE()), '19:00:00', '23:00:00', 'Rivas', 'Calle principal #9, Barrio central, Rivas', 
73, 'Detalles del evento #9', 4900.00, 'Pendiente'),
(4, 8, DATEADD(DAY, 2, GETDATE()), DATEADD(DAY, 32, GETDATE()), '09:00:00', '13:00:00', 'Estelí', 'Calle principal #10, Barrio central, Estelí', 
28, 'Detalles del evento #10', 5200.00, 'Pendiente'),
(1, 2, DATEADD(DAY, -3, GETDATE()), DATEADD(DAY, 27, GETDATE()), '20:00:00', '22:00:00', 'Madriz', 'Calle principal #11, Barrio central, Madriz', 
53, 'Detalles del evento #11', 5000.00, 'Pendiente'),
(12, 1, DATEADD(DAY, 1, GETDATE()), DATEADD(DAY, 31, GETDATE()), '10:00:00', '14:00:00', 'Chinandega', 'Calle principal #12, Barrio central, Chinandega', 
82, 'Detalles del evento #12', 4700.00, 'Pendiente'); 




-- Insertar pagos para los eventos con "Efectivo" como método de pago
-- Insertar pagos para los eventos con "Efectivo" como método de pago

INSERT INTO Pagos (Id_evento, Monto, Fecha_pago, Metodo_pago)
VALUES
(1, 2500.00, DATEADD(DAY, 10, GETDATE()), 'Efectivo'),
(2, 2300.00, DATEADD(DAY, 11, GETDATE()), 'Efectivo'),
(3, 2300.00, DATEADD(DAY, 12, GETDATE()), 'Efectivo'),
(4, 2550.00, DATEADD(DAY, 13, GETDATE()), 'Efectivo'),
(5, 2250.00, DATEADD(DAY, 14, GETDATE()), 'Efectivo'),
(6, 2250.00, DATEADD(DAY, 15, GETDATE()), 'Efectivo'),
(7, 2500.00, DATEADD(DAY, 16, GETDATE()), 'Efectivo'),
(8, 2700.00, DATEADD(DAY, 17, GETDATE()), 'Efectivo'),
(9, 2450.00, DATEADD(DAY, 18, GETDATE()), 'Efectivo'),
(10, 2600.00, DATEADD(DAY, 19, GETDATE()), 'Efectivo'),
(11, 2500.00, DATEADD(DAY, 20, GETDATE()), 'Efectivo'),
(12, 2350.00, DATEADD(DAY, 21, GETDATE()), 'Efectivo');



--*******************************************************************
--*******************************************************************
-- Asignaciones de empleados a servicios para cada evento:
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
(3, 10, 7), -- Animador (Valeria Ortiz)
(3, 1, 7), -- Animador (Juan Pérez)
(3, 7, 7); -- Animador (Miguel Díaz)

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
(6, 13, 7), -- Animador (Andrés Moreno)
(6, 18, 7); -- Animador (Patricia Soto)

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
(8, 16, 7), -- Animador (Clara Fuentes)
(8, 17, 7), -- Animador (Javier Ríos)
(8, 18, 7); -- Animador (Natalia Campos)

-- Evento 9: Paquete_Frozen (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(9, 2, 6), -- Técnico de Sonido (María Gómez)
(9, 4, 2), -- Especialista en Iluminación (Ana Martínez)
(9, 6, 5), -- Encargado de Catering (Sofía López)
-- Servicio de Animación (3 empleados para los personajes de Frozen)
(9, 8, 7), -- Animador (Elena Fernández)
(9, 11, 7), -- Animador (Fernando Castillo)
(9, 12, 7); -- Animador (Isabel Vega)

-- Evento 10: Paquete_ToyStory (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(10, 13, 6), -- Técnico de Sonido (Andrés Moreno)
(10, 14, 2), -- Especialista en Iluminación (Rosa Jiménez)
(10, 15, 5), -- Encargado de Catering (Santiago Domínguez)
-- Servicio de Animación (3 empleados para los personajes de Toy Story)
(10, 17, 7), -- Animador (Javier Ríos)
(10, 18, 7), -- Animador (Natalia Campos)
(10, 19, 7); -- Animador (Emilio García)

-- Evento 11: Paquete_PeppaPig (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(11, 1, 6), -- Técnico de Sonido (Juan Pérez)
(11, 3, 2), -- Especialista en Iluminación (Carlos Ramírez)
(11, 9, 5), -- Encargado de Catering (Diego Torres)
-- Servicio de Animación (3 empleados para los personajes de Peppa Pig)
(11, 10, 7), -- Animador (Valeria Ortiz)
(11, 12, 7), -- Animador (Isabel Vega)
(11, 13, 7); -- Animador (Andrés Moreno)

-- Evento 12: Paquete_SesameStreet (Servicios Generales y Animación con 3 personajes)
INSERT INTO Rol_Empleado_Evento (Id_evento, Id_empleado, Id_rol)
VALUES
-- Servicios Generales
(12, 4, 6), -- Técnico de Sonido (Ana Martínez)
(12, 7, 2), -- Especialista en Iluminación (Miguel Díaz)
(12, 14, 5), -- Encargado de Catering (Rosa Jiménez)
-- Servicio de Animación (3 empleados para los personajes de Sesame Street)
(12, 18, 7), -- Animador (Natalia Campos)
(12, 16, 7), -- Animador (Clara Fuentes)
(12, 19, 7); -- Animador (Emilio García)




--*******************************************************************


