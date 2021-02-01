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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
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
                txtMaKH.Text = ds.Tables[0].Rows[vt]["idcustomer"].ToString();
                txtTenKH.Text = ds.Tables[0].Rows[vt]["name"].ToString();
                txtDiaChi.Text = ds.Tables[0].Rows[vt]["address"].ToString();
                txtFaceBook.Text = ds.Tables[0].Rows[vt]["facebook"].ToString();
                txtPhone.Text = ds.Tables[0].Rows[vt]["phone"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[vt]["email"].ToString();
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
            txtMaKH.ReadOnly = t;
            txtTenKH.ReadOnly = t;
            txtPhone.ReadOnly = t;
            txtDiaChi.ReadOnly = t;
            txtFaceBook.ReadOnly = t;
            txtEmail.ReadOnly = t;
        }

        int Kiemtrakhachhang(string MaKH)
        {
            string sql = "select count(idcustomer) from customer where idcustomer='" + MaKH + "'";
            DataSet dsSanpham = c.LoadData(sql);

            return int.Parse(dsSanpham.Tables[0].Rows[0][0].ToString());


        }


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Trangthaitextbox(false);
            txtMaKH.Focus();
            xulycacchucnang(false);
            t = 1;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            Trangthaitextbox(true);
            xulycacchucnang(true);

            ds = c.LoadData("select * from customer where status = 1");
            dataGridView1.DataSource = ds.Tables[0];
            hienthilen_textbox(ds, vt);
        }

        private void txtMaKH_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dglKqua;
            dglKqua = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dglKqua == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            Trangthaitextbox(false);
            txtMaKH.ReadOnly = true;
            xulycacchucnang(false);
            t = 2;
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            Trangthaitextbox(false);
            t = 3;
            if (MessageBox.Show("Ban co muon xoa khong?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "";
                if (Kiemtrakhachhang(txtMaKH.Text) == 0)
                {
                    sql = "delete from customer where idcustomer = '" + txtMaKH.Text + "'";
                }
                else
                {
                    sql = "update customer set status = '0' where idcustomer ='" + txtMaKH.Text + "'";
                }
                if (c.UpdateData(sql) > 0)
                {
                    MessageBox.Show("Cập nhập thành công");
                    hienthidanhsach_khachhang();
                    t = 0;
                }
            }
        }

        void hienthidanhsach_khachhang()
        {
            vt = 0;
            Trangthaitextbox(true);
            xulycacchucnang(true);

            ds = c.LoadData("select * from customer where status = 1");
            dataGridView1.DataSource = ds.Tables[0];
            hienthilen_textbox(ds, vt);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            xulycacchucnang(true);
            Trangthaitextbox(true);
            if (t == 1) //thêm
            {
                string sql = "insert into customer(idcustomer,name,address,facebook,phone,email) values ('" + txtMaKH.Text + "','" + txtTenKH.Text + "','" + txtDiaChi.Text + "','" + txtFaceBook.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "')";
                if (c.UpdateData(sql) > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    t = 0;
                    hienthidanhsach_khachhang();
                }
            }
            if (t == 2)//sua
            {
                string sql = "update customer set name = '" + txtTenKH.Text + "', address='" + txtDiaChi.Text + "',facebook='" + txtFaceBook.Text + "',email='" + txtEmail.Text + "' where idcustomer ='" + txtMaKH.Text + "'";
                if (c.UpdateData(sql) > 0)
                {
                    MessageBox.Show("Update thành công");
                    t = 0;
                    hienthidanhsach_khachhang();
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
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
