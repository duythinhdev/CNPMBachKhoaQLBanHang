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
    public partial class frmTimKiemKhachHangTheoTen : Form
    {
        public frmTimKiemKhachHangTheoTen()
        {
            InitializeComponent();
        }

        clsqlbanhang c = new clsqlbanhang();

        private void frmTimKiemKhachHangTheoTen_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = c.LoadData("Select * from khachhang").Tables[0];
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (txtTen.Text != "")
            {
                string sql = "select * from customer where name like '%" + txtTen.Text + "%' or phone like '%" + txtTen.Text + "%' or facebook like '%" + txtTen.Text + "%' or email like '%" + txtTen.Text + "%'";
                ds = c.LoadData(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
