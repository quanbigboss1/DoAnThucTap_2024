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
    internal partial class Frm_TaoViecLam : MetroSetForm
    {
        ViTriCongViecController viTriCongViecController;
        List<ViTriCongViec> dsViTriCongViec;
        ViTriCongViec currentViTriCongViec;
        CongTy currentCongTy;
        public Frm_TaoViecLam(CongTy congty)
        {
            InitializeComponent();
            viTriCongViecController = new ViTriCongViecController();
            dsViTriCongViec = new List<ViTriCongViec>();
            currentViTriCongViec = new ViTriCongViec();
            currentCongTy = new CongTy();
            currentCongTy = congty;
            txtMaCongTy.Text = congty.GetMaCongTy().ToString();
            txtMaCongTy.Visible = false;
            dgTuyenDung.ColumnCount = 8;
            dgTuyenDung.Columns[0].Name = "Vị trí";
            dgTuyenDung.Columns[1].Name = "Mô tả công việc";
            dgTuyenDung.Columns[2].Name = "Yêu cầu công việc";
            dgTuyenDung.Columns[3].Name = "Mức lương";
            dgTuyenDung.Columns[4].Name = "Kinh nghiệm";
            dgTuyenDung.Columns[5].Name = "Địa điểm làm việc";
            dgTuyenDung.Columns[6].Name = "Ngày tạo";
            dgTuyenDung.Columns[7].Name = "Mã Vị Trí";
            dgTuyenDung.Columns[7].Visible = false;
            txtMaViTri.Visible = false;
            dsViTriCongViec.Clear();
            dsViTriCongViec = viTriCongViecController.Load(congty.GetMaCongTy().ToString());
            dgTuyenDung.Rows.Clear();
            foreach (ViTriCongViec vitri in dsViTriCongViec)
            {
                string[] row = { vitri.GetTenViTri(), vitri.GetMoTaCongViec(),vitri.GetYeuCauCongViec(),vitri.GetMucLuong().ToString(),vitri.GetKinhNghiem(),vitri.GetDiaDiemLamViec(),vitri.GetNgayTao().ToString("MM/dd/yyyy"), vitri.GetMaViTri().ToString()};
                dgTuyenDung.Rows.Add(row);
            }
            tileSoLuongViTriCongTyDangTuyenDung.TileCount = viTriCongViecController.GetSoLuong(txtMaCongTy.Text);
        }

        private void dgTuyenDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgTuyenDung.Rows[e.RowIndex];
                txtViTri.Text = selectRow.Cells[0].Value.ToString();
                txtYeuCau.Text = selectRow.Cells[2].Value.ToString();
                txtMucLuong.Text = selectRow.Cells[3].Value.ToString();
                txtDiaDiem.Text = selectRow.Cells[5].Value.ToString();
                txtMoTa.Text = selectRow.Cells[1].Value.ToString();
                cbbKinhNghiem.Text = selectRow.Cells[4].Value.ToString();
                dtNgayTao.Text = selectRow.Cells[6].Value.ToString();
                txtMaViTri.Text = selectRow.Cells[7].Value.ToString();
                string kinhNghiemValue = selectRow.Cells[4].Value.ToString();
                if (cbbKinhNghiem.Items.Contains(kinhNghiemValue))
                {
                    cbbKinhNghiem.SelectedItem = kinhNghiemValue;
                }
                else
                {
                    // Nếu giá trị không tồn tại trong ComboBox, bạn có thể thực hiện một hành động khác ở đây.
                    // Ví dụ: hiển thị một thông báo, chọn một giá trị mặc định, vv.
                    MessageBox.Show("Giá trị kinh nghiệm không hợp lệ");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            currentViTriCongViec = new ViTriCongViec(int.Parse(txtMaCongTy.Text), txtViTri.Text, txtMoTa.Text, txtYeuCau.Text, txtMucLuong.Text,cbbKinhNghiem.Text, txtDiaDiem.Text, DateTime.Parse(dtNgayTao.Text));
            if (viTriCongViecController.Add(currentViTriCongViec))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //
            dsViTriCongViec.Clear();
            dsViTriCongViec = viTriCongViecController.Load(txtMaCongTy.Text);
            dgTuyenDung.Rows.Clear();
            foreach (ViTriCongViec vitri in dsViTriCongViec)
            {
                string[] row = { vitri.GetTenViTri(), vitri.GetMoTaCongViec(), vitri.GetYeuCauCongViec(), vitri.GetMucLuong().ToString(), vitri.GetKinhNghiem(), vitri.GetDiaDiemLamViec(), vitri.GetNgayTao().ToString("MM/dd/yyyy"), vitri.GetMaViTri().ToString() };
                dgTuyenDung.Rows.Add(row);
            }
            tileSoLuongViTriCongTyDangTuyenDung.TileCount = viTriCongViecController.GetSoLuong(txtMaCongTy.Text);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaViTri.Text))
            {
                currentViTriCongViec = new ViTriCongViec(int.Parse(txtMaViTri.Text), int.Parse(txtMaCongTy.Text), txtViTri.Text, txtMoTa.Text, txtYeuCau.Text, txtMucLuong.Text, cbbKinhNghiem.Text, txtDiaDiem.Text, DateTime.Parse(dtNgayTao.Text));
                if (viTriCongViecController.Edit(currentViTriCongViec))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //
                dsViTriCongViec.Clear();
                dsViTriCongViec = viTriCongViecController.Load(txtMaCongTy.Text);
                dgTuyenDung.Rows.Clear();
                foreach (ViTriCongViec vitri in dsViTriCongViec)
                {
                    string[] row = { vitri.GetTenViTri(), vitri.GetMoTaCongViec(), vitri.GetYeuCauCongViec(), vitri.GetMucLuong().ToString(), vitri.GetKinhNghiem(), vitri.GetDiaDiemLamViec(), vitri.GetNgayTao().ToString("MM/dd/yyyy"), vitri.GetMaViTri().ToString() };
                    dgTuyenDung.Rows.Add(row);
                }
                tileSoLuongViTriCongTyDangTuyenDung.TileCount = viTriCongViecController.GetSoLuong(txtMaCongTy.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lại vị trí cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            currentViTriCongViec = new ViTriCongViec(int.Parse(txtMaViTri.Text), int.Parse(txtMaCongTy.Text), txtViTri.Text, txtMoTa.Text, txtYeuCau.Text, txtMucLuong.Text, cbbKinhNghiem.Text, txtDiaDiem.Text, DateTime.Parse(dtNgayTao.Text));
            if (viTriCongViecController.Delete(currentViTriCongViec))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //
            dsViTriCongViec.Clear();
            dsViTriCongViec = viTriCongViecController.Load(txtMaCongTy.Text);
            dgTuyenDung.Rows.Clear();
            foreach (ViTriCongViec vitri in dsViTriCongViec)
            {
                string[] row = { vitri.GetTenViTri(), vitri.GetMoTaCongViec(), vitri.GetYeuCauCongViec(), vitri.GetMucLuong().ToString(), vitri.GetKinhNghiem(), vitri.GetDiaDiemLamViec(), vitri.GetNgayTao().ToString("MM/dd/yyyy"), vitri.GetMaViTri().ToString() };
                dgTuyenDung.Rows.Add(row);
            }
            tileSoLuongViTriCongTyDangTuyenDung.TileCount = viTriCongViecController.GetSoLuong(txtMaCongTy.Text);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bool kiemtra = false;
            dsViTriCongViec.Clear();
            dsViTriCongViec = viTriCongViecController.FindByTenViTriLike(txtTimKiemTheoTen.Text);
            dgTuyenDung.Rows.Clear();
            foreach (ViTriCongViec vitri in dsViTriCongViec)
            {
                string[] row = { vitri.GetTenViTri(), vitri.GetMoTaCongViec(), vitri.GetYeuCauCongViec(), vitri.GetMucLuong().ToString(), vitri.GetKinhNghiem(), vitri.GetDiaDiemLamViec(), vitri.GetNgayTao().ToString("MM/dd/yyyy"), vitri.GetMaViTri().ToString() };
                dgTuyenDung.Rows.Add(row);
                if(dgTuyenDung.ColumnCount > 0)
                {
                    kiemtra = true;
                }
            }
            if (kiemtra)
            {
                MessageBox.Show("Tìm kiếm thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
