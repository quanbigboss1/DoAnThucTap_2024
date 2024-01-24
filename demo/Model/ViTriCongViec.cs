using System;

namespace demo.Model
{
    public class ViTriCongViec
    {
        public int maViTri;
        public int maCongTy;
        public string tenViTri;
        public string moTaCongViec;
        public string yeuCauCongViec;
        public string mucLuong;
        public string kinhNghiem;
        public string diaDiemLamViec;
        public DateTime ngayTao;

        public int GetMaViTri()
        {
            return maViTri;
        }

        public void SetMaViTri(int maViTri)
        {
            this.maViTri = maViTri;
        }

        public int GetMaCongTy()
        {
            return maCongTy;
        }

        public void SetMaCongTy(int maCongTy)
        {
            this.maCongTy = maCongTy;
        }

        public string GetTenViTri()
        {
            return tenViTri;
        }

        public void SetTenViTri(string tenViTri)
        {
            this.tenViTri = tenViTri;
        }

        public string GetMoTaCongViec()
        {
            return moTaCongViec;
        }

        public void SetMoTaCongViec(string moTaCongViec)
        {
            this.moTaCongViec = moTaCongViec;
        }

        public string GetYeuCauCongViec()
        {
            return yeuCauCongViec;
        }

        public void SetYeuCauCongViec(string yeuCauCongViec)
        {
            this.yeuCauCongViec = yeuCauCongViec;
        }

        public string GetMucLuong()
        {
            return mucLuong;
        }

        public void SetMucLuong(string mucLuong)
        {
            this.mucLuong = mucLuong;
        }

        public string GetKinhNghiem()
        {
            return kinhNghiem;
        }

        public void SetKinhNghiem(string kinhNghiem)
        {
            this.kinhNghiem = kinhNghiem;
        }

        public string GetDiaDiemLamViec()
        {
            return diaDiemLamViec;
        }

        public void SetDiaDiemLamViec(string diaDiemLamViec)
        {
            this.diaDiemLamViec = diaDiemLamViec;
        }

        public DateTime GetNgayTao()
        {
            return ngayTao;
        }

        public void SetNgayTao(DateTime ngayTao)
        {
            this.ngayTao = ngayTao;
        }

        public ViTriCongViec()
        {
        }
        public ViTriCongViec(int maViTri)
        {
            this.maViTri = maViTri;
        }
        public ViTriCongViec(string tenViTri,string mucLuong, string kinhNghiem,string diaDiemLamViec)
        {
            this.tenViTri = tenViTri;
            this.mucLuong = mucLuong;
            this.kinhNghiem = kinhNghiem;
            this.diaDiemLamViec = diaDiemLamViec;
        }
        public ViTriCongViec(int maCongTy, string tenViTri, string moTaCongViec, string yeuCauCongViec,
            string mucLuong, string kinhNghiem, string diaDiemLamViec, DateTime ngayTao)
        {
            this.maCongTy = maCongTy;
            this.tenViTri = tenViTri;
            this.moTaCongViec = moTaCongViec;
            this.yeuCauCongViec = yeuCauCongViec;
            this.mucLuong = mucLuong;
            this.kinhNghiem = kinhNghiem;
            this.diaDiemLamViec = diaDiemLamViec;
            this.ngayTao = ngayTao;
        }

        public ViTriCongViec(int maViTri, int maCongTy, string tenViTri, string moTaCongViec, string yeuCauCongViec,
            string mucLuong, string kinhNghiem, string diaDiemLamViec, DateTime ngayTao)
        {
            this.maViTri = maViTri;
            this.maCongTy = maCongTy;
            this.tenViTri = tenViTri;
            this.moTaCongViec = moTaCongViec;
            this.yeuCauCongViec = yeuCauCongViec;
            this.mucLuong = mucLuong;
            this.kinhNghiem = kinhNghiem;
            this.diaDiemLamViec = diaDiemLamViec;
            this.ngayTao = ngayTao;
        }
    }
}
