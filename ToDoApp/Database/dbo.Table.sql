CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] NVARCHAR(50) NULL, 
    [image] NVARCHAR(500) NULL, 
    [price] INT NULL, 
    [created_at] DATETIME NULL, 
    [updated_at] DATETIME NULL
)
