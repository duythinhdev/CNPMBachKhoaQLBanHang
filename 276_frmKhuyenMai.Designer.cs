
namespace Project
{
    partial class KhuyenMai
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
            this.dtgrKhuyenMai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbText = new System.Windows.Forms.GroupBox();
            this.rdbTat = new System.Windows.Forms.RadioButton();
            this.rdbBat = new System.Windows.Forms.RadioButton();
            this.txtTrangThai = new System.Windows.Forms.Label();
            this.lblIdKhuyenMai = new System.Windows.Forms.Label();
            this.txtIdDiscount = new System.Windows.Forms.TextBox();
            this.txtMoneyDiscount = new System.Windows.Forms.TextBox();
            this.lblTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameDiscount = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrKhuyenMai)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.grbText.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrKhuyenMai
            // 
            this.dtgrKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgrKhuyenMai.Location = new System.Drawing.Point(31, 321);
            this.dtgrKhuyenMai.Name = "dtgrKhuyenMai";
            this.dtgrKhuyenMai.Size = new System.Drawing.Size(727, 284);
            this.dtgrKhuyenMai.TabIndex = 0;
            this.dtgrKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrKhuyenMai_CellClick);
            this.dtgrKhuyenMai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrKhuyenMai_CellClick);
            this.dtgrKhuyenMai.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgrKhuyenMai_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idDiscount";
            this.Column1.HeaderText = "Mã Khuyến Mãi";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nameDiscount";
            this.Column2.HeaderText = "Tên Khuyến Mãi";
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "moneyDiscount";
            this.Column3.HeaderText = "Tiền Khuyến Mãi ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "status";
            this.Column4.HeaderText = "Trạng Thái";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.Width = 160;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khuyến Mãi Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnHuy);
            this.grbChucNang.Controls.Add(this.btnClear);
            this.grbChucNang.Controls.Add(this.btnSave);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Location = new System.Drawing.Point(490, 90);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(268, 213);
            this.grbChucNang.TabIndex = 2;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức Năng";
            // 
            // btnClear
            // 
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClear.Location = new System.Drawing.Point(148, 83);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Dọn";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 143);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(27, 85);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 38);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnXoa.Location = new System.Drawing.Point(148, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbText
            // 
            this.grbText.Controls.Add(this.rdbTat);
            this.grbText.Controls.Add(this.rdbBat);
            this.grbText.Controls.Add(this.txtTrangThai);
            this.grbText.Controls.Add(this.lblIdKhuyenMai);
            this.grbText.Controls.Add(this.txtIdDiscount);
            this.grbText.Controls.Add(this.txtMoneyDiscount);
            this.grbText.Controls.Add(this.lblTien);
            this.grbText.Controls.Add(this.label2);
            this.grbText.Controls.Add(this.txtNameDiscount);
            this.grbText.Location = new System.Drawing.Point(31, 90);
            this.grbText.Name = "grbText";
            this.grbText.Size = new System.Drawing.Size(441, 213);
            this.grbText.TabIndex = 3;
            this.grbText.TabStop = false;
            // 
            // rdbTat
            // 
            this.rdbTat.AutoSize = true;
            this.rdbTat.Location = new System.Drawing.Point(238, 143);
            this.rdbTat.Name = "rdbTat";
            this.rdbTat.Size = new System.Drawing.Size(41, 17);
            this.rdbTat.TabIndex = 10;
            this.rdbTat.TabStop = true;
            this.rdbTat.Text = "Tắt";
            this.rdbTat.UseVisualStyleBackColor = true;
            this.rdbTat.CheckedChanged += new System.EventHandler(this.rdbTat_CheckedChanged);
            // 
            // rdbBat
            // 
            this.rdbBat.AutoSize = true;
            this.rdbBat.Location = new System.Drawing.Point(143, 143);
            this.rdbBat.Name = "rdbBat";
            this.rdbBat.Size = new System.Drawing.Size(41, 17);
            this.rdbBat.TabIndex = 9;
            this.rdbBat.TabStop = true;
            this.rdbBat.Text = "Bật";
            this.rdbBat.UseVisualStyleBackColor = true;
            this.rdbBat.CheckedChanged += new System.EventHandler(this.rdbBat_CheckedChanged);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.AutoSize = true;
            this.txtTrangThai.Location = new System.Drawing.Point(10, 143);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(59, 13);
            this.txtTrangThai.TabIndex = 8;
            this.txtTrangThai.Text = "Trạng Thái";
            // 
            // lblIdKhuyenMai
            // 
            this.lblIdKhuyenMai.AutoSize = true;
            this.lblIdKhuyenMai.Location = new System.Drawing.Point(11, 22);
            this.lblIdKhuyenMai.Name = "lblIdKhuyenMai";
            this.lblIdKhuyenMai.Size = new System.Drawing.Size(77, 13);
            this.lblIdKhuyenMai.TabIndex = 7;
            this.lblIdKhuyenMai.Text = "ID Khuyến Mãi";
            // 
            // txtIdDiscount
            // 
            this.txtIdDiscount.Location = new System.Drawing.Point(131, 19);
            this.txtIdDiscount.Name = "txtIdDiscount";
            this.txtIdDiscount.Size = new System.Drawing.Size(173, 20);
            this.txtIdDiscount.TabIndex = 6;
            // 
            // txtMoneyDiscount
            // 
            this.txtMoneyDiscount.Location = new System.Drawing.Point(131, 95);
            this.txtMoneyDiscount.Name = "txtMoneyDiscount";
            this.txtMoneyDiscount.Size = new System.Drawing.Size(173, 20);
            this.txtMoneyDiscount.TabIndex = 5;
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Location = new System.Drawing.Point(10, 102);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(55, 13);
            this.lblTien.TabIndex = 3;
            this.lblTien.Text = "Tiền Giảm";
            this.lblTien.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sản Phẩm Khuyến Mãi";
            // 
            // txtNameDiscount
            // 
            this.txtNameDiscount.Location = new System.Drawing.Point(131, 58);
            this.txtNameDiscount.Name = "txtNameDiscount";
            this.txtNameDiscount.Size = new System.Drawing.Size(173, 20);
            this.txtNameDiscount.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHuy.Location = new System.Drawing.Point(148, 143);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 40);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 648);
            this.Controls.Add(this.grbText);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrKhuyenMai);
            this.Name = "KhuyenMai";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KhuyenMai_FormClosing);
            this.Load += new System.EventHandler(this.KhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrKhuyenMai)).EndInit();
            this.grbChucNang.ResumeLayout(false);
            this.grbText.ResumeLayout(false);
            this.grbText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrKhuyenMai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbText;
        private System.Windows.Forms.TextBox txtNameDiscount;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdKhuyenMai;
        private System.Windows.Forms.TextBox txtIdDiscount;
        private System.Windows.Forms.Label txtTrangThai;
        private System.Windows.Forms.RadioButton rdbTat;
        private System.Windows.Forms.RadioButton rdbBat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMoneyDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHuy;
    }
}