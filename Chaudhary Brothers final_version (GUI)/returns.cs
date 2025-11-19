using Org.BouncyCastle.Tls;
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
    public partial class returns : Form
    {
        public returns()
        {
            InitializeComponent();
        }

        private void return_pic_Click(object sender, EventArgs e)
        {

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

        private void logout_panel_Paint(object sender, PaintEventArgs e)
        {
            
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
            customer1 customer = new customer1();
            this.Hide();
            customer.Show();
        }

        private void customer_pic_Click(object sender, EventArgs e)
        {
            customer1 customer = new customer1();
            this.Hide();
            customer.Show();
        }
        public async Task<List<string>> GetInvoiceDetails(int invoiceId)
        {
            using (var client = new HttpClient())
            {
                string url = $"http://localhost:8080/getInvoiceDetails?invoiceId={invoiceId}";
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(jsonString);
                }
                else
                {
                    MessageBox.Show("Failed to load invoice details: " + response.StatusCode);
                    return null;  // Or handle differently
                }
            }
        }
        public async void LoadDataIntoDataGridView(DataGridView dataGridView, int invoiceId)
        {
            try
            {
                List<string> invoiceDetails = await GetInvoiceDetails(invoiceId);
                dataGridView1.Rows.Clear();

                foreach (string detail in invoiceDetails)
                {
                    string[] parts = detail.Split(','); // Split the string by comma
                    if (parts.Length >= 6) // Ensure there are enough parts to avoid index out of range
                    {
                        int rowIndex = dataGridView1.Rows.Add();
                        dataGridView1.Rows[rowIndex].Cells["prod"].Value = parts[0];
                        dataGridView1.Rows[rowIndex].Cells["sale"].Value = parts[1];
                        dataGridView1.Rows[rowIndex].Cells["quant"].Value = parts[2];
                        dataGridView1.Rows[rowIndex].Cells["un"].Value = parts[3];
                        dataGridView1.Rows[rowIndex].Cells["tx"].Value = parts[4];
                        dataGridView1.Rows[rowIndex].Cells["total_Amount"].Value = parts[5];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
        private async Task<int> GetProductID(string productName)
        {
            string url = $"http://localhost:8080/getProductID?productName={Uri.EscapeDataString(productName)}";
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                return int.Parse(response); // Assuming the API returns a string that can be parsed as int
            }
        }
        private async Task<int> GetInvoiceProductQuant(string productName, int invoiceId)
        {
            string url = $"http://localhost:8080/getInvoiceProductQuant?productName={Uri.EscapeDataString(productName)}&invoiceId={invoiceId}";
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var responseString = await httpClient.GetStringAsync(url);
                    return int.Parse(responseString);
                }
                catch (HttpRequestException e)
                {
                    // Handle the case where the resource was not found or server error
                    Console.WriteLine($"Error fetching quantity: {e.Message}");
                    return 0;
                }
            }
        }

        private async Task UpdateProductQuantity2(int productId, int quantity)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/");
                HttpResponseMessage response = await client.PutAsync($"UpdateProductQuantity2/{productId}?quantity={quantity}", null);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Failed to update quantity for product {productId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Action" && e.RowIndex >= 0)
            {
                
                if (MessageBox.Show("Do you want to return this product?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int productId=await GetProductID(dataGridView1.Rows[e.RowIndex].Cells["prod"].Value.ToString());
                    int id = int.Parse(invoice_id.Text);
                    int l = await GetInvoiceProductQuant(dataGridView1.Rows[e.RowIndex].Cells["prod"].Value.ToString(),id);
                



                    try
                    {
                        await DeleteProductFromInvoice(productId,id);
                        MessageBox.Show("Product returned successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await UpdateProductQuantity2(productId, l);
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to return product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async Task DeleteProductFromInvoice(int productId, int invoiceId)
        {
            using (HttpClient client = new HttpClient())
            {
                string uri = $"http://localhost:8080/deleteProductFromInvoice/{invoiceId}/{productId}";
                HttpResponseMessage response = await client.DeleteAsync(uri);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"API call failed with status code: {response.StatusCode} and message: {response.ReasonPhrase}");
                }
            }
        }
        public async Task<bool> CheckInvoiceExistsAsync(int invoiceId)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {

                    
                    string url = $"http://localhost:8080/checkInvoiceExists?invoiceId={invoiceId}";

                   
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception($"API call failed with status code: {response.StatusCode}");
                    }

                   
                    string responseString = await response.Content.ReadAsStringAsync();
                    return bool.Parse(responseString);
                }
                catch (Exception ex)
                {
                   
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return false;
                }
            }

        }

        public async Task<string> GetInvoiceDate(int productId)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                
                httpClient.BaseAddress = new Uri("http://localhost:8080/");

                string url = $"getInvoiceDate?product={productId}";

                try
                {
                    
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        
                        string invoiceDate = await response.Content.ReadAsStringAsync();
                        return invoiceDate;
                    }
                    else
                    {
                    
                        MessageBox.Show($"Failed to retrieve invoice date. Status: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show($"An error occurred while fetching the invoice date: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return "";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(invoice_id.Text))
            {
                MessageBox.Show("Invalid ID ! ");
                return;
            }
            else if (!await CheckInvoiceExistsAsync(int.Parse(invoice_id.Text))){
                MessageBox.Show("Invoice Does Not Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            string obj = await GetInvoiceDate(int.Parse(invoice_id.Text));
            date.Text = obj;
            LoadDataIntoDataGridView(dataGridView1, int.Parse(invoice_id.Text));
        }

        private async void label4_Click(object sender, EventArgs e)
        {
            

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

        private void invoice_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
