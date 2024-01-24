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
    public partial class Frm_DangKy : MetroSetForm
    {
        NguoiDungController nguoidungController;
        List<NguoiDung> dsNguoiDung;
        NguoiDung currentNguoiDung;
        public Frm_DangKy()
        {
            InitializeComponent();
            nguoidungController = new NguoiDungController();
            dsNguoiDung = new List<NguoiDung>();
            currentNguoiDung = new NguoiDung();
            Link_DaCoTaiKhoan.ForeColor = Color.Black;
            pn_total.BorderColor = Color.White;
            pn_child.BorderColor = Color.White;
            pn_header.BorderColor = Color.White;
            pn_footer.BorderColor = Color.White;
            
        }

        private void Link_DaCoTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Login f = new Frm_Login();
            this.Hide();
            f.ShowDialog();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text) && !string.IsNullOrEmpty(txtMatKhau.Text) && !string.IsNullOrEmpty(txtMatKhau2.Text))
            {
                if (cb_DieuKhoan.Checked)
                {
                    if(txtMatKhau.Text != txtMatKhau2.Text)
                    {
                        MessageBox.Show("Mật khẩu bạn nhập không khớp!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (nguoidungController.CheckTaiKhoan(txtTaiKhoan.Text))
                        {
                            MessageBox.Show("Tài khoản này đã có sẵn, Vui lòng chọn tài khoản khác!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            nguoidungController.DangKyTaiKhoan(txtTaiKhoan.Text,txtMatKhau.Text,cbbLoaiNguoiDung.Text);
                            MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //
                            Frm_Login f = new Frm_Login();
                            this.Hide();
                            f.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng tích vào điều khoản của ứng dụng","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning); 
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
