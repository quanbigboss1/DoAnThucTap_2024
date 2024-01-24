namespace demo.View
{
    partial class Frm_DangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.pn_total = new MetroSet_UI.Controls.MetroSetPanel();
            this.pn_child = new MetroSet_UI.Controls.MetroSetPanel();
            this.btnDangKy = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cb_DieuKhoan = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.txtMatKhau2 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtMatKhau = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtTaiKhoan = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.pn_header = new MetroSet_UI.Controls.MetroSetPanel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.pn_footer = new MetroSet_UI.Controls.MetroSetPanel();
            this.Link_DaCoTaiKhoan = new MetroSet_UI.Controls.MetroSetLink();
            this.metroSetLabel9 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cbbLoaiNguoiDung = new MetroSet_UI.Controls.MetroSetComboBox();
            this.pn_total.SuspendLayout();
            this.pn_child.SuspendLayout();
            this.pn_header.SuspendLayout();
            this.pn_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroSetLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(15, 716);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(684, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 7;
            this.metroSetLabel6.Text = "© 2023. All Rights Reserved. YourCV lequanht";
            this.metroSetLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // pn_total
            // 
            this.pn_total.BackgroundColor = System.Drawing.Color.White;
            this.pn_total.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pn_total.BorderThickness = 1;
            this.pn_total.Controls.Add(this.pn_child);
            this.pn_total.Controls.Add(this.pn_header);
            this.pn_total.Controls.Add(this.pn_footer);
            this.pn_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_total.IsDerivedStyle = true;
            this.pn_total.Location = new System.Drawing.Point(15, 99);
            this.pn_total.Name = "pn_total";
            this.pn_total.Size = new System.Drawing.Size(684, 617);
            this.pn_total.Style = MetroSet_UI.Enums.Style.Light;
            this.pn_total.StyleManager = null;
            this.pn_total.TabIndex = 8;
            this.pn_total.ThemeAuthor = "Narwin";
            this.pn_total.ThemeName = "MetroLite";
            // 
            // pn_child
            // 
            this.pn_child.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_child.BackgroundColor = System.Drawing.Color.White;
            this.pn_child.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pn_child.BorderThickness = 1;
            this.pn_child.Controls.Add(this.cbbLoaiNguoiDung);
            this.pn_child.Controls.Add(this.metroSetLabel7);
            this.pn_child.Controls.Add(this.btnDangKy);
            this.pn_child.Controls.Add(this.metroSetLabel3);
            this.pn_child.Controls.Add(this.cb_DieuKhoan);
            this.pn_child.Controls.Add(this.txtMatKhau2);
            this.pn_child.Controls.Add(this.txtMatKhau);
            this.pn_child.Controls.Add(this.txtTaiKhoan);
            this.pn_child.Controls.Add(this.metroSetLabel5);
            this.pn_child.Controls.Add(this.metroSetLabel4);
            this.pn_child.Controls.Add(this.metroSetLabel2);
            this.pn_child.IsDerivedStyle = true;
            this.pn_child.Location = new System.Drawing.Point(0, 60);
            this.pn_child.Name = "pn_child";
            this.pn_child.Size = new System.Drawing.Size(684, 450);
            this.pn_child.Style = MetroSet_UI.Enums.Style.Light;
            this.pn_child.StyleManager = null;
            this.pn_child.TabIndex = 23;
            this.pn_child.ThemeAuthor = "Narwin";
            this.pn_child.ThemeName = "MetroLite";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKy.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDangKy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDangKy.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDangKy.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDangKy.HoverTextColor = System.Drawing.Color.White;
            this.btnDangKy.IsDerivedStyle = true;
            this.btnDangKy.Location = new System.Drawing.Point(42, 370);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDangKy.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDangKy.NormalTextColor = System.Drawing.Color.White;
            this.btnDangKy.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDangKy.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDangKy.PressTextColor = System.Drawing.Color.White;
            this.btnDangKy.Size = new System.Drawing.Size(600, 57);
            this.btnDangKy.Style = MetroSet_UI.Enums.Style.Light;
            this.btnDangKy.StyleManager = null;
            this.btnDangKy.TabIndex = 40;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.ThemeAuthor = "Narwin";
            this.btnDangKy.ThemeName = "MetroLite";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(69, 331);
            this.metroSetLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(663, 35);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 39;
            this.metroSetLabel3.Text = "Tôi đã đọc và đồng ý với Điều khoản dịch vụ và Chính sách bảo mật của YourCV";
            this.metroSetLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // cb_DieuKhoan
            // 
            this.cb_DieuKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_DieuKhoan.BackColor = System.Drawing.Color.Transparent;
            this.cb_DieuKhoan.BackgroundColor = System.Drawing.Color.White;
            this.cb_DieuKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cb_DieuKhoan.Checked = false;
            this.cb_DieuKhoan.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cb_DieuKhoan.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.cb_DieuKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_DieuKhoan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.cb_DieuKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DieuKhoan.IsDerivedStyle = true;
            this.cb_DieuKhoan.Location = new System.Drawing.Point(44, 341);
            this.cb_DieuKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_DieuKhoan.Name = "cb_DieuKhoan";
            this.cb_DieuKhoan.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cb_DieuKhoan.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.cb_DieuKhoan.Size = new System.Drawing.Size(18, 16);
            this.cb_DieuKhoan.Style = MetroSet_UI.Enums.Style.Light;
            this.cb_DieuKhoan.StyleManager = null;
            this.cb_DieuKhoan.TabIndex = 38;
            this.cb_DieuKhoan.ThemeAuthor = "Narwin";
            this.cb_DieuKhoan.ThemeName = "MetroLite";
            // 
            // txtMatKhau2
            // 
            this.txtMatKhau2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau2.AutoCompleteCustomSource = null;
            this.txtMatKhau2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMatKhau2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMatKhau2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMatKhau2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMatKhau2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMatKhau2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtMatKhau2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtMatKhau2.Image = null;
            this.txtMatKhau2.IsDerivedStyle = true;
            this.txtMatKhau2.Lines = null;
            this.txtMatKhau2.Location = new System.Drawing.Point(41, 210);
            this.txtMatKhau2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau2.MaxLength = 32767;
            this.txtMatKhau2.Multiline = false;
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.ReadOnly = false;
            this.txtMatKhau2.Size = new System.Drawing.Size(606, 42);
            this.txtMatKhau2.Style = MetroSet_UI.Enums.Style.Light;
            this.txtMatKhau2.StyleManager = null;
            this.txtMatKhau2.TabIndex = 35;
            this.txtMatKhau2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatKhau2.ThemeAuthor = "Narwin";
            this.txtMatKhau2.ThemeName = "MetroLite";
            this.txtMatKhau2.UseSystemPasswordChar = true;
            this.txtMatKhau2.WatermarkText = "";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau.AutoCompleteCustomSource = null;
            this.txtMatKhau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMatKhau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMatKhau.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMatKhau.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMatKhau.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtMatKhau.Image = null;
            this.txtMatKhau.IsDerivedStyle = true;
            this.txtMatKhau.Lines = null;
            this.txtMatKhau.Location = new System.Drawing.Point(41, 127);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.ReadOnly = false;
            this.txtMatKhau.Size = new System.Drawing.Size(606, 42);
            this.txtMatKhau.Style = MetroSet_UI.Enums.Style.Light;
            this.txtMatKhau.StyleManager = null;
            this.txtMatKhau.TabIndex = 36;
            this.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatKhau.ThemeAuthor = "Narwin";
            this.txtMatKhau.ThemeName = "MetroLite";
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.WatermarkText = "";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaiKhoan.AutoCompleteCustomSource = null;
            this.txtTaiKhoan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTaiKhoan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTaiKhoan.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTaiKhoan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTaiKhoan.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTaiKhoan.Image = null;
            this.txtTaiKhoan.IsDerivedStyle = true;
            this.txtTaiKhoan.Lines = null;
            this.txtTaiKhoan.Location = new System.Drawing.Point(42, 41);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaiKhoan.MaxLength = 32767;
            this.txtTaiKhoan.Multiline = false;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.ReadOnly = false;
            this.txtTaiKhoan.Size = new System.Drawing.Size(606, 46);
            this.txtTaiKhoan.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTaiKhoan.StyleManager = null;
            this.txtTaiKhoan.TabIndex = 37;
            this.txtTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTaiKhoan.ThemeAuthor = "Narwin";
            this.txtTaiKhoan.ThemeName = "MetroLite";
            this.txtTaiKhoan.UseSystemPasswordChar = false;
            this.txtTaiKhoan.WatermarkText = "";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroSetLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(41, 174);
            this.metroSetLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(631, 32);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 32;
            this.metroSetLabel5.Text = "Xác nhận lại mật khẩu";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroSetLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(42, 92);
            this.metroSetLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(631, 33);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 33;
            this.metroSetLabel4.Text = "Mật khẩu";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroSetLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(41, 3);
            this.metroSetLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(637, 33);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 34;
            this.metroSetLabel2.Text = "Tên tài khoản";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // pn_header
            // 
            this.pn_header.BackgroundColor = System.Drawing.Color.White;
            this.pn_header.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pn_header.BorderThickness = 1;
            this.pn_header.Controls.Add(this.metroSetLabel1);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.IsDerivedStyle = true;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(684, 60);
            this.pn_header.Style = MetroSet_UI.Enums.Style.Light;
            this.pn_header.StyleManager = null;
            this.pn_header.TabIndex = 22;
            this.pn_header.ThemeAuthor = "Narwin";
            this.pn_header.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroSetLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(27, 10);
            this.metroSetLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(695, 30);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 31;
            this.metroSetLabel1.Text = "Bước đầu hoàn hảo để xây dựng tương lai của bạn với YourCV";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // pn_footer
            // 
            this.pn_footer.BackgroundColor = System.Drawing.Color.White;
            this.pn_footer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pn_footer.BorderThickness = 0;
            this.pn_footer.Controls.Add(this.Link_DaCoTaiKhoan);
            this.pn_footer.Controls.Add(this.metroSetLabel9);
            this.pn_footer.Controls.Add(this.metroSetLabel8);
            this.pn_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_footer.IsDerivedStyle = true;
            this.pn_footer.Location = new System.Drawing.Point(0, 497);
            this.pn_footer.Name = "pn_footer";
            this.pn_footer.Size = new System.Drawing.Size(684, 120);
            this.pn_footer.Style = MetroSet_UI.Enums.Style.Light;
            this.pn_footer.StyleManager = null;
            this.pn_footer.TabIndex = 21;
            this.pn_footer.ThemeAuthor = "Narwin";
            this.pn_footer.ThemeName = "MetroLite";
            // 
            // Link_DaCoTaiKhoan
            // 
            this.Link_DaCoTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Link_DaCoTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Link_DaCoTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_DaCoTaiKhoan.IsDerivedStyle = true;
            this.Link_DaCoTaiKhoan.LinkArea = new System.Windows.Forms.LinkArea(21, 14);
            this.Link_DaCoTaiKhoan.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Link_DaCoTaiKhoan.Location = new System.Drawing.Point(150, 16);
            this.Link_DaCoTaiKhoan.Name = "Link_DaCoTaiKhoan";
            this.Link_DaCoTaiKhoan.Size = new System.Drawing.Size(381, 34);
            this.Link_DaCoTaiKhoan.Style = MetroSet_UI.Enums.Style.Dark;
            this.Link_DaCoTaiKhoan.StyleManager = null;
            this.Link_DaCoTaiKhoan.TabIndex = 30;
            this.Link_DaCoTaiKhoan.TabStop = true;
            this.Link_DaCoTaiKhoan.Text = "Bạn đã có tài khoản? Đăng nhập ngay";
            this.Link_DaCoTaiKhoan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Link_DaCoTaiKhoan.ThemeAuthor = "Narwin";
            this.Link_DaCoTaiKhoan.ThemeName = "MetroLite";
            this.Link_DaCoTaiKhoan.UseCompatibleTextRendering = true;
            this.Link_DaCoTaiKhoan.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            this.Link_DaCoTaiKhoan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_DaCoTaiKhoan_LinkClicked);
            // 
            // metroSetLabel9
            // 
            this.metroSetLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel9.IsDerivedStyle = true;
            this.metroSetLabel9.Location = new System.Drawing.Point(3, 82);
            this.metroSetLabel9.Name = "metroSetLabel9";
            this.metroSetLabel9.Size = new System.Drawing.Size(675, 37);
            this.metroSetLabel9.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel9.StyleManager = null;
            this.metroSetLabel9.TabIndex = 28;
            this.metroSetLabel9.Text = "Vui lòng gọi tới số (034) 8888 9999 (giờ hành chính).";
            this.metroSetLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel9.ThemeAuthor = "Narwin";
            this.metroSetLabel9.ThemeName = "MetroLite";
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel8.IsDerivedStyle = true;
            this.metroSetLabel8.Location = new System.Drawing.Point(3, 53);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(678, 29);
            this.metroSetLabel8.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.TabIndex = 27;
            this.metroSetLabel8.Text = "Bạn gặp khó khăn khi tạo tài khoản?\r\n";
            this.metroSetLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroLite";
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroSetLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(41, 286);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(180, 36);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 41;
            this.metroSetLabel7.Text = "Loại người dùng";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLite";
            // 
            // cbbLoaiNguoiDung
            // 
            this.cbbLoaiNguoiDung.AllowDrop = true;
            this.cbbLoaiNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbLoaiNguoiDung.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbbLoaiNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiNguoiDung.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbbLoaiNguoiDung.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbbLoaiNguoiDung.CausesValidation = false;
            this.cbbLoaiNguoiDung.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbbLoaiNguoiDung.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbbLoaiNguoiDung.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbbLoaiNguoiDung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiNguoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiNguoiDung.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiNguoiDung.FormattingEnabled = true;
            this.cbbLoaiNguoiDung.IsDerivedStyle = true;
            this.cbbLoaiNguoiDung.ItemHeight = 40;
            this.cbbLoaiNguoiDung.Items.AddRange(new object[] {
            "Ứng Viên",
            "Công Ty"});
            this.cbbLoaiNguoiDung.Location = new System.Drawing.Point(228, 275);
            this.cbbLoaiNguoiDung.Name = "cbbLoaiNguoiDung";
            this.cbbLoaiNguoiDung.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbbLoaiNguoiDung.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbbLoaiNguoiDung.Size = new System.Drawing.Size(420, 46);
            this.cbbLoaiNguoiDung.Style = MetroSet_UI.Enums.Style.Light;
            this.cbbLoaiNguoiDung.StyleManager = null;
            this.cbbLoaiNguoiDung.TabIndex = 42;
            this.cbbLoaiNguoiDung.ThemeAuthor = "Narwin";
            this.cbbLoaiNguoiDung.ThemeName = "MetroLite";
            // 
            // Frm_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 756);
            this.Controls.Add(this.pn_total);
            this.Controls.Add(this.metroSetLabel6);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_DangKy";
            this.Padding = new System.Windows.Forms.Padding(15, 99, 15, 17);
            this.SmallLineColor1 = System.Drawing.Color.Blue;
            this.SmallLineColor2 = System.Drawing.Color.Blue;
            this.SmallRectThickness = 45;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chào mừng bạn đã đến với YourCV";
            this.TextColor = System.Drawing.Color.Black;
            this.pn_total.ResumeLayout(false);
            this.pn_child.ResumeLayout(false);
            this.pn_header.ResumeLayout(false);
            this.pn_footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetPanel pn_total;
        private MetroSet_UI.Controls.MetroSetPanel pn_footer;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel9;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
        private MetroSet_UI.Controls.MetroSetLink Link_DaCoTaiKhoan;
        private MetroSet_UI.Controls.MetroSetPanel pn_header;
        private MetroSet_UI.Controls.MetroSetPanel pn_child;
        private MetroSet_UI.Controls.MetroSetButton btnDangKy;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetCheckBox cb_DieuKhoan;
        private MetroSet_UI.Controls.MetroSetTextBox txtMatKhau2;
        private MetroSet_UI.Controls.MetroSetTextBox txtMatKhau;
        private MetroSet_UI.Controls.MetroSetTextBox txtTaiKhoan;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetComboBox cbbLoaiNguoiDung;
    }
}