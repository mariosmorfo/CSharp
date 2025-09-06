USE Students7DB;
GO

CREATE TABLE Students (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Firstname NVARCHAR(50) NOT NULL,
	Lastname NVARCHAR(50) NOT NULL,
)

GO

INSERT INTO Students (Firstname, Lastname)
VALUES 
	('Μάριος', 'Μορφονίδης'),
	('Αλέξης', 'Παπάς'),
	('Νίκος', 'Ιωάννου');