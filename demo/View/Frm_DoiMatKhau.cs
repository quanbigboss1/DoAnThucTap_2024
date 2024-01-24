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
    public partial class Frm_DoiMatKhau : MetroSetForm
    {
        NguoiDungController nguoidungController;
        List<NguoiDung> dsNguoiDung;
        NguoiDung currentNguoiDung;
        public Frm_DoiMatKhau(NguoiDung nguoidung)
        {
            InitializeComponent();
            nguoidungController = new NguoiDungController();
            dsNguoiDung = new List<NguoiDung>();
            currentNguoiDung = nguoidung;
            this.Size = new Size(762, 617);
            
        }

        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            dsNguoiDung = nguoidungController.GetInfoUser(currentNguoiDung);
            foreach (NguoiDung nguoiDung in dsNguoiDung)
            {
                txtTenDangNhap.Text = nguoiDung.GetTenDangNhap();
                lb_matkhaucu.Text = nguoiDung.GetMatKhau();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMatKhauCu.Text) && !string.IsNullOrEmpty(txtMatKhauMoi.Text) && !string.IsNullOrEmpty(txtMatKhauMoi2.Text))
            {
                if(txtMatKhauCu.Text != lb_matkhaucu.Text)
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(txtMatKhauMoi.Text != txtMatKhauMoi2.Text)
                {
                    MessageBox.Show("Mật khẩu mới không khớp nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtMatKhauMoi.Text.Length < 6 ||  txtMatKhauMoi.Text.Length > 12)
                {
                    MessageBox.Show(" Vui lòng nhập mật khẩu có độ dài từ 6 đến 12 ký tự");
                }
                else
                {
                    NguoiDung currentNguoiDung = new NguoiDung(txtTenDangNhap.Text,txtMatKhauMoi.Text);
                    nguoidungController.DoiMatKhau(currentNguoiDung);
                    MessageBox.Show("Đổi mật khẩu thành công!, Vui lòng đăng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Frm_Login f = new Frm_Login();
                    f.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
