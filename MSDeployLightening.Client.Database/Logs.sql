CREATE TABLE [dbo].[Logs]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [LoggedAt] DATETIME NOT NULL, 
    [Method] VARCHAR(50) NOT NULL, 
    [Response] VARCHAR(50) NOT NULL
)
