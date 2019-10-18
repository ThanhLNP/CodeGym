USE [StudentManagement]
GO
-- =============================================
-- Author:		ThanhLNP
-- Create date: 2019/10/18
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_StudentSearch]
	@SearchValue NVARCHAR(1000) = '',
	@SearchId INT
AS
BEGIN
	SET @SearchValue = ltrim(rtrim(@SearchValue))

	Declare @Query nvarchar(MAX) = 'SELECT Student.Id, Student.Name, Language.Name AS LanguageName, Level.Name AS LevelName, DayOfBirth, Sex, Email
									FROM dbo.Student
									LEFT JOIN dbo.Language ON Language.Id = Student.LanguageId
									LEFT JOIN dbo.Level ON Level.Id = Student.LevelId
									WHERE Student.isDelete = 0 '

	IF(@SearchId = 0) SET @Query += 'AND Student.Name LIKE ''%' + @SearchValue + '%'
	IF(@SearchId = 1) SET @Query += 'AND Email LIKE ''%' + @SearchValue + '%'

	EXECUTE SP_EXECUTESQL @Query
END