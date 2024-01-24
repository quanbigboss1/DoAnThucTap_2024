using CsvHelper;
using CsvHelper.Configuration;
using demo.Controller;
using demo.Model;
using demo.Model.demo.Model;
using MetroFramework;
using MetroFramework.Controls;
using MetroSet_UI.Child;
using MetroSet_UI.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace demo.View
{
    public partial class Frm_MDI : MetroSetForm
    {
        CongTyController congtyController;
        List<CongTy> dsCongTy;
        List<CongTy> dsThongTinCongTy;
        CongTy currentCongTy;
        NguoiDungController nguoidungController;
        List<NguoiDung> dsNguoiDung;
        NguoiDung currentNguoiDung;
        ViTriCongViecController viTriCongViecController;
        List<ViTriCongViec> dsViTriCongViec;
        ViTriCongViec currentViTriCongViec;
        UngTuyenController ungTuyenController;
        List<UngTuyen> dsUngTuyen;
        UngTuyen currentUngTuyen;
        HoSoUngVienController hoSoUngVienController;
        List<HoSoUngVien> dsHoSoUngVien;
        HoSoUngVien currentHoSoUngVien;
        KyNangController kyNangController;
        List<KyNang> dsKyNang;
        public Frm_MDI(NguoiDung nguoidung)
        {
            InitializeComponent();
            //
            nguoidungController = new NguoiDungController();
            dsNguoiDung = new List<NguoiDung>();
            currentNguoiDung = nguoidung;
            dsNguoiDung = nguoidungController.CheckLogin(nguoidung);
            //
            kyNangController = new KyNangController();
            dsKyNang = new List<KyNang>();
            //
            congtyController = new CongTyController();
            dsCongTy = new List<CongTy>();
            dsThongTinCongTy = new List<CongTy>();
            currentCongTy = new CongTy();
            viTriCongViecController = new ViTriCongViecController();
            dsViTriCongViec = new List<ViTriCongViec>();
            currentViTriCongViec = new ViTriCongViec();
            //
            ungTuyenController = new UngTuyenController();
            dsUngTuyen = new List<UngTuyen>();
            currentUngTuyen = new UngTuyen();
            //
            hoSoUngVienController = new HoSoUngVienController();
            dsHoSoUngVien = new List<HoSoUngVien>();
            currentHoSoUngVien = new HoSoUngVien(); 
            /*this.WindowState = FormWindowState.Maximized;*/
            Pn_Menu.Size = new Size(this.ClientSize.Width-40,this.ClientSize.Height + 50);
            // Đặt font mới cho Pn_Menu
            Pn_Menu.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            Pn_Menu.ItemSize = new Size(300, 60);
            //tabcontrol1 - timviec
            pn_total.BorderColor = Color.White;
            title_timviec2.ForeColor = Color.DeepSkyBlue;
            pn_bottom_vieclam.BorderColor = Color.White;    
            cbbDiaDiem.ArrowColor = Color.Blue;
            cbbDiaDiem.BackgroundColor = Color.White;
            cbbTimTheoTieuChi.BorderColor = Color.White;
            cbbTimTheoTieuChi.BackgroundColor = Color.White;
            cbbTimTheoTieuChi.ArrowColor = Color.Blue;
            cbbKinhNghiem.ArrowColor = Color.Blue;
            cbbKinhNghiem.BackgroundColor = Color.White;
            cbbLuong.ArrowColor = Color.Blue;
            cbbLuong.BackgroundColor = Color.White;
            title.ForeColor = Color.DeepSkyBlue;
            txtTimViec.BackColor = Color.WhiteSmoke;
            txtTimViec.HoverColor = Color.WhiteSmoke;
            txtTimViec.DisabledBorderColor = Color.WhiteSmoke;
            txtTimViec.BorderColor = Color.WhiteSmoke;
            dgViecLam.ColumnCount = 7;
            dgViecLam.Columns[0].Name = "Vị trí";
            dgViecLam.Columns[1].Name = "Mô tả công việc";
            dgViecLam.Columns[2].Name = "Yêu cầu công việc";
            dgViecLam.Columns[3].Name = "Mức lương";
            dgViecLam.Columns[4].Name = "Kinh nghiệm";
            dgViecLam.Columns[5].Name = "Địa điểm làm việc";
            dgViecLam.Columns[6].Name = "Ngày tạo";
            dsViTriCongViec.Clear();
            dsViTriCongViec = viTriCongViecController.LoadAll();
            dgViecLam.Rows.Clear();
            
            foreach (ViTriCongViec vitricongviec in dsViTriCongViec)
            {
                string[] row = { vitricongviec.GetTenViTri(), vitricongviec.GetMoTaCongViec(),vitricongviec.GetYeuCauCongViec(),vitricongviec.GetMucLuong().ToString(),vitricongviec.GetKinhNghiem(),vitricongviec.GetDiaDiemLamViec(),vitricongviec.GetNgayTao().ToString("MM/dd/yyyy")};
                dgViecLam.Rows.Add(row);
            }
            pn_3tieuchi.BorderColor = Color.White;
            txtMinLuong.Visible = false;
            txtMaxLuong.Visible = false;
            a5.Visible = false;
            a6.Visible = false;
            b5.Visible = false;
            b6.Visible = false;
            b1.NormalColor = Color.WhiteSmoke;
            b2.NormalColor = Color.WhiteSmoke;
            b3.NormalColor = Color.WhiteSmoke;
            b4.NormalColor = Color.WhiteSmoke;
            b5.NormalColor = Color.WhiteSmoke;
            b6.NormalColor = Color.WhiteSmoke;
            b1.NormalBorderColor = Color.WhiteSmoke;
            b2.NormalBorderColor = Color.WhiteSmoke;
            b3.NormalBorderColor = Color.WhiteSmoke;
            b4.NormalBorderColor = Color.WhiteSmoke;
            b5.NormalBorderColor = Color.WhiteSmoke;
            b6.NormalBorderColor = Color.WhiteSmoke;
            dgLocTieuChi.ColumnCount = 8;
            dgLocTieuChi.Columns[0].Name = "Vị trí";
            dgLocTieuChi.Columns[1].Name = "Mô tả công việc";
            dgLocTieuChi.Columns[2].Name = "Yêu cầu công việc";
            dgLocTieuChi.Columns[3].Name = "Mức lương";
            dgLocTieuChi.Columns[4].Name = "Kinh nghiệm";
            dgLocTieuChi.Columns[5].Name = "Địa điểm làm việc";
            dgLocTieuChi.Columns[6].Name = "Ngày tạo";
            dgLocTieuChi.Columns[7].Name = "Mã vị trí";
            txtTieuChi1.Visible = false;
            txtTieuChi2.Visible = false;
            /// tabcontrol5 - taikhoan
            menu_taikhoan.Height = 50;
            menu_taikhoan.AutoSize = true; // MenuStrip sẽ tự động thay đổi kích thước dựa vào nội dung
            tool_thongtintaikhoan.AutoSize = true;
            tool_doimatkhau.AutoSize = true;
            tool_thongtintaikhoan.Height = 50;
            tool_doimatkhau.Height = 50;
            foreach (NguoiDung nguoiDung in dsNguoiDung)
            {
                lb_welcome_tk.Text = nguoiDung.GetHoTen();
                txtEmail_tk.Text = nguoiDung.Getmail().ToString();
                txtDiaChi_tk.Text = nguoiDung.GetDiaChi().ToString();
                txtHoTen_tk.Text = nguoiDung.GetHoTen().ToString();
                txtSDT_tk.Text = nguoiDung.GetSDT().ToString();
                txtViTriMongMuon_tk.Text = nguoiDung.GetViTriMongMuon().ToString();
                txtMaNguoiDung.Text = nguoiDung.GetMaNguoiDung().ToString();  
                txtLoaiNguoiDung.Text = nguoiDung.GetLoaiNguoiDung().ToString();
            }
            if(txtLoaiNguoiDung.Text == "Ứng Viên")
            {
                panel_tuyendung.Visible = false;
            }
            else
            {
                panel_tuyendung.Visible = true;
            }
            dsHoSoUngVien = hoSoUngVienController.Load(txtMaNguoiDung.Text);
            foreach (HoSoUngVien hoso in dsHoSoUngVien)
            {
                tileSoLuongCongTyDaUngTuyen.TileCount = ungTuyenController.GetSoLuongCV_UngVien(hoso.GetMaUngVien().ToString());
                txtMaUngVien.Text = hoso.GetMaUngVien().ToString();
            }
            tabControl5.Height = 500;
            panel_thongtintaikhoan.Height = 800;

            /////////tabControl - CongTY
            panel_timkiem_congty.BorderColor = Color.White;

            //          
            dgDetails_congty.ColumnCount = 4;
            dgDetails_congty.Columns[0].Name = "Mã công ty";
            dgDetails_congty.Columns[1].Name = "Tên công ty";
            dgDetails_congty.Columns[2].Name = "Địa chỉ";
            dgDetails_congty.Columns[3].Name = "Mô tả công ty";
            dsCongTy.Clear();
            dsCongTy = congtyController.LoadRandom();
            dgDetails_congty.Rows.Clear();
            foreach (CongTy congty in dsCongTy)
            {
                string[] row = {congty.GetMaCongTy().ToString(),congty.GetTenCongTy().ToString(),congty.GetDiaChi(),congty.GetMoTaCongTy() };
                dgDetails_congty.Rows.Add(row);
            }
            for (int i = 0; i < dgDetails_congty.Rows.Count; i++)
            {
                // Lấy giá trị từ ô cụ thể trong hàng hiện tại
                string tenCongTy = dgDetails_congty.Rows[i].Cells[1].Value.ToString();
                string moTaCongTy = dgDetails_congty.Rows[i].Cells[3].Value.ToString();
                string diaChiCongTy = dgDetails_congty.Rows[i].Cells[2].Value.ToString();
                // Sử dụng switch case để gán giá trị vào các tile tương ứng
                switch (i)
                {
                    case 0:
                        tileTenCongTy1.Text = tenCongTy;
                        tileMoTaCongTy1.Text = moTaCongTy;
                        tileDiaChiCongTy1.Text = diaChiCongTy;
                        break;
                    case 1:
                        tileTenCongTy2.Text = tenCongTy;
                        tileMoTaCongTy2.Text = moTaCongTy;
                        tileDiaChiCongTy2.Text = diaChiCongTy;
                        break;
                    case 2:
                        tileTenCongTy3.Text = tenCongTy;
                        tileMoTaCongTy3.Text = moTaCongTy;
                        tileDiaChiCongTy3.Text = diaChiCongTy;
                        break;
                    case 3:
                        tileTenCongTy4.Text = tenCongTy;
                        tileMoTaCongTy4.Text = moTaCongTy;
                        tileDiaChiCongTy4.Text = diaChiCongTy;
                        break;
                    case 4:
                        tileTenCongTy5.Text = tenCongTy;
                        tileMoTaCongTy5.Text = moTaCongTy;
                        tileDiaChiCongTy5.Text = diaChiCongTy;
                        break;
                    case 5:
                        tileTenCongTy6.Text = tenCongTy;
                        tileMoTaCongTy6.Text = moTaCongTy;
                        tileDiaChiCongTy6.Text = diaChiCongTy;
                        break;
                    default:
                        // Xử lý cho các trường hợp khác nếu cần
                        break;
                }
            }
            pn_congty1.BorderColor = Color.White;
            pn_congty2.BorderColor = Color.White;
            pn_congty3.BorderColor = Color.White;
            pn_congty4.BorderColor = Color.White;
            pn_congty5.BorderColor = Color.White;
            pn_congty6.BorderColor = Color.White;
            //tabcontrol4------tuyendung
            pn_soluongCV_TD.BorderColor = Color.White;
            txtTenCongTy_TD.HoverColor = Color.White; txtTenCongTy_TD.DisabledBorderColor = Color.White;
            txtTenCongTy_TD.BorderColor = Color.White;
            txtSDT_TD.DisabledBorderColor = Color.White; txtSDT_TD.BorderColor = Color.White;
            txtSDT_TD.HoverColor = Color.White;
            txtDiaChi_TD.HoverColor = Color.White; txtDiaChi_TD.DisabledBorderColor = Color.White;
            txtDiaChi_TD.BorderColor = Color.White;
            txtMoTa_TD.HoverColor = Color.White; txtMoTa_TD.DisabledBorderColor = Color.White;
            txtMoTa_TD.BorderColor = Color.White;
            txtEmail_TD.HoverColor = Color.White; txtEmail_TD.DisabledBorderColor = Color.White;
            txtEmail_TD.BorderColor = Color.White;
            if (nguoidung.GetLoaiNguoiDung() == "Ứng Viên")
            {
                MessageBox.Show("Hello world");
                
            }
            dsThongTinCongTy = congtyController.CongTyInfo(txtMaNguoiDung.Text);
            foreach (CongTy congty1 in dsThongTinCongTy)
            {
                tileSoViTriCongTyDangTuyen.TileCount = viTriCongViecController.GetSoLuong(congty1.GetMaCongTy().ToString());
                txtTenCongTy_TD.Text = congty1.GetTenCongTy().ToString();
                txtEmail_TD.Text = congty1.GetEmailLienHe().ToString();
                txtMoTa_TD.Text = congty1.GetMoTaCongTy().ToString();
                txtSDT_TD.Text = congty1.GetSoDienThoai().ToString();
                txtDiaChi_TD.Text = congty1.GetDiaChi().ToString();
                tileSoLuongCVungTuyenVaoCongTy.TileCount = congtyController.SoLuongCVNop(congty1.GetMaCongTy());
                txtMaCongTy.Text = congty1.GetMaCongTy().ToString();
                //
            }
            if (dsThongTinCongTy == null || dsThongTinCongTy.Count == 0)
            {
                lbTitle_TD.Visible = true;
                lbTitle1_TD.Visible = false;
            }
            else
            {
                lbTitle_TD.Visible = false;
                lbTitle1_TD.Visible = true;
            }
            //Thêm mã công ty
            if (string.IsNullOrEmpty(txtMaCongTy.Text) && txtLoaiNguoiDung.Text == "Công Ty")
            {
                tileTaoMaCongTy.TileCount = int.Parse(GenerateMaCongTy());
                int maSoCongTy = tileTaoMaCongTy.TileCount;
                currentCongTy = new CongTy(maSoCongTy,int.Parse(txtMaNguoiDung.Text));
                congtyController.Add(currentCongTy);
                txtMaCongTy.Text = maSoCongTy.ToString();
            }
            else if(string.IsNullOrEmpty(txtMaCongTy.Text) && txtLoaiNguoiDung.Text == "Ứng Viên")
            {
                tileTaoMaCongTy.TileCount = 0;
            }
            else
            {
                tileTaoMaCongTy.TileCount = int.Parse(txtMaCongTy.Text);
            }
            //tabcontrol - hosoxinviec:
            dgKyNang.ColumnCount = 2;
            dgKyNang.Columns[0].Name = "Tên kỹ năng";
            dgKyNang.Columns[1].Name = "Mô tả kỹ năng";
            dsKyNang = kyNangController.Load(txtMaUngVien.Text);
            foreach(KyNang kn in dsKyNang)
            {
                string[] row = { kn.GetTenKyNang(), kn.GetMoTaKyNang() };
                dgKyNang.Rows.Add(row);
            }
            string kynang_all = "";
            string motakynang_all = "";
            for (int i = 0; i < dgKyNang.Rows.Count ; i++)
            {
                string kyNangValue = dgKyNang.Rows[i].Cells[0].Value.ToString() + ",";
                string motaValue = dgKyNang.Rows[i].Cells[1].Value.ToString() + ",";
                kynang_all += kyNangValue + Environment.NewLine;
                motakynang_all += motaValue + Environment.NewLine;
            }
            txtKyNang_dexuat.Text = kynang_all;
            txtMoTaKyNang_dexuat.Text = motakynang_all;
            dgDeXuatCongViec.ColumnCount = 1;
            dgDeXuatCongViec.Columns[0].Name = "Tên công việc";
            dgThongTinDeXuat.ColumnCount = 9;
            dgThongTinDeXuat.Columns[0].Name ="Tên công việc";
            dgThongTinDeXuat.Columns[1].Name ="Mô tả công việc";
            dgThongTinDeXuat.Columns[2].Name ="Yêu cầu công việc";
            dgThongTinDeXuat.Columns[3].Name ="Mức lương";
            dgThongTinDeXuat.Columns[4].Name ="Kinh nghiệm";
            dgThongTinDeXuat.Columns[5].Name ="Địa điểm làm việc";
            dgThongTinDeXuat.Columns[6].Name ="Ngày tạo";
            dgThongTinDeXuat.Columns[7].Name = "Mã vị trí";
            dgThongTinDeXuat.Columns[8].Name = "Mã công ty";
            dgThongTinDeXuat.Columns[7].Visible = false;
            dgThongTinDeXuat.Columns[8].Visible = false;
            //
            pn_HoSoCV.BorderColor = Color.White;
            pn_DeXuat.BorderColor = Color.White;
            LoadImageFromDatabase();
            if(txtLoaiNguoiDung.Text == "Công Ty")
            {
                LoadImageFromDatabase_CongTy();
            }
            LoadCongViec();
        }
        private void tool_doimatkhau_Click(object sender, EventArgs e)
        {
            NguoiDung currentNguoiDung = new NguoiDung(int.Parse(txtMaNguoiDung.Text), txtEmail_tk.Text, txtHoTen_tk.Text, txtDiaChi_tk.Text, txtSDT_tk.Text, txtViTriMongMuon_tk.Text);
            Frm_DoiMatKhau f = new Frm_DoiMatKhau(currentNguoiDung);
            f.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btn_LuuThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoTen_tk.Text))
            {
                NguoiDung currentNguoiDung1 = new NguoiDung(int.Parse(txtMaNguoiDung.Text), txtEmail_tk.Text, txtHoTen_tk.Text, txtDiaChi_tk.Text, txtSDT_tk.Text, txtViTriMongMuon_tk.Text);
                if (nguoidungController.Edit(currentNguoiDung1))
                {
                    MessageBox.Show("Lưu thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dsNguoiDung = nguoidungController.GetInfoUser(currentNguoiDung1);
                    foreach (NguoiDung nguoiDung in dsNguoiDung)
                    {
                        lb_welcome_tk.Text = nguoiDung.GetHoTen();
                        txtEmail_tk.Text = nguoiDung.Getmail().ToString();
                        txtDiaChi_tk.Text = nguoiDung.GetDiaChi().ToString();
                        txtHoTen_tk.Text = nguoiDung.GetHoTen().ToString();
                        txtSDT_tk.Text = nguoiDung.GetSDT().ToString();
                        txtViTriMongMuon_tk.Text = nguoiDung.GetViTriMongMuon().ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Lưu thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_TimKiemCongTy_Click(object sender, EventArgs e)
        {
            Frm_TimKiemCongTy f = new Frm_TimKiemCongTy();
            f.ShowDialog();
        }

        private void btnTaoCV_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoTen_tk.Text)&&!string.IsNullOrEmpty(txtEmail_tk.Text)&&!string.IsNullOrEmpty(txtDiaChi_tk.Text)&&!string.IsNullOrEmpty(txtSDT_tk.Text))
            {
                currentNguoiDung = new NguoiDung(int.Parse(txtMaNguoiDung.Text), txtHoTen_tk.Text, txtEmail_tk.Text, txtDiaChi_tk.Text, txtSDT_tk.Text);
                Frm_TaoCV f = new Frm_TaoCV(currentNguoiDung);
                f.ShowDialog();
                //
                dsHoSoUngVien = hoSoUngVienController.Load(txtMaNguoiDung.Text);
                foreach (HoSoUngVien hoso in dsHoSoUngVien)
                {
                    foreach (KyNang kn in dsKyNang)
                    {
                        txtKyNang_dexuat.Text = kn.GetTenKyNang().ToString();
                        txtMoTaKyNang_dexuat.Text = kn.GetMoTaKyNang().ToString();
                        string[] row = { kn.GetTenKyNang(), kn.GetMoTaKyNang() };
                    }

                }
                txtKyNang_dexuat.Text = "";
                txtMoTaKyNang_dexuat.Text = "";
                dsKyNang.Clear();
                dgKyNang.Rows.Clear();
                dsKyNang = kyNangController.Load(txtMaUngVien.Text);
                foreach (KyNang kn in dsKyNang)
                {
                    string[] row = { kn.GetTenKyNang(), kn.GetMoTaKyNang() };
                    dgKyNang.Rows.Add(row);
                }

                string kynang_all = "";
                string motakynang_all = "";
                for (int i = 0; i < dgKyNang.Rows.Count; i++)
                {
                    string kyNangValue = dgKyNang.Rows[i].Cells[0].Value.ToString() + ",";
                    string motaValue = dgKyNang.Rows[i].Cells[1].Value.ToString() + ",";
                    kynang_all += kyNangValue + Environment.NewLine;
                    motakynang_all += motaValue + Environment.NewLine;
                }

                // Gán giá trị của chuỗi kynang_all vào TextBox
                txtKyNang_dexuat.Text = kynang_all;
                txtMoTaKyNang_dexuat.Text = motakynang_all;
                dsHoSoUngVien = hoSoUngVienController.Load(txtMaNguoiDung.Text);
                foreach (HoSoUngVien hoso in dsHoSoUngVien)
                {
                    txtMaUngVien.Text = hoso.GetMaUngVien().ToString();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cá nhân bên danh mục tài khoản trước rồi sau đó hãy tạo CV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnTaoViecLam_Click(object sender, EventArgs e)
        {
            dsThongTinCongTy = congtyController.CongTyInfo(txtMaNguoiDung.Text);
            foreach (CongTy congty in dsThongTinCongTy)
            {
                tileSoViTriCongTyDangTuyen.TileCount = viTriCongViecController.GetSoLuong(congty.GetMaCongTy().ToString());
                int maCongTy = int.Parse(congty.GetMaCongTy().ToString());
                int maNguoiDung = int.Parse(congty.GetMaNguoiDung().ToString());
                string tenCongTy = congty.GetTenCongTy();
                string moTaCongTy = congty.GetMoTaCongTy();
                string diaChi = congty.GetDiaChi();
                string soDienThoai = congty.GetSoDienThoai();
                string emailLienHe = congty.GetEmailLienHe();
                string logoUrl = congty.GetLogoURL();
                currentCongTy = new CongTy(maCongTy,maNguoiDung,tenCongTy,moTaCongTy,diaChi,soDienThoai,emailLienHe,logoUrl);
            }
            Frm_TaoViecLam f = new Frm_TaoViecLam(currentCongTy);
            f.ShowDialog();
        }

        private void btnEditCongTy_Click(object sender, EventArgs e)
        {
            CongTy currentCongTy = new CongTy(int.Parse(txtMaNguoiDung.Text),txtTenCongTy_TD.Text,txtMoTa_TD.Text,txtDiaChi_TD.Text,txtSDT_TD.Text,txtEmail_TD.Text,pcLogoUrl.Text);
            if (congtyController.Edit(currentCongTy))
            {
                MessageBox.Show("Lưu thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu thất bại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemViecLam_Click(object sender, EventArgs e)
        {
            // Đặt giá trị ban đầu và khởi động một Timer để tăng giá trị của ProgressBar
            progressTimKiem.Value = 0;
            Timer timer = new Timer();
            timer.Interval = 10; // Đặt khoảng thời gian giữa mỗi lần tăng giá trị (milliseconds)
            timer.Tick += Timer_Tick;
            timer.Start();
            //
            bool kiemtra = false;
            currentViTriCongViec = new ViTriCongViec(txtTimViec.Text, cbbLuong.Text, cbbKinhNghiem.Text, cbbDiaDiem.Text);
            dsViTriCongViec.Clear();
            dsViTriCongViec = viTriCongViecController.Find3TieuChi(currentViTriCongViec,int.Parse(txtMinLuong.Text),int.Parse(txtMaxLuong.Text));
            dgViecLam.Rows.Clear();
            foreach (ViTriCongViec vitricongviec in dsViTriCongViec)
            {
                kiemtra = true;
                string[] row = { vitricongviec.GetTenViTri(), vitricongviec.GetMoTaCongViec(), vitricongviec.GetYeuCauCongViec(), vitricongviec.GetMucLuong().ToString(), vitricongviec.GetKinhNghiem(), vitricongviec.GetDiaDiemLamViec(), vitricongviec.GetNgayTao().ToString("MM/dd/yyyy") };
                dgViecLam.Rows.Add(row);
            }
            if (kiemtra)
            {
                MessageBox.Show("Tìm thấy thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dsViTriCongViec.Clear();
            dsViTriCongViec = viTriCongViecController.LoadAll();
            dgViecLam.Rows.Clear();
            foreach (ViTriCongViec vitricongviec in dsViTriCongViec)
            {
                string[] row = { vitricongviec.GetTenViTri(), vitricongviec.GetMoTaCongViec(), vitricongviec.GetYeuCauCongViec(), vitricongviec.GetMucLuong().ToString(), vitricongviec.GetKinhNghiem(), vitricongviec.GetDiaDiemLamViec(), vitricongviec.GetNgayTao().ToString("MM/dd/yyyy") };
                dgViecLam.Rows.Add(row);
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Tăng giá trị của ProgressBar và kiểm tra xem đã đạt giá trị tối đa chưa
            if (progressTimKiem.Value < progressTimKiem.Maximum)
            {
                progressTimKiem.Value += 5; // Tăng giá trị (ở đây là 5, bạn có thể điều chỉnh theo ý muốn)
            }
            else
            {
                ((Timer)sender).Stop(); // Dừng Timer khi đạt giá trị tối đa
                
            }
        }
        private void Timer_Tick2(object sender, EventArgs e)
        {
            // Tăng giá trị của ProgressBar và kiểm tra xem đã đạt giá trị tối đa chưa
            if (progressTieuChi.Value < progressTieuChi.Maximum)
            {
                progressTieuChi.Value += 5; // Tăng giá trị (ở đây là 5, bạn có thể điều chỉnh theo ý muốn)
            }
            else
            {
                ((Timer)sender).Stop(); // Dừng Timer khi đạt giá trị tối đa

            }
        }

        private void cbbLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbLuong.SelectedItem?.ToString())
            {
                case "Tất cả mức lương":
                    txtMinLuong.Text = "1";
                    txtMaxLuong.Text = "999999999";
                    break;

                //Thêm các trường hợp khác nếu cần
                case "5 triệu - 10 triệu":
                    txtMinLuong.Text = "5000000";
                    txtMaxLuong.Text = "10000000";
                    break;
                case "10 triệu - 20 triệu":
                    txtMinLuong.Text = "10000000";
                    txtMaxLuong.Text = "20000000";
                    break;
                case "20 triệu - 30 triệu":
                    txtMinLuong.Text = "20000000";
                    txtMaxLuong.Text = "30000000";
                    break;
                case "30 triệu - 40 triệu":
                    txtMinLuong.Text = "30000000";
                    txtMaxLuong.Text = "40000000";
                    break;
                case "Trên 40 triệu":
                    txtMinLuong.Text = "40000000";
                    txtMaxLuong.Text = "999999999";
                    break;
                default:
                    //Xử lý khi không khớp với bất kỳ trường hợp nào
                    break;
            }
        }

        private void a1_Click(object sender, EventArgs e)
        {
            // Đặt giá trị ban đầu và khởi động một Timer để tăng giá trị của ProgressBar
            progressTieuChi.Value = 0;
            Timer timer = new Timer();
            timer.Interval = 10; // Đặt khoảng thời gian giữa mỗi lần tăng giá trị (milliseconds)
            timer.Tick += Timer_Tick2;
            timer.Start();
            ResetButtonColors(); // Assuming you have a method to reset button colors
            a1.BackColor = Color.DeepSkyBlue;
            b1.NormalColor = Color.DeepSkyBlue;
            switch (a1.Text)
            {
                case "Thành phố Hồ Chí Minh":
                    txtTieuChi1.Text = "Thành phố Hồ Chí Minh";
                    LocDiaDiem(txtTieuChi1.Text);
                    break;
                case "Chưa có kinh nghiệm":
                    txtTieuChi1.Text = "Chưa có kinh nghiệm";
                    LocKinhNghiem(txtTieuChi1.Text);
                    break;
                case "5 triệu - 10 triệu":
                    txtTieuChi1.Text = "5000000";
                    txtTieuChi2.Text = "10000000";
                    LocMucLuong(txtTieuChi1.Text,txtTieuChi2.Text);
                    break;
            }
            
        }

        private void a2_Click(object sender, EventArgs e)
        {
            // Đặt giá trị ban đầu và khởi động một Timer để tăng giá trị của ProgressBar
            progressTieuChi.Value = 0;
            Timer timer = new Timer();
            timer.Interval = 10; // Đặt khoảng thời gian giữa mỗi lần tăng giá trị (milliseconds)
            timer.Tick += Timer_Tick2;
            timer.Start();
            ResetButtonColors(); // Assuming you have a method to reset button colors
            a2.BackColor = Color.DeepSkyBlue;
            b2.NormalColor = Color.DeepSkyBlue;
            switch (a2.Text)
            {
                case "Hà Nội":
                    txtTieuChi1.Text = "Hà Nội";
                    LocDiaDiem(txtTieuChi1.Text);
                    break;
                case "1 năm":
                    txtTieuChi1.Text = "1 năm";
                    LocKinhNghiem(txtTieuChi1.Text);
                    break;
                case "10 triệu - 20 triệu":
                    txtTieuChi1.Text = "10000000";
                    txtTieuChi2.Text = "20000000";
                    LocMucLuong(txtTieuChi1.Text, txtTieuChi2.Text);
                    break;
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            // Đặt giá trị ban đầu và khởi động một Timer để tăng giá trị của ProgressBar
            progressTieuChi.Value = 0;
            Timer timer = new Timer();
            timer.Interval = 10; // Đặt khoảng thời gian giữa mỗi lần tăng giá trị (milliseconds)
            timer.Tick += Timer_Tick2;
            timer.Start();
            ResetButtonColors(); // Assuming you have a method to reset button colors
            a3.BackColor = Color.DeepSkyBlue;
            b3.NormalColor = Color.DeepSkyBlue;
            switch (a3.Text)
            {
                case "Đà Nẵng":
                    txtTieuChi1.Text = "Đà Nẵng";
                    LocDiaDiem(txtTieuChi1.Text);
                    break;
                case "2 năm":
                    txtTieuChi1.Text = "2 năm";
                    LocKinhNghiem(txtTieuChi1.Text);
                    break;
                case "20 triệu - 30 triệu":
                    txtTieuChi1.Text = "20000000";
                    txtTieuChi2.Text = "30000000";
                    LocMucLuong(txtTieuChi1.Text, txtTieuChi2.Text);
                    break;
            }
        }

        private void a4_Click(object sender, EventArgs e)
        {
            // Đặt giá trị ban đầu và khởi động một Timer để tăng giá trị của ProgressBar
            progressTieuChi.Value = 0;
            Timer timer = new Timer();
            timer.Interval = 10; // Đặt khoảng thời gian giữa mỗi lần tăng giá trị (milliseconds)
            timer.Tick += Timer_Tick2;
            timer.Start();
            ResetButtonColors(); // Assuming you have a method to reset button colors
            a4.BackColor = Color.DeepSkyBlue;
            b4.NormalColor = Color.DeepSkyBlue;
            switch (a4.Text)
            {
                case "Ngẫu nhiên":
                    txtTieuChi1.Text = "";
                    LocDiaDiem(txtTieuChi1.Text);
                    break;
                case "3 năm":
                    txtTieuChi1.Text = "3 năm";
                    LocKinhNghiem(txtTieuChi1.Text);
                    break;
                case "30 triệu - 40 triệu":
                    txtTieuChi1.Text = "30000000";
                    txtTieuChi2.Text = "40000000";
                    LocMucLuong(txtTieuChi1.Text, txtTieuChi2.Text);
                    break;
            }
        }

        private void a5_Click(object sender, EventArgs e)
        {
            // Đặt giá trị ban đầu và khởi động một Timer để tăng giá trị của ProgressBar
            progressTieuChi.Value = 0;
            Timer timer = new Timer();
            timer.Interval = 10; // Đặt khoảng thời gian giữa mỗi lần tăng giá trị (milliseconds)
            timer.Tick += Timer_Tick2;
            timer.Start();
            ResetButtonColors(); // Assuming you have a method to reset button colors
            a5.BackColor = Color.DeepSkyBlue;
            b5.NormalColor = Color.DeepSkyBlue;
            switch (a5.Text)
            {
                case "4 năm":
                    txtTieuChi1.Text = "4 năm";
                    LocKinhNghiem(txtTieuChi1.Text);
                    break;
                case "Trên 40 triệu":
                    txtTieuChi1.Text = "40000000";
                    txtTieuChi2.Text = "999999999";
                    LocMucLuong(txtTieuChi1.Text, txtTieuChi2.Text);
                    break;
            }
        }

        private void a6_Click(object sender, EventArgs e)
        {
            // Đặt giá trị ban đầu và khởi động một Timer để tăng giá trị của ProgressBar
            progressTieuChi.Value = 0;
            Timer timer = new Timer();
            timer.Interval = 10; // Đặt khoảng thời gian giữa mỗi lần tăng giá trị (milliseconds)
            timer.Tick += Timer_Tick2;
            timer.Start();
            ResetButtonColors(); // Assuming you have a method to reset button colors
            a6.BackColor = Color.DeepSkyBlue;
            b6.NormalColor = Color.DeepSkyBlue;
            switch (a6.Text)
            {
                case "Tất cả kinh nghiệm":
                    txtTieuChi1.Text = "";
                    LocKinhNghiem(txtTieuChi1.Text);
                    break;
                case "Tất cả mức lương":
                    txtTieuChi1.Text = "1";
                    txtTieuChi2.Text = "999999999";
                    LocMucLuong(txtTieuChi1.Text, txtTieuChi2.Text);
                    break;
            }
        }

        private void cbbTimTheoTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetButtonColors();
            txtTieuChi1.Text = "";
            txtTieuChi2.Text = "";
            switch (cbbTimTheoTieuChi.SelectedItem?.ToString())
            {
                case "Địa điểm":
                    a1.Text = "Thành phố Hồ Chí Minh";
                    a2.Text = "Hà Nội";
                    a3.Text = "Đà Nẵng";
                    a4.Text = "Ngẫu nhiên";
                    a5.Visible = false;
                    a6.Visible = false;
                    b5.Visible = false;
                    b6.Visible = false;
                    break;

                //Thêm các trường hợp khác nếu cần
                case "Kinh nghiệm":
                    a1.Text = "Chưa có kinh nghiệm";
                    a2.Text = "1 năm";
                    a3.Text = "2 năm";
                    a4.Text = "3 năm";
                    a5.Visible = true;
                    a6.Visible = true;
                    b5.Visible = true;
                    b6.Visible = true;
                    a5.Text = "4 năm";
                    a6.Text = "Tất cả kinh nghiệm";
                    break;

                case "Mức lương":
                    a1.Text = "5 triệu - 10 triệu";
                    a2.Text = "10 triệu - 20 triệu";
                    a3.Text = "20 triệu - 30 triệu";
                    a4.Text = "30 triệu - 40 triệu";
                    a5.Visible = true;
                    a6.Visible = true;
                    b5.Visible = true;
                    b6.Visible = true;
                    a5.Text = "Trên 40 triệu";
                    a6.Text = "Tất cả mức lương";
                    break;

                default:
                    MessageBox.Show("sai con mẹ nó rồi");
                    break;
            }
        }
        private void ResetButtonColors()
        {
            // Assuming you have similar code to reset other button colors
            a1.BackColor = Color.WhiteSmoke; b1.NormalColor = Color.White;
            a2.BackColor = Color.WhiteSmoke; b2.NormalColor = Color.White;
            a3.BackColor = Color.WhiteSmoke; b3.NormalColor = Color.White;
            a4.BackColor = Color.WhiteSmoke; b4.NormalColor = Color.White;
            a5.BackColor = Color.WhiteSmoke; b5.NormalColor = Color.White;
            a6.BackColor = Color.WhiteSmoke; b6.NormalColor = Color.White;
        }
        public void LocMucLuong(string tieuchi1,string tieuchi2)
        {   
            dsViTriCongViec.Clear();
            dsViTriCongViec = viTriCongViecController.TimMucLuong(int.Parse(tieuchi1),int.Parse(tieuchi2));
            dgLocTieuChi.Rows.Clear();
            foreach (ViTriCongViec vitricongviec in dsViTriCongViec)
            {
                string[] row = { vitricongviec.GetTenViTri(), vitricongviec.GetMoTaCongViec(), vitricongviec.GetYeuCauCongViec(), vitricongviec.GetMucLuong().ToString(), vitricongviec.GetKinhNghiem(), vitricongviec.GetDiaDiemLamViec(), vitricongviec.GetNgayTao().ToString("MM/dd/yyyy"),vitricongviec.GetMaViTri().ToString() };
                dgLocTieuChi.Rows.Add(row);
            }
        }
        public void LocDiaDiem(string diadiem)
        {
            dsViTriCongViec.Clear();
            dsViTriCongViec = viTriCongViecController.TimDiaDiem(diadiem);
            dgLocTieuChi.Rows.Clear();
            foreach (ViTriCongViec vitricongviec in dsViTriCongViec)
            {
                string[] row = { vitricongviec.GetTenViTri(), vitricongviec.GetMoTaCongViec(), vitricongviec.GetYeuCauCongViec(), vitricongviec.GetMucLuong().ToString(), vitricongviec.GetKinhNghiem(), vitricongviec.GetDiaDiemLamViec(), vitricongviec.GetNgayTao().ToString("MM/dd/yyyy"), vitricongviec.GetMaViTri().ToString() };
                dgLocTieuChi.Rows.Add(row);
            }
        }
        public void LocKinhNghiem(string kinhnghiem)
        {
            dsViTriCongViec.Clear();
            dsViTriCongViec = viTriCongViecController.TimKinhNghiem(kinhnghiem);
            dgLocTieuChi.Rows.Clear();
            foreach (ViTriCongViec vitricongviec in dsViTriCongViec)
            {
                string[] row = { vitricongviec.GetTenViTri(), vitricongviec.GetMoTaCongViec(), vitricongviec.GetYeuCauCongViec(), vitricongviec.GetMucLuong().ToString(), vitricongviec.GetKinhNghiem(), vitricongviec.GetDiaDiemLamViec(), vitricongviec.GetNgayTao().ToString("MM/dd/yyyy"),vitricongviec.GetMaViTri().ToString()};
                dgLocTieuChi.Rows.Add(row);
            }
        }

        private void dgLocTieuChi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dgLocTieuChi.Rows[e.RowIndex];

                // Lấy giá trị của ô đầu tiên trong hàng được nhấp và hiển thị nó trong TextBox
                object EndCellValue = clickedRow.Cells[7].Value;
                
                // Kiểm tra xem giá trị có tồn tại không và hiển thị nó trong TextBox
                string MaViTri = EndCellValue?.ToString(); 
                if (MaViTri == null)
                {
                }
                else
                {
                    Frm_ViewCongViec f = new Frm_ViewCongViec(MaViTri,txtMaNguoiDung.Text);
                    f.Show();
                }                
            }
        }

        private void btnXemUngVien_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMaCongTy.Text))
            {
                Frm_XemUngVien f = new Frm_XemUngVien(txtMaCongTy.Text);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin công ty trước khi tuyển dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXemKetQuaUngTuyen_Click(object sender, EventArgs e)
        {
            Frm_TinhTrangCV f = new Frm_TinhTrangCV(txtMaNguoiDung.Text);
            f.ShowDialog();
        }

        // chọn mã công ty ngẫu nhiên 7 ký tự
        public static string GenerateMaCongTy()
        {
            // Sử dụng Guid để tạo một chuỗi duy nhất ngẫu nhiên
            Guid guid = Guid.NewGuid();

            // Chuyển Guid thành chuỗi và chỉ lấy các chữ số
            string maCongTy = new string(guid.ToString().Where(char.IsDigit).ToArray());

            // Giới hạn độ dài của mã ứng viên từ 1 đến 8 ký tự
            maCongTy = maCongTy.Substring(0, Math.Min(maCongTy.Length, 7));

            return maCongTy;
        }
        public void LoadCongViec()
        {
            //
            viTriCongViecController = new ViTriCongViecController();
            dsViTriCongViec = viTriCongViecController.LoadAll();
            List<ViTriCongViecDto> dtos = ConvertToDto(dsViTriCongViec);
            // Lưu danh sách công việc vào file CSV
            SaveToCsv(dtos, @"C:\Users\hongh\OneDrive\Desktop\Tài liệu học năm 4\datasets.csv");
        }
        private async void btnDeXuatCongViec_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMoTaKyNang_dexuat.Text) && !string.IsNullOrEmpty(txtKyNang_dexuat.Text) && !string.IsNullOrEmpty(txtDiaChi_tk.Text))
            {
                pn_DeXuat.Visible = true;
                if (dgDeXuatCongViec.Rows.Count == 0)
                {
                    MessageBox.Show("Đã đề xuất những công việc phù hợp cho bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //
                    txtKyNang_dexuat.Text = "";
                    txtMoTaKyNang_dexuat.Text = "";
                    dsKyNang.Clear();
                    dgKyNang.Rows.Clear();
                    dsKyNang = kyNangController.Load(txtMaUngVien.Text);
                    foreach (KyNang kn in dsKyNang)
                    {
                        string[] row = { kn.GetTenKyNang(), kn.GetMoTaKyNang() };
                        dgKyNang.Rows.Add(row);
                    }

                    string kynang_all = "";
                    string motakynang_all = "";
                    for (int i = 0; i < dgKyNang.Rows.Count; i++)
                    {
                        string kyNangValue = dgKyNang.Rows[i].Cells[0].Value.ToString() + ",";
                        string motaValue = dgKyNang.Rows[i].Cells[1].Value.ToString() + ",";
                        kynang_all += kyNangValue + Environment.NewLine;
                        motakynang_all += motaValue + Environment.NewLine;
                    }

                    // Gán giá trị của chuỗi kynang_all vào TextBox
                    txtKyNang_dexuat.Text = kynang_all;
                    txtMoTaKyNang_dexuat.Text = motakynang_all;
                    dsHoSoUngVien = hoSoUngVienController.Load(txtMaNguoiDung.Text);
                    foreach (HoSoUngVien hoso in dsHoSoUngVien)
                    {
                        txtMaUngVien.Text = hoso.GetMaUngVien().ToString();
                    }
                    /*Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");*/

            // URL của điểm cuối API Flask của bạn
            string apiUrl = "http://127.0.0.1:5000/predict";

                    // Dữ liệu mẫu để gửi trong yêu cầu
                    var requestData = new
                    {
                        mota = txtKyNang_dexuat.Text,
                        yeucau = txtMoTaKyNang_dexuat.Text,
                        location = txtDiaChi_tk.Text
                    };

                    // Tạo một thể hiện của HttpClient
                    using (HttpClient client = new HttpClient())
                    {
                        // Chuyển đổi dữ liệu sang định dạng JSON
                        string jsonData = JsonConvert.SerializeObject(requestData);

                        // Tạo nội dung HTTP với định dạng JSON
                        var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");

                        try
                        {
                            // Gửi yêu cầu POST
                            HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                            // Kiểm tra xem yêu cầu có thành công không
                            if (response.IsSuccessStatusCode)
                            {
                                // Đọc và hiển thị nội dung phản hồi
                                string responseContent = await response.Content.ReadAsStringAsync();

                                // Phân tích JSON từ responseContent
                                JObject jsonResponse = JObject.Parse(responseContent);

                                // Lấy giá trị của key "top_10_jobs"
                                var top10Jobs = jsonResponse["top_10_jobs"];

                                // Hiển thị từng phần tử trong top_10_jobs
                                foreach (var job in top10Jobs)
                                {
                                    /*// Xử lý từng công việc ở đây (job.ToString())
                                    MessageBox.Show(job.ToString(), "Công Việc", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                                    string[] row = { job.ToString() };
                                    dgDeXuatCongViec.Rows.Add(row);
                                }
                            }
                            else
                            {
                                // Hiển thị thông báo lỗi nếu yêu cầu không thành công
                                MessageBox.Show($"Lỗi: {response.StatusCode} - {response.ReasonPhrase}", "Lỗi API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            // Xử lý các ngoại lệ
                            MessageBox.Show($"Ngoại lệ: {ex.Message}", "Ngoại lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    // hiển thị tất cả công việc sau khi đã có tên công việc từ model train bên python
                    for (int i = 0; i < dgDeXuatCongViec.Rows.Count; i++)
                    {
                        dsViTriCongViec.Clear();
                        dsViTriCongViec = viTriCongViecController.DeXuatCongViec(dgDeXuatCongViec.Rows[i].Cells[0].Value.ToString());
                        foreach (ViTriCongViec vt in dsViTriCongViec)
                        {
                            string[] row = { vt.GetTenViTri(), vt.GetMoTaCongViec(), vt.GetYeuCauCongViec(), vt.GetMucLuong().ToString(), vt.GetKinhNghiem(), vt.GetDiaDiemLamViec(), vt.GetNgayTao().ToString("MM/dd/yyyy"), vt.GetMaViTri().ToString(), vt.GetMaCongTy().ToString() };
                            dgThongTinDeXuat.Rows.Add(row);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chúng tôi đã gợi ý cho bạn những công việc phù hợp nhất ở phía dưới rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy hoàn thiện CV của bạn rồi sau đó chúng tôi sẽ đề xuất công việc phù hợp với bạn!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void dgThongTinDeXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgThongTinDeXuat.Rows[e.RowIndex];
                tileTenViTri_dexuat.TileCount = selectRow.Index + 1;
                tileTenViTri_dexuat.Text = selectRow.Cells[0].Value.ToString();
                lb_DiaDiem_DeXuat.Text = selectRow.Cells[5].Value.ToString();
                lb_MoTaCongViec_DeXuat.Text = selectRow.Cells[1].Value.ToString();
                dsCongTy = congtyController.ThongTinCongTy(selectRow.Cells[8].Value.ToString());
                foreach(CongTy ct in dsCongTy)
                {
                    lb_TenCongTy_DeXuat.Text = ct.GetTenCongTy().ToString();
                }
                txtMaViTri.Text = selectRow.Cells[7].Value.ToString();
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if(txtMaViTri.Text == null)
            {
                MessageBox.Show("Vui lòng chọn công việc bạn muốn xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Frm_ViewCongViec f = new Frm_ViewCongViec(txtMaViTri.Text, txtMaNguoiDung.Text);
                f.Show();
            }
        }

        private void btnThemAnhHoSo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                if (nguoidungController.ThemAnhHoSo(int.Parse(txtMaNguoiDung.Text), selectedImagePath))
                {
                    // Đặt kiểu Zoom cho PictureBox
                    pb_HinhAnhHoSo.SizeMode = PictureBoxSizeMode.Zoom;
                    // Hiển thị ảnh trong PictureBox (ví dụ sử dụng pictureBox1)
                    pb_HinhAnhHoSo.Image = Image.FromFile(selectedImagePath);

                    MessageBox.Show("Thêm ảnh hồ sơ thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm ảnh hồ sơ thất bại!");
                }
            }
            LoadImageFromDatabase();
        }
        // Lấy ảnh từ database từ người dùng
        private void LoadImageFromDatabase()
        {
            string imagePath = nguoidungController.LayDuongDanAnhHoSo(int.Parse(txtMaNguoiDung.Text));
            pb_HinhAnhHoSo.BorderStyle = BorderStyle.None;
            if (!string.IsNullOrEmpty(imagePath))
            {
                // Đặt kiểu Zoom cho PictureBox
                pb_HinhAnhHoSo.SizeMode = PictureBoxSizeMode.Zoom;

                // Hiển thị hình ảnh
                pb_HinhAnhHoSo.Image = Image.FromFile(imagePath);
            }
        }
        // Lấy ảnh từ database từ công ty
        private void LoadImageFromDatabase_CongTy()
        {
            string imagePath = congtyController.LayDuongDanAnhHoSo(int.Parse(txtMaCongTy.Text));
            pb_HinhAnhHoSo.BorderStyle = BorderStyle.None;
            if (!string.IsNullOrEmpty(imagePath))
            {
                // Đặt kiểu Zoom cho PictureBox
                pcLogoUrl.SizeMode = PictureBoxSizeMode.Zoom;

                // Hiển thị hình ảnh
                pcLogoUrl.Image = Image.FromFile(imagePath);
            }
        }

        private void btnThemLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                if (congtyController.ThemAnhHoSo(int.Parse(txtMaCongTy.Text), selectedImagePath))
                {
                    // Đặt kiểu Zoom cho PictureBox
                    pb_HinhAnhHoSo.SizeMode = PictureBoxSizeMode.Zoom;
                    // Hiển thị ảnh trong PictureBox (ví dụ sử dụng pictureBox1)
                    pb_HinhAnhHoSo.Image = Image.FromFile(selectedImagePath);

                    MessageBox.Show("Thêm ảnh hồ sơ thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm ảnh hồ sơ thất bại!");
                }
            }
            LoadImageFromDatabase_CongTy();
        }
        ///// xử lý CSV
        private List<ViTriCongViecDto> ConvertToDto(List<ViTriCongViec> data)
        {
            List<ViTriCongViecDto> dtos = new List<ViTriCongViecDto>();

            foreach (var item in data)
            {
                ViTriCongViecDto dto = new ViTriCongViecDto
                {
                    MaViTri = item.GetMaViTri(),
                    MaCongTy = item.GetMaCongTy(),
                    TenViTri = item.GetTenViTri(),
                    MoTaCongViec = item.GetMoTaCongViec(),
                    YeuCauCongViec = item.GetYeuCauCongViec(),
                    MucLuong = item.GetMucLuong(),
                    KinhNghiem = item.GetKinhNghiem(),
                    DiaDiemLamViec = item.GetDiaDiemLamViec(),
                    NgayTao = item.GetNgayTao()
                };

                dtos.Add(dto);
            }

            return dtos;
        }

        private void SaveToCsv(List<ViTriCongViecDto> data, string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (var writer = new StreamWriter(stream, new UTF8Encoding(true)))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ViTriCongViecDtoMap>();
                csv.WriteRecords(data);
            }
        }


        public class ViTriCongViecDtoMap : ClassMap<ViTriCongViecDto>
        {
            public ViTriCongViecDtoMap()
            {
                Map(m => m.MaViTri).Name("MaViTri");
                Map(m => m.MaCongTy).Name("MaCongTy");
                Map(m => m.TenViTri).Name("TenViTri");
                Map(m => m.MoTaCongViec).Name("MoTaCongViec");
                Map(m => m.YeuCauCongViec).Name("YeuCauCongViec");
                Map(m => m.MucLuong).Name("MucLuong");
                Map(m => m.KinhNghiem).Name("KinhNghiem");
                Map(m => m.DiaDiemLamViec).Name("DiaDiemLamViec");
                Map(m => m.NgayTao).Name("NgayTao");
            }
        }

        public class ViTriCongViecDto
        {
            public int MaViTri { get; set; }
            public int MaCongTy { get; set; }
            public string TenViTri { get; set; }
            public string MoTaCongViec { get; set; }
            public string YeuCauCongViec { get; set; }
            public string MucLuong { get; set; }
            public string KinhNghiem { get; set; }
            public string DiaDiemLamViec { get; set; }
            public DateTime NgayTao { get; set; }
        }
    }
}
