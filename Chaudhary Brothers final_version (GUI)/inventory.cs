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
using Newtonsoft.Json;
using System.Text.Json;

namespace Chaudhary_Brothers
{
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
            LoadProductsIntoGrid();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void returns_Click(object sender, EventArgs e)
        {
            returns ret = new returns();
            this.Close();
            ret.Show();

        }

        private void return_pic_Click(object sender, EventArgs e)
        {
            returns ret = new returns();
            this.Hide();
            ret.Show();
        }

        private void generate_bill_Click(object sender, EventArgs e)
        {
            bill billform = new bill();
            this.Hide();
            billform.Show();
        }

        private void bill_pic_Click(object sender, EventArgs e)
        {
            bill billform = new bill();
            this.Hide();
            billform.Show();
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            this.Hide();
            dashboard.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            dashboard dashboard = new dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            customer1 cus = new customer1();
            this.Hide();
            cus.Show();
        }

        private void customer_pic_Click(object sender, EventArgs e)
        {
            customer1 cus = new customer1();
            this.Hide();
            cus.Show();
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
                Form1 obj=new Form1();
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


        private async Task<DataTable> FetchProductsAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://localhost:8080/getAllProducts"; // Adjust as necessary
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


                dataGridView1.Rows[rowIndex].Cells["ID"].Value = row["product_id"];
                dataGridView1.Rows[rowIndex].Cells["Name1"].Value = row["name"];
                dataGridView1.Rows[rowIndex].Cells["Company"].Value = row["company_name"];
                dataGridView1.Rows[rowIndex].Cells["Unit_price"].Value = row["unit_price"];
                dataGridView1.Rows[rowIndex].Cells["Tax"].Value = row["tax"];
                dataGridView1.Rows[rowIndex].Cells["Sale_price"].Value = row["sales_price"];
                dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = row["unit_quantity"];
                dataGridView1.Rows[rowIndex].Cells["Unit"].Value = "Numbers";
            }
        }




        private async void Add_Product(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(comp_name.Text) || string.IsNullOrEmpty(unit_name.Text) || string.IsNullOrEmpty(tax_n.Text)|| string.IsNullOrEmpty(sale_p.Text)|| string.IsNullOrEmpty(quant.Text)) {
                MessageBox.Show("  Empty Fields !"); return; }
            Product product = new Product
            {
                name = name.Text,
                companyName = comp_name.Text,
                unitPrice = decimal.Parse(unit_name.Text),
                tax = decimal.Parse(tax_n.Text),
                salesPrice = decimal.Parse(sale_p.Text),
                unitQuantity = int.Parse(quant.Text)

            };

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/");  // Adjust the port if needed
                var content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync("InsertProduct", content);
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductsIntoGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                Object a = (dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                Object b = (dataGridView1.Rows[e.RowIndex].Cells["Name1"].Value);
                Object c = (dataGridView1.Rows[e.RowIndex].Cells["Company"].Value);
                Object d = (dataGridView1.Rows[e.RowIndex].Cells["Unit_price"].Value);
                Object e1 = (dataGridView1.Rows[e.RowIndex].Cells["Tax"].Value);
                Object f = (dataGridView1.Rows[e.RowIndex].Cells["Sale_price"].Value);
                Object g = (dataGridView1.Rows[e.RowIndex].Cells["Unit"].Value);
                Object h = (dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);
                string a1 = a.ToString();
                string b1=b.ToString();
                string c1 = c.ToString();
                string d1 = d.ToString();
                string e2 = e1.ToString();
                string f1 = f.ToString();
                string g1 = g.ToString();
                string h1 = h.ToString();
                Update_Product obj = new Update_Product(a1, b1, c1, d1, e2, f1, g1, h1);
                obj.ProductUpdated += (s, args) => LoadProductsIntoGrid();
                obj.Show();
                
           
            }
            var dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Deletion!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int productId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["ID"].Value);
                    if (await DeleteProduct(productId))
                    {
                        dgv.Rows.RemoveAt(e.RowIndex);
                        
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product.");
                    }
                }
            }
        }
        private async Task<bool> DeleteProduct(int productId)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:8080/"); // Make sure this is your API base URL
                try
                {
                    HttpResponseMessage response = await httpClient.DeleteAsync($"DeleteProduct/{productId}");
                    return response.IsSuccessStatusCode;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            @enum obj = new @enum();
            bool a = obj.check();
            if (a == true)
            {
                this.Close();
                owner_dashboard obj1=new owner_dashboard();
                obj1.Show();
            }
            else
            {
                MessageBox.Show("Only Owner Has Access  !", "Invalid User Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
