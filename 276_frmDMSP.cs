using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmLoaiSP : Form
    {
        public frmLoaiSP()
        {
            InitializeComponent();
        }

        clsqlbanhang c = new clsqlbanhang();
        DataSet ds = new DataSet();
        int status = 0;
        string table = "category";

        void status_textbox(Boolean t)
        {
            txtMaLoai.ReadOnly = true;
            txtName.ReadOnly = t;
        }
        void status_button(Boolean t)
        {
            btnLuu.Enabled = !t;
            btnThem.Enabled = t;
            btnXoa.Enabled = t;
            btnSua.Enabled = t;
            btnHuy.Enabled = !t;
        }

        string CreateID()
        {
            string id = "";
            ds = c.LoadData("Select idcat from category");
            if (ds.Tables[0].Rows.Count <= 0)
            {
                id = "DM001";
            }
            else
                id = "DM00" + (ds.Tables[0].Rows.Count + 1).ToString();

            return id;
        }

        void ShowInTextBox(int vt)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtMaLoai.Text = ds.Tables[0].Rows[vt]["idcat"].ToString();
                txtName.Text = ds.Tables[0].Rows[vt]["title"].ToString();
                cbbTinhTrang.Text = ds.Tables[0].Rows[vt]["status"].ToString();
            }
        }

        void ShowTableCat()
        {
            int vt = 0;
            ds = c.LoadData("Select idcat,title,status,active from "+ table +" where active = 1");
            dgrDMSP.DataSource = ds.Tables[0];
            ds.Tables[0].Columns.Add("STT");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["STT"] = (i + 1).ToString();
            }

            dgrDMSP.Columns["STT"].DisplayIndex = 0;
            ShowInTextBox(vt);
        }

        void UpdateDataTable(string sql)
        {
            if (c.UpdateData(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                ShowTableCat();
            }
        }

        private void FrmDSsanpham_Load(object sender, EventArgs e)
        {
            status_textbox(true);
            status_button(true);
            if (dgrDMSP.Rows.Count >= 0)
            {
                ShowTableCat();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            status_textbox(false);
            status_button(false);
            status = 1;
            txtMaLoai.Text = CreateID();
            txtName.Focus();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            status_button(true);
            string id = txtMaLoai.Text;
            string name = txtName.Text;
            string statuss = cbbTinhTrang.Text;

            if(status == 1)
            {
                string sql = "INSERT INTO " + table + " (idcat,title, status) VALUES ('"+id+"','" + name + "','" + statuss + "')";
                UpdateDataTable(sql);
            }
            if(status == 2)
            {
                string sql = "UPDATE " + table + " SET title='" + name + "',status='" + statuss + "' WHERE idcat = '" + id + "'";
                UpdateDataTable(sql);
            }
            status = 0;
            txtMaLoai.Clear();
            txtName.Clear();
            cbbTinhTrang.Text = "";
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            status_button(true);
            status = 3;
            string id = txtMaLoai.Text;
            string sql = "UPDATE " + table + " SET active = 0 WHERE idcat = '" + id + "'";
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.Yes)
            {
                if (c.UpdateData(sql) > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    ShowTableCat();
                    status = 0;
                }
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLoaiSP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(status!=0)
            {
                DialogResult dlg = new DialogResult();
                dlg = MessageBox.Show("Bạn có muốn lưu không ?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dlg == DialogResult.Yes)
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

        private void DgrDMSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status != 3)
            {
                int vt = dgrDMSP.CurrentCell.RowIndex;
                ShowInTextBox(vt);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            status_textbox(false);
            status_button(false);
            status = 2;
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            status = 0;
            status_textbox(true);
            status_button(true);
        }
    }
}
