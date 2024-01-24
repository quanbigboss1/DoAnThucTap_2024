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
    public partial class Frm_XemUngVien : MetroSetForm
    {
        UngTuyenController ungTuyenController;
        List<UngTuyen> dsUngTuyen;
        UngTuyen currentUngTuyen;
        HoSoUngVienController hoSoUngVienController;
        HoSoUngVien currentHoSoUngVien;
        List<HoSoUngVien> dsHoSoUngVien;
        public Frm_XemUngVien(string macongty)
        {
            InitializeComponent();
            dsUngTuyen = new List<UngTuyen>();
            ungTuyenController = new UngTuyenController();
            currentUngTuyen = new UngTuyen();
            dsHoSoUngVien = new List<HoSoUngVien>();
            hoSoUngVienController = new HoSoUngVienController();
            currentHoSoUngVien = new HoSoUngVien();
            //
            
            txtMaCongTy.Text = macongty;
            dgDanhSachUngVien.ColumnCount = 7;
            dgDanhSachUngVien.Columns[0].Name = "Mã ứng viên";
            dgDanhSachUngVien.Columns[1].Name = "Tên ứng viên";
            dgDanhSachUngVien.Columns[2].Name = "Mã vị trí";
            dgDanhSachUngVien.Columns[3].Name = "Tên vị trí";
            dgDanhSachUngVien.Columns[4].Name = "Ngày ứng tuyển";
            dgDanhSachUngVien.Columns[5].Name = "Trạng thái ứng tuyển";
            dgDanhSachUngVien.Columns[6].Name = "Hồ sơ ứng viên";
            
            Load();
            radioTruot.Checked = false;
            radioTrungTuyen.Checked = false;
        }
        private void radioTruot_CheckedChanged(object sender, EventArgs e)
        {
            if(radioTruot.Checked == true)
            {
                radioTruot.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                radioTruot.ForeColor = System.Drawing.Color.Black;
            }
          
        }

        private void radioTrungTuyen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTrungTuyen.Checked == true)
            {
                radioTrungTuyen.ForeColor = System.Drawing.Color.LimeGreen;
            }
            else
            {
                radioTrungTuyen.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void dgDanhSachUngVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgDanhSachUngVien.Rows[e.RowIndex];
                txtTenUngVien.Text = selectRow.Cells[1].Value.ToString();
                txtTenViTri.Text = selectRow.Cells[3].Value.ToString();
                dtNgayUngTuyen.Text = selectRow.Cells[4].Value.ToString();
                txtMaViTri.Text = selectRow.Cells[2].Value.ToString();
                txtMaUngVien.Text = selectRow.Cells[0].Value.ToString();
                if (selectRow.Cells[5].Value.ToString() == "Đang xét tuyển")
                {
                    radioTrungTuyen.Checked = false;
                    radioTruot.Checked = false;
                }
                else if (selectRow.Cells[5].Value.ToString() == "Trượt")
                {
                    radioTruot.Checked = true;
                }
                else if (selectRow.Cells[5].Value.ToString() == "Trúng tuyển")
                {
                    radioTrungTuyen.Checked = true;
                }
                else
                {

                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaUngVien.Text) && !string.IsNullOrEmpty(txtMaViTri.Text))
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn cập nhật tình trạng ứng viên này chứ!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rs == DialogResult.Yes)
                {
                    string trangthaiungtuyen = null;
                    if (radioTrungTuyen.Checked)
                    {
                        trangthaiungtuyen = "Trúng tuyển";
                    }
                    else
                    {
                        trangthaiungtuyen = "Trượt";
                    }
                    currentUngTuyen = new UngTuyen(int.Parse(txtMaUngVien.Text), int.Parse(txtMaViTri.Text), trangthaiungtuyen);
                    if (ungTuyenController.Edit(currentUngTuyen))
                    {
                        MessageBox.Show("Cập nhật thông tin ứng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin ứng viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //////
                }                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin ứng viên!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }
        public void Load()
        {
            dgDanhSachUngVien.Rows.Clear();
            dsUngTuyen.Clear();
            dsUngTuyen = ungTuyenController.LoadUngTuyen(int.Parse(txtMaCongTy.Text));
            foreach (UngTuyen ungTuyen in dsUngTuyen)
            {
                if (ungTuyen.GetTrangThaiUngTuyen() == null || ungTuyen.GetTrangThaiUngTuyen() == "")
                {
                    string msg = "Đang xét tuyển";
                    string[] row = { ungTuyen.GetMaUngVien().ToString(), ungTuyen.GetTenUngVien(), ungTuyen.GetMaViTri().ToString(), ungTuyen.GetTenViTri(), ungTuyen.GetNgayUngTuyen().ToString("MM/dd/yyyy"), msg };
                    dgDanhSachUngVien.Rows.Add(row);
                }
                else
                {
                    string[] row = { ungTuyen.GetMaUngVien().ToString(), ungTuyen.GetTenUngVien(), ungTuyen.GetMaViTri().ToString(), ungTuyen.GetTenViTri(), ungTuyen.GetNgayUngTuyen().ToString("MM/dd/yyyy"), ungTuyen.GetTrangThaiUngTuyen() };
                    dgDanhSachUngVien.Rows.Add(row);
                }

            }
            for (int i = 0; i < dgDanhSachUngVien.Rows.Count; i++)
            {
                dgDanhSachUngVien.Rows[i].Cells[6].Value = "Xem CV";
            }

            if (radioTrungTuyen.Checked == false)
            {
                radioTruot.Checked = true;
            }
            else
            {
                radioTruot.Checked = false;
            }
        }

        private void dgDanhSachUngVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6) // Cột thứ 6 (đánh index từ 0)
            {
                // Lấy giá trị của ô được nhấn đôi
                object cellValue = dgDanhSachUngVien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Kiểm tra giá trị có tồn tại hay không
                if (cellValue != null)
                {
                    dsHoSoUngVien =hoSoUngVienController.LoadMaUngVien(txtMaUngVien.Text);
                    foreach(HoSoUngVien hosoungvien in dsHoSoUngVien)
                    {
                        int maUngVien = int.Parse(hosoungvien.GetMaUngVien().ToString());
                        int maNguoiDung = int.Parse(hosoungvien.GetMaNguoiDung().ToString());
                        string mucTieuNgheNghiep = hosoungvien.GetMucTieuNgheNghiep();
                        currentHoSoUngVien = new HoSoUngVien(maUngVien, maNguoiDung, mucTieuNgheNghiep);                       
                    }
                    Frm_CV f = new Frm_CV(currentHoSoUngVien);
                    f.ShowDialog();
                }
                else
                {
                    
                }
            }
        }
    }
}
