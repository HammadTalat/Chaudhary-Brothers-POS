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

namespace Chaudhary_Brothers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void login_but_Click(object sender, EventArgs e)
        {
            
            int cashierId;
            if (!int.TryParse(user_input.Text, out cashierId))
            {
                MessageBox.Show("Please enter a valid cashier ID.");
                return;
            }
            string password = pass_input.Text;

            using (var client = new HttpClient())
            {
                try
                {
                   
                    string baseUrl = "http://localhost:8080/CashierLogin";
                    string url = $"{baseUrl}?cashierId={cashierId}&password={password}";

                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();

            
                        if (result.Contains("Login successful."))
                        {
                            inventory inventory = new inventory();
                            this.Hide();
                            inventory.Show();
                            @enum obj1 = new @enum();
                            obj1.setcashier();
                        }
                        else
                        {
                            MessageBox.Show(result, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error connecting to server.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect to server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cross_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thanks For using Our System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void owner_login_Click(object sender, EventArgs e)
        {
            owner_login owner_Login= new owner_login();
            this.Hide();
            owner_Login.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
