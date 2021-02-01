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
    public partial class frmSearchSP : Form
    {
        public frmSearchSP()
        {
            InitializeComponent();
        }
        clsqlbanhang c = new clsqlbanhang();
        private void TxtNhap_TextChanged(object sender, EventArgs e)
        {
            if (cbbOption.Text != "Lựa chọn tìm kiếm")
            {
                if (txtNhap.Text != "")
                {
                    DataSet ds = new DataSet();
                    string opt = cbbOption.SelectedItem.ToString();
                    string sql = "Select idproduct,name,entry_price,price from products where";
                    string sqlcat = "Select idproduct,name,entry_price,price from products,category where";

                    if (opt == "Theo tên")
                    {
                        sql += " name like '%" + txtNhap.Text + "%'";
                    }

                    if (opt == "Theo mã sản phẩm")
                    {
                        sql += " idproduct like '%" + txtNhap.Text + "%'";
                    }

                    if (opt == "Theo loại")
                    {
                        sqlcat += " products.idcat=category.idcat and category.title like '%" + txtNhap.Text + "%'";
                    }


                    if (opt == "Theo loại")
                        ds = c.LoadData(sqlcat);
                    else
                        ds = c.LoadData(sql);

                    dgrDSSP.DataSource = ds.Tables[0];
                }
                else
                    MessageBox.Show("Nhập từ khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Hãy chọn phương thức tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void FrmSearchSP_Load(object sender, EventArgs e)
        {
        }

        private void FrmSearchSP_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgHoiThoat;
            dlgHoiThoat = MessageBox.Show("Bạn có chắc thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dlgHoiThoat == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
    }
}
