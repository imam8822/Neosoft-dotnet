CREATE PROCEDURE SP_AddCustomerLogin (@CustomerId int,@username VARCHAR(15),@password varchar(20))
-- procedure inserts a new customer
AS BEGIN
  INSERT INTO Login (CustomerId, username, password)
  VALUES (@CustomerId, @username, @password);
END;

