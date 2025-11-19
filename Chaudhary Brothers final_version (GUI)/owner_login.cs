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
    public partial class owner_login : Form
    {
        public owner_login()
        {
            InitializeComponent();
        }

        private void owner_login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show(); 
        }

        private async void login_but_Click(object sender, EventArgs e)
        {

            int cashierId;
            if (!int.TryParse(user_input.Text, out cashierId))
            {
                MessageBox.Show("Please enter a valid Owner ID.");
                return;
            }
            string password = pass_input.Text;

            using (var client = new HttpClient())
            {
                try
                {

                    string baseUrl = "http://localhost:8080/OwnerLogin";
                    string url = $"{baseUrl}?ownerId={cashierId}&password={password}";

                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();


                        if (result.Contains("Login successful."))
                        {
                            owner_dashboard obj=new owner_dashboard();
                            this.Hide();
                            obj.Show();
                            @enum obj1 = new @enum();
                            obj1.setowner();

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
    }
}
