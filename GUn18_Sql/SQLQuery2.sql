Select * From Categories

Select CategoryName, Description From Categories

Select * From Products 
Where SupplierID = 2

Select * From Products Where UnitPrice >= 10

Select * From Products Where UnitPrice >= 10 And UnitPrice <= 20
Select * From Products Where ProductName = 'Perth Pasties'

Select * From Orders 
Where OrderDate >= '1997-01-01 00:00:00' 
	And  OrderDate <= '1997-12-31 23:59:59'

Select * From Orders
Where OrderDate Between '1997-01-01 00:00:00' And '1997-12-31 23:59:59'

-- Ürün tablosunda 1,3 ve 5 CategoryID deðerlerine sahip ürünleri getir
Select * From Products
Where CategoryID =1 Or CategoryID = 3 OR CategoryID = 5

Select * FRom Products
Where CategoryId In (1,3,5)

-- 1 Numaralý personelin 1996 yýlýnda kaydettiði sipariþlerin listesi
Select * From Orders 
Where EmployeeID = 1 And OrderDate >= '1996-01-01' 
				And OrderDate <= '1996-12-31'

-- Berline kayýtlý olan müþterilerin listesini getirin. 
Select * From Customers Where City = 'Berlin'

Select Count(*) From Customers where Country = 'USA'

Select Min(UnitPrice) From  Products

Select Max(UnitPrice) From  Products

Select Avg(UnitPrice) From  Products

Select CategoryID From Products
	Group By CategoryID

Select CategoryID, Count(*) From Products
	Group By CategoryID
	
-- Müþteri ID bazýnda sipariþ sayýlarýný getiren sorguyu yazýnýz. 
Select CustomerId,Count(*) From Orders Group By CustomerID

-- Hangi kategoriye ait ve hangi stok saðlayýcýsýna ait toplam kaç ürünüm var

-- Kategori ve Stok Saðlayýcýsý bazýnda toplam ürün sayýsý listesi
Select CategoryId, SupplierID, Count(*) From Products
	Group By CategoryID, SupplierID

-- Ülke ve þehir bazýnda, 1997 yýlýna ait toplam sipariþ sayýlarý listesi
Select ShipCountry,ShipCity,Count(*) 
From Orders 
Where OrderDate Between '1997-01-01' And '1997-12-31'
Group By ShipCountry,ShipCity

-- Kargo firmasý ve personel bazýnda toplam sipariþ sayýlarý
Select EmployeeID, ShipVia, Count(*) From Orders
Group By EmployeeID, ShipVia
Order By EmployeeID, ShipVia

-- Order by sýralama için kullanýlýr. 
-- Ascending
Select * From Categories Order By CategoryID Asc
-- Descending
Select * From Categories Order By CategoryID Desc

Select * From Categories Order By CategoryName

-- kategori id ve stok saðlayýcýsý
-- bazýnda ortalama ürün fiyatlarý ne kadar

Select CategoryID, SupplierID, Avg(UnitPrice) From Products
Group By CategoryID, SupplierID


-- SUM = toplamýný almak için kullanýlan aggrigate function
Select Sum(UnitPrice) From Products





-- Join
-- Ýlkel birleþim yöntemi. 
Select Categories.CategoryID,Categories.CategoryName,
		Products.ProductID, Products.ProductName
From
	Categories,Products
Where Categories.CategoryID = Products.CategoryID
Order By Categories.CategoryID

-- Orders ve OrderDetails tablolarýný, OrderID kolonu
-- üzerinden birleþtirin. 

Select Orders.*, [Order Details].* From Orders,[Order Details]
Where Orders.OrderId = [Order Details].OrderId

-- Join keyword
Select Orders.*, [Order Details].* 
From Orders 
	Inner Join [Order Details] 
		On Orders.OrderID = [Order Details].OrderId
Where 
	Orders.OrderDate > '1996-01-01'

-- 1996 yýlýnda hangi kargo firmasýyla toplam ne kadarlýk
-- sipariþ sevkiyatý yapmýþým. 
--Select Orders.ShipVia, Sum([Order Details].Quantity * [Order Details].UnitPrice) 
--From Orders	
--	Inner Join [Order Details] 
--		On Orders.OrderID = [Order Details].OrderID
--Where 
--	Orders.OrderDate Between '1996-01-01' And '1996-12-31'
--Group By
--	Orders.ShipVia

-- 1996 yýlýnda hangi kargo firmasýyla toplam ne kadarlýk
-- sipariþ sevkiyatý yapmýþým. 
Select 
o.ShipVia, Sum(od.UnitPrice * od.Quantity) Toplam 
From Orders o
	Inner Join [Order Details] od
		On o.OrderID = od.OrderID
Where 
	o.OrderDate Between '1996-01-01' And '1996-12-31'
Group By
	o.ShipVia
Order By
	Toplam Desc


Select ShipVia,Toplam From (Select 
o.ShipVia, Sum(od.UnitPrice * od.Quantity) Toplam 
From Orders o
	Inner Join [Order Details] od
		On o.OrderID = od.OrderID
Where 
	o.OrderDate Between '1996-01-01' And '1996-12-31'
Group By
	o.ShipVia) TBL