
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            btnDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrKhuyenMai)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrKhuyenMai
            // 
            this.dtgrKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrKhuyenMai.Location = new System.Drawing.Point(71, 159);
            this.dtgrKhuyenMai.Name = "dtgrKhuyenMai";
            this.dtgrKhuyenMai.Size = new System.Drawing.Size(648, 397);
            this.dtgrKhuyenMai.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 27);
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
            this.grbChucNang.Location = new System.Drawing.Point(806, 159);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(310, 187);
            this.grbChucNang.TabIndex = 2;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức Năng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(68, 51);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnXoa.Location = new System.Drawing.Point(188, 51);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(68, 131);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 38);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnDon
            // 
            btnDon.Location = new System.Drawing.Point(188, 131);
            btnDon.Name = "btnDon";
            btnDon.Size = new System.Drawing.Size(75, 38);
            btnDon.TabIndex = 3;
            btnDon.Text = "Dọn";
            btnDon.UseVisualStyleBackColor = true;
            // 
            // KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 648);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrKhuyenMai);
            this.Name = "KhuyenMai";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrKhuyenMai)).EndInit();
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrKhuyenMai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}