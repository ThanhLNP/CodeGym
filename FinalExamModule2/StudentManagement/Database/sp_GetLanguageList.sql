USE [StudentManagement]
GO
-- =============================================
-- Author:		ThanhLNP
-- Create date: 2019/10/18
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetLanguageList]

AS
BEGIN
	SELECT Id, Name
	FROM dbo.Language
	WHERE isDelete = 0
END