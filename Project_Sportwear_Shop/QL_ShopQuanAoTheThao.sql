CREATE DATABASE QL_ShopQuanAoTheThao

USE QL_ShopQuanAoTheThao

GO

CREATE TABLE NHACUNGCAP
(
	IDNhaCungCap varchar(5) PRIMARY KEY NOT NULL,
	TenNhaCungCap NVARCHAR(50),
	DiaChi NVARCHAR(50),
	SDT varchar(10),
	EMAIL varchar(50),
)

GO

--TenLoai :Sân Nhà (Sân Khách)
create table HANGSANPHAM
(
	IDHangSanPham varchar(5) primary key not null,
	TenHang nvarchar(50),
	TenLoai nvarchar(50),
)

GO

--HinhAnh:(...để sau); Size : (X,M,L,XXL,XL);TinhTrang:Hết Hàng/còn hàng (dựa vào số lượng trong bảng sản phẩm trừ đi số lượng sản phẩm đó đã bị mua)
CREATE TABLE SANPHAM--sau nha cung cap
(
	TenSanPham NVARCHAR(50),
	IDHangSanPham VARCHAR(5),
	HinhAnh varchar(999),
	Size varchar(5) NOT NULL,
	GiaBan int,
	SoLuongTon int default 0,
	TinhTrang nvarchar(50) default N'Chưa Nhập Sản Phẩm',
	CONSTRAINT PK_SANPHAM PRIMARY KEY (TenSanPham, Size),
	CONSTRAINT FK_SANPHAM_LOAISANPHAM FOREIGN KEY (IDHangSanPham) references HANGSANPHAM(IDHangSanPham)
)

GO

CREATE TABLE PHIEUNHAP
(
	IDPhieuNhap VARCHAR(5) PRIMARY KEY NOT NULL,
	NGAYNHAP DATETIME,
	IDNhaCungCap VARCHAR(5),
	TIENNHAP INT default 0,
	CONSTRAINT FK_PHIEUNHAP_NHACC FOREIGN KEY (IDNhaCungCap) REFERENCES NHACUNGCAP(IDNhaCungCap)
)

GO

CREATE TABLE ChiTiet_PN
(
	IDPhieuNhap VARCHAR(5) NOT NULL,
	TenSanPham NVARCHAR(50),
	SOLUONG INT ,
	Size varchar(5) NOT NULL,
	GIANHAP INT,
	THANHTIEN INT,
	CONSTRAINT PK_CHITIETPN PRIMARY KEY (IDPhieuNhap,TenSanPham, Size),
	CONSTRAINT FK_CHITIETPN_SANPHAM FOREIGN KEY (TenSanPham,Size) REFERENCES SANPHAM(TenSanPham,Size),
	CONSTRAINT FK_CHITIETPN_PHIEUNHAP FOREIGN KEY (IDPhieuNhap) references PHIEUNHAP(IDPhieuNhap)
)

GO

CREATE TABLE TAIKHOAN 
(
	IDTaiKhoan varchar(5) NOT NULL PRIMARY KEY,
	TaiKhoan VARCHAR(50),
	MatKhau VARCHAR(50)
)

GO

--ViTriCongViec:()  * có nhân viên bán hàng ,quản lí của hàng,bảo vệ , nhân viên quản lí tồn kho , nhân viên thu ngân ,nhân viên marketing,nhân viên kho Mỗi cái một người
CREATE TABLE NHANVIEN--có sau user
(
	IDNhanVien varchar(5) primary key not null,
	TenNhanVien nvarchar(50) ,
	NgaySinh Date,
	GioiTinh nvarchar(3),
	DiaChi nvarchar(50),
	SDT varchar(10),
	Email varchar(50),
	ViTriCongViec nvarchar(50),
	Luong int ,
	NgayVaoLam date,
	IDTaiKhoan varchar(5),
	CONSTRAINT FK_NHANVIEN_TAIKHOAN FOREIGN KEY (IDTaiKhoan) references TAIKHOAN(IDTaiKhoan),
)

GO

-- IDNhanVien :(Phải là nhân viên bán hàng)

create table HOADON
(
	IDHoaDon varchar(5) PRIMARY KEY NOT NULL,
	NgayLapHD DATETIME,
	IDNhanVien varchar(5),
	TenKhachHang nVARCHAR(50) ,
	DiaChi nVARCHAR(50),
	SDT VARCHAR(10) ,
	HinhThuc NVARCHAR(10),
	GiamGia int,
	ThanhTien int,
	CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY (IDNhanVien) references NHANVIEN(IDNhanVien),
)

GO

create table CHITIETHOADON
(
	IDHoaDon varchar(5),
	TenSanPham NVARCHAR(50),
	SoLuong int,
	Size varchar(5),
	ThanhTien int,
	CONSTRAINT PK_CHITIETHOADON PRIMARY KEY (IDHoaDon, TenSanPham, Size),
	CONSTRAINT FK_CHITIETHOADON_HOADON FOREIGN KEY (IDHoaDon) references HOADON(IDHoaDon),
	CONSTRAINT FK_CHITIETHOADON_SANPHAM FOREIGN KEY (TenSanPham, Size) references SANPHAM(TenSanPham,Size),
)

GO

CREATE TRIGGER UpdateSoLuongTon
ON ChiTiet_PN
AFTER INSERT
AS
BEGIN
    -- Update the quantity on hand in SANPHAM based on the products added to ChiTiet_PN
    UPDATE SANPHAM
    SET SoLuongTon = SoLuongTon + i.SOLUONG,
	TinhTrang='Còn Hàng'
    FROM SANPHAM AS s
    INNER JOIN inserted AS i ON s.TenSanPham = i.TenSanPham AND s.Size = i.Size;
END;

GO

INSERT INTO NHACUNGCAP
VALUES
('NCC01',N'Hoàng Tây',N'Thôn 2, Thị Trấn ĐakĐoa, ĐakĐoa, Gia Lai','0862322671','hoangtay2@gmail.com'),
('NCC02',N'Minh Tú',N'Xã Đông Hòa, Châu Thành, Tiền Giang','0384396100','mitu32@gmail.com')

GO

INSERT INTO HANGSANPHAM
VALUES
('HSP01','Adidas', N'Áo Bóng Đá'),
('HSP02','Nike', N'Áo Bóng Đá'),
('HSP03','Puma', N'Áo Bóng Đá')


GO

INSERT INTO SANPHAM
VALUES
(N'Quần áo Liverpool (Sân Nhà)', 'HSP03', '../anh/hinh1.png', 'M', 1500000, 10, 'Còn Hàng'),
(N'Quần áo Liverpool (Sân Khách)', 'HSP03', '../anh/hinh2.png', 'L', 1500000, 10, 'Còn Hàng'),
(N'Quần áo Liverpool (Sân Khách)', 'HSP03', '../anh/hinh2.png', 'XL', 1500000, 20, 'Còn Hàng'),
(N'Quần áo RealMadrid (Sân Nhà)', 'HSP02', '../anh/hinh3.png', 'L', 2000000, 20, 'Còn Hàng'),
(N'Quần áo RealMadrid (Sân Khách)', 'HSP02', '../anh/hinh4.png', 'M', 2000000, 15, 'Còn Hàng'),
(N'Quần áo RealMadrid (Sân Khách)', 'HSP02', '../anh/hinh4.png', 'L', 2000000, 15, 'Còn Hàng'),
(N'Quần áo Đội Tuyển Pháp (Sân Nhà)', 'HSP01', '../anh/hinh5.png', 'XL', 2500000, 40, 'Còn Hàng'),
(N'Quần áo Đội Tuyển Pháp (Sân Khách)', 'HSP01', '../anh/hinh6.png', 'XL', 2500000, 20, 'Còn Hàng')

GO

SET DATEFORMAT DMY
INSERT INTO PHIEUNHAP
VALUES
('PN001','05/05/2023 6:00:00','NCC01','8000000'),
('PN002','05/05/2023 6:00:00','NCC02','24000000')


GO

INSERT INTO ChiTiet_PN
VALUES 
('PN001',N'Quần áo Liverpool (Sân Nhà)','10','M', 100000, 1000000),
('PN001',N'Quần áo Liverpool (Sân Khách)','10','L', 100000, 1000000),
('PN001',N'Quần áo RealMadrid (Sân Nhà)','5','L', 300000, 1500000),
('PN001',N'Quần áo RealMadrid (Sân Khách)','15','M', 300000, 4500000),
('PN002',N'Quần áo RealMadrid (Sân Nhà)','15','L', 300000, 4500000),
('PN002',N'Quần áo RealMadrid (Sân Khách)','15','L', 100000, 1500000),
('PN002',N'Quần áo Đội Tuyển Pháp (Sân Nhà)','40','XL', 200000, 8000000),
('PN002',N'Quần áo Đội Tuyển Pháp (Sân Khách)','20','XL', 300000, 6000000),
('PN002',N'Quần áo Liverpool (Sân Khách)','20','XL', 200000, 4000000)

GO

INSERT INTO TAIKHOAN
VALUES
('TK001', 'hoald', '123456'),
('TK002', 'tuanmk', '123456'),
('TK003', 'sonla', '123456'),
('TK004', 'thoaidt', '123456'),
('TK005', 'hantt', '123456'),
('TK006', 'conghv', '123456')

GO

SET DATEFORMAT DMY
INSERT INTO NHANVIEN
VALUES('NV001', N'Lưu Đức Hòa', '06/10/2003', N'Nam', N'Số 12, Quận Tây Thạnh, Tân Phú, TPHCM', '0864627763', 'hoald@gmail.com', N'Nhân Viên Bán Hàng', 10000000, '10/01/2021', 'TK001'),
('NV002', N'Lê Minh Tuấn', '15/05/1995', N'Nam', N'Số 25, Quận Bình Thạnh, TPHCM', '0987654321', 'tuamt@gmail.com', N'Quản Lý Cửa Hàng', 15000000, '15/08/2020', 'TK002'),
('NV003', N'Nguyễn Thành Tài', '20/12/1990', N'Nam', N'Số 5, Quận 1, TPHCM', '0909876543', 'taitt@gmail.com', N'Bảo Vệ', 9000000, '01/12/2022', NULL),
('NV004', N'Nguyễn Hoàng Sơn', '25/03/1987', N'Nam', N'Số 8, Quận 9, TPHCM', '0978888888', 'sonla@gmail.com', N'Nhân Viên Quản Lý Tồn Kho', 12000000, '04/02/2019', 'TK003'),
('NV005', N'Nguyễn Anh Thoại', '18/09/1991', N'Nam', N'Số 19, Quận Gò Vấp, TPHCM', '0934567890', 'thoaimobi@gmail.com', N'Nhân Viên Thu Ngân', 11000000, '20/03/2021', 'TK004'),
('NV006', N'Nguyễn Thị Thu Hà', '28/02/1998', N'Nữ', N'Số 7, Quận Tân Bình, TPHCM', '0912345678', 'hantt@gmail.com', N'Nhân Viên Marketing', 13000000, '05/10/2022', 'TK005'),
('NV007', N'Huỳnh Văn Công', '18/09/1991', N'Nam', N'Số 14, Quận 3, TPHCM', '0925874545', 'conglh@gmail.com', N'Nhân Viên Kho', 9500000, '11/05/2020', 'TK006')

GO

--ADD SANPHAM
--PROC 
CREATE PROC AddSanPham
(
	@TenSanPham NVARCHAR(50),
	@IDHangSanPham VARCHAR(5),
	@HinhAnh varchar(999),
	@Size varchar(5),
	@GiaBan int
)
AS
	BEGIN
		INSERT INTO SANPHAM(TenSanPham,IDHangSanPham,HinhAnh,Size,GiaBan) VALUES(@TenSanPham,@IDHangSanPham,@HinhAnh,@Size,@GiaBan)
	END

GO

--UPDATE SANPHAM
CREATE PROC EditSanPham
(
	@TenSanPham NVARCHAR(50),
	@IDHangSanPham VARCHAR(5),
	@HinhAnh varchar(999),
	@Size varchar(5),
	@GiaBan int
)
AS
	BEGIN
		UPDATE SANPHAM 
		SET IDHangSanPham=@IDHangSanPham, HinhAnh=@HinhAnh,GiaBan=@GiaBan
		WHERE TenSanPham=@TenSanPham AND Size=@Size
	END

GO
--trigger cập nhập lại số lượng của sản phẩm khi nhập hàng 

CREATE PROC DeleteSanPham
(
	@TenSanPham NVARCHAR(50),
	@Size varchar(5)
)
AS
	BEGIN
		delete from SANPHAM
		WHERE TenSanPham=@TenSanPham AND Size=@Size and TinhTrang= N'Chưa Nhập Sản Phẩm'
	END


GO

--Viết Thêm/ Xóa/ Sửa/NhaCungCap=> STORE PROCEDURE
--ADD
CREATE PROC ADDNhaCungCap
(
	@IDNhaCungCap varchar(5),
	@TenNhaCungCap nvarchar(50),
	@DiaChi nvarchar(50),
	@SDT varchar(10),
	@EMAIL varchar(50)
)
AS
	BEGIN
		INSERT INTO NHACUNGCAP VALUES(@IDNhaCungCap, @TenNhaCungCap, @DiaChi, @SDT, @EMAIL)
	END

GO
-- DELETE
CREATE PROC DELETENhaCungCap
(
	@IDNhaCungCap varchar(5)
)
AS
	BEGIN
		DELETE FROM NHACUNGCAP WHERE IDNhaCungCap = @IDNhaCungCap
	END
GO

-- EDIT
CREATE PROC EDITNhaCungCap
(
	@IDNhaCungCap varchar(5),
	@TenNhaCungCap nvarchar(50),
	@DiaChi nvarchar(50),
	@SDT varchar(10),
	@EMAIL varchar(50)
)
AS
	BEGIN
		UPDATE NHACUNGCAP SET TenNhaCungCap = @TenNhaCungCap, DiaChi = @DiaChi, SDT = @SDT, EMAIL = @EMAIL WHERE IDNhaCungCap = @IDNhaCungCap
	END
GO

--Viết Thêm/ Xóa/ Sửa/Xem PhieuNhap=> STORE PROCEDURE
--ADD
CREATE PROC addPhieuNhap
(	@IDPhieuNhap varchar(5),
	@NGAYNHAP DATETIME, 
	@IDNhaCungCap varchar(5),
	@TienNhap int
)
AS
	BEGIN
		INSERT into PHIEUNHAP  VALUES(@IDPhieuNhap,@NGAYNHAP,@IDNhaCungCap,@TienNhap)
	END
GO
--DELETE
CREATE PROC deletePhieuNhap 
(	
	@IDPhieuNhap varchar(5)
)
AS
	BEGIN
		DELETE FROM PHIEUNHAP WHERE IDPhieuNhap=@IDPhieuNhap
	END
GO
--EDIT
CREATE PROC editPhieuNhap 
(	@IDPhieuNhap varchar(5),
	@NGAYNHAP DATETIME, 
	@IDNhaCungCap varchar(5),
	@TienNhap int
)
AS
	BEGIN
		update PHIEUNHAP SET NGAYNHAP=@NGAYNHAP, IDNhaCungCap=@IDNhaCungCap,TIENNHAP=@TienNhap WHERE IDPhieuNhap=@IDPhieuNhap
	END
GO
--ADD/DELETE/EDIT CT_PHIEUNHAP
--ADD
create proc addCT_PhieuNhap
(
	@IDPhieuNhap varchar(5),
	@TenSanPham NVARCHAR(50),
	@SoLuong int,
	@Size varchar(5),
	@GiaNhap int,
	@ThanhTien int
)
AS
	BEGIN 
		INSERT INTO ChiTiet_PN VALUES(@IDPhieuNhap,@TenSanPham,@SoLuong,@Size,@GiaNhap,@ThanhTien)
	END 

GO

--DELETE
create proc deleteCT_PhieuNhap
(
	@TenSanPham NVARCHAR(50)
)
AS
	BEGIN 
		delete from ChiTiet_PN where TenSanPham=@TenSanPham 
	END 

GO

--EDIT
create proc editCT_PhieuNhap
(
	@IDPhieuNhap varchar(5),
	@TenSanPham NVARCHAR(50),
	@SoLuong int,
	@Size varchar(5),
	@GiaNhap int,
	@ThanhTien int
)
AS
	BEGIN 
		update ChiTiet_PN set TenSanPham=@TenSanPham,SOLUONG=@SoLuong,Size=@Size,GIANHAP=@GiaNhap,THANHTIEN=@ThanhTien where IDPhieuNhap=@IDPhieuNhap
	END 

GO

CREATE FUNCTION ThongKeTheoNgay
(
    @StartDate DATETIME,
    @EndDate DATETIME
)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM HOADON
    WHERE NgayLapHD BETWEEN @StartDate AND @EndDate
);

GO

CREATE FUNCTION TinhTongSoLuongTheoNgay
(
    @StartDate DATETIME,
    @EndDate DATETIME
)
RETURNS INT
AS
BEGIN
    DECLARE @tongsl INT;

    SELECT @tongsl = SUM(HDCT.SoLuong)
    FROM dbo.ThongKeTheoNgay(@StartDate, @EndDate) AS HD
    JOIN CHITIETHOADON HDCT ON HD.IDHoaDon = HDCT.IDHoaDon;

    RETURN ISNULL(@tongsl, 0);
END;