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
        public string id;
        public int idKhuyenMai;
        public frmSanPhamKhuyenMai()
        {
            InitializeComponent();
        }
        private void frmSanPhamKhuyenMai_Load(object sender, EventArgs e)
        {
            dgrSanPham.ReadOnly = true;
            LoadSanPham();
            LoadComboboxKhuyenMai();
            sanPhamKhuyenMai();
        }
        public void LoadSanPham()
        {
            sql = "select idproduct,name,idcat,image,quantity,price,status from products";
            ds = clsqlbanhang.LoadData(sql);
            dgrSanPham.DataSource = ds.Tables[0];
        }
        public void LoadComboboxKhuyenMai()
        {
            sql = "select *  from discount";
            ds = clsqlbanhang.LoadData(sql);
            cbbKhuyenMai.DataSource = ds.Tables[0];
            cbbKhuyenMai.DisplayMember = "nameDiscount";
            cbbKhuyenMai.ValueMember = "idDiscount";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            idKhuyenMai = int.Parse(cbbKhuyenMai.SelectedValue.ToString());
            sql = "insert into product_discount (idProduct,idDiscount) values ('" + id
                + "','" + idKhuyenMai + "')";
            clsqlbanhang.UpdateData(sql);
            sanPhamKhuyenMai();

        }

        private void dgrSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                id = dgrSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(dgrSanPham.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        public void sanPhamKhuyenMai()
        {
            sql = "SELECT products.idproduct, products.name,products.price FROM products LEFT JOIN product_discount ON products.idproduct = product_discount.idProduct";
            ds = clsqlbanhang.LoadData(sql);
            dgrKhuyenMai.DataSource = ds.Tables[0];
        }

        private void cbbKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cbbKhuyenMaiLoad = cbbKhuyenMai.Text;
            sql = "select products.idproduct, products.name,products.price FROM discount,product_discount,products  where nameDiscount=N'" + cbbKhuyenMaiLoad+ "' and discount.idDiscount = product_discount.idDiscount and products.idproduct = product_discount.idProduct";
            showValueFollowCbbKhuyenMai(sql);
        }
        public void showValueFollowCbbKhuyenMai(string sql)
        {
            ds = clsqlbanhang.LoadData(sql);
            dgrKhuyenMai.DataSource = ds.Tables[0];
        }
    }
}
