INSERT INTO Blogs (Title, Summary, Content, ImagePath, AuthoredBy, AuthoredOn, ModfiedBy, ModifiedOn, Active)
VALUES
('My Very First Blog!'
, 'The summary for my very first blog.'
, 'Lorem ipsum has become the industry standard for design mockups and prototypes. By adding a little bit of Latin to a mockup, you’re able to show clients a more complete version of your design without actually having to invest time and effort drafting copy.'
, './Content/Images/Default.jpg'
, 'Troy Campbell'
, GETDATE()
, 'Troy Campbell'
, GETDATE()
, 1)

INSERT INTO Blogs (Title, Summary, Content, ImagePath, AuthoredBy, AuthoredOn, ModfiedBy, ModifiedOn, Active)
VALUES
('My Second Blog!'
, 'The summary for my second blog.'
, 'Lorem ipsum has become the industry standard for design mockups and prototypes. By adding a little bit of Latin to a mockup, you’re able to show clients a more complete version of your design without actually having to invest time and effort drafting copy.'
, './Content/Images/Default.jpg'
, 'Troy Campbell'
, GETDATE()
, 'Troy Campbell'
, GETDATE()
, 1)

INSERT INTO Blogs (Title, Summary, Content, ImagePath, AuthoredBy, AuthoredOn, ModfiedBy, ModifiedOn, Active)
VALUES
('An Inactive Blog'
, 'This shouldn''t show because the blog is inactive.'
, 'Lorem ipsum has become the industry standard for design mockups and prototypes. By adding a little bit of Latin to a mockup, you’re able to show clients a more complete version of your design without actually having to invest time and effort drafting copy.'
, './Content/Images/Default.jpg'
, 'Troy Campbell'
, GETDATE()
, 'Troy Campbell'
, GETDATE()
, 0)


INSERT INTO Comments (BlogId, Content, AuthoredBy, AuthoredOn, ModifiedBy, ModifiedOn)
VALUES
(1, 'This is the best comment ever!', 'Awesome Commenter', GETDATE(), 'Awesome Commenter', GETDATE())

INSERT INTO Comments (BlogId, Content, AuthoredBy, AuthoredOn, ModifiedBy, ModifiedOn)
VALUES
(1, 'This is also a pretty great comment, though maybe not quite as good', 'PrettyGreat Commenter', GETDATE(), 'PrettyGreat Commenter', GETDATE())

INSERT INTO Comments (BlogId, Content, AuthoredBy, AuthoredOn, ModifiedBy, ModifiedOn)
VALUES
(2, 'Whoa! I''m the first person to comment on the second blog!', 'First Commenter', GETDATE(), 'First Commenter', GETDATE())

INSERT INTO Comments (BlogId, Content, AuthoredBy, AuthoredOn, ModifiedBy, ModifiedOn)
VALUES
(3, 'This is a comment on the inactive blog! I''m so devious.', 'Devious Commenter', GETDATE(), 'Devious Commenter', GETDATE())