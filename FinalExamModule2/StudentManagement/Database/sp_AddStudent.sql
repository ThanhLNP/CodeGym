USE [StudentManagement]
GO
-- =============================================
-- Author:		ThanhLNP
-- Create date: 2019/10/18
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_AddStudent]
	@LanguageId INT,
	@LevelId INT,
	@Name NVARCHAR(200),
	@DayOfBirth DATE,
	@Sex BIT,
	@Email NVARCHAR(200)
AS
BEGIN
	DECLARE @ErrMsg NVARCHAR(2000), 
		@ErrSev SMALLINT, 
		@ErrSta SMALLINT

	DECLARE @Result INT = 0

	BEGIN TRANSACTION
	BEGIN TRY
		INSERT dbo.Student
		        ( LanguageId ,
		          LevelId ,
		          Name ,
		          DayOfBirth ,
		          Sex ,
		          Email 
		        )
		VALUES  ( @LanguageId , -- LanguageId - int
		          @LevelId , -- LevelId - int
		          @Name , -- Name - nvarchar(200)
		          @DayOfBirth , -- DayOfBirth - date
		          @Sex , -- Sex - bit
		          @Email  -- Email - nvarchar(200)
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