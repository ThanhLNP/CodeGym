USE [BooksManagement]
GO
-- =============================================
-- Author:		ThanhLNP
-- Create date: 2019/10/16
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetBook]
	@Id INT
AS
BEGIN
	SELECT Book.Id, Category.Name AS CategoryName, Book.Name, Author, SDescription, YearPublication, Amount 
	FROM dbo.Book 
	JOIN dbo.Category ON Category.Id = Book.CategoryId AND Category.isDelete = 0
	WHERE Book.Id = @Id AND Book.isDelete = 0
END