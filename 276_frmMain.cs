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
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain(string status,string name)
        {
            InitializeComponent();
            if(status == "0")
            {
                MessageBox.Show("Xin chào admin", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Xin chào '" + name + "'", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
                sanToolStripMenuItem.Enabled = false;
                hóaĐơnToolStripMenuItem.Enabled = false;
                hìnhẢnhToolStripMenuItem.Enabled = false;
                chiTiếtHóaĐơnToolStripMenuItem.Enabled = false;
                bảngHóaĐơnToolStripMenuItem.Enabled = false;
                hìnhẢnhToolStripMenuItem.Enabled = false;
                toolDMSP.Enabled = false;
                danhSáchSảnPhẩmToolStripMenuItem.Enabled = false;
                toolSearchSPwName.Enabled = false;


            }
                
           
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ToolDMSP_Click(object sender, EventArgs e)
        {
            frmLoaiSP frm = new frmLoaiSP();
            frm.MdiParent = this;
            frm.Show();
        }

        private void DanhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCTHD frm = new frmCTHD();
            frm.MdiParent = this;
            frm.Show();
        }

        private void HìnhẢnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHinh frm = new frmHinh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (internetconnection.IsConnectedToInternet() == false)
            {
                DialogResult dlgHoiThoat = new DialogResult();
                dlgHoiThoat = MessageBox.Show("Hãy kết nối internet", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //if (dlgHoiThoat == DialogResult.OK)
                    //toolsMenu.Enabled = false;

            }

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgHoiThoat;
            dlgHoiThoat = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgHoiThoat == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void ToolSearchSPwName_Click(object sender, EventArgs e)
        {
            frmSearchSP frm = new frmSearchSP();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BảngHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHD frm = new frmHD();
            frm.MdiParent = this;
            frm.Show();
        }

        private void DanhSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void KíchThướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKichThuoc frm = new frmKichThuoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaMau frm = new frmMaMau();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemKhachHangTheoTen frm = new frmTimKiemKhachHangTheoTen();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TìmKiếmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchHD frm = new frmSearchHD();
            frm.MdiParent = this;
            frm.Show();
        }
        private void khuyếnMãiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KhuyenMai frm = new KhuyenMai();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
