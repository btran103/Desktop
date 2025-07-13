CREATE DATABASE QuanLyThuVien;
GO

USE QuanLyThuVien;
GO

CREATE TABLE SACH (
    MaSach CHAR(10) PRIMARY KEY,
    Tensach NVARCHAR(100),
    Tacgia NVARCHAR(100),
    Namxuatban INT,
    Nhaxuatban NVARCHAR(100),
    Trigia FLOAT,
    NgayNhap DATE
);

CREATE TABLE PHIEUMUONSACH (
    MaPhieuMuon CHAR(10) PRIMARY KEY,
    NgayMuon DATE,
    NgayTra DATE
);

CREATE TABLE THONGTINMUONSACH (
    MaSach CHAR(10),
    MaPhieuMuon CHAR(10),
    PRIMARY KEY (MaSach, MaPhieuMuon),
    FOREIGN KEY (MaSach) REFERENCES SACH(MaSach),
    FOREIGN KEY (MaPhieuMuon) REFERENCES PHIEUMUONSACH(MaPhieuMuon)
);

CREATE TABLE TAIKHOAN (
    TenDangNhap NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(50)
);
INSERT INTO TAIKHOAN (TenDangNhap, MatKhau)
VALUES (N'btran', N'100305'),
(N'admin', N'123456'),
(N'user', N'098765');

-- 2. Sách
INSERT INTO SACH (MaSach, Tensach, Tacgia, Namxuatban, Nhaxuatban, Trigia, NgayNhap)
VALUES 
('S001', N'Lập trình C#', N'Nguyễn Văn A', 2020, N'NXB Trẻ', 100000, '2023-01-10'),
('S002', N'Cơ sở dữ liệu', N'Trần Thị B', 2019, N'NXB Giáo dục', 95000, '2023-02-15'),
('S003', N'Giải tích A1', N'Phạm Văn C', 2021, N'NXB Đại học', 120000, '2023-03-20'),
('S004', N'Mạng máy tính', N'Lê Thị D', 2022, N'NXB Khoa học', 110000, '2023-04-05');

-- 3. Phiếu mượn sách
INSERT INTO PHIEUMUONSACH (MaPhieuMuon, NgayMuon, NgayTra)
VALUES 
('PM01', '2024-06-15', '2024-06-30'),
('PM02', '2024-06-20', '2024-07-10'),
('PM03', '2024-06-01', '2024-07-05'), -- quá hạn 30 ngày
('PM04', '2024-06-25', '2024-07-05');

-- 4. Thông tin mượn sách
INSERT INTO THONGTINMUONSACH (MaSach, MaPhieuMuon)
VALUES 
('S001', 'PM01'),
('S002', 'PM01'),
('S003', 'PM02'),
('S004', 'PM03'),
('S001', 'PM04');