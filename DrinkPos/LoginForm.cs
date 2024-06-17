using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace DrinkPos
{
    public partial class LoginForm : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["PosConnection"].ConnectionString;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            idText.Text = pwdText.Text = string.Empty;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idText.Text) || string.IsNullOrEmpty(pwdText.Text))
            {
                MessageBox.Show("帳號以及密碼不可以空白");
                idText.Text = pwdText.Text = string.Empty;
                idText.Focus();
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    string strValidUser = "SELECT COUNT(*) FROM Employee WHERE EmployeeID = @EmpID AND EmployeePwd = @EmpPwd";
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    using (SqlCommand cmd = new SqlCommand(strValidUser, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmpID", idText.Text);
                        cmd.Parameters.AddWithValue("@EmpPwd", pwdText.Text);
                        try
                        {
                            int count = Convert.ToInt32(cmd.ExecuteScalar());
                            if (count == 1)
                            {
                                MessageBox.Show("登入成功");
                                MainForm parent = (MainForm)((this.Parent).Parent);
                                parent.SetLoginResult(true, idText.Text);
                            }
                            else
                            {
                                MessageBox.Show("登入失敗");
                                idText.Text = pwdText.Text = string.Empty;
                            }
                        }
                        catch
                        {
                            MessageBox.Show(":( 系統發生錯誤，請通知管理員");
                        }
                    }
                }
            }
        }

        private void addEmployeeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm parent =(MainForm)((this.Parent).Parent);
            parent.OpenChildForm(new AddEmployeeForm());
        }
    }
}
