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
    public partial class KhuyenMai : Form
    {
        clsqlbanhang c = new clsqlbanhang();
        DataSet ds = new DataSet();
        public KhuyenMai()
        {
            InitializeComponent();
        }

        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            dsKhuyenMai();
        }

        public void dsKhuyenMai()
        {
            ds = c.LoadData("Select idDiscount,nameDiscount,percentDiscount,moneyDiscount from discount");
            dtgrKhuyenMai.DataSource = ds.Tables[0];
        }

        private void grbChucNang_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgrKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            DataGridViewRow selectedRows = dtgrKhuyenMai.Rows[ind];
            txtIdDiscount.Text = selectedRows.Cells[0].Value.ToString();
            txtNameDiscount.Text = selectedRows.Cells[1].Value.ToString();
            txtPercentDiscount.Text = selectedRows.Cells[2].Value.ToString();
            txtMoneyDiscount.Text = selectedRows.Cells[3].Value.ToString();
        }

      
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
