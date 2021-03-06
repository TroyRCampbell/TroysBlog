CREATE TABLE Comments (
	CommentId INT PRIMARY KEY IDENTITY(1,1),
	BlogId INT,
	Content NVARCHAR(MAX),
	AuthoredBy NVARCHAR(256) NOT NULL,
	AuthoredOn DATETIME NOT NULL,
	ModifiedBy NVARCHAR(256) NOT NULL,
	ModifiedOn DATETIME NOT NULL
)

ALTER TABLE Comments
ADD CONSTRAINT FK_BlogComment
FOREIGN KEY (BlogId) REFERENCES Blogs(BlogId)