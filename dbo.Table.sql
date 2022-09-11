CREATE TABLE Product
(
	[Product_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Product_title] NCHAR(20) NOT NULL, 
    [Product_type] NCHAR(20) NOT NULL, 
    [Product_descripation] NCHAR(100) NULL 
)
