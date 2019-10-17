USE [BooksManagement]
GO
-- =============================================
-- Author:		ThanhLNP
-- Create date: 2019/10/16
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetCategoryList]

AS
BEGIN
	SELECT Id, Name FROM dbo.Category WHERE isDelete = 0
END