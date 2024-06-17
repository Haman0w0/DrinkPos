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
    public partial class SaleForm : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["PosConnection"].ConnectionString;
        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            LoadDrinkCombo();
            LoadSizeCombo((int)drinkNameCBox.SelectedValue);
            labPrice.Text = "$" + GetDrinkPrice((int)drinkNameCBox.SelectedValue, (int)sizeCBox.SelectedValue).ToString();
            countCBox.SelectedIndex = 0;
        }

        private void LoadDrinkCombo()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string sqlDrink = "SELECT DISTINCT Drink.* FROM Drink INNER JOIN DrinkSize ON Drink.DrinkID = DrinkSize.DrinkID ORDER BY Drink.DrinkID;";
                using (SqlCommand cmd = new SqlCommand(sqlDrink, conn))
                {
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        drinkNameCBox.DataSource = dataTable;
                        drinkNameCBox.ValueMember = "DrinkID";
                        drinkNameCBox.DisplayMember = "DrinkName";
                        drinkNameCBox.SelectedIndex = 0;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("載入飲料名稱發生錯誤");
                    }
                }
            }
        }

        private void LoadSizeCombo(int DrinkID)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string sqlGetSize = "SELECT Size.SizeID, Size.SizeName FROM DrinkSize INNER JOIN Size ON DrinkSize.SizeID = Size.SizeID WHERE DrinkSize.DrinkID = @DrinkID;";
                using (SqlCommand cmd = new SqlCommand(sqlGetSize, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@DrinkID", DrinkID);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        sizeCBox.DataSource = dataTable;
                        sizeCBox.ValueMember = "SizeID";
                        sizeCBox.DisplayMember = "SizeName";
                        sizeCBox.SelectedIndex = 0;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"載入飲料容量錯誤");
                    }
                }
            }
        }

        private int GetDrinkPrice(int DrinkID, int SizeID)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string sqlGetPrice = $"SELECT Price FROM DrinkSize WHERE DrinkID = @DrinkID AND SizeID = @SizeID;";
                using (SqlCommand cmd = new SqlCommand(sqlGetPrice, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@DrinkID", DrinkID);
                        cmd.Parameters.AddWithValue("@SizeID", SizeID);
                        int price = Convert.ToInt32(cmd.ExecuteScalar());
                        return price;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("取得價格發生錯誤");
                        return -1;
                    }
                }
            }
        }

        private void drinkNameCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadSizeCombo((int)drinkNameCBox.SelectedValue);
            labPrice.Text = "$" + GetDrinkPrice((int)drinkNameCBox.SelectedValue, (int)sizeCBox.SelectedValue).ToString();
        }

        private void sizeCBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            labPrice.Text = "$" + GetDrinkPrice((int)drinkNameCBox.SelectedValue, (int)sizeCBox.SelectedValue).ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int index = detailDGV.Rows.Add();
            detailDGV.Rows[index].Cells[0].Value = detailDGV.Rows.Count;
            detailDGV.Rows[index].Cells[1].Value = drinkNameCBox.Text;
            detailDGV.Rows[index].Cells[2].Value = sizeCBox.Text;
            detailDGV.Rows[index].Cells[3].Value = countCBox.SelectedItem;
            detailDGV.Rows[index].Cells[4].Value = Convert.ToInt32(labPrice.Text.TrimStart('$')) * Convert.ToInt32(countCBox.SelectedItem);
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            if (detailDGV.Rows.Count < 1)
            {
                MessageBox.Show("沒有購買的商品");
                return;
            }
            int total = 0;
            for (int i = 0; i < detailDGV.Rows.Count; i++)
            {
                total += Convert.ToInt32(detailDGV.Rows[i].Cells[4].Value);
            }
            MessageBox.Show($"總金額 = {total}元");
        }
    }
}
