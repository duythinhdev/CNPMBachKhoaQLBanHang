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
    public partial class frmHD : Form
    {
        public frmHD()
        {
            InitializeComponent();
        }
        clsqlbanhang c = new clsqlbanhang();
        string table = "bill";
        DataSet ds = new DataSet();
        DataSet dssp = new DataSet();
        DataSet dscthd = new DataSet();
        DataSet dsnv = new DataSet();
        DataSet dskh = new DataSet();
        int status = 0;
        string idcustomer = "";

        void status_textbox(Boolean t)
        {
            txtKhuyenMai.ReadOnly = t;
            txtSL.ReadOnly = t;
            txtTenSP.ReadOnly = t;
            txtMaSP.ReadOnly = t;
            txtPhoneKH.ReadOnly = t;
            txtGiaBan.ReadOnly = t;
            txtTenKH.ReadOnly = t;
            cbbTenNV.Enabled = !t;
            cbbTrangThai.Enabled = !t;
            dtpNgayLap.Enabled = !t;
        }
        void status_button(Boolean t)
        {
            btnLuu.Enabled = !t;
            btnXoa.Enabled = t;
            btnSua.Enabled = t;
        }

        void ShowInTextBox(int vt)
        {
            if(ds.Tables[0].Rows.Count > 0)
            {
                string mahd = txtMaHĐ.Text = ds.Tables[0].Rows[vt]["idbill"].ToString();
                string makh = ds.Tables[0].Rows[vt]["idcustomer"].ToString();
                string manv = ds.Tables[0].Rows[vt]["idemployee"].ToString();
                dscthd = c.LoadData("Select idproduct,quantity,discount,price,total from bill_detail where idbill = '" + mahd + "'");
                dskh = c.LoadData("Select name,phone from customer where idcustomer = '" + makh + "'");
                dsnv = c.LoadData("Select name from employees where idemployee = '" + manv + "'");
                dgvCTHD.DataSource = dscthd.Tables[0];
                dtpNgayLap.Text = ds.Tables[0].Rows[vt]["date_founded"].ToString();
                txtThanhTien.Text = ds.Tables[0].Rows[vt]["total"].ToString();
                txtTenKH.Text = dskh.Tables[0].Rows[0]["name"].ToString();
                cbbTrangThai.Text = ds.Tables[0].Rows[vt]["status"].ToString();
                txtPhoneKH.Text = "0" + dskh.Tables[0].Rows[0]["phone"].ToString();
                cbbTenNV.Text = dsnv.Tables[0].Rows[0]["name"].ToString();
                //dssp = c.LoadData("Select name,price,image from products where idproduct = '" + dscthd.Tables[0].Rows[0]["idproduct"].ToString() + "'");


                //string masp = txtMaSP.Text = dscthd.Tables[0].Rows[vt]["idproduct"].ToString();
                //dssp = c.LoadData("Select name,price,image from products where idproduct = '" + masp + "'");
                //txtTenSP.Text = dssp.Tables[0].Rows[0]["name"].ToString();
                //txtGiaBan.Text = dssp.Tables[0].Rows[0]["price"].ToString();
            }
        }

        void ShowInTextBoxSP()
        {
            string path = @"D:\LearnC#\Project\bin\Image";
            txtMaSP.Text = dgvCTHD.CurrentRow.Cells[0].Value.ToString();
            txtSL.Text = dgvCTHD.CurrentRow.Cells[1].Value.ToString();
            txtKhuyenMai.Text = dgvCTHD.CurrentRow.Cells[2].Value.ToString();
            dssp = c.LoadData("Select name,price,image from products where idproduct = '" + txtMaSP.Text + "' ");
            txtTenSP.Text = dssp.Tables[0].Rows[0]["name"].ToString();
            txtGiaBan.Text = dssp.Tables[0].Rows[0]["price"].ToString();
            string img = dssp.Tables[0].Rows[0]["image"].ToString();
            string[] arrlistimg = img.Split(new char[] { ';' }).ToArray();
            DirectoryInfo di = new DirectoryInfo(path);
            flpSanPham.Controls.Clear();
            for (int i = 0; i < arrlistimg.Count(); i++)
            {
                FileInfo[] fis = di.GetFiles(arrlistimg[i].ToString());
                foreach (FileInfo f in fis)
                {
                    PictureBox t = new PictureBox();
                    t.Width = 50;
                    t.Height = 50;
                    byte[] by = File.ReadAllBytes(f.FullName);
                    MemoryStream ms = new MemoryStream(by);
                    Bitmap image = new Bitmap(ms);
                    t.Image = image;
                    t.SizeMode = PictureBoxSizeMode.StretchImage;

                    flpSanPham.Controls.Add(t);
                }
            }

        }

        void ShowTable()
        {
            int vt = 0;
            ds = c.LoadData("Select idbill,idemployee,idcustomer,date_founded,total,status from " + table + " where active = 1");
            dgrHD.DataSource = ds.Tables[0];
            ds.Tables[0].Columns.Add("STT");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["STT"] = (i + 1).ToString();
            }

            dgrHD.Columns["STT"].DisplayIndex = 0;
            dgrHD.Columns["STT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ShowInTextBox(vt);
        }

        private void FrmHD_Load(object sender, EventArgs e)
        {
            status_textbox(true);
            status_button(true);
            txtMaSP.Focus();
            ShowTable();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHD_FormClosing(object sender, FormClosingEventArgs e)
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

        void UpdateDataTable(string sql)
        {
            if (c.UpdateData(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                ShowTable();
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            string idbill = txtMaHĐ.Text;
            string idcustomers = idcustomer;
            string date = dtpNgayLap.Text;
            //string total = hd_total.ToString();
            string statuss = cbbTrangThai.Text;
            string idemployee = cbbTenNV.SelectedValue.ToString();
            MessageBox.Show("'" + idemployee + "'");
            if (status == 2)
            {
                if (idcustomers != "")
                {
                    string sql = "UPDATE bill SET idcustomer='" + idcustomer + "',idemployee='" + idemployee + "',date_founded='" + date + "',status='" + statuss + "' WHERE idbill = '" + txtMaHĐ.Text + "'";
                    UpdateDataTable(sql);
                }
                else
                    MessageBox.Show("Nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            txtThanhTien.Clear();
            txtSL.Clear();
            txtMaHĐ.Clear();
            txtKhuyenMai.Clear();
            txtGiaBan.Clear();
            txtMaSP.Clear();
            txtTenSP.Clear();
            status = 0;
        }

        void LoadTableEmployees()
        {
            dsnv = c.LoadData("Select * from employees");
            cbbTenNV.DataSource = dsnv.Tables[0];
            cbbTenNV.DisplayMember = "name";
            cbbTenNV.ValueMember = "idemployee";
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            status_textbox(false);
            status_button(false);
            LoadTableEmployees();
            btnSearchKH.PerformClick();
            status = 2;
        }

        private void DgrHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status != 3)
            {
                int vt = dgrHD.CurrentCell.RowIndex;
                ShowInTextBox(vt);
                status_button(true);
            }
        }

        private void DgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(status != 3)
            {
                ShowInTextBoxSP();
                status_button(true);
            }
        }

        private void TxtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void TxtKhuyenMai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void TxtPhoneKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        DataSet SearchKH(string phone)
        {
            dskh = c.LoadData("Select idcustomer,name from customer where phone = '" + phone + "'");

            return dskh;
        }

        private void BtnSearchKH_Click(object sender, EventArgs e)
        {
            dskh = SearchKH(txtPhoneKH.Text);
            if (dskh.Tables[0].Rows.Count == 0)
                txtTenKH.Text = "Khách hàng không tồn tại";
            else
            {
                txtTenKH.Text = dskh.Tables[0].Rows[0]["name"].ToString();
                idcustomer = dskh.Tables[0].Rows[0]["idcustomer"].ToString();
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            status_button(true);
            status = 3;
            string id = txtMaHĐ.Text;
            string sql = "UPDATE " + table + " SET active = 0 WHERE idbill = '" + id + "'";
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (c.UpdateData(sql) > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    ShowTable();
                    status = 0;
                }
            }
        }
    }
}
