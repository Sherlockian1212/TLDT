namespace CuoiKi
{
    partial class frmChonMaTran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonMaTran));
            this.btnDuyetSau = new System.Windows.Forms.Button();
            this.btnDuyetRong = new System.Windows.Forms.Button();
            this.btnTimLienThong = new System.Windows.Forms.Button();
            this.grpNhapMaTran = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDinhBatDau = new System.Windows.Forms.ComboBox();
            this.cboDS = new System.Windows.Forms.ComboBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnNhapfile = new System.Windows.Forms.Button();
            this.txtNhapMaTran = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpNhapMaTran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDuyetSau
            // 
            this.btnDuyetSau.BackColor = System.Drawing.Color.Cornsilk;
            this.btnDuyetSau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyetSau.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetSau.ForeColor = System.Drawing.Color.DeepPink;
            this.btnDuyetSau.Location = new System.Drawing.Point(621, 256);
            this.btnDuyetSau.Name = "btnDuyetSau";
            this.btnDuyetSau.Size = new System.Drawing.Size(390, 80);
            this.btnDuyetSau.TabIndex = 4;
            this.btnDuyetSau.Text = "Duyệt theo chiều sâu";
            this.btnDuyetSau.UseVisualStyleBackColor = false;
            this.btnDuyetSau.Click += new System.EventHandler(this.btnDuyetSau_Click);
            // 
            // btnDuyetRong
            // 
            this.btnDuyetRong.BackColor = System.Drawing.Color.Cornsilk;
            this.btnDuyetRong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyetRong.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetRong.ForeColor = System.Drawing.Color.DeepPink;
            this.btnDuyetRong.Location = new System.Drawing.Point(621, 170);
            this.btnDuyetRong.Name = "btnDuyetRong";
            this.btnDuyetRong.Size = new System.Drawing.Size(390, 80);
            this.btnDuyetRong.TabIndex = 3;
            this.btnDuyetRong.Text = "Duyệt theo chiều rộng";
            this.btnDuyetRong.UseVisualStyleBackColor = false;
            this.btnDuyetRong.Click += new System.EventHandler(this.btnDuyetRong_Click);
            // 
            // btnTimLienThong
            // 
            this.btnTimLienThong.BackColor = System.Drawing.Color.Cornsilk;
            this.btnTimLienThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimLienThong.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimLienThong.ForeColor = System.Drawing.Color.DeepPink;
            this.btnTimLienThong.Location = new System.Drawing.Point(621, 84);
            this.btnTimLienThong.Name = "btnTimLienThong";
            this.btnTimLienThong.Size = new System.Drawing.Size(390, 80);
            this.btnTimLienThong.TabIndex = 2;
            this.btnTimLienThong.Text = "Tìm thành phần liên thông";
            this.btnTimLienThong.UseVisualStyleBackColor = false;
            this.btnTimLienThong.Click += new System.EventHandler(this.btnTimLienThong_Click);
            // 
            // grpNhapMaTran
            // 
            this.grpNhapMaTran.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.grpNhapMaTran.Controls.Add(this.label2);
            this.grpNhapMaTran.Controls.Add(this.label1);
            this.grpNhapMaTran.Controls.Add(this.cboDinhBatDau);
            this.grpNhapMaTran.Controls.Add(this.cboDS);
            this.grpNhapMaTran.Controls.Add(this.txtKetQua);
            this.grpNhapMaTran.Controls.Add(this.btnNhapfile);
            this.grpNhapMaTran.Controls.Add(this.txtNhapMaTran);
            this.grpNhapMaTran.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNhapMaTran.ForeColor = System.Drawing.Color.DeepPink;
            this.grpNhapMaTran.Location = new System.Drawing.Point(13, 67);
            this.grpNhapMaTran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNhapMaTran.Name = "grpNhapMaTran";
            this.grpNhapMaTran.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNhapMaTran.Size = new System.Drawing.Size(601, 655);
            this.grpNhapMaTran.TabIndex = 4;
            this.grpNhapMaTran.TabStop = false;
            this.grpNhapMaTran.Text = "Chọn ma trận kề có sẵn";
            this.grpNhapMaTran.Enter += new System.EventHandler(this.grpNhapMaTran_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đỉnh bắt đầu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Testcase mẫu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboDinhBatDau
            // 
            this.cboDinhBatDau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboDinhBatDau.FormattingEnabled = true;
            this.cboDinhBatDau.Location = new System.Drawing.Point(209, 77);
            this.cboDinhBatDau.Name = "cboDinhBatDau";
            this.cboDinhBatDau.Size = new System.Drawing.Size(134, 40);
            this.cboDinhBatDau.TabIndex = 2;
            this.cboDinhBatDau.SelectedIndexChanged += new System.EventHandler(this.cboDinhBatDau_SelectedIndexChanged);
            // 
            // cboDS
            // 
            this.cboDS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboDS.FormattingEnabled = true;
            this.cboDS.Items.AddRange(new object[] {
            "Testcase1",
            "Testcase2",
            "Testcase3",
            "Testcase4",
            "Testcase5",
            "Testcase6",
            "Testcase7",
            "Testcase8",
            "Testcase9"});
            this.cboDS.Location = new System.Drawing.Point(7, 77);
            this.cboDS.Name = "cboDS";
            this.cboDS.Size = new System.Drawing.Size(194, 40);
            this.cboDS.TabIndex = 0;
            this.cboDS.SelectedIndexChanged += new System.EventHandler(this.cboDS_SelectedIndexChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(9, 403);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(584, 242);
            this.txtKetQua.TabIndex = 1;
            this.txtKetQua.Text = "Kết quả:";
            // 
            // btnNhapfile
            // 
            this.btnNhapfile.BackColor = System.Drawing.Color.Cornsilk;
            this.btnNhapfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapfile.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapfile.ForeColor = System.Drawing.Color.DeepPink;
            this.btnNhapfile.Location = new System.Drawing.Point(366, 72);
            this.btnNhapfile.Name = "btnNhapfile";
            this.btnNhapfile.Size = new System.Drawing.Size(126, 49);
            this.btnNhapfile.TabIndex = 2;
            this.btnNhapfile.Text = "Nhập file";
            this.btnNhapfile.UseVisualStyleBackColor = false;
            this.btnNhapfile.Click += new System.EventHandler(this.btnNhapfile_Click);
            // 
            // txtNhapMaTran
            // 
            this.txtNhapMaTran.Location = new System.Drawing.Point(9, 125);
            this.txtNhapMaTran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhapMaTran.Multiline = true;
            this.txtNhapMaTran.Name = "txtNhapMaTran";
            this.txtNhapMaTran.Size = new System.Drawing.Size(584, 268);
            this.txtNhapMaTran.TabIndex = 1;
            this.txtNhapMaTran.TextChanged += new System.EventHandler(this.txtNhapMaTran_TextChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Cornsilk;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.DeepPink;
            this.btnMenu.Location = new System.Drawing.Point(86, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(106, 47);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CuoiKi.Properties.Resources.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.Cornsilk;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ForeColor = System.Drawing.Color.DeepPink;
            this.btnDraw.Location = new System.Drawing.Point(621, 342);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(390, 80);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Vẽ đồ thị";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmChonMaTran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1023, 736);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnDuyetSau);
            this.Controls.Add(this.btnDuyetRong);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnTimLienThong);
            this.Controls.Add(this.grpNhapMaTran);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChonMaTran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn ma trận kề";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChonMaTran_FormClosed);
            this.Load += new System.EventHandler(this.ChonMaTran_Load);
            this.grpNhapMaTran.ResumeLayout(false);
            this.grpNhapMaTran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDuyetSau;
        private System.Windows.Forms.Button btnDuyetRong;
        private System.Windows.Forms.Button btnTimLienThong;
        private System.Windows.Forms.GroupBox grpNhapMaTran;
        private System.Windows.Forms.ComboBox cboDS;
        private System.Windows.Forms.TextBox txtNhapMaTran;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDinhBatDau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnNhapfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}