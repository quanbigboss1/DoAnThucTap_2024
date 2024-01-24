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
    public partial class Frm_TimKiemCongTy : MetroSetForm
    {
        CongTyController congtyController;
        List<CongTy> dsCongTy;
        CongTy currentCongTy;
        public Frm_TimKiemCongTy()
        {
            InitializeComponent();
            congtyController = new CongTyController();
            dsCongTy = new List<CongTy>();
            currentCongTy = new CongTy();
            dgDetails.ColumnCount = 5;
            dgDetails.Columns[0].Name = "Tên công ty";
            dgDetails.Columns[1].Name = "Mô tả công ty";
            dgDetails.Columns[2].Name = "Địa chỉ";
            dgDetails.Columns[3].Name = "Email";
            dgDetails.Columns[4].Name = "Mã công ty";
            dgDetails.Columns[4].Visible = false;
            txtMoTaCongTy.BackColor = Color.White;
        }

        private void btnTimKiemCongTy_Click(object sender, EventArgs e)
        {
            dsCongTy.Clear();

            dsCongTy = congtyController.TimKiemCongTy(txtTimKiemCongTy.Text, txtDiaDiem.Text);
            //hien thi len datagridview
            dgDetails.Rows.Clear(); 
            foreach (CongTy congty in dsCongTy)
            {
                string[] row = { congty.GetTenCongTy(),congty.GetMoTaCongTy(),congty.GetDiaChi(),congty.GetEmailLienHe(),congty.GetMaCongTy().ToString()};
                dgDetails.Rows.Add(row);
            }
        }

        private void dgDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dgDetails.Rows[e.RowIndex];
                lbTenCongTy.Text = selectRow.Cells[0].Value.ToString();
                txtMoTaCongTy.Text = selectRow.Cells[1].Value.ToString();
                lbDiaChi.Text = selectRow.Cells[2].Value.ToString();
                lbEmailLienHe.Text = selectRow.Cells[3].Value.ToString();
                txtMaCongTy.Text = selectRow.Cells[4].Value.ToString();
                LoadImageFromDatabase_CongTy(txtMaCongTy.Text);
            }
        }

        private void cbbDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbDiaDiem.SelectedItem?.ToString())
            {
                case "Thành phố Hồ Chí Minh":
                    txtDiaDiem.Text = "Thành phố Hồ Chí Minh";
                    break;

                //Thêm các trường hợp khác nếu cần
                case "Hà Nội":
                    txtDiaDiem.Text = "Hà Nội";
                    break;
                case "Đà Nẵng":
                    txtDiaDiem.Text = "Đà Nẵng";
                    break;
                case "Tất cả":
                    txtDiaDiem.Text = "";
                    break;
                default:
                    //Xử lý khi không khớp với bất kỳ trường hợp nào
                    break;
            }
        }
        //
        private void LoadImageFromDatabase_CongTy(string MaCongTy)
        {
            string imagePath = congtyController.LayDuongDanAnhHoSo(int.Parse(MaCongTy));
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
    }
}
