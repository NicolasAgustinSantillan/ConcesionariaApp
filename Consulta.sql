CREATE DATABASE [Concesionaria_DB];
GO

USE [Concesionaria_DB];
GO

CREATE TABLE [Vehiculos] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Vehiculo_Codigo] VARCHAR(10),
    [Vehiculo_Tipo] VARCHAR(50),
    [Vehiculo_Marca] VARCHAR(50),
    [Vehiculo_Modelo] VARCHAR(50),
    [Vehiculo_Año] INT,
    [Vehiculo_Caracteristicas] VARCHAR(255),
    [Vehiculo_Patente] VARCHAR(50),
    [Vehiculo_Condicion] VARCHAR(50),
    [Vehiculo_Kilometraje] INT,
    [Vehiculo_Precio] DECIMAL(10, 2),
    [Vehiculo_Ingreso] DATETIME
);

INSERT INTO [Vehiculos] (
    [Vehiculo_Codigo],
    [Vehiculo_Tipo],
    [Vehiculo_Marca],
    [Vehiculo_Modelo],
    [Vehiculo_Año],
    [Vehiculo_Caracteristicas],
    [Vehiculo_Patente],
    [Vehiculo_Condicion],
    [Vehiculo_Kilometraje],
    [Vehiculo_Precio],
    [Vehiculo_Ingreso]
)
VALUES
    ('0001', 'Automóvil',   'Toyota',        'Corolla',   2020, 'Aire acondicionado, dirección asistida',       'ABC123', 'Nuevo',  0,     2000000.00, '2024-01-15 10:00:00'),
    ('0002', 'SUV',         'Ford',          'EcoSport',  2019, 'Aire acondicionado, sistema de navegación',    'DEF456', 'Usado',  15000, 1800000.00, '2023-05-20 09:30:00'),
    ('0003', 'Pick Up',     'Chevrolet',     'S10',       2018, 'Aire acondicionado, cámara de reversa',        'GHI789', 'Usado',  30000, 2500000.00, '2023-03-10 14:00:00'),
    ('0004', 'Camioneta',   'Nissan',        'Frontier',  2021, 'Aire acondicionado, frenos ABS',               'JKL012', 'Nuevo',  0,     2700000.00, '2024-02-25 11:45:00'),
    ('0005', 'Automóvil',   'Honda',         'Civic',     2017, 'Aire acondicionado, asientos de cuero',        'MNO345', 'Usado',  40000, 2200000.00, '2022-12-05 16:20:00'),
    ('0006', 'SUV',         'Hyundai',       'Tucson',    2020, 'Aire acondicionado, techo solar',              'PQR678', 'Nuevo',  0,     2800000.00, '2024-04-18 08:50:00'),
    ('0007', 'Pick Up',     'Volkswagen',    'Amarok',    2019, 'Aire acondicionado, sensor de estacionamiento','STU901', 'Usado',  25000, 2600000.00, '2023-06-22 13:10:00'),
    ('0008', 'Camión',      'Mercedes-Benz', 'Actros',    2018, 'Aire acondicionado, control de crucero',       'VWX234', 'Usado',  50000, 5000000.00, '2023-07-15 17:30:00'),
    ('0009', 'Automóvil',   'BMW',           'Serie 3',   2021, 'Aire acondicionado, sistema de sonido premium','YZA567', 'Nuevo',  0,     3500000.00, '2024-03-10 12:00:00'),
    ('0010', 'SUV',         'Audi',          'Q5',        2022, 'Aire acondicionado, faros LED',                'BCD890', 'Nuevo',  0,     4000000.00, '2024-06-01 09:00:00');

GO

SELECT * FROM [dbo].[Vehiculos];

SELECT * FROM [dbo].[Vehiculos] WHERE [Vehiculo_Kilometraje] > 0

GO