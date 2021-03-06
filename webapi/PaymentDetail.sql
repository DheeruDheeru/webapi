use sdirecttestdb

SELECT NEWID()  AS GUID;

Create table PaymentDetails
(
	ID uniqueidentifier not null default NEWID(),
	CardOwner nvarchar(100) not null,
	CardNumber nvarchar(16) not null,
	ExpiryDate nvarchar(5) not null,
	CVV nvarchar(3) not null,
	Constraint PK_PaymentDetails primary key (ID)
)

insert into PaymentDetails
(CardOwner,CardNumber,ExpiryDate,CVV)
values
('Mohit Chandra Joshi','1343267890123456','12/26','143'),
('Chandra Datt Pandey','0987654321123456','12/22','565')

select * from PaymentDetails;