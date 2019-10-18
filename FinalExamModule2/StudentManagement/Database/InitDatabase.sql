CREATE DATABASE StudentManagement
GO

USE StudentManagement
GO

CREATE TABLE Language (
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(200) NOT NULL,
isDelete BIT NOT NULL DEFAULT(0)
)
GO

CREATE TABLE Level (
Id INT PRIMARY KEY IDENTITY,
LanguageId INT FOREIGN KEY REFERENCES Language(Id) NOT NULL,
Name NVARCHAR(200) NOT NULL,
isDelete BIT NOT NULL DEFAULT(0)
)
GO

CREATE TABLE Student (
Id INT PRIMARY KEY IDENTITY,
LanguageId INT FOREIGN KEY REFERENCES Language(Id) NOT NULL,
LevelId INT FOREIGN KEY REFERENCES Level(Id) NOT NULL,
Name NVARCHAR(200) NOT NULL,
DayOfBirth DATE NOT NULL,
Sex BIT NOT NULL,
Email NVARCHAR(200) NOT NULL,
isDelete BIT NOT NULL DEFAULT(0)
)
GO

INSERT dbo.Language
        ( Name )
VALUES  
	( N'Tiếng Anh'  ),
	( N'Tiếng Pháp'  ),
	( N'Tiếng Nhật'  ),
	( N'Tiếng Hàn'  )
GO

INSERT dbo.Level
        ( LanguageId, Name )
VALUES  
	( 1, N'A1' ),
	( 1, N'A2' ),
	( 1, N'B1' ),
	( 1, N'B2' ),
	( 1, N'C1' ),
	( 1, N'C2' ),
	( 2, N'A1' ),
	( 2, N'A2' ),
	( 2, N'B1' ),
	( 2, N'B2' ),
	( 3, N'N3' ),
	( 3, N'N2' ),
	( 3, N'N1' ),
	( 4, N'TOPIK 1' ),
	( 4, N'TOPIK 2' )
GO

INSERT dbo.Student
        ( LanguageId ,
		  LevelId,
          Name ,
          DayOfBirth ,
          Sex ,
          Email
        )
VALUES  ( 1 , -- LanguageId - int
		  3,
          N'Lê Nguyễn Phước Thành' , -- Name - nvarchar(200)
          '1995-02-03' , -- DayOfBirth - date
          1 , -- Sex - bit
          N'lnpttor@gmail.com'  -- Email - nvarchar(200)
        )
GO 