namespace QuanLyBanHang
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChatLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSP = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngTồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntDX = new System.Windows.Forms.Button();
            this.bntUser = new System.Windows.Forms.Button();
            this.bntadmin = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.formTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.bánHàngToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1175, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChatLieu,
            this.nhânViênToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // mnuChatLieu
            // 
            this.mnuChatLieu.Name = "mnuChatLieu";
            this.mnuChatLieu.Size = new System.Drawing.Size(169, 26);
            this.mnuChatLieu.Text = "Chất liệu";
            this.mnuChatLieu.Click += new System.EventHandler(this.mnuChatLieu_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSP,
            this.hóaĐơnBánToolStripMenuItem,
            this.formTestToolStripMenuItem});
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.bánHàngToolStripMenuItem.Text = "Bán hàng";
            // 
            // mnuSP
            // 
            this.mnuSP.Name = "mnuSP";
            this.mnuSP.Size = new System.Drawing.Size(224, 26);
            this.mnuSP.Text = "Sản phẩm";
            this.mnuSP.Click += new System.EventHandler(this.mnuSP_Click);
            // 
            // hóaĐơnBánToolStripMenuItem
            // 
            this.hóaĐơnBánToolStripMenuItem.Name = "hóaĐơnBánToolStripMenuItem";
            this.hóaĐơnBánToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hóaĐơnBánToolStripMenuItem.Text = "Hóa đơn bán";
            this.hóaĐơnBánToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnBánToolStripMenuItem_Click);
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hàngTồnToolStripMenuItem,
            this.doanhThuToolStripMenuItem});
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo thống kê";
            // 
            // hàngTồnToolStripMenuItem
            // 
            this.hàngTồnToolStripMenuItem.Name = "hàngTồnToolStripMenuItem";
            this.hàngTồnToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.hàngTồnToolStripMenuItem.Text = "Hàng tồn";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntDX);
            this.panel1.Controls.Add(this.bntUser);
            this.panel1.Controls.Add(this.bntadmin);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 36);
            this.panel1.TabIndex = 2;
            // 
            // bntDX
            // 
            this.bntDX.Location = new System.Drawing.Point(205, 6);
            this.bntDX.Name = "bntDX";
            this.bntDX.Size = new System.Drawing.Size(75, 28);
            this.bntDX.TabIndex = 3;
            this.bntDX.Text = "Dang xuat";
            this.bntDX.UseVisualStyleBackColor = true;
            this.bntDX.Click += new System.EventHandler(this.bntDX_Click);
            // 
            // bntUser
            // 
            this.bntUser.Location = new System.Drawing.Point(120, 6);
            this.bntUser.Name = "bntUser";
            this.bntUser.Size = new System.Drawing.Size(72, 29);
            this.bntUser.TabIndex = 2;
            this.bntUser.Text = "User";
            this.bntUser.UseVisualStyleBackColor = true;
            // 
            // bntadmin
            // 
            this.bntadmin.Location = new System.Drawing.Point(21, 6);
            this.bntadmin.Name = "bntadmin";
            this.bntadmin.Size = new System.Drawing.Size(72, 29);
            this.bntadmin.TabIndex = 1;
            this.bntadmin.Text = "Admin";
            this.bntadmin.UseVisualStyleBackColor = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(902, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 16);
            this.lbName.TabIndex = 0;
            // 
            // formTestToolStripMenuItem
            // 
            this.formTestToolStripMenuItem.Name = "formTestToolStripMenuItem";
            this.formTestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.formTestToolStripMenuItem.Text = "Form Test";
            this.formTestToolStripMenuItem.Click += new System.EventHandler(this.formTestToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuChatLieu;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSP;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngTồnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntUser;
        private System.Windows.Forms.Button bntadmin;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button bntDX;
        private System.Windows.Forms.ToolStripMenuItem formTestToolStripMenuItem;
    }
}