using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Model
{
    using System;

    namespace demo.Model
    {
        internal class KinhNghiemLamViec
        {
            private int maKinhNghiem;
            private int maUngVien;
            private DateTime thoiGianBatDau;
            private DateTime thoiGianKetThuc;
            private string moTa;

            public int GetMaKinhNghiem()
            {
                return maKinhNghiem;
            }

            public void SetMaKinhNghiem(int maKinhNghiem)
            {
                this.maKinhNghiem = maKinhNghiem;
            }

            public int GetMaUngVien()
            {
                return maUngVien;
            }

            public void SetMaUngVien(int maUngVien)
            {
                this.maUngVien = maUngVien;
            }

            public DateTime GetThoiGianBatDau()
            {
                return thoiGianBatDau;
            }

            public void SetThoiGianBatDau(DateTime thoiGianBatDau)
            {
                this.thoiGianBatDau = thoiGianBatDau;
            }

            public DateTime GetThoiGianKetThuc()
            {
                return thoiGianKetThuc;
            }

            public void SetThoiGianKetThuc(DateTime thoiGianKetThuc)
            {
                this.thoiGianKetThuc = thoiGianKetThuc;
            }

            public string GetMoTa()
            {
                return moTa;
            }

            public void SetMoTa(string moTa)
            {
                this.moTa = moTa;
            }

            // Constructor mặc định
            public KinhNghiemLamViec()
            {
            }

            // Constructor với tham số để dễ dàng khởi tạo đối tượng
            public KinhNghiemLamViec(int maKinhNghiem,int maUngVien, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string moTa)
            {
                this.maKinhNghiem = maKinhNghiem;
                this.maUngVien = maUngVien;
                this.thoiGianBatDau = thoiGianBatDau;
                this.thoiGianKetThuc = thoiGianKetThuc;
                this.moTa = moTa;
            }
            public KinhNghiemLamViec(int maUngVien, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string moTa)
            {
                this.maUngVien = maUngVien;
                this.thoiGianBatDau = thoiGianBatDau;
                this.thoiGianKetThuc = thoiGianKetThuc;
                this.moTa = moTa;
            }
        }
    }

}
