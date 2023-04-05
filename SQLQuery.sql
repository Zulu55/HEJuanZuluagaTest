SELECT CONCAT(Customers.FirstName, ' ', Customers.LastName) AS [Full Name], Customers.Age, Orders.OrderId, 
	   Orders.DateCreated, Orders.MethodofPurchase AS [Purchase Method], OrderDetails.ProductNumber, 
	   OrderDetails.ProductOrigin
FROM   Customers INNER JOIN
       Orders ON Customers.PersonId = Orders.CustomerPersonId INNER JOIN
       OrderDetails ON Orders.OrderId = OrderDetails.OrderId
WHERE  (OrderDetails.ProductId = 1112222333)