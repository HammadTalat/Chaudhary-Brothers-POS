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
    public partial class Update_Customer : Form
    {
        private HttpClient client;
        string iid;

        public Update_Customer(string a, string b, string c, string d, string e, string f)
        {

            InitializeComponent();
            f_name.Text = b;
            l_name.Text = c;
            p.Text = d;
            emai.Text = e;
            addr.Text = f;
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            iid = a;



        }


        public event EventHandler CustomerUpdated;
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Prepare the data to be sent to the API
                int CustomerId = int.Parse(iid); // Assuming there is a textBox for product ID
                Customer custome = new Customer
                {
                    firstName = f_name.Text,
                    lastName = l_name.Text,
                    email = emai.Text,
                    phoneNumber = p.Text,
                    address = addr.Text
                };

                // Send the data to the API
                HttpResponseMessage response = await client.PutAsJsonAsync($"UpdateCustomer/{CustomerId}", custome);
                response.EnsureSuccessStatusCode(); // Ensure a successful response

                // Read the response message
                string responseContent = await response.Content.ReadAsStringAsync();

                // Show the response message to the user
                MessageBox.Show(responseContent, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CustomerUpdated?.Invoke(this, EventArgs.Empty);

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
        private void Update_Customer_Load(object sender, EventArgs e)
        {

        }


    }
  

}
