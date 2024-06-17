using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkPos
{
    public partial class AddEmployeeForm : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["PosConnection"].ConnectionString;
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            idText.Text = nameText.Text = pwdText.Text = repwdText.Text = string.Empty;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idText.Text) || string.IsNullOrEmpty(nameText.Text) || string.IsNullOrEmpty(pwdText.Text) || string.IsNullOrEmpty(repwdText.Text))
            {
                MessageBox.Show("帳號、姓名、密碼以及再輸入密碼不可以空白");
                idText.Text = nameText.Text = pwdText.Text = repwdText.Text = string.Empty;
                idText.Focus();
                return;
            }
            if (repwdText.Text != pwdText.Text)
            {
                MessageBox.Show("密碼與再輸入密碼不相同");
                pwdText.Text = repwdText.Text = string.Empty;
                pwdText.Focus();
                return;
            }
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string strAddEmp = "INSERT INTO [Employee] (EmployeeID, EmployeeName, EmployeePwd) VALUES(@txtId, @txtName, @txtPwd)";
                using (SqlCommand cmd = new SqlCommand(strAddEmp, conn))
                {
                    cmd.Parameters.AddWithValue("@txtId", idText.Text);
                    cmd.Parameters.AddWithValue("@txtName", nameText.Text);
                    cmd.Parameters.AddWithValue("@txtPwd", pwdText.Text);
                    try
                    {
                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show($"成功加入 {count} 位員工");
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("使用者已經存在");
                        }
                        else
                        {
                            MessageBox.Show("新增使用者發生錯誤");
                        }
                    }
                    finally
                    {
                        idText.Text = nameText.Text = pwdText.Text = repwdText.Text = string.Empty;
                    }
                }
            }
        }
    }
}
