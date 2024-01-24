using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Model
{
    internal class HoSoUngVien
    {
        private int maUngVien;
        private int maNguoiDung;
        private string mucTieuNgheNghiep;

        // Getter và Setter cho thuộc tính MaUngVien
        public int GetMaUngVien()
        {
            return maUngVien;
        }

        public void SetMaUngVien(int maUngVien)
        {
            this.maUngVien = maUngVien;
        }

        public int GetMaNguoiDung()
        {
            return maNguoiDung;
        }

        public void SetMaNguoiDung(int maNguoiDung)
        {
            this.maNguoiDung = maNguoiDung;
        }
        public string GetMucTieuNgheNghiep()
        {
            return mucTieuNgheNghiep;
        }

        public void SetMucTieuNgheNghiep(string mucTieuNgheNghiep)
        {
            this.mucTieuNgheNghiep = mucTieuNgheNghiep;
        }
        // Constructor mặc định
        public HoSoUngVien()
        {
        }

        // Constructor với tham số để dễ dàng khởi tạo đối tượng
        public HoSoUngVien(int maNguoiDung)
        {
            this.maNguoiDung = maNguoiDung;
        }
        public HoSoUngVien( int maNguoiDung, string mucTieuNgheNghiep)
        {
            this.maNguoiDung = maNguoiDung;
            this.mucTieuNgheNghiep = mucTieuNgheNghiep;
        }
        public HoSoUngVien(int maUngVien, int maNguoiDung, string mucTieuNgheNghiep)
        {
            this.maUngVien = maUngVien;
            this.maNguoiDung = maNguoiDung;
            this.mucTieuNgheNghiep = mucTieuNgheNghiep;
        }
    }
}
