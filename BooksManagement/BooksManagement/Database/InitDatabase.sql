CREATE DATABASE BooksManagement
GO

USE BooksManagement
GO

CREATE TABLE Category (
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(200) NOT NULL,
isDelete BIT NOT NULL DEFAULT(0)
)
GO

CREATE TABLE Book (
Id INT PRIMARY KEY IDENTITY,
CategoryId INT FOREIGN KEY REFERENCES Category(Id),
Name NVARCHAR(200) NOT NULL,
Author NVARCHAR(200) NOT NULL,
SDescription NVARCHAR(MAX),
YearPublication INT NOT NULL,
Amount INT NOT NULL DEFAULT(0),
isDelete BIT NOT NULL DEFAULT(0)
)
GO

INSERT dbo.Category (Name)
VALUES
(N'Sách giáo khoa'),
(N'Truyện trinh thám'),
(N'Thiên văn học'),
(N'Truyện giả tưởng'),
(N'Tiểu thuyết')
GO

INSERT dbo.Book
        ( CategoryId ,
          Name ,
          Author ,
          SDescription ,
          YearPublication ,
          Amount
        )
VALUES  ( 3 , -- CategoryId - int
          N'Huyền Thoại Về Các Chòm Sao' , -- Name - nvarchar(200)
          N'Unknown' , -- Author - nvarchar(200)
          N'' , -- SDescription - nvarchar(max)
          2017 , -- YearPublication - int
          10  -- Amount - int
        )
GO