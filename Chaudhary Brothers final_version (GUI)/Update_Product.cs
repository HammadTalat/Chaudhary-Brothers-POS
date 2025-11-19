using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Json;


namespace Chaudhary_Brothers
{
    public partial class Update_Product : Form
    {
        private HttpClient client;
        string iid;
      
        public Update_Product(string a,string b, string c, string d, string e, string f, string g, string h)
        {

            InitializeComponent();
            name.Text = b;
            com_name.Text = c;
            u_p.Text = d;
            s_p.Text = e;
            tax1.Text = f;
            unit1.Text = g;
            quantity.Text = h;
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            iid = a;
         


        }

        private void Update_Product_Load(object sender, EventArgs e)
        {

        }
        public event EventHandler ProductUpdated;
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(iid); 
                Product product = new Product
                {
                    name = name.Text, 
                    companyName = com_name.Text,
                    unitPrice = decimal.Parse(u_p.Text),
                    tax = decimal.Parse(tax1.Text),
                    salesPrice = decimal.Parse(s_p.Text),
                    unitQuantity = int.Parse(quantity.Text)
                };

                HttpResponseMessage response = await client.PutAsJsonAsync($"UpdateProduct/{productId}", product);
                response.EnsureSuccessStatusCode(); // Ensure a successful response

                // Read the response message
                string responseContent = await response.Content.ReadAsStringAsync();

                // Show the response message to the user
                MessageBox.Show(responseContent, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProductUpdated?.Invoke(this, EventArgs.Empty);

            }
            catch (FormatException fe)
            {
                MessageBox.Show("Please check your input formats: " + fe.Message, "Input Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
