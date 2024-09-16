-- MüþteriAdý ve KargoFirmasýId bazýnda toplam satýþ tutarlarý
-- MüþteriAdý     KargoFirmasýId      ToplamSatýþTutarý

Select 
	c.CompanyName, o.ShipVia, SUM(od.UnitPrice * od.Quantity)
From Customers c
	Inner Join Orders o 
		On o.CustomerID = c.CustomerID
	Inner Join [Order Details] od
		On o.OrderID = od.OrderID
Group By
	c.CompanyName, o.ShipVia

Go

-- Hangi kategoriden, hangi personelim, toplam ne kadarlýk satýþ 
-- yapmýþ. 

Select 
	c.CategoryID, e.EmployeeID, Sum(od.UnitPrice * od.Quantity)
From Employees e
	Inner Join Orders o 
		On e.EmployeeID = o.EmployeeID
	Inner Join [Order Details] od
		On o.OrderID = od.OrderID
	Inner Join Products p
		On od.ProductID = p.ProductID
	Inner Join Categories c
		On p.CategoryID = c.CategoryID
Group By
	c.CategoryID, e.EmployeeID


Go
Select 
	c.CategoryID, c.CategoryName, p.ProductID, p.ProductName
From Categories c Left Outer Join Products p 
		On c.CategoryID = p.CategoryID
Go
Select
	c.CategoryID, c.CategoryName, p.ProductID, p.ProductName
From Products p Right Outer Join Categories c 
	On p.CategoryID = c.CategoryID

Go
Select Year(OrderDate), Month(OrderDate), Day(OrderDate) From Orders

-- Personellerin yýl ve ay bazýnda toplam satýþ tutarlarýný listeleyiniz.

Select 
	(e.FirstName + ' ' + e.LastName) as 'Ýsim',
	IsNull(Year(o.OrderDate),0) As 'Yýl',
	IsNull(Month(o.OrderDate),0) As 'Ay',
	IsNull(Sum(od.UnitPrice * od.Quantity),0) As 'Toplam Satýþ'
From Employees e
	Left Outer Join Orders o On e.EmployeeID = o.EmployeeID
	Left Join [Order Details] od On o.OrderID = od.OrderID
Group By
	(e.FirstName + ' ' + e.LastName), Year(o.OrderDate), Month(o.OrderDate)

Go
-- Hangi Kargo firmasý ile, hangi stok saðlayýcýsýndan temin ettiðim 
-- ürünlerden toplam kaç adet göndermiþim
-- Tüm kargo firmalarý ve tüm stok saðlayýcýlarý listede görünecek. 

Select 
	sh.CompanyName, sp.CompanyName, Sum(od.Quantity) toplam
From 
	Orders o 
		Inner Join [Order Details] od On o.OrderID = od.OrderID
		Inner Join Products p On p.ProductID = od.ProductID

		Right Outer Join Suppliers sp on sp.SupplierID = p.SupplierID
		Right Outer Join Shippers sh on sh.ShipperID = o.ShipVia
Group By
	sh.CompanyName, sp.CompanyName