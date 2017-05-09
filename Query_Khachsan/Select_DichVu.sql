USE [QL_KhachSan]
GO
create proc Select_DichVu
as

SELECT [MaDV]
      ,[TenDV]
      ,[Gia]
      ,[DonViTinh]
  FROM [dbo].[tblDichVu]
GO


