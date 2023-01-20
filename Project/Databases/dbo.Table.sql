CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(101,1), 
    [username] VARCHAR(50) NOT NULL, 
    [password] VARCHAR(50) NOT NULL, 
    [firstname] VARCHAR(50) NOT NULL, 
    [lastname] VARCHAR(50) NULL, 
    [DOB] DATE NULL, 
    [email] VARCHAR(50) NULL, 
    [phone] BIGINT NULL
)
