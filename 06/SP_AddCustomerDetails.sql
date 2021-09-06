

CREATE PROCEDURE SP_AddCustomerDetails (@customer_name VARCHAR(100), @email varchar(100), @zipcode VARCHAR(10))
-- procedure inserts a new customer
AS BEGIN
  INSERT INTO Customer (name, Email, Zipcode)
  VALUES (@customer_name, @email, @zipcode);
END;
