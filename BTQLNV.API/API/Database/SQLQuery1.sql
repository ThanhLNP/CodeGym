CREATE DATABASE BTQLNV
GO

USE BTQLNV
GO

CREATE TABLE PhongBan (
	ID INT PRIMARY KEY IDENTITY,
	MaPB NVARCHAR(5) UNIQUE NOT NULL,
	TenPB NVARCHAR(50) NOT NULL,
	isDelete BIT DEFAULT 0 NOT NULL
)
GO

CREATE TABLE NhanVien (
	MaNV INT PRIMARY KEY IDENTITY,
	IDPB INT FOREIGN KEY REFERENCES dbo.PhongBan(ID),
	Ho NVARCHAR(20) NOT NULL,
	Ten NVARCHAR(20) NOT NULL,
	DiaChi NVARCHAR(250) NOT NULL,
	DienThoai NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50),
	isDelete BIT DEFAULT 0 NOT NULL
)
GO

CREATE PROCEDURE GetAllPhongBan
AS  
BEGIN  
	SET NOCOUNT ON;

	SELECT *, (SELECT COUNT(MaNV) FROM dbo.NhanVien WHERE dbo.NhanVien.IDPB = dbo.PhongBan.ID AND dbo.NhanVien.isDelete = 0) AS SoLuong
	FROM dbo.PhongBan
	WHERE isDelete = 0
END
GO

CREATE PROCEDURE GetPhongBanByID
	@ID INT  
AS  
BEGIN  
	SET NOCOUNT ON;  
	
	SELECT *, (SELECT COUNT(MaNV) FROM dbo.NhanVien WHERE dbo.NhanVien.IDPB = dbo.PhongBan.ID) AS SoLuong
	FROM dbo.PhongBan
	WHERE ID = @ID AND isDelete = 0
END
GO

CREATE PROCEDURE CreatePhongBan 
	@MaPB NVARCHAR(5),
	@TenPB NVARCHAR(50)
AS  
BEGIN  
	SET NOCOUNT ON;  
	INSERT dbo.PhongBan
			( MaPB, TenPB )
	VALUES  ( @MaPB, -- MaPB - nvarchar(5)
			  @TenPB -- TenPB - nvarchar(50)
			)
END
GO

CREATE PROCEDURE UpdatePhongBan
	@ID INT,
	@MaPB NVARCHAR(5),
	@TenPB NVARCHAR(50)
AS  
BEGIN  
	SET NOCOUNT ON;
	UPDATE dbo.PhongBan SET
		MaPB = @MaPB,
		TenPB = @TenPB
	WHERE ID = @ID AND isDelete = 0
END
GO

CREATE PROCEDURE DeletePhongBan
	@ID INT
AS  
BEGIN  
	SET NOCOUNT ON;
	UPDATE dbo.PhongBan SET isDelete = 1 WHERE ID = @ID
END
GO

CREATE PROCEDURE GetAllNhanVien
AS  
BEGIN  
	SET NOCOUNT ON;  
	SELECT * FROM dbo.NhanVien WHERE isDelete = 0
END
GO

CREATE PROCEDURE GetNhanVienByMaNV
	@MaNV INT  
AS  
BEGIN  
	SET NOCOUNT ON;  
	SELECT * FROM dbo.NhanVien WHERE MaNV = @MaNV AND isDelete = 0;  
END
GO

CREATE PROCEDURE CreateNhanVien
	@IDPB INT,
	@Ho NVARCHAR(20),
	@Ten NVARCHAR(20),
	@DiaChi NVARCHAR(250),
	@DienThoai NVARCHAR(50),
	@Email NVARCHAR(50)
AS  
BEGIN  
	SET NOCOUNT ON;  
	INSERT dbo.NhanVien
	        ( IDPB ,
	          Ho ,
	          Ten ,
	          DiaChi ,
	          DienThoai ,
	          Email
	        )
	VALUES  ( @IDPB , -- MaPB - nvarchar(5)
	          @Ho , -- Ho - nvarchar(20)
	          @Ten , -- Ten - nvarchar(20)
	          @DiaChi , -- DiaChi - nvarchar(250)
	          @DienThoai , -- DienThoai - nvarchar(50)
	          @Email -- Email - nvarchar(50)
	        )
END
GO

CREATE PROCEDURE UpdateNhanVien
	@MaNV INT,
	@IDPB INT,
	@Ho NVARCHAR(20),
	@Ten NVARCHAR(20),
	@DiaChi NVARCHAR(250),
	@DienThoai NVARCHAR(50),
	@Email NVARCHAR(50)
AS  
BEGIN  
	SET NOCOUNT ON;
	UPDATE dbo.NhanVien SET
		IDPB = @IDPB,
		Ho = @Ho,
		Ten = @Ten,
		DiaChi = @DiaChi,
		DienThoai = @DienThoai,
		Email = @Email
	WHERE MaNV = @MaNV AND isDelete = 0
END
GO

CREATE PROCEDURE DeleteNhanVien
	@MaNV INT
AS  
BEGIN  
	SET NOCOUNT ON;  
	UPDATE dbo.NhanVien SET isDelete = 1 WHERE MaNV = @MaNV
END
GO