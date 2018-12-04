CREATE TABLE [dbo].[Table]
(
	[UserId] INT NOT NULL PRIMARY KEY, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [UserBio] NVARCHAR(MAX) NULL, 
    [UserType] INT NOT NULL
)
