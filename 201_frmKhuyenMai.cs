using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Project
{
    public partial class KhuyenMai : Form
    {
        clsqlbanhang clsqlbanhang = new clsqlbanhang();
        DataSet ds = new DataSet();
        MySqlCommand com;
        string str;
        public KhuyenMai()
        {
            InitializeComponent();
        }

        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            dsKhuyenMai();
            txtIdDiscount.ReadOnly = true;
            //loadcombobox();
        }
        public int status;
        public void loadcombobox()
        {

           /* Dictionary<int, string> comboSource = new Dictionary<int, string>();
            comboSource.Add(0, "on");
            comboSource.Add(1, "off");
            comboBox1.DataSource = new BindingSource(comboSource, null);
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Value";*/
        }
        public void loadAuToID()
        {
            str = "select count(*) from employee";
            ds = clsqlbanhang.LoadData(str);
            int count = Convert.ToInt16(com.ExecuteScalar()) + 1;
            txtIdDiscount.Text = "000" + count;
        }

        public void dsKhuyenMai()
        {
            ds = clsqlbanhang.LoadData("Select idDiscount,nameDiscount,moneyDiscount,status from discount");
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
            int RowIndex = e.RowIndex;
            DataGridViewRow selectedRows = dtgrKhuyenMai.Rows[RowIndex];
            txtIdDiscount.Text = selectedRows.Cells[0].Value.ToString();
            txtNameDiscount.Text = selectedRows.Cells[1].Value.ToString();
            txtMoneyDiscount.Text = selectedRows.Cells[2].Value.ToString();
        }

      
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {            
            string sql = "insert into discount (nameDiscount,moneyDiscount,status) values ('" + txtNameDiscount.Text + "','" + txtMoneyDiscount.Text + "','" + status + "')";
            clsqlbanhang.UpdateData(sql);
            dsKhuyenMai();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           string sql = "update discount set nameDiscount='"+txtNameDiscount.Text+ "', moneyDiscount='" + txtMoneyDiscount.Text + "',status='" + status + "' where idDiscount='" + txtIdDiscount.Text+"'";
           clsqlbanhang.UpdateData(sql);
           dsKhuyenMai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from discount where  idDiscount='"+ txtIdDiscount.Text+ "'";
            clsqlbanhang.UpdateData(sql);

            dsKhuyenMai();
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            txtIdDiscount.Text = "";
            txtNameDiscount.Text = "";
            txtMoneyDiscount.Text = "";

        }

        private void dtgrKhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            status = 0;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            status = 1;
        }
    }
}
