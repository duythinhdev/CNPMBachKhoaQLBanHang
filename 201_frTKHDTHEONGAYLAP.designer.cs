namespace Project
{
    partial class frmTKHDTHEONGAYLAP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtrDS = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPanner = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.dtpNgayLapHoaDon = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtrDS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtrDS);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 192);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(752, 313);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // dtrDS
            // 
            this.dtrDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtrDS.Location = new System.Drawing.Point(9, 25);
            this.dtrDS.Margin = new System.Windows.Forms.Padding(4);
            this.dtrDS.Name = "dtrDS";
            this.dtrDS.RowHeadersWidth = 51;
            this.dtrDS.Size = new System.Drawing.Size(735, 281);
            this.dtrDS.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nhập Ngày Lập Hóa Đơn";
            // 
            // lblPanner
            // 
            this.lblPanner.BackColor = System.Drawing.Color.Aquamarine;
            this.lblPanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPanner.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanner.Location = new System.Drawing.Point(0, 0);
            this.lblPanner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPanner.Name = "lblPanner";
            this.lblPanner.Size = new System.Drawing.Size(788, 98);
            this.lblPanner.TabIndex = 21;
            this.lblPanner.Text = "TÌM KIẾM HÓA ĐƠN THEO NGÀY LẬP";
            this.lblPanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(647, 113);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(105, 38);
            this.btnTim.TabIndex = 24;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.BtnTim_Click);
            // 
            // dtpNgayLapHoaDon
            // 
            this.dtpNgayLapHoaDon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLapHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLapHoaDon.Location = new System.Drawing.Point(263, 114);
            this.dtpNgayLapHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayLapHoaDon.Name = "dtpNgayLapHoaDon";
            this.dtpNgayLapHoaDon.Size = new System.Drawing.Size(347, 29);
            this.dtpNgayLapHoaDon.TabIndex = 25;
            // 
            // frmTKHDTHEONGAYLAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 519);
            this.Controls.Add(this.dtpNgayLapHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPanner);
            this.Controls.Add(this.btnTim);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTKHDTHEONGAYLAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm hóa đơn theo thứ ngày lập";
            this.Load += new System.EventHandler(this.frmTKHDTHEONGAYLAP_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtrDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtrDS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPanner;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHoaDon;
    }
}