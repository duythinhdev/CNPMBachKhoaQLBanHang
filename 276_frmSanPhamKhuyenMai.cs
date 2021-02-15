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
    public partial class frmSanPhamKhuyenMai : Form
    {
        clsqlbanhang clsqlbanhang = new clsqlbanhang();
        DataSet ds = new DataSet();
        public string sql;
        public frmSanPhamKhuyenMai()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSanPhamKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }
        public void LoadSanPham()
        {
            sql = "select idproduct,name,idcat,image,quantity,price,status from products";
            ds = clsqlbanhang.LoadData(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
