namespace demo.View
{
    partial class Frm_Test
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
            this.btnSaveToCSV = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
            // 
            // btnSaveToCSV
            // 
            this.btnSaveToCSV.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveToCSV.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveToCSV.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSaveToCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveToCSV.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSaveToCSV.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSaveToCSV.HoverTextColor = System.Drawing.Color.White;
            this.btnSaveToCSV.IsDerivedStyle = true;
            this.btnSaveToCSV.Location = new System.Drawing.Point(727, 393);
            this.btnSaveToCSV.Name = "btnSaveToCSV";
            this.btnSaveToCSV.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveToCSV.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSaveToCSV.NormalTextColor = System.Drawing.Color.White;
            this.btnSaveToCSV.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSaveToCSV.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSaveToCSV.PressTextColor = System.Drawing.Color.White;
            this.btnSaveToCSV.Size = new System.Drawing.Size(186, 45);
            this.btnSaveToCSV.Style = MetroSet_UI.Enums.Style.Light;
            this.btnSaveToCSV.StyleManager = null;
            this.btnSaveToCSV.TabIndex = 0;
            this.btnSaveToCSV.Text = "Save CSV";
            this.btnSaveToCSV.ThemeAuthor = "Narwin";
            this.btnSaveToCSV.ThemeName = "MetroLite";
            this.btnSaveToCSV.Click += new System.EventHandler(this.btnSaveToCsv_Click);
            // 
            // Frm_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.btnSaveToCSV);
            this.Name = "Frm_Test";
            this.Text = "Frm_Test";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btnSaveToCSV;
    }
}