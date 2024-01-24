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
    public partial class Frm_ViewCongViec : MetroSetForm
    {
        ViTriCongViecController viTriCongViecController;
        List<ViTriCongViec> dsViTriCongViec;
        ViTriCongViec currentViTriCongViec;
        CongTyController congTyController;
        List<CongTy> dsCongTy;
        CongTy currentCongTy;
        UngTuyenController ungTuyenController;
        List<UngTuyen> dsUngTuyen;
        UngTuyen currentUngTuyen;
        HoSoUngVienController hoSoUngVienController;
        List<HoSoUngVien> dsHoSoUngVien;
        HoSoUngVien currentHoSoUngVien;
        public Frm_ViewCongViec(string mavitri,string manguoidung)
        {
            InitializeComponent();
            viTriCongViecController = new ViTriCongViecController();
            dsViTriCongViec = new List<ViTriCongViec>();
            currentViTriCongViec = new ViTriCongViec();
            congTyController = new CongTyController();
            ungTuyenController = new UngTuyenController();
            dsUngTuyen = new List<UngTuyen>();
            currentUngTuyen = new UngTuyen();
            dsCongTy = new List<CongTy>();
            currentCongTy = new CongTy();
            hoSoUngVienController = new HoSoUngVienController();
            dsHoSoUngVien = new List<HoSoUngVien>();
            dsViTriCongViec = viTriCongViecController.LoadCongViecBangViTri(int.Parse(mavitri));
            foreach(ViTriCongViec viTriCongViec in dsViTriCongViec)
            {
                txtMucLuong.Text = viTriCongViec.GetMucLuong() +" VNĐ";
                txtYeuCauCongViec.Text = viTriCongViec.GetYeuCauCongViec();
                txtMaCongTy.Text = viTriCongViec.GetMaCongTy().ToString();
                txtTenViTri.Text = viTriCongViec.GetTenViTri();
                txtKinhNghiem.Text = viTriCongViec.GetKinhNghiem();
                txtDiaDiem.Text = viTriCongViec.GetDiaDiemLamViec();
               txtMoTaCongViec.Text = viTriCongViec.GetMoTaCongViec();
            }
            dsCongTy = congTyController.ThongTinCongTy(txtMaCongTy.Text);
            foreach (CongTy congty in dsCongTy)
            {
                lbMoTa.Text = congty.GetMoTaCongTy(); 
                lbTenCongTy.Text = congty.GetTenCongTy();
                lbDiaDiem.Text = congty.GetDiaChi();
            }
            tile_soluong.TileCount = viTriCongViecController.GetSoLuong(txtMaCongTy.Text);
            pn_thongtin.BorderColor = Color.White;
            pn_thongtincongty.BorderColor = Color.White;
            txtMaViTri.Text = mavitri;
            dsHoSoUngVien = hoSoUngVienController.Load(manguoidung);
            foreach (HoSoUngVien hoso in dsHoSoUngVien)
            {
                txtMaUngVien.Text = hoso.GetMaUngVien().ToString();
            }
            if (txtMaUngVien.Text != "")
            {
                currentUngTuyen = new UngTuyen(int.Parse(txtMaUngVien.Text), int.Parse(txtMaViTri.Text), dtCurrrent.Value.Date);
                if (ungTuyenController.CheckUngTuyen(currentUngTuyen))
                {
                    btnUngTuyen.Text = "Đã nộp CV ứng tuyển";
                    btnUngTuyen.NormalColor = Color.LimeGreen;
                    btnUngTuyen.HoverBorderColor = Color.Lime;
                    btnUngTuyen.HoverColor = Color.Lime;
                }
            }
            else
            {

            }
            LoadImageFromDatabase_CongTy(int.Parse(txtMaCongTy.Text));
            // thiết kế:
            txtMoTaCongViec.BackColor = Color.White;
            txtMoTaCongViec.BorderColor = Color.White;
            txtYeuCauCongViec.BorderColor = Color.White;
            txtYeuCauCongViec.BackColor = Color.White;
        }

        private void btnUngTuyen_Click(object sender, EventArgs e)
        {
            if(txtMaUngVien.Text != "")
            {
                currentUngTuyen = new UngTuyen(int.Parse(txtMaUngVien.Text), int.Parse(txtMaViTri.Text), dtCurrrent.Value.Date);
                if (ungTuyenController.CheckUngTuyen(currentUngTuyen) == false)
                {
                    if (ungTuyenController.Add(currentUngTuyen))
                    {
                        MessageBox.Show("Nộp CV thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nộp thất bại!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đã nộp CV vào vị trí công việc này rồi. Hãy kiên nhẫn chờ công ty phản hồi bạn nhé!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hình như bạn chưa có CV, Hãy cập nhật CV thông tin ứng tuyển ở trang hồ sơ sau đó quay lại đây nhé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadImageFromDatabase_CongTy(int MaCongTy)
        {
            string imagePath = congTyController.LayDuongDanAnhHoSo(MaCongTy);
            if (!string.IsNullOrEmpty(imagePath))
            {
                pcLogoUrl.SizeMode = PictureBoxSizeMode.Zoom;
                // Hiển thị hình ảnh
                pcLogoUrl.Image = Image.FromFile(imagePath);
            }
        }
    }
}
