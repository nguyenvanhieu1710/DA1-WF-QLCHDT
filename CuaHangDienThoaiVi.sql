Create database CuaHangDienThoaiVi;
go
use CuaHangDienThoaiVi;
go

-- Bảng Tài khoản
create table TaiKhoan(
	MaTaiKhoan int identity(1,1) primary key,
	TenTaiKhoan nvarchar(max) not null,
	MatKhau nvarchar(max) not null,
	Quyen nvarchar(max) not null,
	NgayTao date not null,
	NhoMatKhau nvarchar(max) not null,
	Email nvarchar(max) not null,
	TrangThai nvarchar(max) not null
);
go
-- Bảng Nhân Viên
create table NhanVien(
	MaNhanVien int references TaiKhoan(MaTaiKhoan) on delete cascade,
	TenNhanVien nvarchar(max) not null,
	NgaySinh date not null,
	SoDienThoai nvarchar(max) not null,
	AnhNhanVien nvarchar(max) not null,
	GioiTinh nvarchar(max) not null,
	DiaChi nvarchar(max) not null,
	primary key(MaNhanVien)
);
go
-- Bảng Khách Hàng
create table KhachHang(
	MaKhachHang int references TaiKhoan(MaTaiKhoan) on delete cascade,
	TenKhachHang nvarchar(max) not null,
	NgaySinh date not null,
	SoDienThoai nvarchar(max) not null,
	AnhKhachHang nvarchar(max) not null,
	Gender nvarchar(max) not null,
	primary key(MaKhachHang)
);
go
-- Bảng Danh mục
create table DanhMuc(
	MaDanhMuc int identity(1,1) primary key,
	TenDanhMuc nvarchar(max) not null,
	ChiTietSanPham nvarchar(max) not null,
	MaDanhMucCha int not null
);
go
-- Bảng Sản phẩm
create table SanPham(
	MaSanPham int identity(1,1) primary key,
	TenSanPham nvarchar(max) not null,
	SoLuong int not null,
	GiaTien decimal not null,
	ThuongHieu nvarchar(max) not null,
	ThoiDiemRaMat date not null,
	AnhSanPham nvarchar(max) not null,
	NgayTao date not null, -- ngày nhập sản phẩm
	MaDanhMuc int references DanhMuc(MaDanhMuc),
	ChiTietSanPham nvarchar(max) not null
);
go
-- Bảng Giỏ Hàng
create table GioHang(
	MaSanPham int references SanPham(MaSanPham),
	MaKhachHang int references KhachHang(MaKhachHang),
	primary key(MaSanPham, MaKhachHang)
);
go
-- Bảng Đơn Hàng
create table DonHang(
	MaDonHang int identity(1,1) primary key,
	MaKhachHang int references KhachHang(MaKhachHang),
	MaNhanVien int references NhanVien(MaNhanVien),
	TrangThaiDonHang nvarchar(max) not null,
	TongGiaTien decimal not null,
	NgayMua date not null,
	DiaChiNhanHang nvarchar(max)
);
go
-- Bảng Mã giảm giá
create table Voucher(
	IdVoucher int identity(1,1) primary key,
	TenVoucher nvarchar(max) not null,
	GiaTienCoDinh nvarchar(max) not null,
	GiaTienToiThieu nvarchar(max) not null,
	SoLuong int not null,
	NgayBatDau date not null,
	NgayKetThuc date not null,
	MaDanhMuc int references DanhMuc(MaDanhMuc)
);
go
-- Bảng Chi Tiết Đơn Hàng
create table ChiTietDonHang(
	MaChiTietDonHang int identity(1,1) primary key,
	MaDonHang int references DonHang(MaDonHang),
	MaSanPham int references SanPham(MaSanPham),
	SoLuongSanPham int not null,
	GiaTien decimal not null,
	SoTienGiamGia int not null,
	IdVoucher int references Voucher(IdVoucher)
);
go

					-- Proc select
create proc selectTaiKhoan as
	select * from TaiKhoan
-- exec selectTaiKhoan
go
create proc selectNhanVien as
	select * from NhanVien
-- exec selectNhanVien
go
create proc selectKhachHang as
	select * from KhachHang
-- exec selectKhachHang
go
create proc selectSanPham as
	select * from SanPham
-- exec selectSanPham
go
create proc selectDanhMuc as
	select * from DanhMuc
go
create proc selectGioHang as
	select * from GioHang
go
create proc selectDonHang as
	select * from DonHang
go
create proc selectChiTietDonHang as
	select * from ChiTietDonHang
go
create proc selectVoucher as
	select * from Voucher
go

					-- Proc insert into
-- insert TaiKhoan và KhachHang
create proc insertTaiKhoanKhachHang(@TenTaiKhoan nvarchar(max), @MatKhau nvarchar(max),
@Email nvarchar(max)) as
	insert into TaiKhoan values(@TenTaiKhoan, @MatKhau, N'KhachHang', GETDATE(), 
	N'No', @Email, N'Offline')
	DECLARE @MaTaiKhoan INT;
	SET @MaTaiKhoan = SCOPE_IDENTITY ();
	insert into KhachHang values(@MaTaiKhoan, @TenTaiKhoan, GETDATE(), N'0123456789',
	N'No Image', N'Male')
go

-- insert KhachHang và TaiKhoan
create proc insertKhachHang(@TenKhachHang nvarchar(max), @NgaySinh date,
@SoDienThoai nvarchar(max), @AnhKhachHang nvarchar(max),
@GioiTinh nvarchar(max)) as
	DECLARE @SoNgauNhien NVARCHAR(MAX);
	DECLARE @TenTaiKhoan NVARCHAR(MAX);
	-- Tạo số ngẫu nhiên: ban đầu là số thực -> int -> nvarchar
	SET @SoNgauNhien = CAST(CAST(RAND() * 10000 AS INT) AS NVARCHAR(MAX));
	-- Nối số ngẫu nhiên vào cuối TenKhachHang
	SET @TenTaiKhoan = CONCAT(@TenKhachHang, @SoNgauNhien);
	insert into TaiKhoan values(@TenTaiKhoan, N'123', N'KhachHang', GETDATE(), 
	N'No', N'defaut@gmail.com', N'Offline')
	DECLARE @MaTaiKhoan INT;
	SET @MaTaiKhoan = SCOPE_IDENTITY ();
	insert into KhachHang values(@MaTaiKhoan, @TenKhachHang, @NgaySinh, @SoDienThoai,
	@AnhKhachHang, @GioiTinh)
go

-- insert TaiKhoan và NhanVien
create proc insertTaiKhoanNhanVien(@TenTaiKhoan nvarchar(max), @MatKhau nvarchar(max),
@Quyen nvarchar(max), @NgayTao date, @NhoMatKhau nvarchar(max),
@Email nvarchar(max), @TrangThai nvarchar(max)) as
	insert into TaiKhoan values(@TenTaiKhoan, @MatKhau, @Quyen, @NgayTao, 
	@NhoMatKhau, @Email, @TrangThai)
	DECLARE @MaTaiKhoan INT;
	SET @MaTaiKhoan = SCOPE_IDENTITY ();
	insert into NhanVien values(@MaTaiKhoan, @TenTaiKhoan, GETDATE(), N'0123456789',
	N'No Image', N'Male', N'Mỹ Hào - Hưng Yên')
go

-- insert NhanVien và TaiKhoan
create proc insertNhanVien(@TenNhanVien nvarchar(max), @NgaySinh date,
@SoDienThoai nvarchar(max), @AnhNhanVien nvarchar(max),
@GioiTinh nvarchar(max), @DiaChi nvarchar(max)) as
	DECLARE @SoNgauNhien NVARCHAR(MAX);
	DECLARE @TenTaiKhoan NVARCHAR(MAX);
	-- Tạo số ngẫu nhiên: ban đầu là số thực -> int -> nvarchar
	SET @SoNgauNhien = CAST(CAST(RAND() * 10000 AS INT) AS NVARCHAR(MAX));
	-- Nối số ngẫu nhiên vào cuối TenKhachHang
	SET @TenTaiKhoan = CONCAT(@TenNhanVien, @SoNgauNhien);
	insert into TaiKhoan values(@TenTaiKhoan, N'123', N'NhanVien', GETDATE(), 
	N'No', N'defaut@gmail.com', N'Offline')
	DECLARE @MaTaiKhoan INT;
	SET @MaTaiKhoan = SCOPE_IDENTITY ();
	insert into NhanVien values(@MaTaiKhoan, @TenNhanVien, @NgaySinh, @SoDienThoai,
	@AnhNhanVien, @GioiTinh, @DiaChi)
go

-- insert SanPham
create proc insertSanPham(@TenSanPham nvarchar(max), @SoLuong int,
@GiaTien decimal, @ThuongHieu nvarchar(max), @ThoiDiemRaMat date, @AnhSanPham nvarchar(max),
@NgayTao date, @MaDanhMuc int, @ChiTietSanPham nvarchar(max)) as
	insert into SanPham values(@TenSanPham, @SoLuong, @GiaTien, @ThuongHieu,
	@ThoiDiemRaMat, @AnhSanPham, @NgayTao, @MaDanhMuc, @ChiTietSanPham)
go

-- insert DanhMuc
create proc insertDanhMuc(@TenDanhMuc nvarchar(max), @ChiTietSanPham nvarchar(max),
@MaDanhMucCha int) as
	insert into DanhMuc values(@TenDanhMuc, @ChiTietSanPham, @MaDanhMucCha)
go

-- insert GioHang
create proc insertGioHang(@MaSanPham int, @MaKhachHang int) as
	insert into GioHang values(@MaSanPham, @MaKhachHang)
go

-- insert DonHang
create proc insertDonHang(@MaKhachHang int, @MaNhanVien int, @TrangThaiDonHang nvarchar(max),
@TongGiaTien decimal, @NgayMua date, @DiaChiNhanHang nvarchar(max)) as
	insert into DonHang values(@MaKhachHang, @MaNhanVien, @TrangThaiDonHang, 
	@TongGiaTien, @NgayMua, @DiaChiNhanHang)
go 

-- insert Voucher
create proc insertVoucher(@TenVoucher nvarchar(max), @GiaTienCoDinh nvarchar(max),
@GiaTienToiThieu nvarchar(max), @SoLuong int, @NgayBatDau date, @NgayKetThuc date, @MaDanhMuc int)
as
	insert into Voucher values(@TenVoucher, @GiaTienCoDinh, @GiaTienToiThieu, 
	@SoLuong, @NgayBatDau, @NgayKetThuc, @MaDanhMuc)
go 

-- insert ChiTietDonHang
create proc insertChiTietDonHang(@MaDonHang int, @MaSanPham int, @SoLuongSanPham int,
@GiaTien decimal, @SoTienGiamGia int, @IdVoucher int) as
	insert into ChiTietDonHang values(@MaDonHang, @MaSanPham, @SoLuongSanPham, 
	@GiaTien, @SoTienGiamGia, @IdVoucher)
go

				-- Proc update
-- update TaiKhoan
create proc updateTaiKhoan(@MaTaiKhoan int, @TenTaiKhoan nvarchar(max), 
@MatKhau nvarchar(max), @Quyen nvarchar(max), @NgayTao date,
@NhoMatKhau nvarchar(max), @Email nvarchar(max), @TrangThai nvarchar(max))
as
begin
	update TaiKhoan 
	set TenTaiKhoan = @TenTaiKhoan, MatKhau = @MatKhau,
	Quyen = @Quyen, NgayTao = @NgayTao, NhoMatKhau = @NhoMatKhau,
	Email = @Email, TrangThai = @TrangThai
	where MaTaiKhoan = @MaTaiKhoan
end
go 

-- update NhanVien
create proc updateNhanVien(@MaNhanVien int, @TenNhanVien nvarchar(max), @NgaySinh date,
@SoDienThoai nvarchar(max), @AnhNhanVien nvarchar(max), @GioiTinh nvarchar(max),
@DiaChi nvarchar(max)) as
begin
	update NhanVien 
	set TenNhanVien = @TenNhanVien, NgaySinh = @NgaySinh,
	SoDienThoai = @SoDienThoai, AnhNhanVien = @AnhNhanVien,
	GioiTinh = @GioiTinh, DiaChi = @DiaChi
	where MaNhanVien = @MaNhanVien
end
go 

-- update KhachHang
create proc updateKhachHang(@MaKhachHang int, @TenKhachHang nvarchar(max),
@NgaySinh date, @SoDienThoai nvarchar(max), @AnhKhachHang nvarchar(max),
@GioiTinh nvarchar(max)) as
begin
	update KhachHang 
	set TenKhachHang = @TenKhachHang, NgaySinh = @NgaySinh,
	SoDienThoai = @SoDienThoai, AnhKhachHang = @AnhKhachHang,
	Gender = @GioiTinh
	where MaKhachHang = @MaKhachHang
end
go 

-- update DanhMuc
create proc updateDanhMuc(@MaDanhMuc int, @TenDanhMuc nvarchar(max),
@ChiTietSanPham nvarchar(max), @MaDanhMucCha int) as
begin
	update DanhMuc
	set TenDanhMuc = @TenDanhMuc, ChiTietSanPham = @ChiTietSanPham,
	MaDanhMucCha = @MaDanhMucCha
	where MaDanhMuc = @MaDanhMuc
end
go 

-- update SanPham
create proc updateSanPham(@MaSanPham int, @TenSanPham nvarchar(max), @SoLuong int,
@GiaTien decimal, @ThuongHieu nvarchar(max), @ThoiDiemRaMat date, @AnhSanPham nvarchar(max),
@NgayTao date, @MaDanhMuc int, @ChiTietSanPham nvarchar(max)) 
as
	update SanPham
	set TenSanPham = @TenSanPham, SoLuong = @SoLuong,
	GiaTien = @GiaTien, ThuongHieu = @ThuongHieu, ThoiDiemRaMat = @ThoiDiemRaMat,
	AnhSanPham = @AnhSanPham, NgayTao = @NgayTao, 
	MaDanhMuc = @MaDanhMuc, ChiTietSanPham = @ChiTietSanPham
	where MaSanPham = @MaSanPham
go 

-- update DonHang
create proc updateDonHang(@MaDonHang int, @MaKhachHang int, @MaNhanVien int, 
@TrangThaiDonHang nvarchar(max), @TongGiaTien decimal, @NgayMua date, 
@DiaChiNhanHang nvarchar(max))
as
	update DonHang
	set MaKhachHang = @MaKhachHang, MaNhanVien = @MaNhanVien, 
	TrangThaiDonHang = @TrangThaiDonHang, TongGiaTien = @TongGiaTien,
	NgayMua = @NgayMua, DiaChiNhanHang = DiaChiNhanHang
	where MaDonHang = @MaDonHang
go 

-- update Voucher
create proc updateVoucher(@IdVoucher int, @TenVoucher nvarchar(max), 
@GiaTienCoDinh nvarchar(max), @GiaTienToiThieu nvarchar(max), @SoLuong int, @NgayBatDau date, 
@NgayKetThuc date, @MaDanhMuc int)
as
	update Voucher 
	set TenVoucher = @TenVoucher, GiaTienCoDinh = @GiaTienCoDinh,
	GiaTienToiThieu = @GiaTienToiThieu, SoLuong = @SoLuong,
	NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, MaDanhMuc = @MaDanhMuc
	where IdVoucher = @IdVoucher
go 

-- update ChiTietDonHang
create proc updateChiTietDonHang(@MaChiTietDonHang int, @MaDonHang int, 
@MaSanPham int, @SoLuongSanPham int, @GiaTien decimal, 
@SoTienGiamGia int, @IdVoucher int)
as
	update ChiTietDonHang 
	set MaDonHang = @MaDonHang, MaSanPham = @MaSanPham, 
	SoLuongSanPham = @SoLuongSanPham, GiaTien = @GiaTien,
	SoTienGiamGia = @SoTienGiamGia, IdVoucher = @IdVoucher
	where MaChiTietDonHang = @MaChiTietDonHang
go 

				-- Proc delete
-- delete TaiKhoan và KhachHang
create proc deleteTaiKhoanKhachHang(@MaTaiKhoan int)
as
	delete from GioHang where MaKhachHang = @MaTaiKhoan
	delete from TaiKhoan where MaTaiKhoan = @MaTaiKhoan
	delete from KhachHang where MaKhachHang = @MaTaiKhoan
go 

-- delete Acount và NhanVien
create proc deleteTaiKhoanNhanVien(@MaTaiKhoan int)
as
	update DonHang set MaNhanVien = 0 where MaNhanVien = @MaTaiKhoan
	delete from TaiKhoan where MaTaiKhoan = @MaTaiKhoan
	delete from NhanVien where MaNhanVien = @MaTaiKhoan
go 

-- delete DanhMuc
create proc deleteDanhMuc(@MaDanhMuc int)
as
	update Voucher set MaDanhMuc = 0 where MaDanhMuc = @MaDanhMuc
	update SanPham set MaDanhMuc = 0 where MaDanhMuc = @MaDanhMuc
	delete from DanhMuc where MaDanhMuc = @MaDanhMuc
go 

-- delete SanPham
create proc deleteSanPham(@MaSanPham int)
as
	delete from GioHang where MaSanPham = @MaSanPham
	update ChiTietDonHang set MaSanPham = 0 where MaSanPham = @MaSanPham
	delete from SanPham where MaSanPham = @MaSanPham
go 

-- delete GioHang
create proc deleteGioHang(@MaSanPham int, @MaKhachHang int)
as
	delete from GioHang where MaKhachHang = @MaKhachHang and
	MaSanPham = @MaSanPham
go 

-- delete DonHang
create proc deleteDonHang(@MaDonHang int)
as
	delete from ChiTietDonHang where MaDonHang = @MaDonHang
	delete from DonHang where MaDonHang = @MaDonHang
go 

-- delete Voucher
create proc deleteVoucher(@IdVoucher int)
as
	delete from Voucher where IdVoucher = @IdVoucher
	update ChiTietDonHang set IdVoucher = 0
	where IdVoucher = @IdVoucher
go 

-- proc bill
create proc bill(@MaDonHang int) as
	SELECT	SanPham.TenSanPham, ChiTietDonHang.SoLuongSanPham, 
			ChiTietDonHang.GiaTien, DonHang.TongGiaTien, DonHang.NgayMua,
			KhachHang.TenKhachHang
	FROM	KhachHang INNER JOIN DonHang on KhachHang.MaKhachHang = DonHang.MaKhachHang
		INNER JOIN ChiTietDonHang ON ChiTietDonHang.MaDonHang = DonHang.MaDonHang
		INNER JOIN SanPham on ChiTietDonHang.MaSanPham = SanPham.MaSanPham
	where DonHang.MaDonHang = @MaDonHang
-- virtual data
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, Quyen, NgayTao, NhoMatKhau, Email, TrangThai)
VALUES (N'hieu', N'123', N'Admin', GETDATE(), N'No', N'defaut@gmail.com', N'Offline');
go
EXEC insertTaiKhoanNhanVien
    @TenTaiKhoan = N'hieu1',
    @MatKhau = N'123',
    @Quyen = N'NhanVien',
    @NgayTao = '2024-1-1',
    @NhoMatKhau = N'No',
    @Email = N'defaut@gmail.com',
    @TrangThai = N'Offline'
go
EXEC insertTaiKhoanKhachHang
    @TenTaiKhoan = N'hieu2',
    @MatKhau = N'123',
    @Email = N'defaut@gmail.com'
go
INSERT INTO DanhMuc (TenDanhMuc, ChiTietSanPham, MaDanhMucCha)
VALUES (N'Danh mục ảo', N'6.5 in', 0)
go
INSERT INTO SanPham (TenSanPham, SoLuong, GiaTien, ThuongHieu, ThoiDiemRaMat, AnhSanPham, NgayTao, MaDanhMuc, ChiTietSanPham)
VALUES (N'Sản Phẩm ảo', 0, 0, N'Virtual', GETDATE(), N'No Image', GETDATE(), 1, N'Virtual')
go
INSERT INTO Voucher (TenVoucher, GiaTienCoDinh, GiaTienToiThieu, SoLuong, NgayBatDau, NgayKetThuc, MaDanhMuc)
VALUES (N'Voucher ảo', '0', '0', 0, GETDATE(), GETDATE(), 1)
go