using MySql.Data.MySqlClient;
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

namespace LibrarySystem
{
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;  // 实际应使用哈希值比较

            string sql = "SELECT * FROM users WHERE Username = @username AND Password = @password";
            MySqlParameter[] parameters = {
        new MySqlParameter("@username", username),
        new MySqlParameter("@password", password)
    };

            DataTable dt = DBHelper.ExecuteQuery(sql, parameters);
            if (dt.Rows.Count > 0)
            {
                User currentUser = new User(
                    Convert.ToInt32(dt.Rows[0]["UserID"]),
                    dt.Rows[0]["Username"].ToString(),
                    dt.Rows[0]["Role"].ToString()
                );

                MainForm mainForm = new MainForm(currentUser);
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }
    }
}
