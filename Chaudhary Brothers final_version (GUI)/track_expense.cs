using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaudhary_Brothers
{
    public partial class track_expense : Form
    {
        public track_expense()
        {
            InitializeComponent();
            LoadProductsIntoGrid();
            this.Load += new EventHandler(Total_Unit_Price);
            this.Load += new EventHandler(Total_Sales_Price);
            this.Load += new EventHandler(Total_Profit);
        }
        private async void Total_Unit_Price(object sender, EventArgs e)
        {
            string unit = await getTotalUnitPrice();
            if (unit != null)
            {
                label7.Text = "" + unit;
            }
            else
            {
                label7.Text = "Failed to retrieve the most popular item.";
            }
        }
        private async Task<string> getTotalUnitPrice()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:8080/"); // Make sure this is your API base URL
                try
                {
                    string response = await httpClient.GetStringAsync("getTotalUnitPrice");
                    return response;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        private async void Total_Sales_Price(object sender, EventArgs e)
        {
            string sales = await getTotalSalesPrice();
            if (sales != null)
            {
                label8.Text = "" + sales;
            }
            else
            {
                label8.Text = "Failed to retrieve the most popular item.";
            }
        }
        private async Task<string> getTotalSalesPrice()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:8080/"); 
                try
                {
                    string response = await httpClient.GetStringAsync("getTotalSalesPrice");
                    return response;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private async void Total_Profit(object sender, EventArgs e)
        {
            string profit = await getExpectedProfit();
            if (profit != null)
            {
                label9.Text = "" + profit;
            }
            else
            {
                label9.Text = "Failed to retrieve the most popular item.";
            }
        }
        private async Task<string> getExpectedProfit()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:8080/"); // Make sure this is your API base URL
                try
                {
                    string response = await httpClient.GetStringAsync("getExpectedProfit");
                    return response;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {
            inventory inventory = new inventory();
            this.Hide();
            inventory.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            inventory inventory = new inventory();
            this.Hide();
            inventory.Show();
        }

        private void username_Click(object sender, EventArgs e)
        {
            owner owner = new owner();
            this.Hide();
            owner.Show();
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            owner_dashboard dashboard = new owner_dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            owner_dashboard dashboard = new owner_dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void inventory_pic_Click(object sender, EventArgs e)
        {
            owner owner = new owner();
            this.Hide();
            owner.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure you want to Logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                @enum obj2 = new @enum();
                obj2.end();
                this.Close();
                Form1 obj = new Form1();
                obj.Show();
            }
        }

        private void logout_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure you want to Logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                @enum obj2 = new @enum();
                obj2.end();
                this.Close();
                Form1 obj = new Form1();
                obj.Show();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async Task<DataTable> FetchProductsAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://localhost:8080/getAllProductsDesc"; // Adjust as necessary
                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var products = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonResponse);
                    return ConvertToDataTable(products);
                }
                else
                {
                    throw new Exception("Failed to retrieve products");
                }
            }
        }


        private DataTable ConvertToDataTable(List<Dictionary<string, object>> items)
        {
            var dt = new DataTable();
            if (items.Count == 0) return dt;

            // Add columns dynamically based on the first element
            foreach (var key in items[0].Keys)
            {
                dt.Columns.Add(key);
            }

            // Add rows
            foreach (var item in items)
            {
                var row = dt.NewRow();
                foreach (var key in item.Keys)
                {
                    row[key] = item[key] ?? DBNull.Value;
                }
                dt.Rows.Add(row);
            }

            return dt;
        }

        private async void LoadProductsIntoGrid()
        {
            DataTable productsTable = await FetchProductsAsync();
            dataGridView1.Rows.Clear();

            foreach (DataRow row in productsTable.Rows)
            {
                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells["Name1"].Value = row["name"];
                dataGridView1.Rows[rowIndex].Cells["Company_Name"].Value = row["company_name"];
                dataGridView1.Rows[rowIndex].Cells["Unit_price"].Value = row["unit_price"];
                dataGridView1.Rows[rowIndex].Cells["Tax"].Value = row["tax"];
                dataGridView1.Rows[rowIndex].Cells["Sale_price"].Value = row["sales_price"];
                dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = row["unit_quantity"];
                dataGridView1.Rows[rowIndex].Cells["Unit"].Value = "Numbers";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }
}
