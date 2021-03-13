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
        public string idProducts;
        public int idDiscount;
        public int flagSave;
        public frmSanPhamKhuyenMai()
        {
            InitializeComponent();
        }
        private void frmSanPhamKhuyenMai_Load(object sender, EventArgs e)
        {
            dgrSanPham.ReadOnly = true;
            dgrKhuyenMai.ReadOnly = true;
            LoadProducts();
            LoadComboboxDiscount();
        }
        public void LoadProducts()
        {
            sql = "select idproduct,name,idcat,image,quantity,price,status from products";
            ds = clsqlbanhang.LoadData(sql);
            dgrSanPham.DataSource = ds.Tables[0];
        }
        public void LoadComboboxDiscount()
        {
            sql = "select *  from discount where status = 1";
            ds = clsqlbanhang.LoadData(sql);
            cbbKhuyenMai.DataSource = ds.Tables[0];
            cbbKhuyenMai.DisplayMember = "nameDiscount";
            cbbKhuyenMai.ValueMember = "idDiscount";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flagSave = 1;
            status_button(false);
        }

        private void dgrSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProduct = e.RowIndex;
            idProducts = dgrSanPham.Rows[idProduct].Cells[0].Value.ToString();
            MessageBox.Show(idProducts);

        }
        public void sanPhamKhuyenMai()
        {
            sql = "SELECT DISTINCT products.idproduct, products.name,products.price FROM products INNER JOIN product_discount ON products.idproduct = product_discount.idProduct ";
            ds = clsqlbanhang.LoadData(sql);
            dgrKhuyenMai.DataSource = ds.Tables[0];
        }

        private void cbbKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cbbKhuyenMaiLoad = cbbKhuyenMai.Text;
            sql = "select DISTINCT products.idproduct, products.name,products.price " +
                "FROM discount,product_discount,products  where nameDiscount=N'" + cbbKhuyenMaiLoad+ "' " +
                "and discount.idDiscount = product_discount.idDiscount and products.idproduct = product_discount.idProduct ";
            showValueFollowCbbKhuyenMai(sql);
        }
        public void showValueFollowCbbKhuyenMai(string sql)
        {
            ds = clsqlbanhang.LoadData(sql);
            dgrKhuyenMai.DataSource = ds.Tables[0];
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            sql = "SELECT  * FROM  product_discount WHERE  idProduct = '" + idProducts+ "' and idDiscount ='"+idDiscount+"'";
            ds = clsqlbanhang.LoadData(sql);
            int checkValue = ds.Tables[0].Rows.Count;
            if (checkValue == 0)
            {
                switch (flagSave)
                {
                    case 1:
                        idDiscount = int.Parse(cbbKhuyenMai.SelectedValue.ToString());
                        sql = "insert into product_discount (idProduct,idDiscount) values ('" + idProducts + "','" + idDiscount + "')";
                        clsqlbanhang.UpdateData(sql);
                        sanPhamKhuyenMai();
                        break;
                    case 2:
                        sql = "DELETE FROM product_discount WHERE idProduct = '" + productes + "'";
                        clsqlbanhang.UpdateData(sql);
                        sanPhamKhuyenMai();
                        break;
                }
            }
            else if(checkValue > 0 )
            {
                MessageBox.Show("idproduct " + idProducts + " Record Already in database");
            }
            status_button(true);
        }
        public string productes;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            flagSave = 2;
            status_button(false);
        }

        private void dgrKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProduct = e.RowIndex;
            productes = dgrKhuyenMai.Rows[idProduct].Cells[0].Value.ToString();
            MessageBox.Show(productes);
        }
        public void status_button(Boolean t)
        {
            btnThem.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
            btnHuy.Enabled = !t;
        }

        private void frmSanPhamKhuyenMai_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgHoiThoat = new DialogResult();
            dlgHoiThoat = MessageBox.Show("Bạn có chắc thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dlgHoiThoat == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            status_button(true);
        }
    }
}
