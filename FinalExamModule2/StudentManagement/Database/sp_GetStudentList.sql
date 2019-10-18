USE [StudentManagement]
GO
-- =============================================
-- Author:		ThanhLNP
-- Create date: 2019/10/18
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetStudentList]

AS
BEGIN
	SELECT Student.Id, Student.Name, Language.Name AS LanguageName, Level.Name AS LevelName, DayOfBirth, Sex, Email
	FROM dbo.Student
	LEFT JOIN dbo.Language ON Language.Id = Student.LanguageId
	LEFT JOIN dbo.Level ON Level.Id = Student.LevelId
	WHERE Student.isDelete = 0
END