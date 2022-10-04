﻿USE master
DROP DATABASE QLYBANHANG
CREATE DATABASE QLYBANHANG
GO
USE QLYBANHANG
GO
CREATE TABLE TAIKHOAN(
	TAIKHOAN VARCHAR(50) PRIMARY KEY ,
	MATKHAU VARCHAR (100) DEFAULT 0,
	HOTEN NVARCHAR (35),
	PHANQUYEN INT DEFAULT 0 -- 0: NHANVIEN, 1: QUANLY
	)
GO 
CREATE TABLE LOAISP(
	MALOAISP VARCHAR(10) PRIMARY KEY,
	TENLOAISP NVARCHAR(50)
	)
GO
CREATE TABLE SANPHAM(
	MASP VARCHAR(10) PRIMARY KEY,
	TENSP NVARCHAR(50),
	MAlOAISP VARCHAR(10),
	GIA FLOAT DEFAULT 0, -- MAT DINH GIA BANG  0
	FOREIGN KEY (MAlOAISP) REFERENCES dbo.LOAISP (MALOAISP)
	)
GO
CREATE TABLE HOADON(
	SOHD INT IDENTITY PRIMARY KEY,
	NGAYLAP DATE DEFAULT GETDATE(),
	NGAYTHANHTOAN DATE DEFAULT GETDATE(),
	TONGTIEN FLOAT,
	TRANGTHAI INT DEFAULT 0 , -- 0: CHUATHANHTOAN, 1: DATHANHTOAN
	)
GO
CREATE TABLE CTHD(
	SOCTHD INT IDENTITY PRIMARY KEY,
	SOHD INT,
	MASP VARCHAR(10),
	SOLUONG INT,
	FOREIGN KEY (SOHD) REFERENCES dbo.HOADON (SOHD),
	FOREIGN KEY (MASP) REFERENCES dbo.SANPHAM (MASP)
	)
GO 
INSERT dbo.TAIKHOAN
(
    TAIKHOAN,
    MATKHAU,
    HOTEN,
    PHANQUYEN
)
VALUES
(   'admin',      -- TAIKHOAN - varchar(50)
    'admin', -- MATKHAU - varchar(100)
    'Giang',    -- HOTEN - nvarchar(35)
    1  -- PHANQUYEN - int
    )

INSERT dbo.TAIKHOAN
(
    TAIKHOAN,
    MATKHAU,
    HOTEN,
    PHANQUYEN
)
VALUES
(   'user',      -- TAIKHOAN - varchar(50)
    'user', -- MATKHAU - varchar(100)
    'phuong',    -- HOTEN - nvarchar(35)
    DEFAULT  -- PHANQUYEN - int
    )

	INSERT dbo.LOAISP
	(
	    MALOAISP,
	    TENLOAISP
	)
	VALUES
	(   'GD001',  -- MALOAISP - varchar(10)
	    'Gia dụng'  -- TENLOAISP - nvarchar(50)
	    )
	INSERT dbo.LOAISP
	(
	    MALOAISP,
	    TENLOAISP
	)
	VALUES
	(   'GV001',  -- MALOAISP - varchar(10)
	    'Gia vị' -- TENLOAISP - nvarchar(50)
	    )
	INSERT dbo.LOAISP
	(
	    MALOAISP,
	    TENLOAISP
	)
	VALUES
	(   'DC001',  -- MALOAISP - varchar(10)
	    'Dụng cụ' -- TENLOAISP - nvarchar(50)
	    )

	INSERT dbo.SANPHAM
	(
	    MASP,
	    TENSP,
	    MAlOAISP,
	    GIA
	)
	VALUES
	(   'CH001',     -- MASP - varchar(10)
	    'Chuổi',   -- TENSP - nvarchar(50)
		'DC001',   -- MAlOAISP - varchar(10)
	    30000 -- GIA - float
	    )
	INSERT dbo.SANPHAM
	(
	    MASP,
	    TENSP,
	    MAlOAISP,
	    GIA
	)
	VALUES
	(   'HR001',     -- MASP - varchar(10)
	    'Hốt rác',   -- TENSP - nvarchar(50)
	    'DC001',   -- MAlOAISP - varchar(10)
	    20000 -- GIA - float
	)
	INSERT dbo.SANPHAM
	(
	    MASP,
	    TENSP,
	    MAlOAISP,
	    GIA
	)
	VALUES
	(   'MU001',     -- MASP - varchar(10)
	    'Muối',   -- TENSP - nvarchar(50)
	    'GV001',   -- MAlOAISP - varchar(10)
	    5000 -- GIA - float
	    )
	INSERT dbo.SANPHAM
	(
	    MASP,
	    TENSP,
	    MAlOAISP,
	    GIA
	)
	VALUES
	(   'DG001',     -- MASP - varchar(10)
	    'Đường',   -- TENSP - nvarchar(50)
	    'GV001',   -- MAlOAISP - varchar(10)
	    20000 -- GIA - float
	    )
	INSERT dbo.SANPHAM
	(
	    MASP,
	    TENSP,
	    MAlOAISP,
	    GIA
	)
	VALUES
	(   'BN001',     -- MASP - varchar(10)
	    'Bột ngọt',   -- TENSP - nvarchar(50)
	    'GV001',   -- MAlOAISP - varchar(10)
	    35000 -- GIA - float
	    )
	INSERT dbo.SANPHAM
	(
	    MASP,
	    TENSP,
	    MAlOAISP,
	    GIA
	)
	VALUES
	(   'NN001',     -- MASP - varchar(10)
	    'Nồi nhôm',   -- TENSP - nvarchar(50)
	    'GD001',   -- MAlOAISP - varchar(10)
	    50000 -- GIA - float
	    )
	GO
	CREATE PROC DANGNHAP
	@TENDANGNHAP VARCHAR(50),
	@MATKHAU VARCHAR(100)
	AS
	BEGIN 
		SELECT * FROM dbo.TAIKHOAN WHERE TAIKHOAN = @TENDANGNHAP AND MATKHAU = @MATKHAU
	END
	GO
	CREATE OR ALTER PROC CAPNHATTAIKHOAN
	@TENDANGNHAP VARCHAR(50),
	@HOTEN NVARCHAR(35),
	@MATKHAU VARCHAR(100)
	AS
	BEGIN
		BEGIN
			DECLARE @MK INT = 0
			SELECT @MK = COUNT(*) FROM dbo.TAIKHOAN WHERE TAIKHOAN = @TENDANGNHAP AND MATKHAU = @MATKHAU
			IF(@MK = 1)
			BEGIN
				UPDATE dbo.TAIKHOAN SET HOTEN = @HOTEN WHERE TAIKHOAN = @TENDANGNHAP
			END
		END
	END
	GO
	CREATE OR ALTER PROC CAPNHATMATKHAU
	@TENDANGNHAP VARCHAR(50),
	@MATKHAU VARCHAR(100),
	@MATKHAUMOI VARCHAR(100)
	AS
	BEGIN
		BEGIN
			DECLARE @MK INT = 0
			SELECT @MK = COUNT(*) FROM dbo.TAIKHOAN WHERE TAIKHOAN = @TENDANGNHAP AND MATKHAU = @MATKHAU
			IF(@MK = 1)
			BEGIN
				UPDATE dbo.TAIKHOAN SET MATKHAU = @MATKHAUMOI WHERE TAIKHOAN = @TENDANGNHAP
			END
		END
	END

GO

	CREATE OR ALTER PROC TAIDSSANPHAM 
	AS
	BEGIN
			SELECT TENLOAISP, MASP, TENSP, GIA  FROM dbo.SANPHAM, dbo.LOAISP WHERE	SANPHAM.MAlOAISP = LOAISP.MALOAISP
	END

	GO 

	CREATE OR ALTER PROC THEMHD
	AS
	BEGIN 
		INSERT dbo.HOADON
		(
		    NGAYLAP,
			NGAYTHANHTOAN,
		    TRANGTHAI
		)
		VALUES
		(   DEFAULT, -- NGAYLAP - date
			DEFAULT, -- NGAYTHANHTOAN -date
		    DEFAULT  -- TRANGTHAI - int
		    )
	END

	GO

	CREATE OR ALTER PROC THEMCTHD 
	@sohd INT, @masp VARCHAR(10), @soluong INT
	AS
	BEGIN 
		
		DECLARE @KTRACTHD INT
		DECLARE @SL INT = 1
		SELECT @KTRACTHD = SOHD, @SL = SOLUONG FROM dbo.CTHD WHERE SOHD = @sohd AND MASP = @masp
		IF(@KTRACTHD > 0)
		BEGIN
			DECLARE @SLMOI INT = @SL + @soluong
			IF(@SLMOI > 0)
			UPDATE dbo.CTHD SET SOLUONG = @SL +  @soluong WHERE MASP = @masp
			ELSE
			DELETE dbo.CTHD WHERE SOHD = @sohd AND MASP = @masp
		END
		ELSE
		BEGIN
		INSERT dbo.CTHD
		(
		    SOHD,
		    MASP,
		    SOLUONG
		)
		VALUES
		(   @sohd,      -- SOHD - int
		    @masp,     -- MASP - varchar(10)
		    @soluong -- SOLUONG - int
		    )
		END
	END
	GO 
	SELECT* FROM dbo.HOADON
	GO 
	SELECT * FROM dbo.CTHD
	GO 
	SELECT SP.TENSP, C.SOLUONG, SP.GIA, SP.GIA * C.SOLUONG AS TONGTIEN 
	FROM dbo.HOADON AS HD, dbo.CTHD AS C, dbo.SANPHAM AS SP 
	WHERE C.SOHD = HD.SOHD AND C.MASP = SP.MASP AND HD.TRANGTHAI = 0
	GO 
	CREATE OR ALTER PROCEDURE XUATCTHD
	AS
	BEGIN
	SELECT HD.SOHD, SP.MASP, SP.TENSP, C.SOLUONG, SP.GIA,(C.SOLUONG * SP.GIA) as THANHTIEN 
	FROM dbo.HOADON HD, dbo.CTHD C, dbo.SANPHAM SP
	WHERE HD.SOHD = C.SOHD AND SP.MASP = C.MASP 
	END
	GO
	CREATE OR ALTER PROC TIMSOHD
	@SOHD INT
	AS
	BEGIN
	SELECT HD.SOHD, SP.MASP, SP.TENSP, C.SOLUONG, SP.GIA,(C.SOLUONG * SP.GIA) as THANHTIEN 
	FROM dbo.HOADON HD, dbo.CTHD C, dbo.SANPHAM SP
	WHERE HD.SOHD = C.SOHD AND SP.MASP = C.MASP AND HD.SOHD = @SOHD
	END
	GO 
	CREATE OR ALTER PROC XOASANPHAM
	@MASANPHAM CHAR(5)
	AS
	BEGIN
	DELETE FROM dbo.CTHD WHERE MASP IN (SELECT MASP FROM dbo.SANPHAM WHERE MASP = @MASANPHAM)
	DELETE FROM dbo.SANPHAM WHERE MAlOAISP = @MASANPHAM
	DELETE FROM dbo.LOAISP WHERE  MALOAISP = @MASANPHAM
	END
