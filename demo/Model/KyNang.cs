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
        public class KyNang
        {
            private int maKyNang;
            private int maUngVien;
            private string tenKyNang;
            private string moTaKyNang;

            public int GetMaKyNang()
            {
                return maKyNang;
            }

            public void SetMaKyNang(int maKyNang)
            {
                this.maKyNang = maKyNang;
            }

            public int GetMaUngVien()
            {
                return maUngVien;
            }

            public void SetMaUngVien(int maUngVien)
            {
                this.maUngVien = maUngVien;
            }

            public string GetTenKyNang()
            {
                return tenKyNang;
            }

            public void SetTenKyNang(string tenKyNang)
            {
                this.tenKyNang = tenKyNang;
            }

            public string GetMoTaKyNang()
            {
                return moTaKyNang;
            }

            public void SetMoTaKyNang(string moTaKyNang)
            {
                this.moTaKyNang = moTaKyNang;
            }

            // Constructor mặc định
            public KyNang()
            {
            }
            public KyNang(string tenKyNang, string moTaKyNang)
            {
                this.tenKyNang= tenKyNang;
                this.moTaKyNang= moTaKyNang;
            }

            // Constructor với tham số để dễ dàng khởi tạo đối tượng
            public KyNang(int maUngVien, string tenKyNang, string moTaKyNang)
            {
                this.maUngVien = maUngVien;
                this.tenKyNang = tenKyNang;
                this.moTaKyNang = moTaKyNang;
            }
            public KyNang(int maKyNang,int maUngVien, string tenKyNang, string moTaKyNang)
            {
                this.maKyNang=maKyNang;
                this.maUngVien = maUngVien;
                this.tenKyNang = tenKyNang;
                this.moTaKyNang = moTaKyNang;
            }
        }
    }

}
