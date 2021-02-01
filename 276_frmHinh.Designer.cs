namespace Project
{
    partial class frmHinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.flpHinhSP = new System.Windows.Forms.FlowLayoutPanel();
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.btnUpHinh = new System.Windows.Forms.Button();
            this.btnUpNHinh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.oldHinh = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPLOAD HÌNH ẢNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpHinhSP
            // 
            this.flpHinhSP.AutoScroll = true;
            this.flpHinhSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpHinhSP.Location = new System.Drawing.Point(208, 282);
            this.flpHinhSP.Name = "flpHinhSP";
            this.flpHinhSP.Size = new System.Drawing.Size(578, 197);
            this.flpHinhSP.TabIndex = 1;
            // 
            // picHinh
            // 
            this.picHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picHinh.Location = new System.Drawing.Point(12, 73);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(194, 197);
            this.picHinh.TabIndex = 0;
            this.picHinh.TabStop = false;
            // 
            // btnUpHinh
            // 
            this.btnUpHinh.Location = new System.Drawing.Point(252, 149);
            this.btnUpHinh.Name = "btnUpHinh";
            this.btnUpHinh.Size = new System.Drawing.Size(120, 40);
            this.btnUpHinh.TabIndex = 1;
            this.btnUpHinh.Text = "Upload Hình";
            this.btnUpHinh.UseVisualStyleBackColor = true;
            this.btnUpHinh.Click += new System.EventHandler(this.BtnUpHinh_Click);
            // 
            // btnUpNHinh
            // 
            this.btnUpNHinh.Location = new System.Drawing.Point(42, 350);
            this.btnUpNHinh.Name = "btnUpNHinh";
            this.btnUpNHinh.Size = new System.Drawing.Size(120, 40);
            this.btnUpNHinh.TabIndex = 2;
            this.btnUpNHinh.Text = "Upload N Hình";
            this.btnUpNHinh.UseVisualStyleBackColor = true;
            this.btnUpNHinh.Click += new System.EventHandler(this.BtnUpNHinh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(416, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 187);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(134, 122);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(197, 76);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 40);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(73, 76);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(197, 30);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(73, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // oldHinh
            // 
            this.oldHinh.FileName = "openFileDialog1";
            // 
            // frmHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpNHinh);
            this.Controls.Add(this.btnUpHinh);
            this.Controls.Add(this.picHinh);
            this.Controls.Add(this.flpHinhSP);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHinh";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmHinh_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpHinhSP;
        private System.Windows.Forms.PictureBox picHinh;
        private System.Windows.Forms.Button btnUpHinh;
        private System.Windows.Forms.Button btnUpNHinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.OpenFileDialog oldHinh;
    }
}