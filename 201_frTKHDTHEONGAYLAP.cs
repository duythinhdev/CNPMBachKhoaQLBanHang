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
    public partial class frmTKHDTHEONGAYLAP : Form
    {
        public frmTKHDTHEONGAYLAP()
        {
            InitializeComponent();
        }
        clsqlbanhang c = new clsqlbanhang();
        private void frmTKHDTHEONGAYLAP_Load(object sender, EventArgs e)
        {

            
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (dtpNgayLapHoaDon.Text != "")
            {
                string sql = "select * from bill where date_founded like '%" + dtpNgayLapHoaDon.Text + "%'";
                ds = c.LoadData(sql);
                dtrDS.DataSource = ds.Tables[0];
            }
        }
    }
}
