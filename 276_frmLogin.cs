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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        clsqlbanhang c = new clsqlbanhang();


        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDN_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string sql = "Select count(idemployee),permission,name from employees where idemployee = '" + txtMaNV.Text + "'";
            ds = c.LoadData(sql);
            int value = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            if (value == 1)
            {
                this.Hide();
                frmMain frm = new frmMain(ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString());
                frm.Show();
                //((Form)frm).Controls["toolStripStatusLabel"].Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
                MessageBox.Show("Mã nhân viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void TxtMaNV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnDN.PerformClick();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
