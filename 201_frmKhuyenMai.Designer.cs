
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdDiscount = new System.Windows.Forms.TextBox();
            this.txtMoneyDiscount = new System.Windows.Forms.TextBox();
            this.txtPercentDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameDiscount = new System.Windows.Forms.TextBox();
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
            // 
            // dtgrKhuyenMai
            // 
            this.dtgrKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrKhuyenMai.Location = new System.Drawing.Point(31, 272);
            this.dtgrKhuyenMai.Name = "dtgrKhuyenMai";
            this.dtgrKhuyenMai.Size = new System.Drawing.Size(944, 284);
            this.dtgrKhuyenMai.TabIndex = 0;
            this.dtgrKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrKhuyenMai_CellClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 22);
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
            this.grbChucNang.Size = new System.Drawing.Size(268, 176);
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
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // grbText
            // 
            this.grbText.Controls.Add(this.label5);
            this.grbText.Controls.Add(this.txtIdDiscount);
            this.grbText.Controls.Add(this.txtMoneyDiscount);
            this.grbText.Controls.Add(this.txtPercentDiscount);
            this.grbText.Controls.Add(this.label4);
            this.grbText.Controls.Add(this.label3);
            this.grbText.Controls.Add(this.label2);
            this.grbText.Controls.Add(this.txtNameDiscount);
            this.grbText.Location = new System.Drawing.Point(31, 90);
            this.grbText.Name = "grbText";
            this.grbText.Size = new System.Drawing.Size(418, 176);
            this.grbText.TabIndex = 3;
            this.grbText.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "idDisCount";
            // 
            // txtIdDiscount
            // 
            this.txtIdDiscount.Location = new System.Drawing.Point(121, 19);
            this.txtIdDiscount.Name = "txtIdDiscount";
            this.txtIdDiscount.Size = new System.Drawing.Size(173, 20);
            this.txtIdDiscount.TabIndex = 6;
            this.txtIdDiscount.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtMoneyDiscount
            // 
            this.txtMoneyDiscount.Location = new System.Drawing.Point(121, 141);
            this.txtMoneyDiscount.Name = "txtMoneyDiscount";
            this.txtMoneyDiscount.Size = new System.Drawing.Size(173, 20);
            this.txtMoneyDiscount.TabIndex = 5;
            // 
            // txtPercentDiscount
            // 
            this.txtPercentDiscount.Location = new System.Drawing.Point(121, 99);
            this.txtPercentDiscount.Name = "txtPercentDiscount";
            this.txtPercentDiscount.Size = new System.Drawing.Size(173, 20);
            this.txtPercentDiscount.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MoneyDiscount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PercentDiscount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NameDisCount";
            // 
            // txtNameDiscount
            // 
            this.txtNameDiscount.Location = new System.Drawing.Point(121, 58);
            this.txtNameDiscount.Name = "txtNameDiscount";
            this.txtNameDiscount.Size = new System.Drawing.Size(173, 20);
            this.txtNameDiscount.TabIndex = 0;
            this.txtNameDiscount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 648);
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
        private System.Windows.Forms.TextBox txtPercentDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdDiscount;
    }
}