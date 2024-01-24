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
    public partial class Frm_Admin : MetroSetForm
    {
        // khai bao
        NguoiDungController nguoiDungController;
        List<NguoiDung> dsNguoiDung;
        NguoiDung currentNguoiDung;
        //
        CongTyController congTyController;
        List<CongTy> dsCongTy;
        CongTy currentCongTy;
        //
        //
        ViTriCongViecController viTriCongViecController;
        List<ViTriCongViec> dsViTriCongViec;
        ViTriCongViec currentViTriCongViec;
        //
        HoSoUngVienController hoSoUngVienController;
        List<HoSoUngVien> dsHoSoUngVien;
        HoSoUngVien currentHoSoUngVien;
        //
        UngTuyenController ungTuyenController;
        List<UngTuyen> dsUngTuyen;
        UngTuyen currentUngTuyen;
        public Frm_Admin()
        {
            InitializeComponent();
            // tabcontrol : Danh mục tài khoản
            nguoiDungController = new NguoiDungController();
            dsNguoiDung = new List<NguoiDung>();
            currentNguoiDung = new NguoiDung();
            dgThongTinTaiKhoan.ColumnCount = 9;
            dgThongTinTaiKhoan.Columns[0].Name = "Mã người dùng";
            dgThongTinTaiKhoan.Columns[1].Name = "Tên đăng nhập";
            dgThongTinTaiKhoan.Columns[2].Name = "Mật khẩu";
            dgThongTinTaiKhoan.Columns[3].Name = "Email";
            dgThongTinTaiKhoan.Columns[4].Name = "Họ tên";
            dgThongTinTaiKhoan.Columns[5].Name = "Địa chỉ";
            dgThongTinTaiKhoan.Columns[6].Name = "Số điện thoại";
            dgThongTinTaiKhoan.Columns[7].Name = "Vị trí mong muốn";
            dgThongTinTaiKhoan.Columns[8].Name = "Loại người dùng";
            // tabcontrol : Danh mục công ty
            congTyController = new CongTyController();
            dsCongTy = new List<CongTy>();
            currentCongTy = new CongTy();
            dgThongTinCongTy.ColumnCount = 7;
            dgThongTinCongTy.Columns[0].Name = "Mã công ty";
            dgThongTinCongTy.Columns[1].Name = "Mã người dùng";
            dgThongTinCongTy.Columns[2].Name = "Tên công ty";
            dgThongTinCongTy.Columns[3].Name = "Mô tả công ty";
            dgThongTinCongTy.Columns[4].Name = "Địa chỉ";
            dgThongTinCongTy.Columns[5].Name = "Số điện thoại";
            dgThongTinCongTy.Columns[6].Name = "Email liên hệ";
            //tabControl
            //tabControl: Vị trí công việc
            viTriCongViecController = new ViTriCongViecController();
            dsViTriCongViec = new List<ViTriCongViec>();
            currentViTriCongViec = new ViTriCongViec();
            dgTuyenDung.ColumnCount = 9;
            dgTuyenDung.Columns[0].Name = "Vị trí";
            dgTuyenDung.Columns[1].Name = "Mô tả công việc";
            dgTuyenDung.Columns[2].Name = "Yêu cầu công việc";
            dgTuyenDung.Columns[3].Name = "Mức lương";
            dgTuyenDung.Columns[4].Name = "Kinh nghiệm";
            dgTuyenDung.Columns[5].Name = "Địa điểm làm việc";
            dgTuyenDung.Columns[6].Name = "Ngày tạo";
            dgTuyenDung.Columns[7].Name = "Mã Vị Trí";
            dgTuyenDung.Columns[8].Name = "Tên công ty";
            dgTuyenDung.Columns[8].Visible = false;
            //tabControl: Hồ sơ ứng viên
            hoSoUngVienController = new HoSoUngVienController();
            dsHoSoUngVien = new List<HoSoUngVien>();
            currentHoSoUngVien = new HoSoUngVien();
            dgHoSoUngVien.ColumnCount = 3;
            dgHoSoUngVien.Columns[0].Name = "Mã ứng viên";
            dgHoSoUngVien.Columns[1].Name = "Mã người dùng";
            dgHoSoUngVien.Columns[2].Name = "Mục tiêu nghề nghiệp";
            // tabControl : Ứng tuyển
            ungTuyenController = new UngTuyenController();
            dsUngTuyen = new List<UngTuyen>();
            currentUngTuyen = new UngTuyen();
            dgThongTinUngTuyen.ColumnCount = 5;
            dgThongTinUngTuyen.Columns[0].Name = "Mã ứng tuyển";
            dgThongTinUngTuyen.Columns[1].Name = "Mã ứng viên";
            dgThongTinUngTuyen.Columns[2].Name = "Mã vị trí";
            dgThongTinUngTuyen.Columns[3].Name = "Ngày ứng tuyển";
            dgThongTinUngTuyen.Columns[4].Name = "Trạng thái ứng tuyển";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Load();  
        }
        public void Load()
        {
            txtId.Text = ""; txtEmail.Text = "";
            txtDiaDiem.Text = ""; txtTen.Text = "";
            txtSDT.Text = ""; txtUsername.Text = "";
            txtViTriMongMuon.Text = "";
            txtPassword.Text = ""; txtLoaiNguoiDung.Text = "";
            pcAnhHoSo.Image = null;
            //
            dsNguoiDung.Clear();
            dgThongTinTaiKhoan.Rows.Clear();
            dsNguoiDung = nguoiDungController.Load();
            foreach(NguoiDung nd in dsNguoiDung)
            {
                string[] row = { nd.GetMaNguoiDung().ToString(), nd.GetTenDangNhap(), nd.GetMatKhau(), nd.Getmail(), nd.GetHoTen(), nd.GetDiaChi(), nd.GetSDT(), nd.GetViTriMongMuon(), nd.GetLoaiNguoiDung() };
                dgThongTinTaiKhoan.Rows.Add(row);
            }
        }

        private void dgThongTinTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgThongTinTaiKhoan.Rows[e.RowIndex];
                txtId.Text = selectRow.Cells[0].Value.ToString();
                txtUsername.Text = selectRow.Cells[1].Value.ToString();
                txtPassword.Text = selectRow.Cells[2].Value.ToString();
                txtEmail.Text = selectRow.Cells[3].Value.ToString();
                txtTen.Text = selectRow.Cells[4].Value.ToString();
                txtDiaDiem.Text = selectRow.Cells[5].Value.ToString();
                txtSDT.Text = selectRow.Cells[6].Value.ToString();
                txtViTriMongMuon.Text = selectRow.Cells[7].Value.ToString();
                txtLoaiNguoiDung.Text = selectRow.Cells[8].Value.ToString();
                LoadImageFromDatabase();
            }
        }
        private void LoadImageFromDatabase()
        {
            string imagePath = nguoiDungController.LayDuongDanAnhHoSo(int.Parse(txtId.Text));
            pcAnhHoSo.BorderStyle = BorderStyle.None;
            if (!string.IsNullOrEmpty(imagePath))
            {
                // Đặt kiểu Zoom cho PictureBox
                pcAnhHoSo.SizeMode = PictureBoxSizeMode.Zoom;
                // Hiển thị hình ảnh
                pcAnhHoSo.Image = Image.FromFile(imagePath);
            }
            else
            {
                pcAnhHoSo.Image = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentNguoiDung = new NguoiDung(txtUsername.Text, txtPassword.Text, txtEmail.Text, txtTen.Text, txtDiaDiem.Text, txtSDT.Text, txtViTriMongMuon.Text, txtLoaiNguoiDung.Text);
            if (nguoiDungController.Add_User(currentNguoiDung))
            {
                MessageBox.Show("Thêm thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Load();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            currentNguoiDung = new NguoiDung(int.Parse(txtId.Text),txtUsername.Text, txtPassword.Text, txtEmail.Text, txtTen.Text, txtDiaDiem.Text, txtSDT.Text,pcAnhHoSo.Text, txtViTriMongMuon.Text, txtLoaiNguoiDung.Text);
            if (nguoiDungController.Edit_User(currentNguoiDung))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            currentNguoiDung = new NguoiDung(int.Parse(txtId.Text), txtUsername.Text, txtPassword.Text, txtEmail.Text, txtTen.Text, txtDiaDiem.Text, txtSDT.Text, pcAnhHoSo.Text, txtViTriMongMuon.Text, txtLoaiNguoiDung.Text);
            if (nguoiDungController.Delete_User(currentNguoiDung))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            bool ktra = false;
            dsNguoiDung.Clear();
            dgThongTinTaiKhoan.Rows.Clear();
            dsNguoiDung = nguoiDungController.Find(txtTimKiemTheoTen.Text);
            foreach(NguoiDung nd in dsNguoiDung)
            {
                ktra = true;
                string[] row = { nd.GetMaNguoiDung().ToString(), nd.GetTenDangNhap(), nd.GetMatKhau(), nd.Getmail(), nd.GetHoTen(), nd.GetDiaChi(), nd.GetSDT(), nd.GetViTriMongMuon(), nd.GetLoaiNguoiDung() };
                dgThongTinTaiKhoan.Rows.Add(row);
            }
            if (ktra)
            {
                MessageBox.Show("Tìm thấy thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadCongTy()
        {
            txtMaCongTy.Text = "";
            txtMaNguoiDung.Text = "";
            txtSDT_CongTy.Text = "";
            txtTenCongTy.Text = "";
            txtMoTaCongTy.Text = "";
            txtEmailLienHe.Text = "";
            txtDiaChiCongTy.Text = "";
            pcAnhCongTy.Image = null;
            //
            dsCongTy.Clear();
            dgThongTinCongTy.Rows.Clear();
            dsCongTy = congTyController.Load();
            foreach (CongTy ct in dsCongTy)
            {
                string[] row = { ct.GetMaCongTy().ToString(), ct.GetMaNguoiDung().ToString(), ct.GetTenCongTy(), ct.GetMoTaCongTy(), ct.GetDiaChi(), ct.GetSoDienThoai(), ct.GetEmailLienHe() };
                dgThongTinCongTy.Rows.Add(row);
            }
        }

        private void btnTimKiemCongTy_Click(object sender, EventArgs e)
        {
            bool ktra = false;
            dsCongTy.Clear();
            dgThongTinCongTy.Rows.Clear();
            dsCongTy = congTyController.Find(txtTimTheoTenCongTy.Text);
            foreach(CongTy ct in dsCongTy)
            {
                ktra = true;
                string[] row = { ct.GetMaCongTy().ToString(), ct.GetMaNguoiDung().ToString(), ct.GetTenCongTy(), ct.GetMoTaCongTy(), ct.GetDiaChi(), ct.GetSoDienThoai(), ct.GetEmailLienHe() };
                dgThongTinCongTy.Rows.Add(row);
            }
            if (ktra)
            {
                MessageBox.Show("Tìm thấy thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgThongTinCongTy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgThongTinCongTy.Rows[e.RowIndex];
                txtMaCongTy.Text = selectRow.Cells[0].Value.ToString();
                txtTenCongTy.Text = selectRow.Cells[2].Value.ToString();
                txtMaNguoiDung.Text = selectRow.Cells[1].Value.ToString();
                txtSDT_CongTy.Text = selectRow.Cells[5].Value.ToString();
                txtEmailLienHe.Text = selectRow.Cells[6].Value.ToString();
                txtDiaChiCongTy.Text = selectRow.Cells[4].Value.ToString();
                txtMoTaCongTy.Text = selectRow.Cells[3].Value.ToString();
                LoadAnhCongTy();
            }
        }
        public void LoadAnhCongTy()
        {
            string imagePath = congTyController.LayDuongDanAnhHoSo(int.Parse(txtMaCongTy.Text));
            pcAnhCongTy.BorderStyle = BorderStyle.None;
            if (!string.IsNullOrEmpty(imagePath))
            {
                // Đặt kiểu Zoom cho PictureBox
                pcAnhCongTy.SizeMode = PictureBoxSizeMode.Zoom;

                // Hiển thị hình ảnh
                pcAnhCongTy.Image = Image.FromFile(imagePath);
            }
            else
            {
                pcAnhCongTy.Image = null;
            }
        }

        private void btnThemCongTy_Click(object sender, EventArgs e)
        {
            currentCongTy = new CongTy(int.Parse(txtMaCongTy.Text),int.Parse(txtMaNguoiDung.Text), txtTenCongTy.Text, txtMoTaCongTy.Text, txtDiaChiCongTy.Text, txtSDT_CongTy.Text, txtEmailLienHe.Text);
            if (congTyController.AddCongTy(currentCongTy))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCongTy();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSuaCongTy_Click(object sender, EventArgs e)
        {
            currentCongTy = new CongTy(int.Parse(txtMaCongTy.Text), int.Parse(txtMaNguoiDung.Text), txtTenCongTy.Text, txtMoTaCongTy.Text, txtDiaChiCongTy.Text, txtSDT_CongTy.Text, txtEmailLienHe.Text);
            if (congTyController.EditCongTy(currentCongTy))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCongTy();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaCongTy_Click(object sender, EventArgs e)
        {
            currentCongTy = new CongTy(int.Parse(txtMaCongTy.Text), int.Parse(txtMaNguoiDung.Text), txtTenCongTy.Text, txtMoTaCongTy.Text, txtDiaChiCongTy.Text, txtSDT_CongTy.Text, txtEmailLienHe.Text);
            if (congTyController.DeleteCongTy(currentCongTy))
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCongTy();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadCongTy_Click(object sender, EventArgs e)
        {
            LoadCongTy();
        }

        private void btnXemViTriCongViec_Click(object sender, EventArgs e)
        {
            dsViTriCongViec.Clear();
            dgTuyenDung.Rows.Clear();
            dsViTriCongViec = viTriCongViecController.LoadAll();
            foreach (ViTriCongViec vitri in dsViTriCongViec)
            {
                string[] row = { vitri.GetTenViTri(), vitri.GetMoTaCongViec(), vitri.GetYeuCauCongViec(), vitri.GetMucLuong().ToString(), vitri.GetKinhNghiem(), vitri.GetDiaDiemLamViec(), vitri.GetNgayTao().ToString("MM/dd/yyyy"), vitri.GetMaViTri().ToString(), vitri.GetMaCongTy().ToString() };
                dgTuyenDung.Rows.Add(row);
            }
        }

        private void dgTuyenDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow selectRow = dgTuyenDung.Rows[e.RowIndex];
                txtCongViec_VTCV.Text = selectRow.Cells[0].Value.ToString();
                txtMaViTri.Text = selectRow.Cells[7].Value.ToString();
                dsCongTy = congTyController.ThongTinCongTy(selectRow.Cells[8].Value.ToString());
                foreach (CongTy ct in dsCongTy)
                {
                    txtTenCongTy_VTCV.Text = ct.GetTenCongTy().ToString();
                    LoadAnhCongTy2(selectRow.Cells[8].Value.ToString());
                }
            }
        }
        public void LoadAnhCongTy2(string maCongTy)
        {
            string imagePath = congTyController.LayDuongDanAnhHoSo(int.Parse(maCongTy));
            pcAnhCongTy.BorderStyle = BorderStyle.None;
            if (!string.IsNullOrEmpty(imagePath))
            {
                // Đặt kiểu Zoom cho PictureBox
                pc_AnhCongTy_VTCV.SizeMode = PictureBoxSizeMode.Zoom;

                // Hiển thị hình ảnh0
                pc_AnhCongTy_VTCV.Image = Image.FromFile(imagePath);
            }
            else
            {
                pc_AnhCongTy_VTCV.Image = null;
            }
        }

        // Xóa vị trí công việc
        private void btnXoaViTriCongViec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaViTri.Text))
            {
                MessageBox.Show("Vui lòng chọn vị trí công việc cần xóa","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                currentViTriCongViec = new ViTriCongViec(int.Parse(txtMaViTri.Text));
                if (viTriCongViecController.Delete(currentViTriCongViec))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dsViTriCongViec.Clear();
                    dgTuyenDung.Rows.Clear();
                    dsViTriCongViec = viTriCongViecController.LoadAll();
                    foreach (ViTriCongViec vitri in dsViTriCongViec)
                    {
                        string[] row = { vitri.GetTenViTri(), vitri.GetMoTaCongViec(), vitri.GetYeuCauCongViec(), vitri.GetMucLuong().ToString(), vitri.GetKinhNghiem(), vitri.GetDiaDiemLamViec(), vitri.GetNgayTao().ToString("MM/dd/yyyy"), vitri.GetMaViTri().ToString(), vitri.GetMaCongTy().ToString() };
                        dgTuyenDung.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Tìm kiếm vị trí công việc
        private void btnTimKiemCongViec_Click(object sender, EventArgs e)
        {
            bool ktra = false;
            dsViTriCongViec.Clear();
            dgTuyenDung.Rows.Clear();
            dsViTriCongViec = viTriCongViecController.FindByTenViTriLike(txtTenCongViec.Text);
            foreach (ViTriCongViec vitri in dsViTriCongViec)
            {
                ktra = true;
                string[] row = { vitri.GetTenViTri(), vitri.GetMoTaCongViec(), vitri.GetYeuCauCongViec(), vitri.GetMucLuong().ToString(), vitri.GetKinhNghiem(), vitri.GetDiaDiemLamViec(), vitri.GetNgayTao().ToString("MM/dd/yyyy"), vitri.GetMaViTri().ToString(), vitri.GetMaCongTy().ToString() };
                dgTuyenDung.Rows.Add(row);
            }
            if (ktra)
            {
                MessageBox.Show("Tìm thấy thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xem hồ sơ ứng viên
        private void btnXemHoSoUngVien_Click(object sender, EventArgs e)
        {
            dsHoSoUngVien.Clear();
            dgHoSoUngVien.Rows.Clear();
            dsHoSoUngVien = hoSoUngVienController.LoadAll();
            foreach (HoSoUngVien hs in dsHoSoUngVien)
            {
                string[] row = { hs.GetMaUngVien().ToString(), hs.GetMaNguoiDung().ToString(), hs.GetMucTieuNgheNghiep() };
                dgHoSoUngVien.Rows.Add(row);
            }
        }

        private void dgHoSoUngVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow selectRow = dgHoSoUngVien.Rows[e.RowIndex];
                txtMaHoSoUngVien.Text = selectRow.Cells[0].Value.ToString();
                txtMaNguoiDung_HS.Text = selectRow.Cells[1].Value.ToString();
                dsNguoiDung = nguoiDungController.LoadCV(txtMaNguoiDung_HS.Text);
                foreach(NguoiDung nd in dsNguoiDung)
                {
                    txtTenUngVien.Text =  nd.GetHoTen().ToString();
                }
            }
        }

        private void btnXoaHoSoUngVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHoSoUngVien.Text))
            {
                MessageBox.Show("Vui lòng chọn hồ sơ ứng viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (hoSoUngVienController.Delete(txtMaHoSoUngVien.Text))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dsHoSoUngVien.Clear();
                    dgHoSoUngVien.Rows.Clear();
                    dsHoSoUngVien = hoSoUngVienController.LoadAll();
                    foreach (HoSoUngVien hs in dsHoSoUngVien)
                    {
                        string[] row = { hs.GetMaUngVien().ToString(), hs.GetMaNguoiDung().ToString(), hs.GetMucTieuNgheNghiep() };
                        dgHoSoUngVien.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXemUngTuyen_Click(object sender, EventArgs e)
        {
            dsUngTuyen.Clear();
            dgThongTinUngTuyen.Rows.Clear();
            dsUngTuyen = ungTuyenController.LoadAll();
            foreach (UngTuyen ut in dsUngTuyen)
            {
                string[] row = { ut.GetMaUngTuyen().ToString(), ut.GetMaUngVien().ToString(),ut.GetMaViTri().ToString(),ut.GetNgayUngTuyen().ToString("MM/dd/yyyy"),ut.GetTrangThaiUngTuyen().ToString() };
                dgThongTinUngTuyen.Rows.Add(row);
            }
        }


        private void dgThongTinUngTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow selectRow = dgThongTinUngTuyen.Rows[e.RowIndex];
                txtMaUngTuyen.Text = selectRow.Cells[0].Value.ToString();
                txtMaUngVien_UT.Text = selectRow.Cells[1].Value.ToString();
                txtMaViTri_UT.Text = selectRow.Cells[2].Value.ToString();
                // lấy tên vị trí công việc
                dsViTriCongViec = viTriCongViecController.LoadMaViTri(txtMaViTri_UT.Text);
                foreach(ViTriCongViec vt in dsViTriCongViec)
                {
                    txtTenCongViec_UT.Text = vt.GetTenViTri().ToString();
                }
                // lấy tên người ứng tuyển
                dsHoSoUngVien = hoSoUngVienController.LoadMaUngVien(txtMaUngVien_UT.Text);
                foreach(HoSoUngVien hs in dsHoSoUngVien)
                {
                    dsNguoiDung = nguoiDungController.LoadCV(hs.GetMaNguoiDung().ToString());
                    txtMaNguoiDung_UT.Text = hs.GetMaNguoiDung().ToString();
                    foreach(NguoiDung nd in dsNguoiDung)
                    {
                        txtTenUngVien_UT.Text = nd.GetHoTen().ToString();
                    }
                }
                LoadAnhUngTuyen(txtMaNguoiDung_UT.Text);
            }
        }
        public void LoadAnhUngTuyen(string maNguoiDung)
        {
            string imagePath = nguoiDungController.LayDuongDanAnhHoSo(int.Parse(maNguoiDung));
            pcAnhHoSo_UT.BorderStyle = BorderStyle.None;
            if (!string.IsNullOrEmpty(imagePath))
            {
                // Đặt kiểu Zoom cho PictureBox
                pcAnhHoSo_UT.SizeMode = PictureBoxSizeMode.Zoom;

                // Hiển thị hình ảnh
                pcAnhHoSo_UT.Image = Image.FromFile(imagePath);
            }
            else
            {
                pcAnhHoSo_UT.Image = null;
            }
        }

        private void btnXoaUngTuyen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaUngTuyen.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin ứng tuyển cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ungTuyenController.Delete(txtMaUngTuyen.Text))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dsUngTuyen.Clear();
                    dgThongTinUngTuyen.Rows.Clear();
                    dsUngTuyen = ungTuyenController.LoadAll();
                    foreach (UngTuyen ut in dsUngTuyen)
                    {
                        string[] row = { ut.GetMaUngTuyen().ToString(), ut.GetMaUngVien().ToString(), ut.GetMaViTri().ToString(), ut.GetNgayUngTuyen().ToString("MM/dd/yyyy"), ut.GetTrangThaiUngTuyen().ToString() };
                        dgThongTinUngTuyen.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
