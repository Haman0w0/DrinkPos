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
    public partial class SetupForm : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["PosConnection"].ConnectionString;
        string strGetDrinkName = @"SELECT * FROM [Drink]";
        string strGetDrinkSize = @"SELECT * FROM [Size]";
        public SetupForm()
        {
            InitializeComponent();
        }

        private void RefreshCombobox(SqlConnection conn, ComboBox cbControl, string strSql, string strValue, string strDisplay)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(strSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cbControl.DataSource = dataTable;
            cbControl.ValueMember = strValue;
            cbControl.DisplayMember = strDisplay;
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                RefreshCombobox(conn, sizeCBox, strGetDrinkSize, "SizeID", "SizeName");
                RefreshCombobox(conn, setSizeCBox, strGetDrinkSize, "SizeID", "SizeName");

                RefreshCombobox(conn, drinkNameCBox, strGetDrinkName, "DrinkID", "DrinkName");
                RefreshCombobox(conn, setDrinkNameCBox, strGetDrinkName, "DrinkID", "DrinkName");
            }
        }

        private void addDrinkNameBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(drinkNameText.Text))
            {
                MessageBox.Show("飲料名稱不可以空白");
                drinkNameText.Focus();
                return;
            }
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string strAddName = "INSERT INTO [Drink] (DrinkName) VALUES(@txtName)";
                using (SqlCommand cmd = new SqlCommand(strAddName, conn))
                {
                    cmd.Parameters.AddWithValue("@txtName", drinkNameText.Text);
                    try
                    {
                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show("新增飲料成功");
                        RefreshCombobox(conn, drinkNameCBox, strGetDrinkName, "DrinkID", "DrinkName");
                        RefreshCombobox(conn, setDrinkNameCBox, strGetDrinkName, "DrinkID", "DrinkName");
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("飲料名稱已經存在");
                        }
                        else
                        {
                            MessageBox.Show("新增飲料名稱發生錯誤");
                        }
                    }
                    finally
                    {
                        drinkNameText.Text = string.Empty;
                    }
                }
            }
        }

        private void addSizeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sizeText.Text))
            {
                MessageBox.Show("容量不可以空白");
                sizeText.Focus();
                return;
            }
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string strAddSize = "INSERT INTO [Size] (SizeName) VALUES(@txtSize)";
                using (SqlCommand cmd = new SqlCommand(strAddSize, conn))
                {
                    cmd.Parameters.AddWithValue("@txtSize", sizeText.Text);
                    try
                    {
                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show("新增容量成功");
                        RefreshCombobox(conn, sizeCBox, strGetDrinkSize, "SizeID", "SizeName");
                        RefreshCombobox(conn, setSizeCBox, strGetDrinkSize, "SizeID", "SizeName");
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("容量已經存在");
                        }
                        else
                        {
                            MessageBox.Show("新增容量發生錯誤");
                        }
                    }
                    finally
                    {
                        sizeText.Text = string.Empty;
                    }
                }
            }
        }

        private void drinkAddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(setPriceText.Text))
            {
                MessageBox.Show("請輸入價格");
                setPriceText.Text = string.Empty;
                return;
            }
            if (!int.TryParse(setPriceText.Text, out int price))
            {
                MessageBox.Show("價格必須是整數");
                setPriceText.Text = string.Empty;
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PosConnection"].ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string strInertDrink = $"INSERT INTO DrinkSize(DrinkID, SizeID, Price) VALUES (@DrinkID, @SizeID, @Price);";
                using (SqlCommand cmd = new SqlCommand(strInertDrink, conn))
                {
                    cmd.Parameters.AddWithValue("@DrinkID", Convert.ToInt32(setDrinkNameCBox.SelectedValue));
                    cmd.Parameters.AddWithValue("@SizeID", Convert.ToInt32(setSizeCBox.SelectedValue));
                    cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(setPriceText.Text));
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("新增成功");
                        setPriceText.Text = string.Empty;
                        setDrinkNameCBox.SelectedIndex = 0;
                        setSizeCBox.SelectedIndex = 0;
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("飲料名稱與容量組合已經存在");
                        }
                        else
                        {
                            MessageBox.Show($"新增失敗 - {ex.Message}");
                        }
                        setPriceText.Text = string.Empty;
                    }
                }
            }
        }
    }
}
