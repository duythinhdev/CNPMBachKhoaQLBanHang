using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        clsqlbanhang c = new clsqlbanhang();
        DataSet ds = new DataSet();
        DataSet dscat = new DataSet();
        DataView dvLoaiSP = new DataView();
        string path = @"D:\LearnC#\Project\bin\Image";
        int status = 0;
        string table = "products";
        bool flag = false;

        string CreateID()
        {
            string id = "";
            ds = c.LoadData("Select idproduct from products");
            if (ds.Tables[0].Rows.Count <= 0)
            {
                id = "SP001";
            }
            else
                id = "SP00" + (ds.Tables[0].Rows.Count + 1).ToString();

            return id;
        }

        void status_textbox(Boolean t)
        {
            txtMaSP.ReadOnly = true;
            txtGiaNhap.ReadOnly = t;
            txtGB.ReadOnly = t;
            txtGiaNhap.ReadOnly = t;
            txtSL.ReadOnly = t;
            txtTenSP.ReadOnly = t;
            cbbKichThuoc.Enabled = !t;
            cbbLoaiSP.Enabled = !t;
            cbbTrangThai.Enabled = !t;
            cbbMau.Enabled = !t;
            txtAnh.ReadOnly = t;
        }
        void status_button(Boolean t)
        {
            btnLuu.Enabled = !t;
            btnThem.Enabled = t;
            btnXoa.Enabled = t;
            btnSua.Enabled = t;
            btnHuy.Enabled = !t;
        }

        void ShowInTextBox(int vt)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtMaSP.Text = ds.Tables[0].Rows[vt]["idproduct"].ToString();
                txtTenSP.Text = ds.Tables[0].Rows[vt]["name"].ToString();
                txtGB.Text = ds.Tables[0].Rows[vt]["price"].ToString();
                txtGiaNhap.Text = ds.Tables[0].Rows[vt]["entry_price"].ToString();
                txtSL.Text = ds.Tables[0].Rows[vt]["quantity"].ToString();
                cbbTrangThai.Text = ds.Tables[0].Rows[vt]["status"].ToString();
                txtAnh.Text = ds.Tables[0].Rows[vt]["image"].ToString();

                DirectoryInfo di = new DirectoryInfo(path);
                string[] arrlistimg = txtAnh.Text.Split(new char[] {';'}).ToArray();
                flpHinhSP.Controls.Clear();
                for (int i= 0;i < arrlistimg.Count();i++)
                {
                    FileInfo[] fis = di.GetFiles(arrlistimg[i].ToString());
                    foreach(FileInfo f in fis)
                    {
                        PictureBox t = new PictureBox();
                        t.Width = 50;
                        t.Height = 50;
                        byte[] by = File.ReadAllBytes(f.FullName);
                        MemoryStream ms = new MemoryStream(by);
                        Bitmap image = new Bitmap(ms);
                        t.Image = image;
                        t.SizeMode = PictureBoxSizeMode.StretchImage;
                        
                        flpHinhSP.Controls.Add(t);
                    }
                }
                //Show category = category product
                dscat = c.LoadData("Select * from category");
                dvLoaiSP.Table = dscat.Tables[0];
                cbbLoaiSP.DataSource = dvLoaiSP;
                cbbLoaiSP.DisplayMember = "title";
                cbbLoaiSP.ValueMember = "idcat";
                dvLoaiSP.RowFilter = "idcat='" + ds.Tables[0].Rows[vt]["idcat"].ToString() + "'";
            }
        }

        void ShowInCombobox()
        {
            dscat = c.LoadData("Select * from category");
            dvLoaiSP.Table = dscat.Tables[0];
            cbbLoaiSP.DataSource = dvLoaiSP;
            cbbLoaiSP.DisplayMember = "title";
            cbbLoaiSP.ValueMember = "idcat";
        }

        void ShowTableProducts()
        {
            int vt = 0;
            ds = c.LoadData("Select idproduct, name, idcat, image, size, color, quantity, entry_price, price, status from products where active = 1");
            drgDSSP.DataSource = ds.Tables[0];
            ds.Tables[0].Columns.Add("STT");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["STT"] = (i + 1).ToString();
            }

            drgDSSP.Columns["STT"].DisplayIndex = 0;
            ShowInTextBox(vt);
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            status_textbox(true);
            status_button(true);
            ShowTableProducts();
            ShowInCombobox();
            flag = true;
        }

        void UpdateDataTable(string sql)
        {
            if (c.UpdateData(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                ShowTableProducts();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            status_textbox(false);
            status = 1;
            txtMaSP.Text = CreateID();
            txtTenSP.Focus();
            txtAnh.Clear();
            flpHinhSP.Controls.Clear();
            status_button(false);
            ShowInCombobox();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            status_textbox(true);
            status_button(true);
            string name = txtTenSP.Text;
            string entry_price = txtGiaNhap.Text;
            string price = txtGB.Text;
            string quanlity = txtSL.Text;
            string cat = cbbLoaiSP.SelectedValue.ToString();
            string statuss = cbbTrangThai.Text;
            string id = txtMaSP.Text;
            string img = txtAnh.Text;
            if (status == 1)
            {
                string sql = "INSERT INTO " + table + "(idproduct,name, idcat, quantity, entry_price, price,image, status) VALUES ('"+id+"','"+name+"','"+cat+"','"+quanlity+"','"+entry_price+"','"+price+"','"+img+"','"+statuss+"')";
                flpHinhSP.Controls.Clear();
                UpdateDataTable(sql);
            }
            if (status == 2)
            {
                string sql = "UPDATE " + table + " SET name='" + name + "',idcat='" + cat + "',quantity='"+quanlity+"',entry_price='"+entry_price+"',price='"+price+"',status='"+statuss+"' WHERE idproduct = '" + id + "'";
                UpdateDataTable(sql);
            }
            txtGB.Clear();
            txtGiaNhap.Clear();
            txtMaSP.Clear();
            txtSL.Clear();
            txtTenSP.Clear();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            status_button(true);
            status = 3;
            string id = txtMaSP.Text;
            string sql = "UPDATE " + table + " SET active = 0 WHERE idproduct = '" + id + "'";
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (c.UpdateData(sql) > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    ShowTableProducts();
                    status = 0;
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            status_textbox(false);
            status_button(false);
            ShowInCombobox();
            status = 2;
        }

        private void BtnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog oldNHinh = new OpenFileDialog();
            oldNHinh.Multiselect = true;
            oldNHinh.InitialDirectory = path;
            oldNHinh.Filter = "File (*.jpeg)|*.jpeg|File (*.png)|*.png";
            DialogResult kq = new DialogResult();
            kq = oldNHinh.ShowDialog();
            if (kq == DialogResult.Cancel)
            {
                DialogResult kq2 = new DialogResult();
                kq2 = MessageBox.Show("Bạn phải chọn hình", "Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if(kq2 == DialogResult.OK)
                {
                    oldNHinh.ShowDialog();
                }
            }
            else
            {
                string[] tenhinh = oldNHinh.FileNames;
                string name = "";
                foreach (string v in tenhinh)
                {
                    PictureBox t = new PictureBox();
                    t.Width = 50;
                    t.Height = 50;
                    Bitmap img = new Bitmap(v);
                    t.Image = img;
                    t.SizeMode = PictureBoxSizeMode.StretchImage;
                    flpHinhSP.Controls.Add(t);
                }
                for (int i = 0; i < tenhinh.Count(); i++)
                {
                    name = Path.GetFileName(tenhinh[i].ToString()) + ";";
                    txtAnh.Text += name;
                }
            }

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UploadNhiềuHinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnPic_Click(sender, e);
        }

        private void MnColor_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.Color = txtTenSP.ForeColor;
            c.ShowDialog();
            txtTenSP.ForeColor = c.Color;
        }

        private void MnFont_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.Font = txtTenSP.Font;
            f.ShowDialog();
            txtTenSP.Font = f.Font;
        }

        private void FrmSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnThoat.PerformClick();
            }
        }

        private void DrgDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status != 3)
            {
                int vt = drgDSSP.CurrentCell.RowIndex;
                ShowInTextBox(vt);
                status_button(true);
            }
        }

        private void CbbMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(flag)
                MessageBox.Show("Mã loại:"+ cbbLoaiSP.SelectedValue.ToString(), "Thông báo");
        }

        private void FrmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (status != 0)
            {
                DialogResult dlg = new DialogResult();
                dlg = MessageBox.Show("Bạn có muốn lưu không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                    BtnLuu_Click(sender, e);
            }
            else
            {
                DialogResult dlgHoiThoat = new DialogResult();
                dlgHoiThoat = MessageBox.Show("Bạn có chắc thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dlgHoiThoat == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            status = 0;
            status_textbox(true);
            status_button(true);
        }

        private void TxtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void TxtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void TxtGB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
