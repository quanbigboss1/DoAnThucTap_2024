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
        internal class HocVan
        {
            private int maHocVan;
            private int maUngVien;
            private string trinhDo;
            private string nganhHoc;
            private string truongHoc;

            public int GetMaHocVan()
            {
                return maHocVan;
            }

            public void SetMaHocVan(int maHocVan)
            {
                this.maHocVan = maHocVan;
            }

            public int GetMaUngVien()
            {
                return maUngVien;
            }

            public void SetMaUngVien(int maUngVien)
            {
                this.maUngVien = maUngVien;
            }

            public string GetTrinhDo()
            {
                return trinhDo;
            }

            public void SetTrinhDo(string trinhDo)
            {
                this.trinhDo = trinhDo;
            }

            public string GetNganhHoc()
            {
                return nganhHoc;
            }

            public void SetNganhHoc(string nganhHoc)
            {
                this.nganhHoc = nganhHoc;
            }

            public string GetTruongHoc()
            {
                return truongHoc;
            }

            public void SetTruongHoc(string truongHoc)
            {
                this.truongHoc = truongHoc;
            }

            // Constructor mặc định
            public HocVan()
            {
            }

            // Constructor với tham số để dễ dàng khởi tạo đối tượng
            public HocVan(int maUngVien, string trinhDo, string nganhHoc, string truongHoc)
            {
                this.maUngVien = maUngVien;
                this.trinhDo = trinhDo;
                this.nganhHoc = nganhHoc;
                this.truongHoc = truongHoc;
            }
            public HocVan(int maHocVan,int maUngVien, string trinhDo, string nganhHoc, string truongHoc)
            {
                this.maHocVan = maHocVan;
                this.maUngVien = maUngVien;
                this.trinhDo = trinhDo;
                this.nganhHoc = nganhHoc;
                this.truongHoc = truongHoc;
            }
        }
    }

}
