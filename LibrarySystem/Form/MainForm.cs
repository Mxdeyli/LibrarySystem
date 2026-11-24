using System;
using System.Drawing;
using System.Windows.Forms;
using LibrarySystem.Models;
using LibrarySystem.Services;
using MySql.Data.MySqlClient;

namespace LibrarySystem
{
    public partial class MainForm : Form
    {
        private readonly User currentUser;
        private bool IsAdmin => string.Equals(currentUser.Role, "admin", StringComparison.OrdinalIgnoreCase);

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            btnBorrow.Text = "借阅";
            btnReturn.Text = "归还";
            btnAddBook.Text = "新增图书";
            btnAddUser.Text = "新增用户";
            btnManageUsers.Text = "刷新用户列表";
            ManageUsers.Text = "用户管理";
            book.Text = "图书";
            Text = "图书管理系统";

            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.MultiSelect = false;
            dgvBooks.ReadOnly = dgvUsers.ReadOnly = true;
            dgvBooks.AllowUserToAddRows = dgvUsers.AllowUserToAddRows = false;
            btnBorrow.Click += (s, e) => ChangeLoan(true);
            btnReturn.Click += (s, e) => ChangeLoan(false);
            txtSearch.AccessibleName = "搜索书名、作者或 ISBN";
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode != Keys.Enter)
                    return;
                e.SuppressKeyPress = true;
                RunDatabaseAction(LoadBooks);
            };
            刷新系统ToolStripMenuItem.Click += (s, e) => RunDatabaseAction(LoadBooks);
            退出系统ToolStripMenuItem.Click += (s, e) => Close();

            btnAddBook.Visible = IsAdmin;
            if (IsAdmin)
            {
                cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbRole.Items.AddRange(new[] { "user", "admin" });
                cmbRole.SelectedIndex = 0;
                txtPassword.UseSystemPasswordChar = true;
                btnAddUser.Click += btnAddUser_Click;
                LoadUsers();
            }
            else
            {
                tabControl1.TabPages.Remove(ManageUsers);
            }
            LoadBooks();
        }

        private void LoadBooks()
        {
            dgvBooks.DataSource = BookService.Search(txtSearch.Text.Trim());
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = DBHelper.ExecuteQuery("SELECT UserID, Username, Role FROM users ORDER BY Username");
        }

        private void ChangeLoan(bool borrowing)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("请先选择一本图书。");
                return;
            }

            int bookId = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookID"].Value);
            RunDatabaseAction(() =>
            {
                bool success = BookService.ChangeLoan(currentUser.UserID, bookId, borrowing);
                if (!success)
                {
                    MessageBox.Show(borrowing ? "库存不足，无法借阅。" : "你没有这本书的待归还记录。");
                    return;
                }
                LoadBooks();
                MessageBox.Show(borrowing ? "借阅成功。" : "归还成功。");
            });
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            if (IsAdmin)
                RunDatabaseAction(LoadUsers);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!IsAdmin)
                return;

            using (var dialog = new Form { Text = "新增图书", ClientSize = new Size(360, 195),
                FormBorderStyle = FormBorderStyle.FixedDialog, StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false, MaximizeBox = false })
            {
                var fields = new[] { new TextBox(), new TextBox(), new TextBox() };
                var stock = new NumericUpDown { Maximum = int.MaxValue };
                var rows = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(12),
                    ColumnCount = 2, AutoSize = true };
                string[] labels = { "ISBN", "书名", "作者" };
                for (int index = 0; index < fields.Length; index++)
                {
                    fields[index].AccessibleName = labels[index];
                    fields[index].Dock = DockStyle.Fill;
                    rows.Controls.Add(new Label { Text = labels[index], AutoSize = true }, 0, index);
                    rows.Controls.Add(fields[index], 1, index);
                }
                stock.AccessibleName = "库存";
                rows.Controls.Add(new Label { Text = "库存", AutoSize = true }, 0, 3);
                rows.Controls.Add(stock, 1, 3);
                var save = new Button { Text = "保存", AutoSize = true };
                rows.Controls.Add(save, 1, 4);
                dialog.AcceptButton = save;
                dialog.Controls.Add(rows);

                save.Click += (s, args) =>
                {
                    string isbn = fields[0].Text.Trim();
                    string title = fields[1].Text.Trim();
                    string author = fields[2].Text.Trim();
                    if (isbn.Length == 0 || title.Length == 0 || author.Length == 0)
                    {
                        MessageBox.Show(dialog, "请填写 ISBN、书名和作者。");
                        return;
                    }

                    RunDatabaseAction(() =>
                    {
                        DBHelper.ExecuteNonQuery(
                            "INSERT INTO books (ISBN, Title, Author, Stock) VALUES (@isbn, @title, @author, @stock)",
                            new MySqlParameter("@isbn", isbn), new MySqlParameter("@title", title),
                            new MySqlParameter("@author", author), new MySqlParameter("@stock", (int)stock.Value));
                        dialog.DialogResult = DialogResult.OK;
                    });
                };
                if (dialog.ShowDialog(this) == DialogResult.OK)
                    RunDatabaseAction(LoadBooks);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!IsAdmin)
                return;

            string username = txtUsername.Text.Trim();
            if (username.Length == 0 || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("请填写用户名和密码。");
                return;
            }

            RunDatabaseAction(() =>
            {
                const string sql = @"INSERT INTO users (Username, PasswordHash, Role)
                    VALUES (@username, @passwordHash, @role)";
                DBHelper.ExecuteNonQuery(sql, new MySqlParameter("@username", username),
                    new MySqlParameter("@passwordHash", BCrypt.Net.BCrypt.HashPassword(txtPassword.Text)),
                    new MySqlParameter("@role", cmbRole.SelectedItem));
                txtUsername.Clear();
                txtPassword.Clear();
                LoadUsers();
            });
        }

        private void RunDatabaseAction(Action action)
        {
            try
            {
                action();
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Number == 1062 ? "记录已存在。" : "数据库操作失败，请检查连接和数据库配置。");
            }
        }
    }
}
