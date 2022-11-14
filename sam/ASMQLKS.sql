Create database ASMGIAY
go
use ASMGIAY
go

drop table TAIKHOAN
create table TAIKHOAN(
    Email Nvarchar(50) primary key not null,
    MatKhau Nvarchar(50) not null,
	MaKH nvarchar(10) references KHACHHANG(MaKH),
);
drop table KHACHHANG
create table KHACHHANG(
     MaKH nvarchar(10) primary key not null,
	 TenKH Nvarchar(50) not null,
	 SoDT int not null,
	 SoCMND int not null,
	 DiaChi Nvarchar(50) not null,
	 GioiTinh nvarchar(5) not null
);
drop table SANPHAM
select * from SANPHAM
create table SANPHAM(
     MaSP nvarchar(10) primary key not null,
	 TenSP Nvarchar(50) not null,
	 Gia int not null,
	 XuatSu Nvarchar(50) not null,
	 HinhAnh Nvarchar(50) not null
);
drop table SANPHAMHOT
create table SANPHAMHOT(
     MaSPH nvarchar(10) primary key not null,
	 TenSPH Nvarchar(50) not null,
	 Gia int not null,
	 XuatSu Nvarchar(50) not null,
	 HinhAnh Nvarchar(50) not null
);
drop table SANPHAMKHUYENMAI
create table SANPHAMKHUYENMAI(
     MaSPKM nvarchar(10) primary key not null,
	 TenSPKM Nvarchar(50) not null,
	 Gia int not null,
	 XuatSu Nvarchar(50) not null,
	 ThoiHan Nvarchar(50) not null, 
	 HinhAnh Nvarchar(50) not null
);
drop table HOADON
create table HOADON(
     MaHD nvarchar(10) primary key not null ,
	 MaSP nvarchar(10) references SANPHAM(MaSP),
	 MaKH nvarchar(10) references KHACHHANG(MaKH) not null,
	 NgayThanhToan date null,
	 TongTien int not null
);
