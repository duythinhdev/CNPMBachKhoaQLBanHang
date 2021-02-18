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
        DataTable dt = new DataTable();
        public string sql;
        public frmSanPhamKhuyenMai()
        {
            InitializeComponent();
        }
        private void frmSanPhamKhuyenMai_Load(object sender, EventArgs e)
        {
            dgrSanPham.ReadOnly = true;
            LoadSanPham();
            LoadComboboxKhuyenMai();
        }
        public void LoadSanPham()
        {
            sql = "select idproduct,name,idcat,image,quantity,price,status from products";
            ds = clsqlbanhang.LoadData(sql);
            dgrSanPham.DataSource = ds.Tables[0];
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void LoadComboboxKhuyenMai()
        {
            sql = "select * from discount";
            ds = clsqlbanhang.LoadData(sql);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "nameDiscount";
            comboBox1.ValueMember = "idDiscount";
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
        }
        public int id;
        private void btnThem_Click(object sender, EventArgs e)
        {

            //int idSanPham = int.Parse(dgrSanPham.SelectedCells[0].Value.ToString());
            int idKhuyenMai = int.Parse(comboBox1.SelectedValue.ToString());
            sql = "insert into product_discount (id_product,id_discount) values ('" + id
                + "','" + idKhuyenMai + "')";
            clsqlbanhang.UpdateData(sql);
        }

        private void dgrSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             id = row.Cells["idDataGridViewTextBoxColumn"].Value;
        }

        private void dgrSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


        }
    }
}
