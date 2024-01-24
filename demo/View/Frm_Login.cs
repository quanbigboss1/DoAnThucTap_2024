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
    public partial class Frm_Login : MetroSetForm
    {
        NguoiDungController nguoiDungController;
        List<NguoiDung> dsNguoiDung;
        NguoiDung currentNguoiDung;
        public Frm_Login()
        {
            InitializeComponent();
            nguoiDungController = new NguoiDungController();
            currentNguoiDung = new NguoiDung();
            dsNguoiDung = new List<NguoiDung> ();
        }

        private void link_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_DangKy f = new Frm_DangKy();
            f.ShowDialog();
            this.Hide();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text) &&!string.IsNullOrEmpty(txtMatKhau.Text))
            {
                if (cb_DieuKhoan.Checked)
                {
                    currentNguoiDung = new NguoiDung(txtTaiKhoan.Text,txtMatKhau.Text);
                    if (nguoiDungController.CheckLogin(currentNguoiDung)!= null)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bool ktra = false;
                        dsNguoiDung = nguoiDungController.CheckLogin(currentNguoiDung);
                        foreach(NguoiDung nguoiDung in dsNguoiDung)
                        {
                            if( nguoiDung.GetLoaiNguoiDung().ToString() == "Admin")
                            {
                                ktra = true;
                            }
                            else
                            {
                                ktra = false;
                            }
                        }
                        if (ktra)
                        {
                            Frm_Admin f = new Frm_Admin();
                            f.ShowDialog();
                            this.Hide();
                        }
                        else
                        {                           
                            Frm_MDI f = new Frm_MDI(currentNguoiDung);
                            f.ShowDialog();
                            this.Hide();
                        }               
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng tích vào điều khoản của phần mềm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
