using System;
using System.Windows.Forms;
using LibrarySystem.Models;
using LibrarySystem.Services;
using MySql.Data.MySqlClient;

namespace LibrarySystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User currentUser = AuthService.ValidateUser(txtUsername.Text.Trim(), txtPassword.Text);
                if (currentUser == null)
                {
                    MessageBox.Show("用户名或密码错误。");
                    return;
                }

                var mainForm = new MainForm(currentUser);
                mainForm.FormClosed += (s, args) => Close();
                mainForm.Show();
                Hide();
            }
            catch (MySqlException)
            {
                MessageBox.Show("无法打开图书系统，请检查数据库连接和初始化配置。");
            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
