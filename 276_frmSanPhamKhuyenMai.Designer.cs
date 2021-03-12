
namespace Project
{
    partial class frmSanPhamKhuyenMai
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
            this.cbbKhuyenMai = new System.Windows.Forms.ComboBox();
            this.dgrSanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrKhuyenMai = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKhuyenMai)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbKhuyenMai
            // 
            this.cbbKhuyenMai.FormattingEnabled = true;
            this.cbbKhuyenMai.Location = new System.Drawing.Point(35, 81);
            this.cbbKhuyenMai.Name = "cbbKhuyenMai";
            this.cbbKhuyenMai.Size = new System.Drawing.Size(215, 21);
            this.cbbKhuyenMai.TabIndex = 0;
            this.cbbKhuyenMai.SelectedIndexChanged += new System.EventHandler(this.cbbKhuyenMai_SelectedIndexChanged);
            // 
            // dgrSanPham
            // 
            this.dgrSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgrSanPham.Location = new System.Drawing.Point(35, 288);
            this.dgrSanPham.Name = "dgrSanPham";
            this.dgrSanPham.Size = new System.Drawing.Size(985, 150);
            this.dgrSanPham.TabIndex = 2;
            this.dgrSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrSanPham_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idproduct";
            this.Column1.HeaderText = "Mã Sản Phẩm ";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Tên Sản Phẩm ";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "idcat";
            this.Column3.HeaderText = "Mã Danh Mục ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "image";
            this.Column4.HeaderText = "Hình ảnh ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "quantity";
            this.Column5.HeaderText = "Định Lượng";
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "price";
            this.Column6.HeaderText = "Giá Tiền ";
            this.Column6.Name = "Column6";
            this.Column6.Width = 130;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "status";
            this.Column7.HeaderText = "Trạng Thái";
            this.Column7.Name = "Column7";
            this.Column7.Width = 130;
            // 
            // dgrKhuyenMai
            // 
            this.dgrKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgrKhuyenMai.Location = new System.Drawing.Point(275, 81);
            this.dgrKhuyenMai.Name = "dgrKhuyenMai";
            this.dgrKhuyenMai.Size = new System.Drawing.Size(467, 191);
            this.dgrKhuyenMai.TabIndex = 3;
            this.dgrKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrKhuyenMai_CellClick);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "idproduct";
            this.Column8.HeaderText = "Mã Sản Phẩm ";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "name";
            this.Column9.HeaderText = "Tên Sản Phẩm ";
            this.Column9.Name = "Column9";
            this.Column9.Width = 230;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "price";
            this.Column10.HeaderText = "Giá Sản Phẩm ";
            this.Column10.Name = "Column10";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1016, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sản Phẩm Khuyến Mãi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnLuu);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Location = new System.Drawing.Point(768, 81);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(252, 191);
            this.grbChucNang.TabIndex = 5;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức Năng ";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(84, 102);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 45);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(144, 39);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 44);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(22, 39);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmSanPhamKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrKhuyenMai);
            this.Controls.Add(this.dgrSanPham);
            this.Controls.Add(this.cbbKhuyenMai);
            this.Name = "frmSanPhamKhuyenMai";
            this.Text = "frmSanPhamKhuyenMai";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSanPhamKhuyenMai_FormClosing);
            this.Load += new System.EventHandler(this.frmSanPhamKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKhuyenMai)).EndInit();
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbKhuyenMai;
        private System.Windows.Forms.DataGridView dgrSanPham;
        private System.Windows.Forms.DataGridView dgrKhuyenMai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}