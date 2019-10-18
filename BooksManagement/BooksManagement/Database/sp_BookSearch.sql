USE [BooksManagement]
GO
-- =============================================
-- Author:		ThanhLNP
-- Create date: 2019/10/16
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_BookSearch]
	@SearchValue NVARCHAR(1000) = '',
	@SearchId INT
AS
BEGIN
	SET @SearchValue = ltrim(rtrim(@SearchValue))

	Declare @Query nvarchar(MAX) = 'SELECT Book.Name, Category.Name AS CategoryName, Author, YearPublication, Amount FROM dbo.Book
									JOIN dbo.Category ON Category.Id = Book.CategoryId
									WHERE Book.isDelete = 0 '
	IF(@SearchId = 0) SET @Query += 'AND (Book.Name LIKE ''%' + @SearchValue + '%'' OR Category.Name LIKE ''%' + @SearchValue + '%'' OR Author LIKE ''%' + @SearchValue + '%'' OR YearPublication LIKE ''%' + @SearchValue + '%'' OR Amount LIKE ''%' + @SearchValue + '%'')'
	IF(@SearchId = 1) SET @Query += 'AND (Book.Name LIKE ''%' + @SearchValue + '%'')'
	IF(@SearchId = 2) SET @Query += 'AND (Category.Name LIKE ''%' + @SearchValue + '%'')'
	IF(@SearchId = 3) SET @Query += 'AND (Author LIKE ''%' + @SearchValue + '%'')'
	IF(@SearchId = 4) SET @Query += 'AND (YearPublication LIKE ''%' + @SearchValue + '%'')'
	IF(@SearchId = 5) SET @Query += 'AND (Amount LIKE ''%' + @SearchValue + '%'')'
	
	EXECUTE SP_EXECUTESQL @Query
END