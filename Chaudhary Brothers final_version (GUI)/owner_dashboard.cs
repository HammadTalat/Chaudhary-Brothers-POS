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

namespace Chaudhary_Brothers
{
    public partial class owner_dashboard : Form
    {
        public owner_dashboard()
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

        private void label1_Click(object sender, EventArgs e)
        {
            inventory inventory = new inventory();
            this.Hide();
            inventory.Show();
        }

        private void dashboard_label_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {
            owner owner = new owner();
            this.Hide();
            owner.Show();
        }

        private void inventory_pic_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            inventory inventory = new inventory();
            this.Hide();
            inventory.Show();
        }

        private void inventory_pic_Click_1(object sender, EventArgs e)
        {
            owner owner = new owner();
            this.Hide();
            owner.Show();
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            inventory_alerts alerts = new inventory_alerts();
            this.Hide();
            alerts.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            inventory_alerts alerts = new inventory_alerts();
            this.Hide();
            alerts.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            inventory_alerts alerts = new inventory_alerts();
            this.Hide();
            alerts.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            sales_reports sales_Reports = new sales_reports();
            this.Hide();
            sales_Reports.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            sales_reports sales_Reports = new sales_reports();
            this.Hide();
            sales_Reports.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            track_expense track_Expense = new track_expense();
            this.Hide();
            track_Expense.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            track_expense track_Expense = new track_expense();
            this.Hide();
            track_Expense.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private async void label7_Click(object sender, EventArgs e)
        {

            string popularItem = await GetPopularItem();
            if (popularItem != null)
            {
                label7.Text = " " + popularItem; // Directly updating the label text
            }
            else
            {
                label7.Text = "Failed to retrieve the most popular item.";
            }


        }

        public async Task<string> GetPopularItem()
        {
            using (var httpClient = new HttpClient())
            {
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

        private void owner_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
