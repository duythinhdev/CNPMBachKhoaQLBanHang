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
    public partial class frmHinh : Form
    {
        public frmHinh()
        {
            InitializeComponent();
        }
        void status_textbox(Boolean t)
        {
            //txtMaLoai.ReadOnly = t;
            //txtTenLoai.ReadOnly = t;
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
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpHinh_Click(object sender, EventArgs e)
        {
            if (oldHinh.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Bạn phải chọn hình", "Thông báo");
            }
            else
            {
                picHinh.Image = Image.FromFile(oldHinh.FileName);
                picHinh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void BtnUpNHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog oldNHinh = new OpenFileDialog();
            oldNHinh.Multiselect = true;
            oldNHinh.Filter = "Files (*.jpeg)|*.jpeg|Files (*.png)|*.png";
            DialogResult kq = new DialogResult(); 
            kq  = oldNHinh.ShowDialog();
            if(kq == DialogResult.Cancel)
            {
                MessageBox.Show("Bạn phải chọn hình","Thông báo");
            }
            else
            {
                string[] tenhinh = oldNHinh.FileNames;
                foreach(string v in tenhinh)
                {
                    PictureBox t = new PictureBox();
                    t.Width = 77;
                    t.Height = 77;
                    Bitmap img = new Bitmap(v);
                    t.Image = img;
                    t.SizeMode = PictureBoxSizeMode.StretchImage;
                    flpHinhSP.Controls.Add(t);
                }
            }
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

        private void FrmHinh_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnThoat.PerformClick();
            }
        }
    }
}
