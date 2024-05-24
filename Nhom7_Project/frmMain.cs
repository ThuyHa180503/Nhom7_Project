using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Nhom7_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //click
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.frmHome());
            label1.Text = btnHome.Text;
        }

        private void btnPhongmay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.frmPhongMay());
            label1.Text = btnPhongmay.Text;
        }
        private void btnLichthuchanh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.frmLichTH());
            label1.Text = btnLichthuchanh.Text;
        }
       

        private void btnQuanlyCa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.QuanLyCa());
            label1.Text = btnQuanlyCa.Text;
        }

        private void btnQuanlyPhongMay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.QuanLyPhongMay());
            label1.Text = btnQuanlyPhongMay.Text;
        }

        private void btnQuanlyTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.frmPhongMay());
            label1.Text = btnPhongmay.Text;
        }
        private void btnQLLichTH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.QuanLyLichTH());
            label1.Text = btnQLLichTH.Text;
        }
        private void btnMe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.CaNhanMe());
            label1.Text = btnMe.Text;
        }

        private void btnDangkyTH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.CaNhanDkiLichTH());
            label1.Text = btnDangkyTH.Text;
        }

        private void btnBCSC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.CaNhanBCSC());
            label1.Text = btnBCSC.Text;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //ẤN VÀO QUẢN LÝ
        bool menuExpand = false;
        private void menuTransition0_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer0.Height += 10;
                if (menuContainer0.Height >= 160)
                {
                    menuTransition0.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer0.Height -= 10;
                if (menuContainer0.Height <= 35)
                {
                    menuTransition0.Stop();
                    menuExpand = false;
                }
            }
        }
        private void btnManager_Click(object sender, EventArgs e)
        {
            menuTransition0.Start();
        }
        //ẤN VÀO CÁ NHÂN
        bool menuExpand1 = false;

        private void menuTransition1_Tick(object sender, EventArgs e)
        {
            if (menuExpand1 == false)
            {
                menuContainer1.Height += 10;
                if (menuContainer1.Height >= 168)
                {
                    menuTransition1.Stop();
                    menuExpand1 = true;
                }
            }
            else
            {
                menuContainer1.Height -= 10;
                if (menuContainer1.Height <= 35)
                {
                    menuTransition1.Stop();
                    menuExpand1 = false;
                }
            }
        }

        private void btnTTCaNhan_Click(object sender, EventArgs e)
        {
            menuTransition1.Start();
        }
        //sidebar
        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 0)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    pnHome.Width = sidebar.Width;
                    pnPhongMay.Width = sidebar.Width;
                    pnLichTH.Width = sidebar.Width;
                    menuContainer0.Width = sidebar.Width;
                    menuContainer1.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 152)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    pnHome.Width = sidebar.Width;
                    pnPhongMay.Width = sidebar.Width;
                    pnLichTH.Width = sidebar.Width;
                    menuContainer0.Width = sidebar.Width;
                    menuContainer1.Width = sidebar.Width;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
