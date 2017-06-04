USE [QL_KhachSan]
GO
/****** Object:  StoredProcedure [dbo].[DangNhap]    Script Date: 6/1/2017 9:12:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[DangNhap]
@UserName nvarchar(20),
@Pass nvarchar(20)
as
SELECT* FROM [dbo].[tblDangNhap]
where @UserName =UserName and @Pass=Pass

--insert khach hang
create proc Insert_KTP
	@MaKH nvarchar(10),
    @TenKH nvarchar(50),
    @GT nvarchar(3),
    @NgaySinh date,
    @CMND varchar(20)
as
INSERT INTO [dbo].[tblKhachThuePhong]
           ([MaKH]
           ,[TenKH]
           ,[GT]
           ,[NgaySinh]
           ,[CMND])
     VALUES
          ( @MaKH,
           @TenKH,
           @GT,
           @NgaySinh,
           @CMND)
GO

--update khach hang
create proc UpdateKTP
		@MaKH nvarchar(10),
		@TenKH nvarchar(50),
		@GT nvarchar(3),
		@NgaySinh date,
		@CMND varchar(20)
as 
UPDATE [dbo].[tblKhachThuePhong]
   SET [MaKH] = @MaKH, 
      [TenKH] = @TenKH, 
      [GT] = @GT,
      [NgaySinh] = @NgaySinh,
      [CMND] = @CMND
 WHERE [MaKH]=@MaKH

 --xoa khach hang
create proc DeleteKTP
@MaKH nvarchar(10)
as
DELETE FROM [dbo].[tblKhachThuePhong]
      WHERE MaKH=@MaKH 

--Insert DichVu
create proc Insert_Dichvu
@madv nvarchar(10),@tendv nvarchar(50) ,@gia float , @donvitinh nvarchar(10)
as
begin
INSERT INTO [dbo].[tblDichVu]
           ([MaDV]
           ,[TenDV]
           ,[Gia]
           ,[DonViTinh])
     VALUES
           (@madv,@tendv,@gia,@donvitinh)
end

-- Update dich vu
ALTER proc [dbo].[Update_Dichvu]
	@MaDV nvarchar(10),
    @TenDV nvarchar(50),
	@Gia float,
	@DonViTinh nvarchar(10)
as
UPDATE [dbo].[tblDichVu]
   SET	[MaDV] = @MaDV,
		[TenDV] = @TenDV,
		[Gia] = @Gia,
		[DonViTinh] = @DonViTinh 
 WHERE @MaDV=MaDV

 --delete dich vu
 ALTER proc [dbo].[Delete_dichvu]
@MaDV nvarchar(10)
as
DELETE FROM [dbo].[tblDichVu]
      WHERE @MaDV =MaDV 

--insert do dung
ALTER proc [dbo].[Insert_Dodung]
@ma nvarchar(10) , @ten nvarchar(50) , @SL int ,@DVT nvarchar(20) ,@gia float
as
begin
INSERT INTO [dbo].[DoDung]
           ([MaDD]
           ,[TenDD]
           ,[SoLuong]
           ,[DonViTinh]
           ,[GiaMua])
     VALUES
           (@ma,@ten,@SL,@DVT,@gia)
		   end

--update do dung
create proc Update_Dodung
@ma nvarchar(10) , @ten nvarchar(50) , @SL int ,@DVT nvarchar(20) ,@gia float
as
UPDATE [dbo].[DoDung]
   SET [MaDD] = @ma
      ,[TenDD] = @ten
      ,[SoLuong] = @SL
      ,[DonViTinh] = @DVT 
      ,[GiaMua] = @gia
 WHERE MaDD=@ma
GO
---delete do dung
create proc Delete_Dodung
@ma nvarchar(10)
as
DELETE FROM [dbo].[DoDung]
      WHERE MaDD=@ma
GO
select *from DoDung
exec Delete_Dodung @ma='DD1'

--insert phong
create proc Insert_Phong
           @MaPhong nvarchar(10)
           ,@TenPhong nvarchar(50)
           ,@LoaiPhong nvarchar(10)
           ,@TinhTrang nvarchar(50)
           ,@GiaPhong bigint
as
INSERT INTO [dbo].[tblPhong]
           ([MaPhong]
           ,[TenPhong]
           ,[LoaiPhong]
           ,[TinhTrang]
           ,[GiaPhong])
     VALUES
           (@MaPhong
           ,@TenPhong
           ,@LoaiPhong
           ,@TinhTrang
           ,@GiaPhong)

---update phong
           @MaPhong nvarchar(10)
           ,@TenPhong nvarchar(50)
           ,@LoaiPhong nvarchar(10)
           ,@TinhTrang nvarchar(50)
           ,@GiaPhong bigint

--delete phong
create proc Delete_Phong
@ma nvarchar(10)
as
DELETE FROM [dbo].[tblPhong]
      WHERE @ma=MaPhong
GO

--insert hoa don
create proc Insert_Hoadon
			@MaHD nvarchar(10)
           ,@MaKH nvarchar(10)
           ,@NguoiLap nvarchar(50)
           ,@TongTien bigint
           ,@TGMuon datetime
           ,@TGTra datetime
		   as

INSERT INTO [dbo].[tblHoaDon]
           ([MaHD]
           ,[MaKH]
           ,[NguoiLap]
           ,[TongTien]
           ,[TGMuon]
           ,[TGTra])
     VALUES
           (@MaHD
           ,@MaKH
           ,@NguoiLap
           ,@TongTien
           ,@TGMuon
           ,@TGTra)
GO
--update hoa don
create proc Update_Hoadon
			@MaHD nvarchar(10)
           ,@MaKH nvarchar(10)
           ,@NguoiLap nvarchar(50)
           ,@TongTien bigint
           ,@TGMuon datetime
           ,@TGTra datetime
		   as
UPDATE [dbo].[tblHoaDon]
   SET [MaHD] = @MaHD
      ,[MaKH] = @MaKH
      ,[NguoiLap] = @NguoiLap
      ,[TongTien] = @TongTien
      ,[TGMuon] = @TGMuon
      ,[TGTra] = @TGTra
 WHERE MaHD = @MaHD or @MaKH= MaKH
GO
--delete hoa don
create proc Delete_Hoadon
@MaHD nvarchar(10),
@MaKH nvarchar(10)
as

DELETE FROM [dbo].[tblHoaDon]
      WHERE MaHD=@MaHD or MaKH=@MaKH
	  GO

-- update do dung trong phong
create proc Update_Ddtp
@ma nvarchar(10),@sl int , @dvt nvarchar(10), @tinhtrang nvarchar(50) ,@maphong nvarchar(10)
as
UPDATE [dbo].[tblDoDungTrongPhong]
   SET [MaDoDung] = @ma
      ,[SoLuong] = @sl
      ,[DonViTinh] = @dvt
      ,[TinhTrang] = @tinhtrang
      ,[MaPhong] = @maphong
 WHERE [MaDoDung] = @ma
     
GO
--- xoa do dung trong phong
create proc [dbo].[Delete_Ddtp]
@ma nvarchar(10)
as
DELETE FROM [dbo].[tblDoDungTrongPhong]
      WHERE MaDoDung=@ma 