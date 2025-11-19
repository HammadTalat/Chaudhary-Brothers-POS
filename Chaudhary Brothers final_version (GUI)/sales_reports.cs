using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaudhary_Brothers
{
    public partial class sales_reports : Form
    {
        public sales_reports()
        {
            InitializeComponent();
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

        private void username_Click(object sender, EventArgs e)
        {
            owner owner = new owner();
            this.Hide();
            owner.Show();
        }

        private void inventory_pic_Click(object sender, EventArgs e)
        {
            owner owner = new owner();
            this.Hide();
            owner.Show();
        }

        private void logout_panel_Paint(object sender, PaintEventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private async Task<DataTable> FetchProductsAsync(string startDate, string endDate)
        {
            using (var httpClient = new HttpClient())
            {
                string url = $"http://localhost:8080/getSalesDetailsByDateRange?startDate={startDate}&endDate={endDate}";
                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var products = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonResponse);
                    return ConvertToDataTable(products);
                }
                else
                {
                    throw new Exception("Failed to retrieve Details");
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
            string s_date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string e_date = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            DataTable productsTable = await FetchProductsAsync(s_date, e_date);
            dataGridView1.Rows.Clear();

            foreach (DataRow row in productsTable.Rows)
            {
                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells["date"].Value = row["invoice_date"];
                dataGridView1.Rows[rowIndex].Cells["name"].Value = row["name"];
                dataGridView1.Rows[rowIndex].Cells["Company_Name"].Value = row["company_name"];
                dataGridView1.Rows[rowIndex].Cells["sale_price"].Value = row["sales_price"];
                dataGridView1.Rows[rowIndex].Cells["total_price"].Value = row["total_price"];
                dataGridView1.Rows[rowIndex].Cells["sales"].Value = row["total_quantity_sold"];
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            LoadProductsIntoGrid();
        }

        private void button_Click_1(object sender, EventArgs e)
        {
            LoadProductsIntoGrid();
        }
    }
}
