using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        string tenDN = "";
        string Mk = "";
        string Quyen = "";
        frmLogin frmlogin = new frmLogin();
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string tenDN, string Mk, string Quyen)
        {
            InitializeComponent();
            this.tenDN = tenDN;
            this.Mk = Mk;
            this.Quyen = Quyen; 
        }


        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Form1"))
            {
                Form1 frm = new Form1();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
                ActiveChildForm("Form1");
        }
        //Kiểm tra sự tồn tại của form
        bool CheckExistForm(string formName)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name==formName)
                {
                    check = true;
                    break;
                }    
            }    
            return check;
        }
        //Active 1 form
       void ActiveChildForm(string formName)
        {
            
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == formName)
                {
                    frm.Activate();
                    break;
                }
            }
            
        }

        private void mnuSP_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmSP"))
            {
                Forms.frmSP frm = new Forms.frmSP();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
                ActiveChildForm("Form1");
        }
        private void PQ()
        {
            if (this.Quyen == "1")
            {
                bntadmin.Enabled = true;
                bntUser.Enabled = true ;
            }
            else
            {
                bntUser.Enabled = false;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lbName.Text = "Xin chao " + this.tenDN;
            PQ();
        }

        private void bntDX_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co muon dang xuat ko", "Thong bao", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //this.Close();
                frmlogin.Show();
                this.Close();
            }
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmHDB"))
            {
                frmHDB frm = new frmHDB();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
                ActiveChildForm("frmHDB");
        }

        private void formTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckExistForm("FormTest"))
            {
                Forms.FormTest frmTest = new Forms.FormTest();
                frmTest.MdiParent = this;
                frmTest.Dock = DockStyle.Fill;
                frmTest.Show();
            } else
            {
                ActiveChildForm("FormTest");
            }
        }
    }
}
