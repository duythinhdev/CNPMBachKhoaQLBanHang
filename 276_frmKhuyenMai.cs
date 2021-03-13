using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class KhuyenMai : Form
    {
        clsqlbanhang clsqlbanhang = new clsqlbanhang();
        DataSet ds = new DataSet();

        public int flagSave;
        public KhuyenMai()
        {
            InitializeComponent();
        }

        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            dsKhuyenMai();
            textBox();
            status_textbox(true);
        }
        public void textBox()
        {
            dtgrKhuyenMai.ReadOnly = true;
            txtIdDiscount.ReadOnly = true;

        }
        int status;

        public void dsKhuyenMai()
        {
            ds = clsqlbanhang.LoadData("Select * from discount");
            dtgrKhuyenMai.DataSource = ds.Tables[0];
            autoIdKhuyenMai();
        }
        public void autoIdKhuyenMai()
        {
            ds.Tables[0].Columns.Add("STT");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["STT"] = (i + 1).ToString();
            }

            dtgrKhuyenMai.Columns["STT"].DisplayIndex = 0;
        }
        private void dtgrKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            DataGridViewRow selectedRows = dtgrKhuyenMai.Rows[RowIndex];
            txtIdDiscount.Text = selectedRows.Cells[0].Value.ToString();
            txtNameDiscount.Text = selectedRows.Cells[1].Value.ToString();
            txtMoneyDiscount.Text = selectedRows.Cells[2].Value.ToString();
            rdbTat.Checked = !bool.Parse(selectedRows.Cells[3].Value.ToString());
            rdbBat.Checked = bool.Parse(selectedRows.Cells[3].Value.ToString());
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flagSave = 1;
            status_button(false);
            status_textbox(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagSave = 2;
            status_button(false);
            status_textbox(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flagSave = 3;
            status_button(false);
            status_textbox(false);
        }
        private void rdbBat_CheckedChanged(object sender, EventArgs e)
        {
            status = 1;
        }

        private void rdbTat_CheckedChanged(object sender, EventArgs e)
        {
            status = 0;
        }
        string queryKhuyenMai;
        private void btnSave_Click(object sender, EventArgs e)
        {
            status_button(true);
            switch(flagSave)
            {
                case 1:
                    queryKhuyenMai = "insert into discount (nameDiscount,moneyDiscount,status) values ('" + txtNameDiscount.Text + "','" + txtMoneyDiscount.Text + "','" + status + "')";
                    clsqlbanhang.UpdateData(queryKhuyenMai);
                    dsKhuyenMai();
                    break;
                case 2:
                    queryKhuyenMai = "update discount set nameDiscount='" + txtNameDiscount.Text + "', moneyDiscount='" + txtMoneyDiscount.Text + "',status='" + status + "' where idDiscount='" + txtIdDiscount.Text + "'";
                    clsqlbanhang.UpdateData(queryKhuyenMai);
                    dsKhuyenMai();
                    break;
                case 3:
                    queryKhuyenMai = "delete from discount where  idDiscount='" + txtIdDiscount.Text + "'";
                    clsqlbanhang.UpdateData(queryKhuyenMai);
                    dsKhuyenMai();
                    break;
            }    
            clearData();

        }
        public void clearData()
        {
            txtIdDiscount.Clear();
            txtNameDiscount.Clear();
            txtMoneyDiscount.Clear();
        }
        public void dtgrKhuyenMai_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtgrKhuyenMai.Columns[e.ColumnIndex].Name == "Column4")
            {
                if (e.Value != null)
                {
                    e.Value = bool.Parse(e.Value.ToString()) == true ?  "Bật" : "Tắt";
                    e.FormattingApplied = true;
                }
            }

        }
        public void status_button(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnSave.Enabled =  !t;
            btnClear.Enabled = t;
            btnHuy.Enabled = !t;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdDiscount.Text = "";
            txtNameDiscount.Text = "";
            txtMoneyDiscount.Text = "";
        }
        public void status_textbox(Boolean t)
        {
            txtIdDiscount.ReadOnly = true;
            txtNameDiscount.ReadOnly = t;
            txtMoneyDiscount.ReadOnly = t;
        }
        private void KhuyenMai_FormClosing(object sender, FormClosingEventArgs e)
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
            status_textbox(true);
        }
    }
}
