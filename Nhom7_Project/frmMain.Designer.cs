namespace Nhom7_Project
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnPhongMay = new System.Windows.Forms.Panel();
            this.btnPhongmay = new System.Windows.Forms.Button();
            this.pnLichTH = new System.Windows.Forms.Panel();
            this.btnLichthuchanh = new System.Windows.Forms.Button();
            this.menuContainer0 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnManager = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnQuanlyCa = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnQuanlyPhongMay = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnQuanlyTaiKhoan = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnQLLichTH = new System.Windows.Forms.Button();
            this.menuContainer1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnTTCaNhan = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnMe = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDangkyTH = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnBCSC = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnHead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnBody = new System.Windows.Forms.Panel();
            this.menuTransition0 = new System.Windows.Forms.Timer(this.components);
            this.menuTransition1 = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnHome.SuspendLayout();
            this.pnPhongMay.SuspendLayout();
            this.pnLichTH.SuspendLayout();
            this.menuContainer0.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.menuContainer1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.sidebar.Controls.Add(this.pictureBox1);
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.pnHome);
            this.sidebar.Controls.Add(this.pnPhongMay);
            this.sidebar.Controls.Add(this.pnLichTH);
            this.sidebar.Controls.Add(this.menuContainer0);
            this.sidebar.Controls.Add(this.menuContainer1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(322, 1228);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(20, 10, 0, 30);
            this.pictureBox1.Size = new System.Drawing.Size(97, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(120, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 30);
            this.button1.Size = new System.Drawing.Size(113, 97);
            this.button1.TabIndex = 1;
            this.button1.Text = "LabNet";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnHome
            // 
            this.pnHome.BackColor = System.Drawing.SystemColors.Menu;
            this.pnHome.Controls.Add(this.btnHome);
            this.pnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnHome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnHome.Location = new System.Drawing.Point(2, 123);
            this.pnHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnHome.Name = "pnHome";
            this.pnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnHome.Size = new System.Drawing.Size(326, 53);
            this.pnHome.TabIndex = 7;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.btnHome.Image = global::Nhom7_Project.Properties.Resources.icons8_home_25;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-8, -9);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(334, 68);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = " Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnPhongMay
            // 
            this.pnPhongMay.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnPhongMay.Controls.Add(this.btnPhongmay);
            this.pnPhongMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPhongMay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnPhongMay.Location = new System.Drawing.Point(2, 182);
            this.pnPhongMay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnPhongMay.Name = "pnPhongMay";
            this.pnPhongMay.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnPhongMay.Size = new System.Drawing.Size(326, 53);
            this.pnPhongMay.TabIndex = 9;
            // 
            // btnPhongmay
            // 
            this.btnPhongmay.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnPhongmay.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.btnPhongmay.Image = global::Nhom7_Project.Properties.Resources.icons8_classroom_25;
            this.btnPhongmay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhongmay.Location = new System.Drawing.Point(-8, -9);
            this.btnPhongmay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPhongmay.Name = "btnPhongmay";
            this.btnPhongmay.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPhongmay.Size = new System.Drawing.Size(334, 68);
            this.btnPhongmay.TabIndex = 0;
            this.btnPhongmay.Text = " Phòng máy";
            this.btnPhongmay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhongmay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhongmay.UseVisualStyleBackColor = false;
            this.btnPhongmay.Click += new System.EventHandler(this.btnPhongmay_Click);
            // 
            // pnLichTH
            // 
            this.pnLichTH.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnLichTH.Controls.Add(this.btnLichthuchanh);
            this.pnLichTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLichTH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnLichTH.Location = new System.Drawing.Point(2, 241);
            this.pnLichTH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnLichTH.Name = "pnLichTH";
            this.pnLichTH.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnLichTH.Size = new System.Drawing.Size(326, 53);
            this.pnLichTH.TabIndex = 8;
            // 
            // btnLichthuchanh
            // 
            this.btnLichthuchanh.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLichthuchanh.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.btnLichthuchanh.Image = global::Nhom7_Project.Properties.Resources.icons8_schedule_25;
            this.btnLichthuchanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichthuchanh.Location = new System.Drawing.Point(-8, -9);
            this.btnLichthuchanh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLichthuchanh.Name = "btnLichthuchanh";
            this.btnLichthuchanh.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLichthuchanh.Size = new System.Drawing.Size(334, 68);
            this.btnLichthuchanh.TabIndex = 0;
            this.btnLichthuchanh.Text = " Lịch TH";
            this.btnLichthuchanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichthuchanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichthuchanh.UseVisualStyleBackColor = false;
            this.btnLichthuchanh.Click += new System.EventHandler(this.btnLichthuchanh_Click);
            // 
            // menuContainer0
            // 
            this.menuContainer0.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuContainer0.Controls.Add(this.panel11);
            this.menuContainer0.Controls.Add(this.panel7);
            this.menuContainer0.Controls.Add(this.panel8);
            this.menuContainer0.Controls.Add(this.panel9);
            this.menuContainer0.Controls.Add(this.panel10);
            this.menuContainer0.ForeColor = System.Drawing.SystemColors.MenuText;
            this.menuContainer0.Location = new System.Drawing.Point(3, 300);
            this.menuContainer0.Name = "menuContainer0";
            this.menuContainer0.Size = new System.Drawing.Size(325, 305);
            this.menuContainer0.TabIndex = 11;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnManager);
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(2, 3);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(323, 53);
            this.panel11.TabIndex = 4;
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnManager.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManager.Location = new System.Drawing.Point(-8, -9);
            this.btnManager.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnManager.Name = "btnManager";
            this.btnManager.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnManager.Size = new System.Drawing.Size(331, 68);
            this.btnManager.TabIndex = 0;
            this.btnManager.Text = "       Quản lý";
            this.btnManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnQuanlyCa);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(2, 62);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(323, 53);
            this.panel7.TabIndex = 4;
            // 
            // btnQuanlyCa
            // 
            this.btnQuanlyCa.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnQuanlyCa.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnQuanlyCa.Image = global::Nhom7_Project.Properties.Resources.icons8_time_machine_25;
            this.btnQuanlyCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanlyCa.Location = new System.Drawing.Point(-8, -9);
            this.btnQuanlyCa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnQuanlyCa.Name = "btnQuanlyCa";
            this.btnQuanlyCa.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnQuanlyCa.Size = new System.Drawing.Size(331, 68);
            this.btnQuanlyCa.TabIndex = 0;
            this.btnQuanlyCa.Text = " Ca";
            this.btnQuanlyCa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanlyCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanlyCa.UseVisualStyleBackColor = false;
            this.btnQuanlyCa.Click += new System.EventHandler(this.btnQuanlyCa_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnQuanlyPhongMay);
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(2, 121);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(323, 53);
            this.panel8.TabIndex = 4;
            // 
            // btnQuanlyPhongMay
            // 
            this.btnQuanlyPhongMay.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnQuanlyPhongMay.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnQuanlyPhongMay.Image = global::Nhom7_Project.Properties.Resources.icons8_classroom_251;
            this.btnQuanlyPhongMay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanlyPhongMay.Location = new System.Drawing.Point(-8, -9);
            this.btnQuanlyPhongMay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnQuanlyPhongMay.Name = "btnQuanlyPhongMay";
            this.btnQuanlyPhongMay.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnQuanlyPhongMay.Size = new System.Drawing.Size(331, 68);
            this.btnQuanlyPhongMay.TabIndex = 0;
            this.btnQuanlyPhongMay.Text = " Phòng máy";
            this.btnQuanlyPhongMay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanlyPhongMay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanlyPhongMay.UseVisualStyleBackColor = false;
            this.btnQuanlyPhongMay.Click += new System.EventHandler(this.btnQuanlyPhongMay_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnQuanlyTaiKhoan);
            this.panel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(2, 180);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(323, 53);
            this.panel9.TabIndex = 4;
            // 
            // btnQuanlyTaiKhoan
            // 
            this.btnQuanlyTaiKhoan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnQuanlyTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnQuanlyTaiKhoan.Image = global::Nhom7_Project.Properties.Resources.icons8_team_25;
            this.btnQuanlyTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanlyTaiKhoan.Location = new System.Drawing.Point(-8, -9);
            this.btnQuanlyTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnQuanlyTaiKhoan.Name = "btnQuanlyTaiKhoan";
            this.btnQuanlyTaiKhoan.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnQuanlyTaiKhoan.Size = new System.Drawing.Size(331, 68);
            this.btnQuanlyTaiKhoan.TabIndex = 0;
            this.btnQuanlyTaiKhoan.Text = " Tài khoản";
            this.btnQuanlyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanlyTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanlyTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQuanlyTaiKhoan.Click += new System.EventHandler(this.btnQuanlyTaiKhoan_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnQLLichTH);
            this.panel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(2, 239);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(323, 53);
            this.panel10.TabIndex = 4;
            // 
            // btnQLLichTH
            // 
            this.btnQLLichTH.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnQLLichTH.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnQLLichTH.Image = global::Nhom7_Project.Properties.Resources.icons8_schedule_25;
            this.btnQLLichTH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLLichTH.Location = new System.Drawing.Point(-8, -9);
            this.btnQLLichTH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnQLLichTH.Name = "btnQLLichTH";
            this.btnQLLichTH.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnQLLichTH.Size = new System.Drawing.Size(331, 68);
            this.btnQLLichTH.TabIndex = 0;
            this.btnQLLichTH.Text = " Lịch TH";
            this.btnQLLichTH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLLichTH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLLichTH.UseVisualStyleBackColor = false;
            this.btnQLLichTH.Click += new System.EventHandler(this.btnQLLichTH_Click);
            // 
            // menuContainer1
            // 
            this.menuContainer1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuContainer1.Controls.Add(this.panel14);
            this.menuContainer1.Controls.Add(this.panel12);
            this.menuContainer1.Controls.Add(this.panel5);
            this.menuContainer1.Controls.Add(this.panel13);
            this.menuContainer1.Controls.Add(this.panel6);
            this.menuContainer1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuContainer1.Location = new System.Drawing.Point(3, 611);
            this.menuContainer1.Name = "menuContainer1";
            this.menuContainer1.Size = new System.Drawing.Size(325, 305);
            this.menuContainer1.TabIndex = 10;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel14.Controls.Add(this.btnTTCaNhan);
            this.panel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.Location = new System.Drawing.Point(2, 3);
            this.panel14.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(323, 53);
            this.panel14.TabIndex = 4;
            // 
            // btnTTCaNhan
            // 
            this.btnTTCaNhan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnTTCaNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnTTCaNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTTCaNhan.Location = new System.Drawing.Point(-8, -3);
            this.btnTTCaNhan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTTCaNhan.Name = "btnTTCaNhan";
            this.btnTTCaNhan.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnTTCaNhan.Size = new System.Drawing.Size(331, 68);
            this.btnTTCaNhan.TabIndex = 0;
            this.btnTTCaNhan.Text = "       Cá nhân";
            this.btnTTCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTTCaNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTTCaNhan.UseVisualStyleBackColor = false;
            this.btnTTCaNhan.Click += new System.EventHandler(this.btnTTCaNhan_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel12.Controls.Add(this.btnMe);
            this.panel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel12.Location = new System.Drawing.Point(2, 62);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(323, 53);
            this.panel12.TabIndex = 4;
            // 
            // btnMe
            // 
            this.btnMe.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnMe.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnMe.Image = global::Nhom7_Project.Properties.Resources.icons8_me_25;
            this.btnMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMe.Location = new System.Drawing.Point(-8, -9);
            this.btnMe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMe.Name = "btnMe";
            this.btnMe.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMe.Size = new System.Drawing.Size(331, 68);
            this.btnMe.TabIndex = 0;
            this.btnMe.Text = " Tôi";
            this.btnMe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMe.UseVisualStyleBackColor = false;
            this.btnMe.Click += new System.EventHandler(this.btnMe_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel5.Controls.Add(this.btnDangkyTH);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(2, 121);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(323, 53);
            this.panel5.TabIndex = 4;
            // 
            // btnDangkyTH
            // 
            this.btnDangkyTH.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnDangkyTH.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangkyTH.Image = global::Nhom7_Project.Properties.Resources.icons8_task_25;
            this.btnDangkyTH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangkyTH.Location = new System.Drawing.Point(-8, -9);
            this.btnDangkyTH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDangkyTH.Name = "btnDangkyTH";
            this.btnDangkyTH.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDangkyTH.Size = new System.Drawing.Size(331, 68);
            this.btnDangkyTH.TabIndex = 0;
            this.btnDangkyTH.Text = " Đăng ký TH";
            this.btnDangkyTH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangkyTH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangkyTH.UseVisualStyleBackColor = false;
            this.btnDangkyTH.Click += new System.EventHandler(this.btnDangkyTH_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel13.Controls.Add(this.btnBCSC);
            this.panel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel13.Location = new System.Drawing.Point(2, 180);
            this.panel13.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(323, 53);
            this.panel13.TabIndex = 4;
            // 
            // btnBCSC
            // 
            this.btnBCSC.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnBCSC.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCSC.Image = global::Nhom7_Project.Properties.Resources.icons8_error_25;
            this.btnBCSC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBCSC.Location = new System.Drawing.Point(-8, -9);
            this.btnBCSC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBCSC.Name = "btnBCSC";
            this.btnBCSC.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBCSC.Size = new System.Drawing.Size(331, 68);
            this.btnBCSC.TabIndex = 0;
            this.btnBCSC.Text = " BC sự cố";
            this.btnBCSC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBCSC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBCSC.UseVisualStyleBackColor = false;
            this.btnBCSC.Click += new System.EventHandler(this.btnBCSC_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel6.Controls.Add(this.btnLogout);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(2, 239);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(323, 53);
            this.panel6.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = global::Nhom7_Project.Properties.Resources.icons8_logout_25;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-8, -9);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(331, 68);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = " Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnHead
            // 
            this.pnHead.BackColor = System.Drawing.SystemColors.Menu;
            this.pnHead.Controls.Add(this.label1);
            this.pnHead.Controls.Add(this.pictureBox2);
            this.pnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHead.Location = new System.Drawing.Point(322, 0);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(1659, 100);
            this.pnHead.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Nhom7_Project.Properties.Resources.icons8_menu_25;
            this.pictureBox2.Location = new System.Drawing.Point(21, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pnBody
            // 
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.pnBody.Location = new System.Drawing.Point(322, 100);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1659, 1128);
            this.pnBody.TabIndex = 2;
            // 
            // menuTransition0
            // 
            this.menuTransition0.Interval = 6;
            this.menuTransition0.Tick += new System.EventHandler(this.menuTransition0_Tick);
            // 
            // menuTransition1
            // 
            this.menuTransition1.Interval = 6;
            this.menuTransition1.Tick += new System.EventHandler(this.menuTransition1_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1981, 1228);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnHead);
            this.Controls.Add(this.sidebar);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnHome.ResumeLayout(false);
            this.pnPhongMay.ResumeLayout(false);
            this.pnLichTH.ResumeLayout(false);
            this.menuContainer0.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.menuContainer1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pnHead.ResumeLayout(false);
            this.pnHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnHead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnLichTH;
        private System.Windows.Forms.Button btnLichthuchanh;
        private System.Windows.Forms.Panel pnPhongMay;
        private System.Windows.Forms.Button btnPhongmay;
        private System.Windows.Forms.FlowLayoutPanel menuContainer0;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnQuanlyCa;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnQuanlyPhongMay;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnQuanlyTaiKhoan;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnQLLichTH;
        private System.Windows.Forms.FlowLayoutPanel menuContainer1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnTTCaNhan;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnMe;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDangkyTH;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnBCSC;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer menuTransition0;
        private System.Windows.Forms.Timer menuTransition1;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}

