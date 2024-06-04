use Northwind

select*from [dbo].[Customers]
select*from [dbo].[Employees]
select*from [dbo].[Products]
select*from [dbo].[Order Details]
select*from [dbo].[Orders]
select*from [dbo].[Categories]
select*from [dbo].[Shippers]
select*from [dbo].[Shippers]

-- replicacion de bd

--	12/04/2024
select*from Products
execute sp_helpindex 'products';

--		muestre la cantidad de productos de Products
select count (productid) as [Cantidad de productos]from products;

--		muestre la suma de los precios unitarios de los productos, agg un alias
select sum(UnitPrice) as [Suma de los precios] from Products

--		muestre el promedio de todos los precios de los productos, agg un alias
select avg(UnitPrice) as [Promedio de precios]  from Products

--		muestre el producto mas caro
select max(UnitPrice) [Precio mayor]  from Products

--		muestre el producto mas economico
select min(UnitPrice) [Precio menor]  from Products

--		muestre la cantidad de veces que se repite un producto
select distinct (productName) as [Nombre de los productos], count(*) as [Repite]
from Products where productName like 'l%o%' or  ProductName='chai' group by Products.ProductName


select count (ProductName) as [Cantidad]from products where UnitPrice>(select 
MAX(unitPrice) from Products)

select count (ProductName) as [Cantidad]from products where UnitPrice<(select 
min(unitPrice) from Products)

select count (ProductName) as [Cantidad]from products where UnitPrice<(select 
count(unitPrice)'precio mayor' from Products)

select ProductName, UnitPrice as precios from Products order by precios asc

--	22-04-2024		Procedimientos almacenados (parical 4)
	--	GUIA 222
select GETDATE() as [Fecha y hora]

create procedure Mostrar_producto
@productId int
as
select ProductName from products 
where ProductID=@productId

exec Mostrar_producto 10

create procedure MostrarProductoPrecios
@precio money
as
select productName, unitPrice from Products
where UnitPrice=@precio

exec MostrarProductoPrecios 5

-- 26-04-2024
	-- Segunda dia prodAlma
select*from Categories

/*
1. Utilice la base de datos de northwind y crear un procedimiento almacenado para
ingresar nuevas categorías, primero se debe verificar si existe el nombre o el
código de categoría en la tabla.
*/
create proc sp_insertar_categorias
--variables, tipo de dato acorde a la informacion que se compara con los campos
	@codigocategorias int,
	@nombrecategoria varchar (50)
as
if (select COUNT(*) from Categories where CategoryID=@codigocategorias
or CategoryName=@nombrecategoria)=0 
-- si es igual  a 0 es porque no existe nasda igual a ese nombre
insert into Categories(CategoryName) values (@nombrecategoria)
else
print 'Error ya existe un codigo o nombre en la tabla'

/*
no se ejecutara porque ya existe  CategoryID=6 and CategoryName='Seafood'

		execute sp_insertar_categorias 13, 'Seafood';
		execute sp_insertar_categorias 6, 'Camara';
*/

select*from Categories
execute sp_insertar_categorias 14, 'Computadora';

/*
2. Utilice la base de datos Northwind y cree un procedimiento almacenado para
verificar si existen clientes en una ciudad determinada. Utilice la sentencia
case.
*/
select*from Customers

create proc sp_encontrar_clientes
@ciudad varchar (50)
as
select
case (select COUNT(*) from Customers where City=@ciudad)
when 0 then 'No hay clientes en la ciudad de: '+@ciudad
/*when, en caso de que:*/
/*then, entonces:*/
else 'Si existen clientes en la ciudad: '+@ciudad
end

--buscar clientes en la libertad
exec sp_encontrar_clientes 'londo'

select COUNT(*) as Repite from Customers where City='london'

/*
3. Mostrar el mensaje si hay o no clientes en una ciudad determinada, además 
mostrar quienes son esos clientes
*/
create procedure sp_encontrar_clientes_detalle
@ciudad varchar (50)
as
select * from Customers where City=@ciudad
select -- se realiza una subConsulta luego del primer select
case (select COUNT(*) from Customers where City=@ciudad)
when 0 then 'No hay clientes de: '+@ciudad
else 'Si hay clientes en la ciudad de: '+@ciudad
end

exec sp_encontrar_clientes_detalle 'london';

/*
4. Modificar el procedimiento almacenado anterior para que en lugar de mostrar 
todas las columnas de los clientes encontrados que muestre el CustomerID 
con alias 'Código', CompanyName con alias 'Nombre cliente',
city con alias 'Ciudad', Country con alias 'Pais',Address con alias 'Direccion',
Phone con alias 'Telefono'
*/
create procedure sp_encontrar_cliente_detalle
@ciudad varchar (50)
as
select 
CustomerID as 'Codigo', 
CompanyName as [Nombre cliente], 
City 'Ciudad', 
Country as 'Pais',
Address as 'Direccion',
Phone 'Telefono'
from Customers where City=@ciudad
select -- se realiza una subConsulta luego del primer select
case (select COUNT(*) from Customers where City=@ciudad)
when 0 then 'No hay clientes de: '+@ciudad
else 'Si hay clientes en la ciudad de: '+@ciudad
end

exec sp_encontrar_clientes_detalle 'london';
exec sp_encontrar_clientes_detalle 'paris';
exec sp_encontrar_clientes_detalle 'sao paulo';

-- eliminar este ultimo prodAlma
	drop proc sp_encontrar_clientes_detalle

--	29-04-2024		Triggers o disparadores
select*from Categories

--	trigger para insertar
create trigger Insert_categoria 
on categories
for insert 
as 
print 'Se ha agregado una nueva categoria'
go
insert into Categories values ('Higiene', 'Pasta dental Papel Higienico','')

--	trigger para actualizar
select*from Categories
create trigger Modificar_categoria
on categories
for update
as
print 'Se ha actualizado una categoria'
go
update Categories
set CategoryName='Sabrosadores'
where CategoryID=2

--	trigger para eliminar
select*from Categories
create trigger Eliminar_categoria
on categories
for delete
as
print 'Se ha eliminado una categoria'
go
delete from Categories where CategoryID=1010

select *from Categories

insert into Categories (CategoryName) values
('Verduras'),('Frutras'),('Cereales')

/*crear un trigger que permita comprobar que se registre una categoria, 
si existe un nombre igual a la categoría, mandar un mensaje que le diga que la 
categoría ya se encuentra registrada.*/
create trigger tr_EliminarUnSoloCategoria
on categories
for delete
as
if(select COUNT (*) from deleted)>1
begin
print 'No puedes eliminar mas de un registro'
rollback tran --	los cambios que hicieron devuelvan, deshaga lo que se hizo
end

------------	visualizar los triggers
					select*from sys.triggers
select *from Categories

delete Categories where CategoryID=9

delete Categories where CategoryID in (1011,1013)

create trigger TrCategoriasSinRepetir
on categories
for insert
as
if(select count(*) from inserted,Categories
where inserted.CategoryName=Categories.CategoryName)>1
begin
rollback transaction
print 'El nombre de la categoria ya Existe elije otro nombre....'
end
else
print 'La categoria se Registro con Exito en la base de datos'

select*from [dbo].[Categories]
select*from [dbo].[Customers]
select*from [dbo].[Employees]
select*from [dbo].[Order Details]
select*from [dbo].[Orders]
select*from [dbo].[Products]
select*from [dbo].[Shippers]
select*from [dbo].[Shippers]
select*from [dbo].[CustomerCustomerDemo]
select*from [dbo].[CustomerDemographics]
select*from [dbo].[EmployeeTerritories]
select*from [dbo].[Region]
select*from [dbo].[Territories]


--	03-05-2024		LOS JOIN
--	1.	Mostrar el nombre del empleado y nombre el territoio que atiende
select e.FirstName, e.LastName, t.TerritoryDescription from Employees e inner join
EmployeeTerritories y on y.EmployeeID=e.EmployeeID inner join Territories t on
t.TerritoryID=y.TerritoryID

--	2.	muestre el nombre, apellido y ciudad de los empleados que vivan en la mimsa ciudad
	select e.FirstName, j.FirstName, j.City  from Employees e inner join Employees j on 
	j.EmployeeID=e.ReportsTo where j.City=e.City
/*		select FirstName+' '+LastName as Nombre, City from Employees 
where City like '%london%'		*/	

/*
3. Consultar el nombre del producto, categoría a la que pertenece y el proveedor. 
Mostrar el nombre de la categoría que inicie con cualquier texto, tenga un espacio 
en blanco y termine con cualquier texto.
*/
select p.ProductName, c.CategoryName, s.CompanyName from Products p inner join Categories c
on c.CategoryID=p.CategoryID inner join Suppliers s on s.SupplierID=p.SupplierID
where CategoryName like '% %'

/*
4.	muestre las ordenes donde el producto sea queso y que se han vendido menor
o igual a 5 productos
*/
select p.ProductName, o.Quantity from Products p inner join 
[Order Details] o on p.ProductID=o.ProductID where 
ProductName like 'queso%' and o.Quantity<=5
/*
muestre el folio de la orden, la fecha, el nombre del empleado y la edad, 
ordenar por edad de menor a mayor
*/
select o.OrderID, o.OrderDate, e.FirstName, e.LastName , 
datediff(year, e.BirthDate, OrderDate) as edad from Orders o inner join 
-- para sacar la edad funciona, diferencia de años
Employees e on e.EmployeeID=o.EmployeeID order by edad

------------		UNIDAD 3-Funciones del sistema			06-05-2024
	-- sql left: funcion de texto.
-- extraer 12 caracteres de Ejemplo de left()
select left('Ejemplo de left()', 12) as resultado

select left ('El salvador es un pais pequeño pero bonito', 25) as resultado

-- mostrar 15 caracteres de la descripcion de la categoria
select CategoryID as 'Cod_Categoria', CategoryName, left(Description, 15) 
as resultado  from Categories

select LastName+ ' ' + FirstName as nombre, left (title,15) as resultado from Employees

select right('Esto es solo un ejemplo', 4) as resultado

	-- sql right: funcion de texto.
select right('Ejemplo de left()', 8) as resultado
select LastName+ ' ' + FirstName as nombre, right(title,15) as resultado from Employees

select CONCAT(lastname, ' ',FirstName) as resultado, left (title, 11) as titulo
from Employees

select *from Employees
select concat(TitleOfCourtesy,' ', FirstName,' ', LastName) as 'titulo y nombre' 
from Employees 
where concat(FirstName,' ', LastName) ='Laura Callahan'

	-- sql ISNULL
select*from Categories
select CategoryID , CategoryName, isnull(description, 'sin descripcion') from Categories

select left(OrderDate, 10)  as 'fecha de pedido', ShipName, ShipCity,
isnull(shipREgion, 'Sin region') as region
from Orders

-- Parcial 4; trigguers, prodAlma, joins, funciones
select*from [dbo].[Categories]
select*from [dbo].[Customers]
select*from [dbo].[Employees]
select*from [dbo].[Order Details]
select*from [dbo].[Orders]

select*from [dbo].[Shippers]
select*from [dbo].[Shippers]
select*from [dbo].[CustomerCustomerDemo]
select*from [dbo].[CustomerDemographics]
select*from [dbo].[EmployeeTerritories]
select*from [dbo].[Region]
select*from [dbo].[Territories]
-----------	13-05-2024
--	sql Cast, convertir un valor	--------------------------

-- la parte entera del precio
select ProductName, cast(UnitPrice as int )'precio entero' from Products

-- la fecha de pedido convertida en DATE
select OrderID, cast(orderDate as date) 'fecha sin el tiempo' from Orders

-- sql datepart, devuelve parte de una fecha	---------
select getdate() as 'fecha', 
datepart(d, getdate()) as 'dia',
datepart (m, getdate()) as 'mes',
datepart (yyyy, getdate()) as 'año'

select OrderID, CustomerID, 
		datepart(yyyy, OrderDate)as 'year', 
		datepart(m, OrderDate) 'month', 
		datepart(d, OrderDate) as 'day'
from Orders where CustomerID= 'QUICK'

----		EJERCICIO PARCIAL 4		---
create trigger Ins_Categoria
on categories
for insert
as
if(select count(*) from inserted join Categories
on inserted.CategoryName=Categories.CategoryName)>1
begin
rollback transaction
print 'Error al insertarla'
end
else
print 'Se realizo correctamente'

insert into Categories (CategoryName)  values ('Flores')
select*from [dbo].[Categories]
------

-- 20/05/2024		Funciones definidas por el usuario.

--		1.	Funcion para calcular el promedio
create function promedio(
@num1 float,
@num2 float
)
returns float
as begin
	declare @resultado float
	set @resultado=(@num1+@num2)/2
	return @resultado
end

select dbo.promedio(6, 5.9) 'promedio'

print 'resultado: '+cast(dbo.promedio(6, 5.9) as varchar)

/*
		2.	muestre el valor de la cantidad que corresponde a la multiplicacion del precio unitario
y las unidades en stock de un producto especifico
*/
create function ventas(
@codigoProducto int
)
returns float
as
begin
	declare @precioUnitario float, @unidadesEnStock int, @resultado float
	select @precioUnitario=unitPrice,  @unidadesEnStock=unitsInStock from Products
	where ProductID=@codigoProducto
	set @resultado=@precioUnitario*@unidadesEnStock
	return @resultado
end
select dbo.ventas(1) as 'valor de la multipliacion'
print 'Multiplicacion: '+cast(dbo.ventas(1) as char(5))
		-- select ProductID, UnitPrice, UnitsInStock, dbo.ventas(1) from Products

/*
		3.	Crear una función para aplicar descuentos a los productos, el resultado debe mostrar el 
nombre del producto, el precio sin descuento y el nuevo precio.
*/
create function descuento(
@porcentaje_descuento money
)
returns table
as
return (select ProductName, UnitPrice as 'precio sin descuento', 
(UnitPrice-UnitPrice*@porcentaje_descuento/100) as 'Nuevo precio' from Products)

select*from descuento(10)
--		4.	modificar
alter function descuento(
@porcentaje_descuento money
)
returns table
as
return (select ProductName, UnitPrice as 'precio sin descuento', 
(UnitPrice-UnitPrice*@porcentaje_descuento/100) as 'Nuevo precio', 
(UnitPrice*@porcentaje_descuento/100) as 'ahorro con bukele'
from Products)
select*from descuento(10)

/*
		5.	El proveedor con código 3 desea aplicarle un descuento a todos sus productos, por lo que 
se desea una función que muestre el código de proveedor, el nombre del producto, el precio 
sin descuento, el nuevo precio y la cantidad ahorrada por producto.
*/

create function descuento_proveedor(
@porcentaje_descuento money,
@codigo_proveeedor int
)
returns table
as
return(select  SupplierID, ProductName, UnitPrice as 'precio sin descuento', 
			(UnitPrice-UnitPrice*@porcentaje_descuento/100) as 'Nuevo precio',
			(UnitPrice*@porcentaje_descuento/100) as 'Ahorro'
from Products where SupplierID=@codigo_proveeedor)
select*from descuento_proveedor(10, 1) 
-- (10, 1)
-- 10=@porcentaje_descuento, 1=@codigo_proveeedor 

--		24/05/2024		FUNCIONES

--	escalares, valores de tabla son los que retornan las funciones
/*		6.	Cree una función que permita mostrar la edad del empleado, para mostrar el resultado
se debe ingresar el código de empleado
*/
alter function Edad_empleado(
@codigo_empleado int
)
returns table
as
return (select concat(FirstName, ' ', LastName) as 'Nombre de empleado', 
datepart(year,birthDate) as 'nacimiento',
datepart(yy, getdate())-datepart(yy, BirthDate) as 'Edad' from Employees
where EmployeeID=@codigo_empleado)
--	ejecutando
select*from dbo.Edad_empleado(4)

/*		7.	Se necesita mostrar en letras la fecha de un pedido, para ello se necesita ingresar 
el orden de pedido. Antes de crear la función evaluar si esta ya existe.
*/
if OBJECT_ID('fecha_texto') is not null	--evaluar si la funcion existe
begin
	drop function fecha_texto
end
go
create function fecha_texto(
@codigoPedido int
)
returns table
as
return (select concat(day(orderDate), ' de ' ,datename(month, orderdate), ' del ',
year (orderDate)) as 'fecha de pedido' from Orders where OrderID=@codigoPedido)

select*from Orders
select*from dbo.fecha_texto(10249)

/*		8.	Se necesita mostrar en letras la fecha de un pedido, consulte la tabla orders. 
Antes de crear la función evaluar si esta ya existe.
*/
if OBJECT_ID('fecha_texto_todos') is not null	--evaluar si la funcion existe
begin
	drop function fecha_texto_todos
end
go
create function fecha_texto_todos(
	@fecha date
)
returns varchar(50)
as
begin
	declare @conversion varchar(50)
	set @conversion=concat(day(@fecha), ' de ', datename(month, @fecha), ' del ', year(@fecha))
	return @conversion
end

select dbo.fecha_texto_todos ('2024-02-06') as 'fecha en letras'

/*		10.	Con la función de convertir fechas en textos consulte la tabla Orders y muestre el 
código del pedido, las fechas de pedido (OrderDate) y envío (ShippedDate).
*/
select OrderID, dbo.fecha_texto_todos(orderDate) as 'Fecha de pedido', 
dbo.fecha_texto_todos(ShippedDate) as 'Fecha de envio' from Orders

/*		11.		Utilice la función anterior para mostrar en texto la fecha de nacimiento del 
empleado, concatene con una función del sistema el nombre completo del empleado.
*/
select concat(firstname, ' ',lastname) as nombre, dbo.fecha_texto_todos(birthdate) as 
'fecha de nacimiento' from Employees

/*		12 Haga uso de un join y consulte las tablas Orders y Customers de la base 
de datos Northwind para mostrar el código de pedido (OrderId), el nombre del cliente 
(CompanyName) y la fecha del pedido (OrderDate) únicamente del cliente 'LILA-Supermercado'. 
Para mostrar la fecha del pedido debe hacer uso de la función de convertir textos a letras.
*/
select o.OrderID, c.CompanyName, dbo.fecha_texto_todos(o.OrderDate) 
'Fecha de pedido' from Orders o inner join Customers c on 
o.CustomerID=c.CustomerID where c.CompanyName='LILA-Suoermercado'



