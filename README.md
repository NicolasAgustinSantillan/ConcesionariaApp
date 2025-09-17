# Paso 1 - Crear base de datos

```sql
CREATE TABLE [car] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Code] VARCHAR(10),
    [Type] VARCHAR(50),
    [Brand] VARCHAR(50),
    [Model] VARCHAR(50),
    [Year] INT,
    [Description] VARCHAR(255),
    [Patent] VARCHAR(50),
    [Kilometers] INT DEFAULT 0,
    [Price] DECIMAL(10, 2) DEFAULT 0.00,
    [Photo] VARBINARY(MAX) DEFAULT NULL,
    [Active] BIT DEFAULT 1,
    [IncomeDate] DATETIME DEFAULT GETDATE()
);


INSERT INTO Vehiculos (Code, Type, Brand, Model, Year, Description, Patent, Kilometers, Price, Active, IncomeDate)
VALUES ('C001', 'SUV', 'Ford', 'EcoSport', 2021, 'Automática, techo solar', 'ABC123', 12000, 3000000.00, 1, GETDATE());

INSERT INTO Vehiculos (Code, Type, Brand, Model, Year, Description, Patent, Kilometers, Price, Active, IncomeDate)
VALUES ('C002', 'Sedan', 'Toyota', 'Corolla', 2020, 'Full equipo, cuero', 'XYZ456', 35000, 2500000.00, 1, GETDATE());

INSERT INTO Vehiculos (Code, Type, Brand, Model, Year, Description, Patent, Kilometers, Price, Active, IncomeDate)
VALUES ('C003', 'Hatchback', 'Volkswagen', 'Golf', 2019, 'Manual, 1.6 TSI', 'JKL789', 45000, 2200000.00, 1, GETDATE());

INSERT INTO Vehiculos (Code, Type, Brand, Model, Year, Description, Patent, Kilometers, Price, Active, IncomeDate)
VALUES ('C004', 'Pickup', 'Chevrolet', 'S10', 2022, '4x4 doble cabina', 'LMN321', 5000, 5500000.00, 1, GETDATE());

INSERT INTO Vehiculos (Code, Type, Brand, Model, Year, Description, Patent, Kilometers, Price, Active, IncomeDate)
VALUES ('C005', 'Coupe', 'BMW', 'Serie 3', 2018, 'Automática deportiva', 'QRS654', 60000, 8000000.00, 1, GETDATE());
```

# Paso 2 - Editar la coneccion a base de datos (appsettings.json)

```xml
Data Source=127.0.0.1;Initial Catalog=Concesionaria_DB;User ID=sa;Password=******;Persist Security Info=True;Max Pool Size=200;MultipleActiveResultSets=True;Connect Timeout=30;Connection Lifetime=300;TrustServerCertificate=True;
```

# Paso 3 - Ejecutar la app 
