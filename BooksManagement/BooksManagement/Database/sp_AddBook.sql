USE [BooksManagement]
GO
-- =============================================
-- Author:		ThanhLNP
-- Create date: 2019/10/16
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_AddBook]
	@CategoryId INT,
	@Name NVARCHAR(200),
	@Author NVARCHAR(200),
	@SDescription NVARCHAR(MAX),
	@YearPublication INT,
	@Amount INT
AS
BEGIN
	DECLARE @ErrMsg NVARCHAR(2000), 
		@ErrSev SMALLINT, 
		@ErrSta SMALLINT

	DECLARE @Result INT = 0

	BEGIN TRANSACTION
	BEGIN TRY
		INSERT dbo.Book
				( CategoryId ,
				  Name ,
				  Author ,
				  SDescription ,
				  YearPublication ,
				  Amount 
				)
		VALUES  ( @CategoryId , -- CategoryId - int
				  @Name , -- Name - nvarchar(200)
				  @Author , -- Author - nvarchar(200)
				  @SDescription , -- SDescription - nvarchar(max)
				  @YearPublication , -- YearPublication - int
				  @Amount  -- Amount - int
				)

		SET @Result = 1
		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
    ROLLBACK TRANSACTION

	SELECT @ErrMsg = ERROR_MESSAGE(),
		@ErrSev = ERROR_SEVERITY(),
		@ErrSta = ERROR_STATE()

    RAISERROR(@ErrMsg, @ErrSev, @ErrSta)

    END CATCH

	SELECT @Result AS Result
END