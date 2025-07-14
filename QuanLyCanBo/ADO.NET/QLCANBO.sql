-- Tạo database
CREATE DATABASE QLCANBO;
GO
USE QLCANBO;
GO

-- Tạo bảng CanBo
CREATE TABLE CanBo (
    MaCB CHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50),
    NgaySinh DATE,
    GioiTinh NVARCHAR(5),
    HeSoLuong FLOAT
);

-- Tạo bảng CongTac
CREATE TABLE CongTac (
    MaCV CHAR(10) PRIMARY KEY,
    TenCV NVARCHAR(50),
    TienLuong FLOAT
);

-- Tạo bảng TienLuong
CREATE TABLE TienLuong (
    MaCB CHAR(10),
    MaCV CHAR(10),
    SoNgayCong INT,
    FOREIGN KEY (MaCB) REFERENCES CanBo(MaCB),
    FOREIGN KEY (MaCV) REFERENCES CongTac(MaCV)
);

-- Thêm dữ liệu vào CanBo
INSERT INTO CanBo (MaCB, HoTen, NgaySinh, GioiTinh, HeSoLuong)
VALUES 
('CB001', N'Nguyễn Văn A', '1985-03-10', N'Nam', 2.75),
('CB002', N'Lê Thị B', '1990-07-20', N'Nữ', 3.10),
('CB003', N'Phạm Văn C', '1982-12-01', N'Nam', 3.50),
('CB004', N'Trần Thị D', '1995-05-05', N'Nữ', 2.95);

-- Thêm dữ liệu vào CongTac
INSERT INTO CongTac (MaCV, TenCV, TienLuong)
VALUES 
('CV001', N'Giảng dạy', 1000000),
('CV002', N'Nghiên cứu', 1200000),
('CV003', N'Quản lý', 1500000);

-- Thêm dữ liệu vào TienLuong
INSERT INTO TienLuong (MaCB, MaCV, SoNgayCong)
VALUES 
('CB001', 'CV001', 26),
('CB002', 'CV002', 24),
('CB003', 'CV003', 25),
('CB004', 'CV001', 23);
CREATE TABLE TaiKhoan (
    TenDN NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(50)
);

INSERT INTO TaiKhoan (TenDN, MatKhau)
VALUES 
(N'admin', N'123'),
(N'user', N'456'),
(N'btran',N'103');
