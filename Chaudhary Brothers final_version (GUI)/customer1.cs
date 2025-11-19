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
    public partial class customer1 : Form
    {
        public customer1()
        {
            InitializeComponent();
            LoadCustomersIntoGrid();
        }

        private void customer_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
                this.Hide();
            dashboard.Show();
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

        private void username_Click(object sender, EventArgs e)
        {

            inventory inventory = new inventory();
            this.Hide();
            inventory.Show();
        }

        private void inventory_pic_Click(object sender, EventArgs e)
        {

            inventory inventory = new inventory();
            this.Hide();
            inventory.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            returns returns = new returns();
            this.Hide();
            returns.Show();
        }

        private void return_pic_Click(object sender, EventArgs e)
        {
            returns returns = new returns();
            this.Hide();
            returns.Show();
        }

        private void generate_bill_Click(object sender, EventArgs e)
        {
            bill bill = new bill();
            this.Hide();
            bill.Show();
        }

        private void bill_pic_Click(object sender, EventArgs e)
        {

            bill bill = new bill();
            this.Hide();
            bill.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            dashboard dashboard = new dashboard();
            this.Hide();
            dashboard.Show();
        }

      
        private async Task<DataTable> FetchProductsAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string url = "http://localhost:8080/getAllCustomers"; // Adjust as necessary
                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var products = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonResponse);
                    return ConvertToDataTable(products);
                }
                else
                {
                    throw new Exception("Failed to retrieve Customers");
                }
            }
        }


        private DataTable ConvertToDataTable(List<Dictionary<string, object>> items)
        {
            var dt = new DataTable();
            if (items.Count == 0) return dt;

           
            foreach (var key in items[0].Keys)
            {
                dt.Columns.Add(key);
            }

           
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

        private async void LoadCustomersIntoGrid()
        {
            DataTable productsTable = await FetchProductsAsync();
            dataGridView1.Rows.Clear();

            foreach (DataRow row in productsTable.Rows)
            {
                int rowIndex = dataGridView1.Rows.Add();


                dataGridView1.Rows[rowIndex].Cells["id"].Value = row["customer_id"];
                dataGridView1.Rows[rowIndex].Cells["fname"].Value = row["first_name"];
                dataGridView1.Rows[rowIndex].Cells["lname"].Value = row["last_name"];
                dataGridView1.Rows[rowIndex].Cells["em"].Value = row["email"];
                dataGridView1.Rows[rowIndex].Cells["ph"].Value = row["phone_number"];
                dataGridView1.Rows[rowIndex].Cells["adr"].Value = row["address"];
              
            }
        }




       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                Object a = (dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                Object b = (dataGridView1.Rows[e.RowIndex].Cells["fname"].Value);
                Object c = (dataGridView1.Rows[e.RowIndex].Cells["lname"].Value);
                Object d = (dataGridView1.Rows[e.RowIndex].Cells["ph"].Value);
                Object e1 = (dataGridView1.Rows[e.RowIndex].Cells["em"].Value);
                Object f = (dataGridView1.Rows[e.RowIndex].Cells["adr"].Value);
            
                string a1 = a.ToString();
                string b1 = b.ToString();
                string c1 = c.ToString();
                string d1 = d.ToString();
                string e2 = e1.ToString();
                string f1 = f.ToString();
               
                Update_Customer obj = new Update_Customer(a1, b1, c1, d1, e2, f1);
                obj.CustomerUpdated += (s, args) => LoadCustomersIntoGrid();
                obj.Show();


            }
            var dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Deletion!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int productId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["ID"].Value);
                    if (await DeleteCustomer(productId))
                    {
                        dgv.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("customer deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete Customer.");
                    }
                }
            }
            }
        private async Task<bool> DeleteCustomer(int productId)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:8080/"); 
                try
                {
                    HttpResponseMessage response = await httpClient.DeleteAsync($"DeleteCustomer/{productId}");
                    return response.IsSuccessStatusCode;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fnam.Text) || string.IsNullOrEmpty(lnam.Text) || string.IsNullOrEmpty(ema.Text) || string.IsNullOrEmpty(phn.Text) || string.IsNullOrEmpty(ar.Text))
            {
                MessageBox.Show("  Empty Fields !"); return;
            }
            Customer customer = new Customer
            {
                firstName = fnam.Text,
                lastName = lnam.Text,
                email = ema.Text,
                phoneNumber = phn.Text,
                address = ar.Text
            };



            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/");  // Adjust the port if needed
                var content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync("InsertCustomer", content);
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCustomersIntoGrid();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            @enum obj = new @enum();
            bool a = obj.check();
            if (a == true)
            {
                this.Close();
                owner_dashboard obj1 = new owner_dashboard();
                obj1.Show();
            }
            else
            {
                MessageBox.Show("Only Owner Has Access  !", "Invalid User Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
