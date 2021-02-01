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
    public partial class frmSearchHD : Form
    {
        public frmSearchHD()
        {
            InitializeComponent();
        }
        //clsqlsanpham c = new clsqlsanpham();
        clsqlbanhang c = new clsqlbanhang();
        private void frmTKHDTHEOTT_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = c.Laydulieu("Select * from khachhang").Tables[0];
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (dtpNgayLapHoaDon.Text != "")
            {

                string sql = "select * from bill where date_founded = '" + dtpNgayLapHoaDon.Text + "'";
                string sql_id = "select * from bill where idbill = '" + txtTuKhoa.Text + "'";
                if (ckbNgay.Checked == true)
                {
                    ds = c.LoadData(sql);
                    dtrDS.DataSource = ds.Tables[0];
                }
                else
                {
                    ds = c.LoadData(sql_id);
                    dtrDS.DataSource = ds.Tables[0];
                }


            }

        }
    }
}
