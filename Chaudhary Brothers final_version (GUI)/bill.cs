using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemTextJson = System.Text.Json.JsonSerializer;
using NewtonsoftJson = Newtonsoft.Json.JsonSerializer;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;
using iText.IO.Font.Constants;
using iText.Kernel.Font;

namespace Chaudhary_Brothers
{
    public partial class bill : Form
    {
        private List<string> allProductNames = new List<string>(); // Store all product names

        public bill()
        {
            InitializeComponent();
            name.TextChanged += new EventHandler(name_TextChanged);
            name.KeyDown += new KeyEventHandler(name_KeyDown); // Handle the KeyDown event
            this.Load += new EventHandler(Form_Load);
            listBox1.MouseClick += new MouseEventHandler(listBox1_MouseClick);
            listBox1.KeyDown += new KeyEventHandler(listBox1_KeyDown);

            cash.Checked = true; // Set default payment method as cash


        }

        private async void Form_Load(object sender, EventArgs e)
        {
            // Load all product names when the form loads
            allProductNames = await GetProductNamesAsync();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string searchText = textBox.Text.Trim();
                List<string> filteredNames = allProductNames.FindAll(
                    name => name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0
                );
                listBox1.DataSource = null; // Clear the ListBox to ensure the UI updates
                listBox1.DataSource = filteredNames; // Update ListBox with filtered names
            }
        }
        private async void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox textBox = sender as TextBox;
                if (textBox != null && listBox1.SelectedItem != null)
                {
                    string productName = listBox1.SelectedItem.ToString();
                    textBox.Text = productName; // Update the search box with the selected product name
                    int quantity = await GetProductQuantity(productName);
                    int rat = await GetProductRate(productName);

                    inventory.Text = quantity.ToString(); // Set the inventory textbox to the fetched quantity
                    rate.Text = rat.ToString(); // Set the rate textbox to the fetched rate

                    e.Handled = true; // Mark the event as handled
                }
            }
        }

        // Fetches all product names from the API
        public async Task<List<string>> GetProductNamesAsync()
        {
            string url = "http://localhost:8080/getProductsName"; // API that returns all product names
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetStringAsync(url);
                    var products = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(response);
                    List<string> productNames = new List<string>();
                    foreach (var product in products)
                    {
                        productNames.Add(product["name"].ToString());
                    }
                    return productNames;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching product names: " + ex.Message);
                    return new List<string>(); // Return an empty list on failure
                }
            }
        }

        private async Task<int> GetProductQuantity(string productName)
        {
            string url = $"http://localhost:8080/getProductQuantity?productName={Uri.EscapeDataString(productName)}";
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                return int.Parse(response); // Assuming the API returns a string that can be parsed as int
            }
        }

        // API call to get product rate
        private async Task<int> GetProductRate(string productName)
        {
            string url = $"http://localhost:8080/getProductRate?productName={Uri.EscapeDataString(productName)}";
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                return int.Parse(response); // Assuming the API returns a string that can be parsed as int
            }
        }
        private async Task<int> GetProductTax(string productName)
        {
            string url = $"http://localhost:8080/getProductTax?productName={Uri.EscapeDataString(productName)}";
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                return int.Parse(response); // Assuming the API returns a string that can be parsed as int
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Control ctrl in this.Controls)
            {
                // Check if the control is a TextBox
                if (ctrl is TextBox)
                {
                    // Clear the text in the TextBox
                    ctrl.Text = "";
                }
            }

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

        private void returns_Click(object sender, EventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private async void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            await UpdateProductDetails();
        }

        private async void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                await UpdateProductDetails();
            }
        }
        private async Task UpdateProductDetails()
        {
            if (listBox1.SelectedItem != null)
            {
                ;
                string productName = listBox1.SelectedItem.ToString();
                int quantity = await GetProductQuantity(productName);
                int rat = await GetProductRate(productName);
                name.Text = productName;
                inventory.Text = quantity.ToString(); // Set the inventory textbox to the fetched quantity
                rate.Text = rat.ToString(); // Set the rate textbox to the fetched rate
            }
        }


        private async void buttonAdd_Click(object sender, EventArgs e)
        {
                        if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(rate.Text) || string.IsNullOrEmpty(quant.Text)) { MessageBox.Show("  Empty Fields !"); return; }
            else if (int.Parse(quant.Text) == 0) { MessageBox.Show("Invalid quantity ! ");return; }
            int n = await GetProductID(name.Text);
            decimal gst = await GetProductTax(name.Text);
            int quanti = await GetProductQuantity(name.Text);
            if (int.Parse(quant.Text)>quanti)
            {
                MessageBox.Show("  Low Quantity ! ");
            }
           else  if (inventory.Text == "0")
            {
                MessageBox.Show(" Low Inventory  !");
                return;
            }
           

            else {
                InvoiceProduct product = new InvoiceProduct
                {
                    invoiceId = 1,
                    productId = n,
                    name = name.Text,
                    unitPrice = rate.Text,
                    quantity = int.Parse(quant.Text),
                    gstApplied = gst.ToString(),
                    subtotal = (decimal.Parse(rate.Text) * int.Parse(quant.Text)).ToString()


                };
                string temp = (decimal.Parse(product.gstApplied) * (product.quantity)).ToString();
                product.gstApplied = temp;

                int rowIndex = dataGridView1.Rows.Add();


                dataGridView1.Rows[rowIndex].Cells["ID"].Value = product.productId;
                dataGridView1.Rows[rowIndex].Cells["product"].Value = product.name;
                dataGridView1.Rows[rowIndex].Cells["r"].Value = product.unitPrice;
                dataGridView1.Rows[rowIndex].Cells["unit"].Value = "Number";
                dataGridView1.Rows[rowIndex].Cells["quantity"].Value = product.quantity;
                dataGridView1.Rows[rowIndex].Cells["gst"].Value = product.gstApplied;
                dataGridView1.Rows[rowIndex].Cells["Total"].Value = product.subtotal;
                subtot.Text = SumTotalColumn().ToString();
                grandtot.Text = SumTotalColumn().ToString();
            }

        }
        public decimal SumTotalColumn()
        {
            decimal totalSum = 0;  // Variable to hold the sum

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // Ensure the row is not the 'new row' placeholder
                {
                    object value = row.Cells["Total"].Value; // Replace "Total" with your column name
                    if (value != DBNull.Value && value != null) // Check for non-null values
                    {
                        decimal rowTotal = 0;
                        if (decimal.TryParse(value.ToString(), out rowTotal))
                        {
                            totalSum += rowTotal;
                        }
                    }
                }
            }

            return totalSum;  // Return the calculated sum
        }




        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bill_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Remove")
            {
                dgv.Rows.RemoveAt(e.RowIndex);

            }
        }
        private void GeneratePDF(string billNumber, string customerId, string paymentMethod, decimal grandTotal, DataGridView dataGridView, string filePath, string disc)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    using (Document document = new Document(pdf))
                    {
                        // Adding document header
                        PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                        document.Add(new Paragraph("Chaudhary Brothers\n\n")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFont(font)
                            .SetFontSize(20)) ;
                        // Get today's date
                        string today = DateTime.Now.ToString("MMMM dd, yyyy"); // Example: May 01, 2024

                        // Create a paragraph with the current date
                        Paragraph dateParagraph = new Paragraph("Date: " + today+"\n")
                        .SetFont(font)
                            .SetFontSize(12);
                        document.Add(dateParagraph);

                        // Adding sub-header
                        document.Add(new Paragraph($"Invoice ID: {billNumber}\nCustomer ID: {customerId}\n")
                            .SetFont(font)
                            .SetFontSize(12));

                        Table table = new Table(5);
                        table.SetWidth(UnitValue.CreatePercentValue(100));

                        // Adding headers to the table
                        table.AddHeaderCell("Product Name");
                        table.AddHeaderCell("Unit Price");
                        table.AddHeaderCell("Quantity");
                        table.AddHeaderCell("GST");
                        table.AddHeaderCell("Sub Total");

                        // Adding rows from DataGridView, skipping the last "new row" if present
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            if (!row.IsNewRow) // Check if it's not a new row
                            {
                                table.AddCell(new Cell().Add(new Paragraph(row.Cells["product"].Value?.ToString() ?? "")));
                                table.AddCell(new Cell().Add(new Paragraph(row.Cells["r"].Value?.ToString() ?? "")));
                                table.AddCell(new Cell().Add(new Paragraph(row.Cells["quantity"].Value?.ToString() ?? "")));
                                table.AddCell(new Cell().Add(new Paragraph(row.Cells["gst"].Value?.ToString() ?? "")));
                                table.AddCell(new Cell().Add(new Paragraph(row.Cells["Total"].Value?.ToString() ?? "")));
                            }
                        }

                        // Add table to document
                        document.Add(table);
                        document.Add(new Paragraph("\n"));
                        // Discount and total
                        document.Add(new Paragraph($"Discount: {disc} /-\n")
                            .SetFont(font)
                            .SetTextAlignment(TextAlignment.RIGHT));

                        // Adding footer
                        document.Add(new Paragraph($"Grand Total: {grandTotal} /-\n")
                            .SetFont(font)
                            .SetTextAlignment(TextAlignment.RIGHT));
                        document.Add(new Paragraph($"Payment Method: {paymentMethod}\n")
                            .SetFont(font)
                            .SetTextAlignment(TextAlignment.RIGHT));
                    }
                }
            }
        }

        private async Task<int> GetInvoiceCountAsync()
        {
            string url = $"http://localhost:8080/countInvoices";
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                return int.Parse(response) ; // Assuming the API returns a string that can be parsed as int
            }
        }
        private string GetSelectedPaymentMethod()
        {
            if (cash.Checked)
                return "Cash";
            else if (card.Checked)
                return "Card";
            else
                return "Unknown";  // Default or error case
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(subtot.Text) || string.IsNullOrEmpty(grandtot.Text) || string.IsNullOrEmpty(cust_id.Text)|| string.IsNullOrEmpty(paidamount.Text)|| string.IsNullOrEmpty(returnamount.Text)) { MessageBox.Show("  Empty Fields !"); return; }
            else if (decimal.Parse(paidamount.Text) < decimal.Parse(grandtot.Text))
            {
                MessageBox.Show("Incorrect Amount Paid !  ");
                return;
            }
        
         
            else if(!(await CheckCustomerExists(int.Parse(cust_id.Text))))
            {

                MessageBox.Show("Invalid Customer ID  !  ");
                return;

            }


            Invoice invoice = new Invoice();
            invoice.customerId = int.Parse(cust_id.Text);
            invoice.invoiceDate = DateTime.Parse(dateTimePicker1.Text);
            invoice.total = grandtot.Text;
            invoice.products = new List<InvoiceProduct>();

    // Populate the list of products from the DataGridView
    foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    InvoiceProduct product = new InvoiceProduct
                    {
                        productId = int.Parse(row.Cells["ID"].Value.ToString()),
                        name = row.Cells["product"].Value.ToString(),
                        quantity = int.Parse(row.Cells["quantity"].Value.ToString()),
                        unit = row.Cells["unit"].Value.ToString(),
                        unitPrice = row.Cells["r"].Value.ToString(),
                        gstApplied = row.Cells["gst"].Value.ToString(),
                        subtotal = (row.Cells["Total"].Value.ToString())
                      

                };
                    
                    await UpdateProductQuantity(product.productId, product.quantity);
                    invoice.products.Add(product);
                    
                }
            }

            // Serialize the Invoice object to JSON
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/");  // Adjust the port if needed
                var content = new StringContent(JsonConvert.SerializeObject(invoice), Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync("InsertInvoice1", content);
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int invoiceCount = await GetInvoiceCountAsync();
                        string billNumber = invoiceCount.ToString();
                        string customerId = cust_id.Text;
                        string disc = (decimal.Parse(subtot.Text)-decimal.Parse(grandtot.Text)).ToString();
                
                        string paymentMethod = GetSelectedPaymentMethod();
                        decimal grandTotal = decimal.Parse(grandtot.Text);

                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "PDF file|*.pdf";
                        sfd.FileName = $"Bill_{billNumber}.pdf";
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                GeneratePDF(billNumber, customerId, paymentMethod,grandTotal, dataGridView1, sfd.FileName,disc);
                               
                            }
                            catch (Exception ex)
                            {
                             
                                MessageBox.Show($"Failed to generate PDF: {ex.ToString()}");
                           
                            }

                        }

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
        private async Task UpdateProductQuantity(int productId, int quantity)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8080/");
                HttpResponseMessage response = await client.PutAsync($"UpdateProductQuantity/{productId}?quantity={quantity}", null);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Failed to update quantity for product {productId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (discount.Text != "" && subtot.Text != ""){
                decimal final;
                decimal val = decimal.Parse(subtot.Text);
                final = val;
                final = final * (decimal.Parse(discount.Text) / 100);
                val = val - final;
                grandtot.Text = val.ToString();
                if (paidamount.Text != "")
                {
                    decimal val1 = decimal.Parse(paidamount.Text);
                    decimal f = decimal.Parse(grandtot.Text);
                    f = val1 - f;
                    returnamount.Text = f.ToString();
                }
            }
            
        }
        private async Task<bool> CheckCustomerExists(int customerId)
        {
            using (var client = new HttpClient()) { 
            try
            {
                // Construct the API endpoint URL
                string url = $"http://localhost:8080/checkCustomer?id={customerId}";
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    return result == "1";  // Check if response is '1', which means customer exists
                }
                else
                {
                    MessageBox.Show($"API call failed: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            return false;  // Return false if there was an issue with the API call
        }


        private void paidamount_TextChanged(object sender, EventArgs e)
        {
            if (paidamount.Text != "")
            {
                decimal val = decimal.Parse(paidamount.Text);
                decimal f = decimal.Parse(grandtot.Text);
                f = val - f;
                returnamount.Text = f.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
