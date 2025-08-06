CREATE DATABASE RepuestosMSP;

USE RepuestosMSP;

CREATE TABLE Categoria 
(
IdCategoria INT PRIMARY KEY IDENTITY(1,1),
Nombre NVARCHAR(100) NOT NULL
);

CREATE TABLE Proveedor 
(
IdProveedor INT PRIMARY KEY IDENTITY(1,1),
Nombre NVARCHAR(50) NOT NULL,
Telefono NVARCHAR(20),
Correo NVARCHAR(100),
Direccion NVARCHAR(200)
);

CREATE TABLE Repuesto 
(
IdRepuesto INT PRIMARY KEY IDENTITY(1,1),
Nombre NVARCHAR(20) NOT NULL,
Descripcion NVARCHAR(255),
Precio DECIMAL(10, 2) NOT NULL,
Existencia INT NOT NULL,
IdCategoria INT FOREIGN KEY REFERENCES Categoria(IdCategoria),
IdProveedor INT FOREIGN KEY REFERENCES Proveedor(IdProveedor)
);

CREATE TABLE Cliente 
(
IdCliente INT PRIMARY KEY IDENTITY(1,1),
Nombre NVARCHAR(30) NOT NULL,
Telefono NVARCHAR(20),
Direccion NVARCHAR(200),
Email NVARCHAR(100)
);

CREATE TABLE Venta 
(
IdVenta INT PRIMARY KEY IDENTITY(1,1),
Fecha DATETIME DEFAULT GETDATE(),
IdCliente INT FOREIGN KEY REFERENCES Cliente(IdCliente),
Total DECIMAL(10,2)
);

CREATE TABLE DetalleVenta 
(
IdDetalle INT PRIMARY KEY IDENTITY(1,1),
IdVenta INT FOREIGN KEY REFERENCES Venta(IdVenta),
IdRepuesto INT FOREIGN KEY REFERENCES Repuesto(IdRepuesto),
Cantidad INT NOT NULL,
PrecioUnitario DECIMAL(10,2) NOT NULL
);

CREATE TABLE EntradaRepuesto 
(
IdEntrada INT PRIMARY KEY IDENTITY(1,1),
IdRepuesto INT FOREIGN KEY REFERENCES Repuesto(IdRepuesto),
Pieza NVARCHAR(100), 
FechaLlegada DATETIME NOT NULL,
Cantidad INT NOT NULL,
Existencia INT, 
Observacion NVARCHAR(255)
);

CREATE TABLE SalidaRepuesto
(
IdSalida INT PRIMARY KEY IDENTITY(1,1),
IdRepuesto INT FOREIGN KEY REFERENCES Repuesto(IdRepuesto),
Pieza NVARCHAR(100), 
FechaSalida DATETIME NOT NULL,
Cantidad INT NOT NULL,
Existencia INT, 
Destino NVARCHAR(100),
Observacion NVARCHAR(255)
);

INSERT INTO Categoria (Nombre) VALUES 
('Motor'), ('Suspensión'), ('Frenos'), ('Transmisión'), 
('Electricidad'), ('Aceites'), ('Filtros'), ('Neumáticos'), 
('Luces'), ('Accesorios');

INSERT INTO Proveedor (Nombre, Telefono, Direccion) VALUES 
('AutoImport SRL', '809-111-2222', 'Calle Duarte #101'), 
('Repuestera El Sol', '809-222-3333', 'Av. Independencia #205'), 
('Repuestos Rápidos', '809-333-4444', 'Calle 30 de Marzo #50'), 
('Suministros J&M', '809-444-5555', 'Calle 5, Zona Industrial'), 
('Distribuidora Omega', '809-555-6666', 'Av. Kennedy #300'), 
('Repuestos Express', '809-666-7777', 'Av. Luperón #120'), 
('Importadora CarMax', '809-777-8888', 'Calle Mella #80'), 
('TodoMotor SRL', '809-888-9999', 'Zona Franca Villa Mella'), 
('Mega Repuestos', '809-999-0000', 'Calle 8, Ensanche Ozama'), 
('AutoPlus Import', '809-000-1111', 'Carretera Mella KM 12');

INSERT INTO Repuesto (Nombre, Descripcion, Precio, Existencia, IdCategoria, IdProveedor) VALUES
('Filtro de aceite', 'Filtro para motor Nissan', 350.00, 25, 7, 1),
('Bujía NGK', 'Bujía para motores 4 cilindros', 120.00, 100, 5, 2),
('Pastillas de freno', 'Delanteras para Toyota Corolla', 950.00, 30, 3, 3),
('Aceite 10W-30', 'Aceite sintético 1L', 450.00, 60, 6, 4),
('Amortiguador', 'Trasero para Honda Civic', 1600.00, 15, 2, 5),
('Neumático 195/65R15', 'Para carro mediano', 3200.00, 20, 8, 6),
('Alternador', 'Para Hyundai Accent', 4800.00, 8, 5, 7),
('Bombillo H4', 'Luz delantera blanca', 200.00, 50, 9, 8),
('Cruzeta', 'Para transmisión Toyota', 700.00, 10, 4, 9),
('Alfombra de goma', 'Set de 4 piezas', 650.00, 40, 10, 10);

INSERT INTO Cliente (Nombre, Telefono, Direccion, Email) VALUES
('Carlos Pérez', '829-111-0001', 'Calle A #12', 'carlos.perez@gmail.com'),
('Ana Martínez', '809-222-0002', 'Av. Bolívar #45', 'ana.martinez@hotmail.com'),
('Luis Gómez', '849-333-0003', 'Calle B #67', 'luisg@hotmail.com'),
('Sofía Ramírez', '829-444-0004', 'Av. Las Américas #90', 'sofiar@gmail.com'),
('Pedro Torres', '809-555-0005', 'Ens. Ozama #100', 'ptorres@yahoo.com'),
('Marta Lora', '849-666-0006', 'Calle Central #10', 'martalora@gmail.com'),
('Jorge Díaz', '829-777-0007', 'Zona Colonial #22', 'jorge.d@hotmail.com'),
('Patricia Núñez', '809-888-0008', 'Av. Luperón #30', 'pattyn@gmail.com'),
('Julio Reyes', '849-999-0009', 'Calle Duarte Vieja #2', 'julio.r@gmail.com'),
('Lucía Paredes', '829-000-0010', 'Calle Independencia #1', 'luciap@hotmail.com'),
('Carlos Lopez', '8098887766', 'Calle 5, Santiago', 'carlosm@gmail.com'),
('Luisa Fernández', '8291122334', 'Av. Duarte, La Vega', 'luisa.f@hotmail.com'),
('Pedro Gómez', '8093344556', 'Calle Central, Moca', 'pedrog@gmail.com'),
('Andrea López', '8495566778', 'Zona Colonial, Santo Domingo', 'andrea.lopez@yahoo.com'),
('Juan Ramírez', '8292233445', 'Av. Libertad, San Cristóbal', 'juan.r@gmail.com'),
('María Rodríguez', '8092233445', 'Calle 10, Higüey', 'mariarod@hotmail.com'),
('José Pérez', '8293344556', 'Villa Mella, SDN', 'jperez@gmail.com'),
('Ana Castro', '8494455667', 'Bávaro, La Altagracia', 'anacastro@outlook.com'),
('Raúl Méndez', '8099988776', 'Jarabacoa', 'raulm@yahoo.com'),
('Sofía Reyes', '8295566778', 'Punta Cana', 'sofia.reyes@gmail.com');

INSERT INTO Venta (IdCliente, Total) VALUES
(1, 950.00), (2, 450.00), (3, 1600.00), (4, 3200.00), (5, 4800.00),
(6, 200.00), (7, 700.00), (8, 650.00), (9, 470.00), (10, 120.00);

INSERT INTO DetalleVenta (IdVenta, IdRepuesto, Cantidad, PrecioUnitario) VALUES
(1, 3, 1, 950.00),
(2, 4, 1, 450.00),
(3, 5, 1, 1600.00),
(4, 6, 1, 3200.00),
(5, 7, 1, 4800.00),
(6, 8, 1, 200.00),
(7, 9, 1, 700.00),
(8, 10, 1, 650.00),
(9, 1, 1, 350.00),
(9, 2, 1, 120.00);

INSERT INTO EntradaRepuesto (IdRepuesto, Pieza, FechaLlegada, Cantidad, Existencia, Observacion) VALUES
(1, 'Filtro de aceite', '2025-07-01', 50, 75, 'Llegada de proveedor AutoImport SRL'),
(2, 'Bujía NGK', '2025-07-02', 100, 200, 'Lote nuevo NGK'),
(3, 'Pastillas de freno', '2025-07-03', 20, 50, 'Reposición de stock'),
(4, 'Aceite 10W-30', '2025-07-04', 40, 100, 'Aceite sintético'),
(5, 'Amortiguador', '2025-07-05', 15, 30, 'Llegada amortiguadores'),
(6, 'Neumático 195/65R15', '2025-07-06', 25, 45, 'Ingreso neumáticos'),
(7, 'Alternador', '2025-07-07', 10, 18, 'Nuevo stock'),
(8, 'Bombillo H4', '2025-07-08', 60, 110, 'Alta demanda'),
(9, 'Cruzeta', '2025-07-09', 12, 22, 'Ingreso por devolución'),
(10, 'Juego Alfombra de goma', '2025-07-10', 35, 75, 'Lote nuevo');

INSERT INTO SalidaRepuesto (IdRepuesto, Pieza, FechaSalida, Cantidad, Existencia, Destino, Observacion) VALUES
(1, 'Filtro de aceite', '2025-07-11', 10, 65, 'Venta', 'Cliente 1001'),
(2, 'Bujía NGK', '2025-07-12', 15, 185, 'Venta', 'Mostrador'),
(3, 'Pastillas de freno', '2025-07-13', 5, 45, 'Taller interno', 'Servicio'),
(4, 'Aceite 10W-30', '2025-07-14', 10, 90, 'Venta', 'Sucursal Este'),
(5, 'Amortiguador', '2025-07-15', 3, 27, 'Mayorista', 'Factura 784'),
(6, 'Neumático 195/65R15', '2025-07-16', 8, 37, 'Taller externo', 'Contrato taller'),
(7, 'Alternador', '2025-07-17', 2, 16, 'Reparación', 'Instalación directa'),
(8, 'Bombillo H4', '2025-07-18', 20, 90, 'Venta', 'Promoción'),
(9, 'Cruzeta', '2025-07-19', 4, 18, 'Venta', 'Orden #4598'),
(10, 'Alfombra de goma', '2025-07-20', 12, 63, 'Taller interno', 'Stock taller');

SELECT * FROM Categoria;
SELECT * FROM Proveedor;
SELECT * FROM Repuesto;
SELECT * FROM Cliente;
SELECT * FROM Venta;
SELECT * FROM DetalleVenta;
SELECT * FROM EntradaRepuesto;
SELECT * FROM SalidaRepuesto;

SELECT 
    V.IdVenta,
    V.Fecha,
    C.Nombre AS Cliente,
    R.Nombre AS Repuesto,
    DV.Cantidad,
    DV.PrecioUnitario,
    (DV.Cantidad * DV.PrecioUnitario) AS Subtotal,
    V.Total
FROM Venta V
INNER JOIN Cliente C ON V.IdCliente = C.IdCliente
INNER JOIN DetalleVenta DV ON V.IdVenta = DV.IdVenta
INNER JOIN Repuesto R ON DV.IdRepuesto = R.IdRepuesto
ORDER BY V.IdVenta;

SELECT 
    'Entrada' AS TipoMovimiento,
    E.FechaLlegada AS Fecha,
    E.Pieza,
    E.Cantidad,
    E.Existencia,
    E.Observacion
FROM EntradaRepuesto E

UNION ALL

SELECT 
    'Salida' AS TipoMovimiento,
    S.FechaSalida AS Fecha,
    S.Pieza,
    S.Cantidad,
    S.Existencia,
    S.Observacion
FROM SalidaRepuesto S
ORDER BY Fecha;
