using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Model
{
    public class NguoiDung
    {
        private int maNguoiDung;
        private string tenDangNhap;
        private string matKhau;
        private string email;
        private string hoTen;
        private string diaChi;
        private string soDienThoai;
        private string hinhAnhHoSo;
        private string viTriMongMuon;
        private string loaiNguoiDung;
        // Constructor mặc định
        public NguoiDung()
        {
        }
      
        public NguoiDung(string tenDangNhap,string MatKhau)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = MatKhau;
        }

        public NguoiDung(int maNguoiDung,string hoTen,string email,string diaChi,string soDienThoai)
        {
            this.maNguoiDung = maNguoiDung;
            this.hoTen = hoTen;
            this.email = email;     
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
        }
        // Constructor có tham số
        public NguoiDung(string tenDangNhap, string matKhau, string email, string hoTen, string diaChi, string soDienThoai, string hinhAnhHoSo, string viTriMongMuon, string loaiNguoiDung)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.email = email;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.hinhAnhHoSo = hinhAnhHoSo;
            this.viTriMongMuon = viTriMongMuon;
            this.loaiNguoiDung = loaiNguoiDung;
        }
        public NguoiDung( int maNguoiDung,string email, string hoTen, string diaChi, string soDienThoai,  string viTriMongMuon)
        {
            this.maNguoiDung = maNguoiDung;
            this.email = email;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.viTriMongMuon = viTriMongMuon;
        }
        public NguoiDung(string tenDangNhap, string matKhau, string email, string hoTen, string diaChi, string soDienThoai, string viTriMongMuon, string loaiNguoiDung)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.email = email;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.viTriMongMuon = viTriMongMuon;
            this.loaiNguoiDung = loaiNguoiDung;
        }
        public NguoiDung(int maNguoiDung,string tenDangNhap, string matKhau, string email, string hoTen, string diaChi, string soDienThoai, string hinhAnhHoSo, string viTriMongMuon, string loaiNguoiDung)
        {
            this.maNguoiDung = maNguoiDung; 
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.email = email;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.hinhAnhHoSo = hinhAnhHoSo;
            this.viTriMongMuon = viTriMongMuon;
            this.loaiNguoiDung = loaiNguoiDung;
        }
        public int GetMaNguoiDung()
        {
            return maNguoiDung;
        }

        public void SetMaNguoiDung(int maNguoiDung)
        {
            this.maNguoiDung = maNguoiDung;
        }
        public string GetTenDangNhap()
        {
            return tenDangNhap;
        }

        public void SetTenDangNhap(string TenDangNhap)
        {
            this.tenDangNhap = TenDangNhap;
        }
        public string GetMatKhau()
        {
            return matKhau;
        }
        public void SetMatKhau(string matKhau)
        {
            this.matKhau = matKhau;
        }
        public string Getmail()
        {
            return email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetHoTen()
        {
            return hoTen;
        }
        public void SetHoTen(string hoTen)
        {
            this.hoTen = hoTen;
        }
        public string GetDiaChi()
        {
            return diaChi;
        }
        public void SetDiaChi(string diachi)
        {
            this.diaChi = diachi;
        }
        public string GetSDT()
        {
            return soDienThoai;
        }
        public void SetSDT(string soDienThoai)
        {
            this.soDienThoai = soDienThoai;
        }
        public string GetHinhAnhHoSo()
        {
            return hinhAnhHoSo;
        }
        public void SetHinhAnhHoSo(string hinhAnhHoSo)
        {
            this.hinhAnhHoSo = hinhAnhHoSo;
        }
        public string GetViTriMongMuon()
        {
            return viTriMongMuon;
        }
        public void SetViTriMongMuon(string viTriMongMuon)
        {
            this.viTriMongMuon = viTriMongMuon;
        }
        public string GetLoaiNguoiDung()
        {
            return loaiNguoiDung;
        }
        public void SetLoaiNguoiDung(string loaiNguoiDung)
        {
            this.loaiNguoiDung = loaiNguoiDung;
        }

    }
}
