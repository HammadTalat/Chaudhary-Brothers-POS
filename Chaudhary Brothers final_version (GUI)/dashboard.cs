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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainForm_Load);
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            string popularItem = await GetPopularItem();
            if (popularItem != null)
            {
                label7.Text = "" + popularItem;
            }
            else
            {
                label7.Text = "Failed to retrieve the most popular item.";
            }
        }
        public async Task<string> GetPopularItem()
        {
            using (var httpClient = new HttpClient()) { 
                try
                {
                    string url = "http://localhost:8080/getPopularItem";
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        throw new Exception($"API call failed with status code: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                   
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return null; 
                }
        }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sorry You are not the owner! Can't access this feature", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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
            this.Hide(); bill.Show();
        }

        private void bill_pic_Click(object sender, EventArgs e)
        {

            bill bill = new bill();
            this.Hide(); bill.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sorry You are not the owner! Can't access this feature", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sorry You are not the owner! Can't access this feature", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sorry You are not the owner! Can't access this feature", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void label4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sorry You are not the owner! Can't access this feature", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sorry You are not the owner! Can't access this feature", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
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
      
        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
