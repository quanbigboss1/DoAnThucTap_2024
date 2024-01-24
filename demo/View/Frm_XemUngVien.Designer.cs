namespace demo.View
{
    partial class Frm_XemUngVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgDanhSachUngVien = new MetroFramework.Controls.MetroGrid();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtTenUngVien = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetTile1 = new MetroSet_UI.Controls.MetroSetTile();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtTenViTri = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.dtNgayUngTuyen = new MetroFramework.Controls.MetroDateTime();
            this.metroSetTile2 = new MetroSet_UI.Controls.MetroSetTile();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.radioTrungTuyen = new System.Windows.Forms.RadioButton();
            this.radioTruot = new System.Windows.Forms.RadioButton();
            this.btnSua = new MetroSet_UI.Controls.MetroSetButton();
            this.txtMaViTri = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtMaUngVien = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtMaCongTy = new MetroSet_UI.Controls.MetroSetTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSachUngVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDanhSachUngVien
            // 
            this.dgDanhSachUngVien.AllowUserToAddRows = false;
            this.dgDanhSachUngVien.AllowUserToDeleteRows = false;
            this.dgDanhSachUngVien.AllowUserToResizeRows = false;
            this.dgDanhSachUngVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDanhSachUngVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDanhSachUngVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDanhSachUngVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgDanhSachUngVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgDanhSachUngVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgDanhSachUngVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDanhSachUngVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgDanhSachUngVien.ColumnHeadersHeight = 40;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDanhSachUngVien.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgDanhSachUngVien.EnableHeadersVisualStyles = false;
            this.dgDanhSachUngVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgDanhSachUngVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgDanhSachUngVien.Location = new System.Drawing.Point(15, 428);
            this.dgDanhSachUngVien.Name = "dgDanhSachUngVien";
            this.dgDanhSachUngVien.ReadOnly = true;
            this.dgDanhSachUngVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDanhSachUngVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgDanhSachUngVien.RowHeadersWidth = 4;
            this.dgDanhSachUngVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgDanhSachUngVien.RowTemplate.Height = 24;
            this.dgDanhSachUngVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDanhSachUngVien.Size = new System.Drawing.Size(946, 158);
            this.dgDanhSachUngVien.TabIndex = 2;
            this.dgDanhSachUngVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDanhSachUngVien_CellClick);
            this.dgDanhSachUngVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDanhSachUngVien_CellDoubleClick);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(15, 356);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(239, 39);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 3;
            this.metroSetLabel1.Text = "Danh sách ứng viên";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(32, 100);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(151, 32);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 5;
            this.metroSetLabel2.Text = "Tên ứng viên";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // txtTenUngVien
            // 
            this.txtTenUngVien.AutoCompleteCustomSource = null;
            this.txtTenUngVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenUngVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenUngVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTenUngVien.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTenUngVien.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTenUngVien.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTenUngVien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenUngVien.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTenUngVien.Image = null;
            this.txtTenUngVien.IsDerivedStyle = true;
            this.txtTenUngVien.Lines = null;
            this.txtTenUngVien.Location = new System.Drawing.Point(271, 90);
            this.txtTenUngVien.MaxLength = 32767;
            this.txtTenUngVien.Multiline = false;
            this.txtTenUngVien.Name = "txtTenUngVien";
            this.txtTenUngVien.ReadOnly = false;
            this.txtTenUngVien.Size = new System.Drawing.Size(368, 42);
            this.txtTenUngVien.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTenUngVien.StyleManager = null;
            this.txtTenUngVien.TabIndex = 6;
            this.txtTenUngVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenUngVien.ThemeAuthor = "Narwin";
            this.txtTenUngVien.ThemeName = "MetroLite";
            this.txtTenUngVien.UseSystemPasswordChar = false;
            this.txtTenUngVien.WatermarkText = "";
            // 
            // metroSetTile1
            // 
            this.metroSetTile1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTile1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTile1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.metroSetTile1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile1.IsDerivedStyle = true;
            this.metroSetTile1.Location = new System.Drawing.Point(15, 102);
            this.metroSetTile1.Name = "metroSetTile1";
            this.metroSetTile1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetTile1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile1.PressTextColor = System.Drawing.Color.White;
            this.metroSetTile1.Size = new System.Drawing.Size(11, 234);
            this.metroSetTile1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTile1.StyleManager = null;
            this.metroSetTile1.TabIndex = 7;
            this.metroSetTile1.ThemeAuthor = "Narwin";
            this.metroSetTile1.ThemeName = "MetroLite";
            this.metroSetTile1.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(32, 165);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(183, 32);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 5;
            this.metroSetLabel3.Text = "Ứng tuyển vị trí";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // txtTenViTri
            // 
            this.txtTenViTri.AutoCompleteCustomSource = null;
            this.txtTenViTri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenViTri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenViTri.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTenViTri.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTenViTri.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTenViTri.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTenViTri.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenViTri.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTenViTri.Image = null;
            this.txtTenViTri.IsDerivedStyle = true;
            this.txtTenViTri.Lines = null;
            this.txtTenViTri.Location = new System.Drawing.Point(271, 154);
            this.txtTenViTri.MaxLength = 32767;
            this.txtTenViTri.Multiline = false;
            this.txtTenViTri.Name = "txtTenViTri";
            this.txtTenViTri.ReadOnly = false;
            this.txtTenViTri.Size = new System.Drawing.Size(368, 42);
            this.txtTenViTri.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTenViTri.StyleManager = null;
            this.txtTenViTri.TabIndex = 6;
            this.txtTenViTri.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenViTri.ThemeAuthor = "Narwin";
            this.txtTenViTri.ThemeName = "MetroLite";
            this.txtTenViTri.UseSystemPasswordChar = false;
            this.txtTenViTri.WatermarkText = "";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(32, 234);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(183, 32);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 5;
            this.metroSetLabel4.Text = "Ngày ứng tuyển";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // dtNgayUngTuyen
            // 
            this.dtNgayUngTuyen.Location = new System.Drawing.Point(271, 223);
            this.dtNgayUngTuyen.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtNgayUngTuyen.Name = "dtNgayUngTuyen";
            this.dtNgayUngTuyen.Size = new System.Drawing.Size(368, 43);
            this.dtNgayUngTuyen.TabIndex = 8;
            // 
            // metroSetTile2
            // 
            this.metroSetTile2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTile2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTile2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTile2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.metroSetTile2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetTile2.IsDerivedStyle = true;
            this.metroSetTile2.Location = new System.Drawing.Point(15, 400);
            this.metroSetTile2.Name = "metroSetTile2";
            this.metroSetTile2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.NormalTextColor = System.Drawing.Color.White;
            this.metroSetTile2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTile2.PressTextColor = System.Drawing.Color.White;
            this.metroSetTile2.Size = new System.Drawing.Size(214, 10);
            this.metroSetTile2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTile2.StyleManager = null;
            this.metroSetTile2.TabIndex = 9;
            this.metroSetTile2.ThemeAuthor = "Narwin";
            this.metroSetTile2.ThemeName = "MetroLite";
            this.metroSetTile2.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(32, 304);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(222, 32);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 5;
            this.metroSetLabel5.Text = "Trạng thái xét tuyển";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // radioTrungTuyen
            // 
            this.radioTrungTuyen.AutoSize = true;
            this.radioTrungTuyen.BackColor = System.Drawing.Color.White;
            this.radioTrungTuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTrungTuyen.ForeColor = System.Drawing.Color.Black;
            this.radioTrungTuyen.Location = new System.Drawing.Point(306, 300);
            this.radioTrungTuyen.Name = "radioTrungTuyen";
            this.radioTrungTuyen.Size = new System.Drawing.Size(159, 35);
            this.radioTrungTuyen.TabIndex = 10;
            this.radioTrungTuyen.TabStop = true;
            this.radioTrungTuyen.Text = "Trúng tuyển";
            this.radioTrungTuyen.UseVisualStyleBackColor = false;
            this.radioTrungTuyen.CheckedChanged += new System.EventHandler(this.radioTrungTuyen_CheckedChanged);
            // 
            // radioTruot
            // 
            this.radioTruot.AutoSize = true;
            this.radioTruot.BackColor = System.Drawing.Color.White;
            this.radioTruot.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTruot.ForeColor = System.Drawing.Color.Black;
            this.radioTruot.Location = new System.Drawing.Point(509, 300);
            this.radioTruot.Name = "radioTruot";
            this.radioTruot.Size = new System.Drawing.Size(91, 35);
            this.radioTruot.TabIndex = 10;
            this.radioTruot.TabStop = true;
            this.radioTruot.Text = "Trượt";
            this.radioTruot.UseVisualStyleBackColor = false;
            this.radioTruot.CheckedChanged += new System.EventHandler(this.radioTruot_CheckedChanged);
            // 
            // btnSua
            // 
            this.btnSua.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSua.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSua.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSua.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSua.HoverTextColor = System.Drawing.Color.White;
            this.btnSua.IsDerivedStyle = true;
            this.btnSua.Location = new System.Drawing.Point(710, 288);
            this.btnSua.Name = "btnSua";
            this.btnSua.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSua.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSua.NormalTextColor = System.Drawing.Color.White;
            this.btnSua.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSua.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSua.PressTextColor = System.Drawing.Color.White;
            this.btnSua.Size = new System.Drawing.Size(238, 47);
            this.btnSua.Style = MetroSet_UI.Enums.Style.Light;
            this.btnSua.StyleManager = null;
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Lưu";
            this.btnSua.ThemeAuthor = "Narwin";
            this.btnSua.ThemeName = "MetroLite";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaViTri
            // 
            this.txtMaViTri.AutoCompleteCustomSource = null;
            this.txtMaViTri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMaViTri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMaViTri.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMaViTri.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMaViTri.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMaViTri.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtMaViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaViTri.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtMaViTri.Image = null;
            this.txtMaViTri.IsDerivedStyle = true;
            this.txtMaViTri.Lines = null;
            this.txtMaViTri.Location = new System.Drawing.Point(306, 16);
            this.txtMaViTri.MaxLength = 32767;
            this.txtMaViTri.Multiline = false;
            this.txtMaViTri.Name = "txtMaViTri";
            this.txtMaViTri.ReadOnly = false;
            this.txtMaViTri.Size = new System.Drawing.Size(166, 30);
            this.txtMaViTri.Style = MetroSet_UI.Enums.Style.Light;
            this.txtMaViTri.StyleManager = null;
            this.txtMaViTri.TabIndex = 12;
            this.txtMaViTri.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaViTri.ThemeAuthor = "Narwin";
            this.txtMaViTri.ThemeName = "MetroLite";
            this.txtMaViTri.UseSystemPasswordChar = false;
            this.txtMaViTri.Visible = false;
            this.txtMaViTri.WatermarkText = "";
            // 
            // txtMaUngVien
            // 
            this.txtMaUngVien.AutoCompleteCustomSource = null;
            this.txtMaUngVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMaUngVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMaUngVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMaUngVien.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMaUngVien.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMaUngVien.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtMaUngVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaUngVien.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtMaUngVien.Image = null;
            this.txtMaUngVien.IsDerivedStyle = true;
            this.txtMaUngVien.Lines = null;
            this.txtMaUngVien.Location = new System.Drawing.Point(509, 16);
            this.txtMaUngVien.MaxLength = 32767;
            this.txtMaUngVien.Multiline = false;
            this.txtMaUngVien.Name = "txtMaUngVien";
            this.txtMaUngVien.ReadOnly = false;
            this.txtMaUngVien.Size = new System.Drawing.Size(115, 30);
            this.txtMaUngVien.Style = MetroSet_UI.Enums.Style.Light;
            this.txtMaUngVien.StyleManager = null;
            this.txtMaUngVien.TabIndex = 12;
            this.txtMaUngVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaUngVien.ThemeAuthor = "Narwin";
            this.txtMaUngVien.ThemeName = "MetroLite";
            this.txtMaUngVien.UseSystemPasswordChar = false;
            this.txtMaUngVien.Visible = false;
            this.txtMaUngVien.WatermarkText = "";
            // 
            // txtMaCongTy
            // 
            this.txtMaCongTy.AutoCompleteCustomSource = null;
            this.txtMaCongTy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMaCongTy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMaCongTy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMaCongTy.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMaCongTy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMaCongTy.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtMaCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaCongTy.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtMaCongTy.Image = null;
            this.txtMaCongTy.IsDerivedStyle = true;
            this.txtMaCongTy.Lines = null;
            this.txtMaCongTy.Location = new System.Drawing.Point(732, 16);
            this.txtMaCongTy.MaxLength = 32767;
            this.txtMaCongTy.Multiline = false;
            this.txtMaCongTy.Name = "txtMaCongTy";
            this.txtMaCongTy.ReadOnly = false;
            this.txtMaCongTy.Size = new System.Drawing.Size(135, 30);
            this.txtMaCongTy.Style = MetroSet_UI.Enums.Style.Light;
            this.txtMaCongTy.StyleManager = null;
            this.txtMaCongTy.TabIndex = 13;
            this.txtMaCongTy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaCongTy.ThemeAuthor = "Narwin";
            this.txtMaCongTy.ThemeName = "MetroLite";
            this.txtMaCongTy.UseSystemPasswordChar = false;
            this.txtMaCongTy.Visible = false;
            this.txtMaCongTy.WatermarkText = "";
            // 
            // Frm_XemUngVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(978, 611);
            this.Controls.Add(this.txtMaCongTy);
            this.Controls.Add(this.txtMaUngVien);
            this.Controls.Add(this.txtMaViTri);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.radioTruot);
            this.Controls.Add(this.radioTrungTuyen);
            this.Controls.Add(this.metroSetTile2);
            this.Controls.Add(this.dtNgayUngTuyen);
            this.Controls.Add(this.metroSetTile1);
            this.Controls.Add(this.txtTenViTri);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.txtTenUngVien);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.dgDanhSachUngVien);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_XemUngVien";
            this.Text = "Thông tin ứng viên";
            this.TextColor = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSachUngVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid dgDanhSachUngVien;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox txtTenUngVien;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetTextBox txtTenViTri;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroFramework.Controls.MetroDateTime dtNgayUngTuyen;
        private MetroSet_UI.Controls.MetroSetTile metroSetTile2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private System.Windows.Forms.RadioButton radioTrungTuyen;
        private System.Windows.Forms.RadioButton radioTruot;
        private MetroSet_UI.Controls.MetroSetButton btnSua;
        private MetroSet_UI.Controls.MetroSetTextBox txtMaViTri;
        private MetroSet_UI.Controls.MetroSetTextBox txtMaUngVien;
        private MetroSet_UI.Controls.MetroSetTextBox txtMaCongTy;
    }
}