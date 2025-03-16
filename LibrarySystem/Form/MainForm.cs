using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystem.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace LibrarySystem
{
    public partial class MainForm : Form
    {
        private readonly User _currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            InitAccessControl();
            LoadBooks();
            LoadUsers();
        }

        private void InitAccessControl()
        {
            // 权限控制
            btnManageUsers.Visible = (_currentUser.Role == "Admin");
        }

        private void LoadBooks()
        {
            string sql = "SELECT BookID, ISBN, Title, Author, Stock FROM books";
            dgvBooks.DataSource = DBHelper.ExecuteQuery(sql);
        }
        private void LoadUsers()
        {
            string sql = "SELECT UserID, Username, Role FROM users";
            dgvUsers.DataSource = DBHelper.ExecuteQuery(sql);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0) return;

            int bookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);
            string sql = @"UPDATE books SET Stock = Stock - 1 
                      WHERE BookID = @bookId AND Stock > 0";

            if (DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@bookId", bookId)) > 0)
            {
                MessageBox.Show("借阅成功");
                LoadBooks();
            }
        }
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            
         
            LoadUsers(); // 刷新用户列表
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            
             string isbn;
             string title ;
             string author ;
             int stock ;
            
            string sql = @"insert intobooks values (null, @isbn, @title, @author, @stock)";
            LoadBooks();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO users (Username, PasswordHash, Role)
                     VALUES (@name, @pwd, @role)";

            string hashedPwd = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

            DBHelper.ExecuteNonQuery(sql,
                new MySqlParameter("@name", txtUsername.Text),
                new MySqlParameter("@pwd", hashedPwd),
                new MySqlParameter("@role", cmbRole.SelectedValue));
        }
    }

    // 用户管理窗体


    // 用户管理窗体
   
}
