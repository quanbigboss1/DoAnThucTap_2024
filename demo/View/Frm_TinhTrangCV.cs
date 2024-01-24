using demo.Controller;
using demo.Model;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.View
{
    public partial class Frm_TinhTrangCV : MetroSetForm
    {
        UngTuyenController ungTuyenController;
        List<UngTuyen> dsUngTuyen;
        UngTuyen currentUngTuyen;
        public Frm_TinhTrangCV(string maNguoiDung)
        {
            InitializeComponent();
            ungTuyenController = new UngTuyenController();
            dsUngTuyen = new List<UngTuyen>();
            currentUngTuyen = new UngTuyen();
            //
            dgDanhSachCongTyDaUngTuyen.ColumnCount = 4;
            dgDanhSachCongTyDaUngTuyen.Columns[0].Name = "Tên vị trí";
            dgDanhSachCongTyDaUngTuyen.Columns[1].Name = "Tên công ty";
            dgDanhSachCongTyDaUngTuyen.Columns[2].Name = "Ngày ứng tuyển";
            dgDanhSachCongTyDaUngTuyen.Columns[3].Name = "Tình trạng ứng tuyển";
            dsUngTuyen = ungTuyenController.GetCVDaNop_UngVien(maNguoiDung);
            foreach(UngTuyen ungTuyen in dsUngTuyen)
            {
                if (string.IsNullOrEmpty(ungTuyen.GetTrangThaiUngTuyen()))
                {
                    string msg = "Đang xét tuyển";
                    string[] row = { ungTuyen.GetTenViTri(), ungTuyen.GetTenCongTy(), ungTuyen.GetNgayUngTuyen().ToString("MM/dd/yyyy"), msg };
                    dgDanhSachCongTyDaUngTuyen.Rows.Add(row);
                }
                else
                {
                    string[] row = { ungTuyen.GetTenViTri(), ungTuyen.GetTenCongTy(), ungTuyen.GetNgayUngTuyen().ToString("MM/dd/yyyy"), ungTuyen.GetTrangThaiUngTuyen() };
                    dgDanhSachCongTyDaUngTuyen.Rows.Add(row);
                }
                if(ungTuyen.GetTrangThaiUngTuyen() == "Trúng tuyển")
                {
                    MessageBox.Show("Chúc mừng bạn đã trúng tuyển vị trí " + ungTuyen.GetTenViTri() + " của công ty " + ungTuyen.GetTenCongTy(),"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
    }
}
