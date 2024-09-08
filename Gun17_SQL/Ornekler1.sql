-- Koþullar --

-- Kategorisi konfeksiyon olan ürünler
Select * From Products Where CategoryID = 3

-- ALFKI müþterisinin bütün sipariþlerini listele
Select * From Orders Where CustomerID = 'ALFKI'

-- Birim fiyatý 10 dolardan yüksek olan ürünleri listele
Select * From Products Where UnitPrice > 10.00

-- En yetkili personelleri listele
Select * From Employees Where ReportsTo is null 

-- 1 Numaralý çalýþanýmýn, 1996 yýlýnda girmiþ olduðu sipariþler
Select * From Orders 
	Where EmployeeID = 1 AND
			--ShippedDate >= '1996-01-01 00:00:00' AND
			--ShippedDate <= '1996-12-31 23:59:59'
			ShippedDate Between '1996-01-01 00:00:00' And '1996-12-31 23:59:59'

-- 2 numaralý kargo firmasýnýn 1997 yýlýnda taþýdýðý sipariþler
Select * From Orders
			Where ShipVia = 2 And
			Year(ShippedDate) = 1997

-- 2, 3 ve 4 numaralý kategorilerin hiç stoðu kalmamýþ ürünleri
Select  * From Products
	Where 
	--(CategoryID = 1 Or CategoryID = 2 Or CategoryID=3)
	CategoryID In(1,2,3)
	And UnitsInStock = 0


Select Count(*) FRom Products
	Where CategoryID = 1

Select Max(UnitPrice) From Products 


Select Min(UnitPrice) From Products

Select AVG(UnitPrice) From Products


SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Orders'

Select * From Orders