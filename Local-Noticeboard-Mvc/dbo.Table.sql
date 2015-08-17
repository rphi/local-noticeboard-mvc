CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserId] INT NOT NULL, 
    [Category] TEXT NULL, 
    [Title] TEXT NULL, 
    [Body] TEXT NULL, 
    [Timestamp] TIMESTAMP NOT NULL DEFAULT GETDATE(), 
    [Ranking] INT NOT NULL DEFAULT 0
)
