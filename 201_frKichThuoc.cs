using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Project
{
    public partial class frmKichThuoc : Form
    {
        public frmKichThuoc()
        {
            InitializeComponent();
        }
        clsqlbanhang c = new clsqlbanhang();
        int vt = 0;
        int t = 0;
        DataSet ds = new DataSet();

        void hienthilen_textbox(DataSet ds, int vt)
        {
            if(ds.Tables[0].Rows.Count > 0)
            {
                txtMaKT.Text = ds.Tables[0].Rows[vt][0].ToString();
                txtTenKT.Text = ds.Tables[0].Rows[vt][1].ToString();
                txtGhiChu.Text = ds.Tables[0].Rows[vt][2].ToString();
            }

        }

        void xulycacchucnang(Boolean t)
        {
            btnAdd.Enabled = t;
            btnEdit.Enabled = t;
            btnDel.Enabled = t;
            btnSave.Enabled = !t;
        }
        void Trangthaitextbox(Boolean t)
        {
            txtMaKT.ReadOnly = t;
            txtTenKT.ReadOnly = t;
            txtGhiChu.ReadOnly = t;
        }

        void hienthidanhsach_khachhang()
        {
            vt = 0;
            Trangthaitextbox(true);
            xulycacchucnang(true);

            ds = c.LoadData("SELECT * FROM `size` WHERE active = 1");
            dataGridView1.DataSource = ds.Tables[0];
            hienthilen_textbox(ds, vt);
        }

        private void frmKichThuoc_Load(object sender, EventArgs e)
        {
            vt = 0;
            Trangthaitextbox(true);
            xulycacchucnang(true);

            ds = c.LoadData("select * from size where active = 1");
            dataGridView1.DataSource = ds.Tables[0];
            hienthilen_textbox(ds, vt);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKichThuoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dglKqua;
            dglKqua = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dglKqua == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Trangthaitextbox(false);
            txtMaKT.Focus();
            xulycacchucnang(false);
            t = 1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Trangthaitextbox(false);
            txtMaKT.ReadOnly = true;
            xulycacchucnang(false);
            t = 2;
        }

        int Kiemtrakhachhang(string v)
        {
            string sql = "select count(idsize) from size where idsize='" + v + "'";
            DataSet dsSanpham = c.LoadData(sql);

            return int.Parse(dsSanpham.Tables[0].Rows[0][0].ToString());


        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            Trangthaitextbox(false);
            t = 3;
            if (MessageBox.Show("Ban co muon xoa khong?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "";
                if (Kiemtrakhachhang(txtMaKT.Text) == 0)
                {
                    sql = "delete from size where idsize = '" + txtMaKT.Text + "'";
                }
                else
                {
                    sql = "update size set active = '0' where idsize ='" + txtMaKT.Text + "'";
                }
                if (c.UpdateData(sql) > 0)
                {
                    MessageBox.Show("Cập nhập thành công");
                    hienthidanhsach_khachhang();
                    t = 0;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            xulycacchucnang(true);
            Trangthaitextbox(true);
            if (t == 1) //thêm
            {
                string sql = "insert into size (idsize,size,note) values ('" + txtMaKT.Text + "','" + txtTenKT.Text + "','" + txtGhiChu.Text + "')";
                if (c.UpdateData(sql) > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    t = 0;
                    hienthidanhsach_khachhang();
                }
            }
            if (t == 2)//sua
            {
                string sql = "update size set size = '" + txtTenKT.Text + "', note = '"+txtGhiChu.Text+"' where idsize ='" + txtMaKT.Text + "'";
                if (c.UpdateData(sql) > 0)
                {
                    MessageBox.Show("Update thành công");
                    t = 0;
                    hienthidanhsach_khachhang();
                }
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            vt = 0;
            hienthilen_textbox(ds, vt);
            btnDau.Enabled = false;
            btnCuoi.Enabled = true;
            btnlui.Enabled = false;
            btntoi.Enabled = true;
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            vt = ds.Tables[0].Rows.Count - 1;
            hienthilen_textbox(ds, vt);
            btnDau.Enabled = true;
            btnCuoi.Enabled = false;
            btntoi.Enabled = false;
            btnlui.Enabled = true;
           
        }

        private void btnlui_Click(object sender, EventArgs e)
        {
            if (vt <= 0)
            {
                btnlui.Enabled = false;
                btnDau.Enabled = false;
                btntoi.Enabled = true;
                btnCuoi.Enabled = true;
            }
            else
            {
                vt = vt - 1;
                
                btnlui.Enabled = true;
                btntoi.Enabled = true;
                btnCuoi.Enabled = true;
                btnDau.Enabled = true;
                hienthilen_textbox(ds, vt);
               
            }
        }

        private void btntoi_Click(object sender, EventArgs e)
        {
        
            if (vt >= ds.Tables[0].Rows.Count - 1)
            {
                btnlui.Enabled = true;
                btnDau.Enabled = true;
                btntoi.Enabled = false;
                btnCuoi.Enabled = false;
                vt = ds.Tables[0].Rows.Count - 1;
            }
            else
            {
                vt = vt + 1;
                
                btnlui.Enabled = true;
                btnCuoi.Enabled = true;
                btnDau.Enabled = true;
                hienthilen_textbox(ds, vt);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(t!=3)
            {
                vt = dataGridView1.CurrentCell.RowIndex;
                hienthilen_textbox(ds, vt);
            }

        }
    }
}
