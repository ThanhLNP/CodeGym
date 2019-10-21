USE [StudentManagement]
GO
-- =============================================
-- Author:		ThanhLNP
-- Create date: 2019/10/18
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetLevelList]
	@LanguageId INT
AS
BEGIN
	SELECT Id, Name
	FROM dbo.Level
	WHERE isDelete = 0 AND LanguageId = @LanguageId
END