using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class frmCTHD : Form
    {
        public frmCTHD()
        {
            InitializeComponent();
        }

        clsqlbanhang c = new clsqlbanhang();
        DataSet dsnv = new DataSet();
        DataSet dssp = new DataSet();
        DataSet dshd = new DataSet();
        DataSet dskh = new DataSet();
        DataSet listDetailProduct = new DataSet();
        string idcusctomer = "";
        int status = 0;
        float hd_total = 0;
        public string sql;

        string CreateID()
        {
            
            string idbill = "";
            dshd = c.LoadData("Select idbill from bill");
            if (dshd.Tables[0].Rows.Count <= 0)
            {
                idbill = "HD001";
            }
            else
                idbill = "HD00" + (dshd.Tables[0].Rows.Count+1).ToString();

            return idbill;
        }

        void status_textbox(Boolean t)
        {
            txtKhuyenMai.ReadOnly = t;
            txtSL.ReadOnly = t;
            /*cbbTenSp.ReadOnly = t;*/
            txtMaSP.ReadOnly = t;
            txtPhoneKH.ReadOnly = t;
            txtGiaBan.ReadOnly = t;
            txtTenKH.ReadOnly = t;
            cbbTenNV.Enabled = !t;
            cbbTrangThai.Enabled = !t;
            dtpNgayLap.Enabled = !t;
            txtTenKhuyenMai.ReadOnly = t;
        }
        void status_button(Boolean t)
        {
            btnLuu.Enabled = !t;
            btnThem.Enabled = t;
            btnXoa.Enabled = t;
            btnSua.Enabled = t;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            status_textbox(false);
            status_button(false);
            txtMaSP.ReadOnly = true;
            status = 1;
            txtMaHĐ.Text = CreateID();
            txtMaHĐ.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            status_textbox(false);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            txtKhuyenMai.Clear();
            txtMaHĐ.Clear();
            txtSL.Clear();
            txtThanhTien.Clear();
            status_button(true);
        }

        void UpdateDataTable(string sql)
        {
            if (c.UpdateData(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            status_textbox(true);
            status_button(true);
            string idbill = txtMaHĐ.Text;
            string idcustomers = idcusctomer;
            string date = dtpNgayLap.Text;
            string total = hd_total.ToString();
            string statuss = cbbTrangThai.Text;
            string idemployee = cbbTenNV.SelectedValue.ToString();

            //Hoa don
            if (status == 1)
            {
                if(idbill != "")
                {
                    sql = "INSERT INTO bill(idbill,idcustomer,idemployee,date_founded,total,status) VALUES ('" + idbill + "','" + idcustomers + "','" + idemployee + "','" + date + "','" + total + "','" + statuss + "')";
                    UpdateDataTable(sql);
                }
            }
            //Chi tiet hoa don
            for (int i = 0; i < dgvCTHD.Rows.Count ; i++)
            {
                string idproduct = dgvCTHD.Rows[i].Cells[0].Value.ToString();
                string price = dgvCTHD.Rows[i].Cells[1].Value.ToString();
                string quantity = dgvCTHD.Rows[i].Cells[2].Value.ToString();
                string discount = dgvCTHD.Rows[i].Cells[3].Value.ToString();
                string detail_total = dgvCTHD.Rows[i].Cells[4].Value.ToString();
                if(idbill != "")
                {
                    sql = "INSERT INTO bill_detail(idbill,idproduct,price,quantity,discount,total) VALUES('" + idbill + "','" + idproduct + "','" + price + "','" + quantity + "','" + discount + "','" + detail_total + "')";
                    c.UpdateData(sql);
                }

            }

            txtThanhTien.Clear();
            txtSL.Clear();
            txtMaHĐ.Clear();
            txtKhuyenMai.Clear();
            txtGiaBan.Clear();
            txtMaSP.Clear();
           /* cbbTenSp.Clear();*/
            txtPhoneKH.Clear();
            txtTenKH.Clear();
            cbbTenNV.Text = "";
            cbbTrangThai.Text = "";
            dgvCTHD.Rows.Clear();
            status = 0;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlgHoiThoat;
            dlgHoiThoat = MessageBox.Show("Bạn có chắc thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dlgHoiThoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        void LoadTableEmployees()
        {
            dsnv = c.LoadData("Select * from employees");
            cbbTenNV.DataSource = dsnv.Tables[0];
            cbbTenNV.DisplayMember = "name";
            cbbTenNV.ValueMember = "idemployee";
        }

        private void FrmCTHD_Load(object sender, EventArgs e)
        {
            status_textbox(true);
            status_button(true);
            LoadTableEmployees();
            loadCbbNameProduct();

        }

        DataSet SearchKH(string phone)
        {
            dskh = c.LoadData("Select idcustomer,name from customer where phone = '"+phone+"'");

            return dskh;
        }

        private void FrmCTHD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnThoat.PerformClick();
            }
        }

        int CheckIDProduct(string value)
        {
            string sql = "Select count(idproduct) from products where idproduct = '" + value + "'";
            dssp = c.LoadData(sql);
            return int.Parse(dssp.Tables[0].Rows[0][0].ToString());
        }

        private void TxtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtMaSP.Text != "")
                {
                    if (CheckIDProduct(txtMaSP.Text) != 0)
                    {
                        string path = @"D:\LearnC#\Project\bin\Image";
                        dssp = c.LoadData("Select name,price,image from products where idproduct = '" + txtMaSP.Text + "'");
                        cbbTenSp.Text = dssp.Tables[0].Rows[0]["name"].ToString();
                        txtGiaBan.Text = dssp.Tables[0].Rows[0]["price"].ToString();
                        string img = dssp.Tables[0].Rows[0]["image"].ToString();
                        string[] arrlistimg = img.Split(new char[] { ';' }).ToArray();
                        DirectoryInfo di = new DirectoryInfo(path);
                        flpSanPham.Controls.Clear();
                        for (int i = 0; i < arrlistimg.Count(); i++)
                        {
                            FileInfo[] fis = di.GetFiles(arrlistimg[i].ToString());
                            foreach (FileInfo f in fis)
                            {
                                PictureBox t = new PictureBox();
                                t.Width = 50;
                                t.Height = 50;
                                byte[] by = File.ReadAllBytes(f.FullName);
                                MemoryStream ms = new MemoryStream(by);
                                Bitmap image = new Bitmap(ms);
                                t.Image = image;
                                t.SizeMode = PictureBoxSizeMode.StretchImage;

                                flpSanPham.Controls.Add(t);
                            }
                        }

                    }
                    else
                        MessageBox.Show("Sản phẩm không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void BtnThemMoiSp_Click(object sender, EventArgs e)
        {
            float price;
            //float discount;
            price = float.Parse(txtGiaBan.Text) * int.Parse(txtSL.Text) - float.Parse(txtKhuyenMai.Text);
            hd_total += price;
            txtThanhTien.Text = hd_total.ToString();

            object[] t = { txtMaSP.Text, txtGiaBan.Text, txtSL.Text, txtKhuyenMai.Text, price.ToString() };

            dgvCTHD.Rows.Add(t);
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            status_button(true);
            status_textbox(true);
            status = 0;
        }

        private void BtnSearchKH_Click(object sender, EventArgs e)
        {
            dskh = SearchKH(txtPhoneKH.Text);
            if (dskh.Tables[0].Rows.Count == 0)
                txtTenKH.Text = "Khách hàng không tồn tại";
            else
            {
                txtTenKH.Text = dskh.Tables[0].Rows[0]["name"].ToString();
                idcusctomer = dskh.Tables[0].Rows[0]["idcustomer"].ToString();
            }
        }

        private void BtnFrmHD_Click(object sender, EventArgs e)
        {
            frmHD frm = new frmHD();
            frm.Show();
        }

        private void FrmCTHD_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (status != 0)
            {
                DialogResult dlg = new DialogResult();
                dlg = MessageBox.Show("Bạn có muốn lưu không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                    BtnLuu_Click(sender, e);
            }
            else
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
        }

        private void BtnSua_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void TxtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void TxtKhuyenMai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void TxtPhoneKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        public void loadCbbNameProduct()
        {
            sql = "select * from products";
            listDetailProduct = c.LoadData(sql);
            cbbTenSp.DisplayMember = "name";
            cbbTenSp.ValueMember = "idproduct";
            cbbTenSp.DataSource = listDetailProduct.Tables[0];
        }

        private void cbbTenSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cbbNameProductLoad = cbbTenSp.Text;
            sql = "SELECT discount.moneyDiscount,products.idproduct,discount.nameDiscount,products.price " +
                "from product_discount,discount,products where products.name=N'" + cbbNameProductLoad + "'  " +
                "and discount.idDiscount = product_discount.idDiscount and  product_discount.idProduct = products.idproduct";
            getValueDetailBill(sql);   
        }
        public void getValueDetailBill(string sql)
        {
            int amout = 1;
            string nameDiscount= "";
            int sumMoneyDiscount = 0;
            listDetailProduct = c.LoadData(sql);
            fetchValuedetailBill(sumMoneyDiscount,nameDiscount, amout, listDetailProduct);
        }
        public int valueAmount;
        private int resultMultiplyPriceDiscount;
        private int resultMultiplyPriceProduct;
        public void fetchValuedetailBill(int sumMoneyDiscount,string nameDiscount, int amout, DataSet listNameProduct)
        {
            txtSL.Text = amout.ToString();
            DataTable dataTable = listNameProduct.Tables[0];
            foreach (DataRow row in dataTable.Rows)
            {
                sumMoneyDiscount += int.Parse(row["moneyDiscount"].ToString());
                nameDiscount += row["nameDiscount"] + ", ";
            }
            assignValueDetailBill(sumMoneyDiscount, dataTable, nameDiscount);
        }
        public void assignValueDetailBill(int sumMoneyDiscount, DataTable dataTable, string nameDiscount)
        {
            txtKhuyenMai.Text = sumMoneyDiscount.ToString();
            txtMaSP.Text = dataTable.Rows[0]["idproduct"].ToString();
            txtGiaBan.Text = dataTable.Rows[0]["price"].ToString();
            txtTenKhuyenMai.Text = nameDiscount;
        } 
        private void txtSL_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable dataTable = listDetailProduct.Tables[0];
            int moneyDiscount = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                moneyDiscount += int.Parse(row["moneyDiscount"].ToString());
            }
            valueAmount = txtSL.Text != "" ?  int.Parse(txtSL.Text): 1;
            resultMultiplyPriceDiscount = valueAmount * moneyDiscount;
            resultMultiplyPriceProduct = valueAmount * int.Parse(listDetailProduct.Tables[0].Rows[0]["price"].ToString());
            txtKhuyenMai.Text = resultMultiplyPriceDiscount.ToString();
            txtGiaBan.Text = resultMultiplyPriceProduct.ToString();
        }
    }
}


