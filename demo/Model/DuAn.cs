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
        internal class DuAn
        {
            private int maDuAn;
            private int maUngVien;
            private string tenDuAn;
            private string moTaDuAn;

            public int GetMaDuAn()
            {
                return maDuAn;
            }

            public void SetMaDuAn(int maDuAn)
            {
                this.maDuAn = maDuAn;
            }

            public int GetMaUngVien()
            {
                return maUngVien;
            }

            public void SetMaUngVien(int maUngVien)
            {
                this.maUngVien = maUngVien;
            }

            public string GetTenDuAn()
            {
                return tenDuAn;
            }

            public void SetTenDuAn(string tenDuAn)
            {
                this.tenDuAn = tenDuAn;
            }

            public string GetMoTaDuAn()
            {
                return moTaDuAn;
            }

            public void SetMoTaDuAn(string moTaDuAn)
            {
                this.moTaDuAn = moTaDuAn;
            }

            // Constructor mặc định
            public DuAn()
            {
            }

            // Constructor với tham số để dễ dàng khởi tạo đối tượng
            public DuAn(int maUngVien, string tenDuAn, string moTaDuAn)
            {
                this.maUngVien = maUngVien;
                this.tenDuAn = tenDuAn;
                this.moTaDuAn = moTaDuAn;
            }
            public DuAn(int maDuAn,int maUngVien, string tenDuAn, string moTaDuAn)
            {
                this.maDuAn = maDuAn;
                this.maUngVien = maUngVien;
                this.tenDuAn = tenDuAn;
                this.moTaDuAn = moTaDuAn;
            }
        }
    }

}
