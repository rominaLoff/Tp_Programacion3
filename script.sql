-- Script de creación de la base de datos, tabla y datos de prueba
-- TP Integrador - Programación 3

-- 1. Crear la base de datos
CREATE DATABASE Programacion3;
GO

USE Programacion3;
GO

-- 2. Crear la tabla Productos
CREATE TABLE Productos (
    Id     INT IDENTITY(1,1) PRIMARY KEY,  -- Identificador autonumérico
    Nombre NVARCHAR(200) NOT NULL,          -- Nombre del producto
    Precio DECIMAL(10,2) NOT NULL,          -- Precio (valor monetario)
    Stock  INT NOT NULL                     -- Cantidad disponible
);
GO

-- 3. Insertar datos de prueba (al menos 5 productos)
INSERT INTO Productos (Nombre, Precio, Stock) VALUES
('Notebook Lenovo',   850000.00, 10),
('Mouse Logitech',     25000.00, 25),
('Teclado Redragon',   45000.00, 15),
('Monitor Samsung 24', 180000.00, 8),
('Auriculares JBL',    30000.00, 20);
GO

-- 4. Consulta para verificar que los datos se cargaron
SELECT Id, Nombre, Precio, Stock FROM Productos;
GO