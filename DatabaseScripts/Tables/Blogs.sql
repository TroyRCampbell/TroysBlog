CREATE TABLE Blogs (
	BlogId INT PRIMARY KEY IDENTITY(1,1),
	Title NVARCHAR(120) NOT NULL,
	ImagePath NVARCHAR(250), 
	Summary NVARCHAR(250),
	Content NVARCHAR(MAX),
	AuthoredBy NVARCHAR(256) NOT NULL,
	AuthoredOn DATETIME NOT NULL,
	ModfiedBy NVARCHAR(256) NOT NULL,
	ModifiedOn DATETIME NOT NULL,
	Active BIT NOT NULL DEFAULT(0)
)