-- Tạo cơ sở dữ liệu
Go
CREATE DATABASE UngDungXinViec;
go
USE UngDungXinViec;
go
-- Bảng Người Dùng
CREATE TABLE NguoiDung (
    MaNguoiDung INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(255) UNIQUE NOT NULL,
    MatKhau NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255),
    HoTen NVARCHAR(255),
    DiaChi NVARCHAR(255),
    SoDienThoai NVARCHAR(15),
    HinhAnhHoSo NVARCHAR(255),
    ViTriMongMuon NVARCHAR(255),
    LoaiNguoiDung NVARCHAR(10)
);
-- Bảng Công Ty và liên kết với Người Dùng
CREATE TABLE CongTy (
    MaCongTy INT PRIMARY KEY,
    MaNguoiDung INT,
    TenCongTy NVARCHAR(255),
    MoTaCongTy NVARCHAR(MAX),
    DiaChi NVARCHAR(255),
    SoDienThoai NVARCHAR(15),
    EmailLienHe NVARCHAR(255),
    LogoURL NVARCHAR(255),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
);

-- Bảng Vị Trí Công Việc và liên kết với Công Ty
CREATE TABLE ViTriCongViec (
    MaViTri INT IDENTITY(1,1) PRIMARY KEY,
    MaCongTy INT,
    TenViTri NVARCHAR(255) NOT NULL,
    MoTaCongViec NVARCHAR(MAX),
    YeuCauCongViec NVARCHAR(MAX),
    MucLuong NVARCHAR(50),
    KinhNghiem NVARCHAR(255),
	DiaDiemLamViec NVARCHAR(255),
    NgayTao DATE,
    FOREIGN KEY (MaCongTy) REFERENCES CongTy(MaCongTy)
);

-- Bảng Hồ Sơ Ứng Viên và liên kết với Người Dùng
CREATE TABLE HoSoUngVien (
    MaUngVien INT PRIMARY KEY,
    MaNguoiDung INT,
    MucTieuNgheNghiep NVARCHAR(MAX),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
);

-- Bảng Kinh Nghiệm Làm Việc
CREATE TABLE KinhNghiemLamViec (
    MaKinhNghiem INT IDENTITY(1,1) PRIMARY KEY,
    MaUngVien INT,
    ThoiGianBatDau DATE,
    ThoiGianKetThuc DATE,
    MoTa NVARCHAR(MAX),
    FOREIGN KEY (MaUngVien) REFERENCES HoSoUngVien(MaUngVien)
);

-- Bảng Học Vấn
CREATE TABLE HocVan (
    MaHocVan INT IDENTITY(1,1) PRIMARY KEY,
    MaUngVien INT,
    TrinhDo NVARCHAR(MAX),
    NganhHoc NVARCHAR(MAX),
    TruongHoc NVARCHAR(MAX),
    FOREIGN KEY (MaUngVien) REFERENCES HoSoUngVien(MaUngVien)
);

-- Bảng Dự Án Đã Làm
CREATE TABLE DuAn (
    MaDuAn INT IDENTITY(1,1) PRIMARY KEY,
    MaUngVien INT,
    TenDuAn NVARCHAR(MAX),
    MoTaDuAn NVARCHAR(MAX),
    FOREIGN KEY (MaUngVien) REFERENCES HoSoUngVien(MaUngVien)
);

-- Bảng Kỹ Năng
CREATE TABLE KyNang (
    MaKyNang INT IDENTITY(1,1) PRIMARY KEY,
    MaUngVien INT,
    TenKyNang NVARCHAR(MAX),
    MoTaKyNang NVARCHAR(MAX),
    FOREIGN KEY (MaUngVien) REFERENCES HoSoUngVien(MaUngVien)
);
CREATE TABLE UngTuyen (
    MaUngTuyen INT IDENTITY(1,1) PRIMARY KEY,
    MaUngVien INT,
    MaViTri INT,
    NgayUngTuyen DATE,
    TrangThaiUngTuyen NVARCHAR(50),
    FOREIGN KEY (MaUngVien) REFERENCES HoSoUngVien(MaUngVien),
    FOREIGN KEY (MaViTri) REFERENCES ViTriCongViec(MaViTri)
);


