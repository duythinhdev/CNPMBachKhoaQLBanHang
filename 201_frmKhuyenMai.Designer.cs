
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
            System.Windows.Forms.Button btnDon;
            this.dtgrKhuyenMai = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbText = new System.Windows.Forms.GroupBox();
            this.txtTrangThai = new System.Windows.Forms.Label();
            this.lblIdKhuyenMai = new System.Windows.Forms.Label();
            this.txtIdDiscount = new System.Windows.Forms.TextBox();
            this.txtMoneyDiscount = new System.Windows.Forms.TextBox();
            this.lblTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameDiscount = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            btnDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrKhuyenMai)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.grbText.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDon
            // 
            btnDon.Location = new System.Drawing.Point(148, 99);
            btnDon.Name = "btnDon";
            btnDon.Size = new System.Drawing.Size(75, 38);
            btnDon.TabIndex = 3;
            btnDon.Text = "Dọn";
            btnDon.UseVisualStyleBackColor = true;
            btnDon.Click += new System.EventHandler(this.btnDon_Click);
            // 
            // dtgrKhuyenMai
            // 
            this.dtgrKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrKhuyenMai.Location = new System.Drawing.Point(31, 321);
            this.dtgrKhuyenMai.Name = "dtgrKhuyenMai";
            this.dtgrKhuyenMai.Size = new System.Drawing.Size(727, 284);
            this.dtgrKhuyenMai.TabIndex = 0;
            this.dtgrKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrKhuyenMai_CellClick);
            this.dtgrKhuyenMai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrKhuyenMai_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khuyến Mãi Sản Phẩm";
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(btnDon);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Location = new System.Drawing.Point(490, 90);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(268, 213);
            this.grbChucNang.TabIndex = 2;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức Năng";
            this.grbChucNang.Enter += new System.EventHandler(this.grbChucNang_Enter);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(27, 99);
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
            this.btnXoa.Location = new System.Drawing.Point(148, 38);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbText
            // 
            this.grbText.Controls.Add(this.checkBox2);
            this.grbText.Controls.Add(this.checkBox1);
            this.grbText.Controls.Add(this.txtTrangThai);
            this.grbText.Controls.Add(this.lblIdKhuyenMai);
            this.grbText.Controls.Add(this.txtIdDiscount);
            this.grbText.Controls.Add(this.txtMoneyDiscount);
            this.grbText.Controls.Add(this.lblTien);
            this.grbText.Controls.Add(this.label2);
            this.grbText.Controls.Add(this.txtNameDiscount);
            this.grbText.Location = new System.Drawing.Point(31, 90);
            this.grbText.Name = "grbText";
            this.grbText.Size = new System.Drawing.Size(418, 213);
            this.grbText.TabIndex = 3;
            this.grbText.TabStop = false;
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
            this.lblIdKhuyenMai.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtIdDiscount
            // 
            this.txtIdDiscount.Location = new System.Drawing.Point(131, 19);
            this.txtIdDiscount.Name = "txtIdDiscount";
            this.txtIdDiscount.Size = new System.Drawing.Size(173, 20);
            this.txtIdDiscount.TabIndex = 6;
            this.txtIdDiscount.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
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
            this.txtNameDiscount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(131, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(38, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "on";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(190, 143);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(38, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "off";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 648);
            this.Controls.Add(this.grbText);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrKhuyenMai);
            this.Name = "KhuyenMai";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox txtMoneyDiscount;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdKhuyenMai;
        private System.Windows.Forms.TextBox txtIdDiscount;
        private System.Windows.Forms.Label txtTrangThai;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}