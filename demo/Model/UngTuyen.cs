using System;

namespace demo.Model
{
    internal class UngTuyen
    {
        private int maUngTuyen;
        private int maUngVien;
        private int maViTri;
        private DateTime ngayUngTuyen;
        private string trangThaiUngTuyen;
        //
        private string TenUngVien;
        private string TenViTri;
        private string TenCongTy;

        public UngTuyen()
        {
        }
        public UngTuyen(string tenViTri, string tenCongTy, DateTime ngayUngTuyen,string trangThaiUngTuyen)
        {
            this.TenViTri = tenViTri;
            this.TenCongTy = tenCongTy;
            this.ngayUngTuyen = ngayUngTuyen;
            this.trangThaiUngTuyen = trangThaiUngTuyen;
        }
        public UngTuyen(int maUngVien, int maViTri, string trangThaiUngTuyen)
        {
            this.maUngVien = maUngVien;
            this.maViTri = maViTri;
            this.trangThaiUngTuyen = trangThaiUngTuyen;
        }

        public UngTuyen(int maUngVien, int maViTri, DateTime ngayUngTuyen, string trangThaiUngTuyen)
        {
            this.maUngVien = maUngVien;
            this.maViTri = maViTri;
            this.ngayUngTuyen = ngayUngTuyen;
            this.trangThaiUngTuyen = trangThaiUngTuyen;
        }

        public UngTuyen(int maUngTuyen, int maUngVien, int maViTri, DateTime ngayUngTuyen, string trangThaiUngTuyen)
        {
            this.maUngTuyen = maUngTuyen;
            this.maUngVien = maUngVien;
            this.maViTri = maViTri;
            this.ngayUngTuyen = ngayUngTuyen;
            this.trangThaiUngTuyen = trangThaiUngTuyen;
        }
        public UngTuyen(int maUngVien, int maViTri, DateTime ngayUngTuyen)
        {
            this.maUngVien = maUngVien;
            this.maViTri = maViTri;
            this.ngayUngTuyen = ngayUngTuyen;
        }
        public UngTuyen(int maUngVien, string tenUngVien, int maViTri, string tenViTri,  DateTime ngayUngTuyen, string trangThaiUngTuyen)
        {
            this.TenUngVien= tenUngVien;
            this.TenViTri= tenViTri;
            this.maUngVien = maUngVien;
            this.maViTri = maViTri;
            this.ngayUngTuyen = ngayUngTuyen;
            this.trangThaiUngTuyen = trangThaiUngTuyen;
        }
        public int GetMaUngTuyen()
        {
            return maUngTuyen;
        }

        public void SetMaUngTuyen(int maUngTuyen)
        {
            this.maUngTuyen = maUngTuyen;
        }

        public int GetMaUngVien()
        {
            return maUngVien;
        }

        public void SetMaUngVien(int maUngVien)
        {
            this.maUngVien = maUngVien;
        }

        public int GetMaViTri()
        {
            return maViTri;
        }

        public void SetMaViTri(int maViTri)
        {
            this.maViTri = maViTri;
        }

        public DateTime GetNgayUngTuyen()
        {
            return ngayUngTuyen;
        }

        public void SetNgayUngTuyen(DateTime ngayUngTuyen)
        {
            this.ngayUngTuyen = ngayUngTuyen;
        }

        public string GetTrangThaiUngTuyen()
        {
            return trangThaiUngTuyen;
        }

        public void SetTrangThaiUngTuyen(string trangThaiUngTuyen)
        {
            this.trangThaiUngTuyen = trangThaiUngTuyen;
        }
        /////
        public string GetTenUngVien()
        {
            return TenUngVien;
        }

        public void SetTenUngVien(string tenUngVien)
        {
            this.TenUngVien = tenUngVien;
        }
        public string GetTenViTri()
        {
            return TenViTri;
        }

        public void SetTenViTri(string tenViTri)
        {
            this.TenViTri = tenViTri;
        }
        public string GetTenCongTy()
        {
            return TenCongTy;
        }

        public void SetTenCongTy(string tenCongTy)
        {
            this.TenCongTy = tenCongTy;
        }
    }
}
