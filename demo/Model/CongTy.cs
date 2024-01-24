using System;

namespace demo.Model
{
    internal class CongTy
    {
        private int maCongTy;
        private int maNguoiDung;
        private string tenCongTy;
        private string moTaCongTy;
        private string diaChi;
        private string soDienThoai;
        private string emailLienHe;
        private string logoURL;

        public CongTy()
        {
        }
        public CongTy(int maCongTy, int maNguoiDung)
        {
            this.maCongTy = maCongTy;
            this.maNguoiDung = maNguoiDung;
        }

        public CongTy(int maNguoiDung, string tenCongTy, string moTaCongTy, string diaChi, string soDienThoai, string emailLienHe, string logoURL)
        {
            this.maNguoiDung = maNguoiDung;
            this.tenCongTy = tenCongTy;
            this.moTaCongTy = moTaCongTy;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.emailLienHe = emailLienHe;
            this.logoURL = logoURL;
        }
        public CongTy(int maCongTy,int maNguoiDung, string tenCongTy, string moTaCongTy, string diaChi, string soDienThoai, string emailLienHe, string logoURL)
        {
            this.maCongTy = maCongTy;
            this.maNguoiDung = maNguoiDung;
            this.tenCongTy = tenCongTy;
            this.moTaCongTy = moTaCongTy;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.emailLienHe = emailLienHe;
            this.logoURL = logoURL;
        }
        public CongTy(int maCongTy, int maNguoiDung, string tenCongTy, string moTaCongTy, string diaChi, string soDienThoai, string emailLienHe)
        {
            this.maCongTy = maCongTy;
            this.maNguoiDung = maNguoiDung;
            this.tenCongTy = tenCongTy;
            this.moTaCongTy = moTaCongTy;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.emailLienHe = emailLienHe;
        }

        public int GetMaCongTy()
        {
            return maCongTy;
        }

        public void SetMaCongTy(int maCongTy)
        {
            this.maCongTy = maCongTy;
        }

        public int GetMaNguoiDung()
        {
            return maNguoiDung;
        }

        public void SetMaNguoiDung(int maNguoiDung)
        {
            this.maNguoiDung = maNguoiDung;
        }

        public string GetTenCongTy()
        {
            return tenCongTy;
        }

        public void SetTenCongTy(string tenCongTy)
        {
            this.tenCongTy = tenCongTy;
        }

        public string GetMoTaCongTy()
        {
            return moTaCongTy;
        }

        public void SetMoTaCongTy(string moTaCongTy)
        {
            this.moTaCongTy = moTaCongTy;
        }

        public string GetDiaChi()
        {
            return diaChi;
        }

        public void SetDiaChi(string diaChi)
        {
            this.diaChi = diaChi;
        }

        public string GetSoDienThoai()
        {
            return soDienThoai;
        }

        public void SetSoDienThoai(string soDienThoai)
        {
            this.soDienThoai = soDienThoai;
        }

        public string GetEmailLienHe()
        {
            return emailLienHe;
        }

        public void SetEmailLienHe(string emailLienHe)
        {
            this.emailLienHe = emailLienHe;
        }

        public string GetLogoURL()
        {
            return logoURL;
        }

        public void SetLogoURL(string logoURL)
        {
            this.logoURL = logoURL;
        }
    }
}
