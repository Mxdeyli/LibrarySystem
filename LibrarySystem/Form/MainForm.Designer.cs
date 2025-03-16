namespace LibrarySystem
{
    partial class MainForm
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
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.book = new System.Windows.Forms.TabPage();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ManageUsers = new System.Windows.Forms.TabPage();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看历史ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.ManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(307, 693);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(110, 23);
            this.btnBorrow.TabIndex = 0;
            this.btnBorrow.Text = "btnBorrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(73, 693);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(113, 23);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "btnAddBook";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(531, 693);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "btnReturn";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(1413, 717);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(130, 23);
            this.btnManageUsers.TabIndex = 3;
            this.btnManageUsers.Text = "btnManageUsers";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.book);
            this.tabControl1.Controls.Add(this.ManageUsers);
            this.tabControl1.Location = new System.Drawing.Point(28, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1807, 775);
            this.tabControl1.TabIndex = 4;
            // 
            // book
            // 
            this.book.Controls.Add(this.dgvBooks);
            this.book.Controls.Add(this.txtSearch);
            this.book.Controls.Add(this.btnAddBook);
            this.book.Controls.Add(this.btnBorrow);
            this.book.Controls.Add(this.btnReturn);
            this.book.Location = new System.Drawing.Point(4, 25);
            this.book.Name = "book";
            this.book.Padding = new System.Windows.Forms.Padding(3);
            this.book.Size = new System.Drawing.Size(1799, 746);
            this.book.TabIndex = 0;
            this.book.Text = "book";
            this.book.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(6, 84);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 27;
            this.dgvBooks.Size = new System.Drawing.Size(1787, 573);
            this.dgvBooks.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(760, 694);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(320, 25);
            this.txtSearch.TabIndex = 5;
            // 
            // ManageUsers
            // 
            this.ManageUsers.Controls.Add(this.cmbRole);
            this.ManageUsers.Controls.Add(this.txtPassword);
            this.ManageUsers.Controls.Add(this.txtUsername);
            this.ManageUsers.Controls.Add(this.btnAddUser);
            this.ManageUsers.Controls.Add(this.dgvUsers);
            this.ManageUsers.Controls.Add(this.btnManageUsers);
            this.ManageUsers.Location = new System.Drawing.Point(4, 25);
            this.ManageUsers.Name = "ManageUsers";
            this.ManageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.ManageUsers.Size = new System.Drawing.Size(1799, 746);
            this.ManageUsers.TabIndex = 1;
            this.ManageUsers.Text = "ManageUsers";
            this.ManageUsers.UseVisualStyleBackColor = true;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(520, 683);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(121, 23);
            this.cmbRole.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(398, 680);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 25);
            this.txtPassword.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(398, 639);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 25);
            this.txtUsername.TabIndex = 8;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(398, 717);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(107, 23);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "btnAddUser";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(42, 124);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 27;
            this.dgvUsers.Size = new System.Drawing.Size(1722, 494);
            this.dgvUsers.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 992);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1897, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.图书管理ToolStripMenuItem,
            this.借阅记录ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1897, 30);
            this.menuMain.TabIndex = 9;
            this.menuMain.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出系统ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新系统ToolStripMenuItem,
            this.导出excelToolStripMenuItem});
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            // 
            // 刷新系统ToolStripMenuItem
            // 
            this.刷新系统ToolStripMenuItem.Name = "刷新系统ToolStripMenuItem";
            this.刷新系统ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.刷新系统ToolStripMenuItem.Text = "刷新系统";
            // 
            // 导出excelToolStripMenuItem
            // 
            this.导出excelToolStripMenuItem.Name = "导出excelToolStripMenuItem";
            this.导出excelToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.导出excelToolStripMenuItem.Text = "导出excel";
            // 
            // 借阅记录ToolStripMenuItem
            // 
            this.借阅记录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看历史ToolStripMenuItem});
            this.借阅记录ToolStripMenuItem.Name = "借阅记录ToolStripMenuItem";
            this.借阅记录ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.借阅记录ToolStripMenuItem.Text = "借阅记录";
            // 
            // 查看历史ToolStripMenuItem
            // 
            this.查看历史ToolStripMenuItem.Name = "查看历史ToolStripMenuItem";
            this.查看历史ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.查看历史ToolStripMenuItem.Text = "查看历史";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1897, 1018);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.book.ResumeLayout(false);
            this.book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ManageUsers.ResumeLayout(false);
            this.ManageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage book;
        private System.Windows.Forms.TabPage ManageUsers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看历史ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
    }
}