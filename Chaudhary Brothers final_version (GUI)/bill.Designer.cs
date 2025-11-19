namespace Chaudhary_Brothers
{
    partial class bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.generate_bill = new System.Windows.Forms.Label();
            this.bill_pic = new System.Windows.Forms.PictureBox();
            this.inventory_pic = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dashboard_label = new System.Windows.Forms.Label();
            this.return_pic = new System.Windows.Forms.PictureBox();
            this.returns = new System.Windows.Forms.Label();
            this.logout_panel = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.customer = new System.Windows.Forms.Label();
            this.customer_pic = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inventory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quant = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.subtot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.TextBox();
            this.grandtot = new System.Windows.Forms.TextBox();
            this.paidamount = new System.Windows.Forms.TextBox();
            this.returnamount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.card = new System.Windows.Forms.RadioButton();
            this.cust_id = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bill_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_pic)).BeginInit();
            this.logout_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_pic)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.inventory_pic);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.dashboard_label);
            this.panel1.Controls.Add(this.return_pic);
            this.panel1.Controls.Add(this.returns);
            this.panel1.Controls.Add(this.logout_panel);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.customer);
            this.panel1.Controls.Add(this.customer_pic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 750);
            this.panel1.TabIndex = 55;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.generate_bill);
            this.panel2.Controls.Add(this.bill_pic);
            this.panel2.Location = new System.Drawing.Point(3, 346);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 87);
            this.panel2.TabIndex = 23;
            // 
            // generate_bill
            // 
            this.generate_bill.AutoSize = true;
            this.generate_bill.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_bill.ForeColor = System.Drawing.Color.Transparent;
            this.generate_bill.Location = new System.Drawing.Point(95, 28);
            this.generate_bill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generate_bill.Name = "generate_bill";
            this.generate_bill.Size = new System.Drawing.Size(156, 25);
            this.generate_bill.TabIndex = 5;
            this.generate_bill.Text = "Generate Bill";
            // 
            // bill_pic
            // 
            this.bill_pic.Image = ((System.Drawing.Image)(resources.GetObject("bill_pic.Image")));
            this.bill_pic.Location = new System.Drawing.Point(10, 17);
            this.bill_pic.Margin = new System.Windows.Forms.Padding(4);
            this.bill_pic.Name = "bill_pic";
            this.bill_pic.Size = new System.Drawing.Size(73, 54);
            this.bill_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bill_pic.TabIndex = 3;
            this.bill_pic.TabStop = false;
            // 
            // inventory_pic
            // 
            this.inventory_pic.Image = ((System.Drawing.Image)(resources.GetObject("inventory_pic.Image")));
            this.inventory_pic.Location = new System.Drawing.Point(13, 177);
            this.inventory_pic.Margin = new System.Windows.Forms.Padding(4);
            this.inventory_pic.Name = "inventory_pic";
            this.inventory_pic.Size = new System.Drawing.Size(73, 54);
            this.inventory_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventory_pic.TabIndex = 0;
            this.inventory_pic.TabStop = false;
            this.inventory_pic.Click += new System.EventHandler(this.inventory_pic_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Transparent;
            this.username.Location = new System.Drawing.Point(95, 192);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(123, 25);
            this.username.TabIndex = 4;
            this.username.Text = "Inventory";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, 449);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // dashboard_label
            // 
            this.dashboard_label.AutoSize = true;
            this.dashboard_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_label.ForeColor = System.Drawing.Color.Transparent;
            this.dashboard_label.Location = new System.Drawing.Point(95, 463);
            this.dashboard_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashboard_label.Name = "dashboard_label";
            this.dashboard_label.Size = new System.Drawing.Size(133, 25);
            this.dashboard_label.TabIndex = 6;
            this.dashboard_label.Text = "Dashboard";
            this.dashboard_label.Click += new System.EventHandler(this.dashboard_label_Click);
            // 
            // return_pic
            // 
            this.return_pic.Image = ((System.Drawing.Image)(resources.GetObject("return_pic.Image")));
            this.return_pic.Location = new System.Drawing.Point(13, 273);
            this.return_pic.Margin = new System.Windows.Forms.Padding(4);
            this.return_pic.Name = "return_pic";
            this.return_pic.Size = new System.Drawing.Size(73, 54);
            this.return_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.return_pic.TabIndex = 1;
            this.return_pic.TabStop = false;
            this.return_pic.Click += new System.EventHandler(this.return_pic_Click);
            // 
            // returns
            // 
            this.returns.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returns.ForeColor = System.Drawing.Color.Transparent;
            this.returns.Location = new System.Drawing.Point(98, 284);
            this.returns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.returns.Name = "returns";
            this.returns.Size = new System.Drawing.Size(125, 43);
            this.returns.TabIndex = 8;
            this.returns.Text = "Returns";
            this.returns.Click += new System.EventHandler(this.returns_Click);
            // 
            // logout_panel
            // 
            this.logout_panel.Controls.Add(this.logout);
            this.logout_panel.Controls.Add(this.pictureBox7);
            this.logout_panel.Location = new System.Drawing.Point(3, 695);
            this.logout_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_panel.Name = "logout_panel";
            this.logout_panel.Size = new System.Drawing.Size(262, 53);
            this.logout_panel.TabIndex = 16;
            this.logout_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.logout_panel_Paint);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Transparent;
            this.logout.Location = new System.Drawing.Point(80, 14);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(110, 28);
            this.logout.TabIndex = 14;
            this.logout.Text = "Log Out";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(23, 10);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(49, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(103, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(87, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.Transparent;
            this.customer.Location = new System.Drawing.Point(98, 548);
            this.customer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(119, 25);
            this.customer.TabIndex = 7;
            this.customer.Text = "Customer";
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // customer_pic
            // 
            this.customer_pic.Image = ((System.Drawing.Image)(resources.GetObject("customer_pic.Image")));
            this.customer_pic.Location = new System.Drawing.Point(13, 535);
            this.customer_pic.Margin = new System.Windows.Forms.Padding(4);
            this.customer_pic.Name = "customer_pic";
            this.customer_pic.Size = new System.Drawing.Size(73, 54);
            this.customer_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customer_pic.TabIndex = 1;
            this.customer_pic.TabStop = false;
            this.customer_pic.Click += new System.EventHandler(this.customer_pic_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(267, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1011, 59);
            this.panel3.TabIndex = 73;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(635, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 30);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(622, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Chaudhary Brothers Management System 2.0";
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N.ForeColor = System.Drawing.Color.Black;
            this.N.Location = new System.Drawing.Point(275, 74);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(183, 25);
            this.N.TabIndex = 75;
            this.N.Text = "Search Product";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(470, 74);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(190, 28);
            this.name.TabIndex = 74;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(460, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 79);
            this.listBox1.TabIndex = 76;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(275, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 77;
            this.label1.Text = "Product List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(705, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 79;
            this.label3.Text = "Inventory";
            // 
            // inventory
            // 
            this.inventory.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.Location = new System.Drawing.Point(851, 75);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(190, 28);
            this.inventory.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(718, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Price";
            // 
            // rate
            // 
            this.rate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.Location = new System.Drawing.Point(851, 123);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(190, 28);
            this.rate.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(705, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 83;
            this.label5.Text = "Quantity";
            // 
            // quant
            // 
            this.quant.Location = new System.Drawing.Point(863, 169);
            this.quant.Name = "quant";
            this.quant.Size = new System.Drawing.Size(120, 22);
            this.quant.TabIndex = 84;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1115, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 41);
            this.button2.TabIndex = 86;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Location = new System.Drawing.Point(1115, 166);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 41);
            this.buttonAdd.TabIndex = 85;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.product,
            this.r,
            this.quantity,
            this.unit,
            this.gst,
            this.Total,
            this.del});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(267, 227);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 261);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.MinimumWidth = 6;
            this.product.Name = "product";
            this.product.ReadOnly = true;
            // 
            // r
            // 
            this.r.HeaderText = "Rate";
            this.r.MinimumWidth = 6;
            this.r.Name = "r";
            this.r.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.HeaderText = "Unit";
            this.unit.MinimumWidth = 6;
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // gst
            // 
            this.gst.HeaderText = "GST";
            this.gst.MinimumWidth = 6;
            this.gst.Name = "gst";
            this.gst.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "SubTotal";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // del
            // 
            this.del.HeaderText = "Action";
            this.del.MinimumWidth = 6;
            this.del.Name = "del";
            this.del.ReadOnly = true;
            this.del.Text = "Remove";
            this.del.UseColumnTextForButtonValue = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(303, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 89;
            this.label6.Text = "Sub Total";
            // 
            // subtot
            // 
            this.subtot.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtot.Location = new System.Drawing.Point(478, 508);
            this.subtot.Name = "subtot";
            this.subtot.Size = new System.Drawing.Size(190, 28);
            this.subtot.TabIndex = 90;
            this.subtot.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(303, 548);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 89;
            this.label7.Text = "Discount %";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(303, 594);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 89;
            this.label9.Text = "Grand Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(303, 636);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 25);
            this.label10.TabIndex = 89;
            this.label10.Text = "Paid Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(303, 677);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 25);
            this.label11.TabIndex = 89;
            this.label11.Text = "Return Amount";
            // 
            // discount
            // 
            this.discount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(478, 548);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(190, 28);
            this.discount.TabIndex = 90;
            this.discount.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // grandtot
            // 
            this.grandtot.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtot.Location = new System.Drawing.Point(478, 594);
            this.grandtot.Name = "grandtot";
            this.grandtot.Size = new System.Drawing.Size(190, 28);
            this.grandtot.TabIndex = 90;
            // 
            // paidamount
            // 
            this.paidamount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidamount.Location = new System.Drawing.Point(478, 636);
            this.paidamount.Name = "paidamount";
            this.paidamount.Size = new System.Drawing.Size(190, 28);
            this.paidamount.TabIndex = 90;
            this.paidamount.TextChanged += new System.EventHandler(this.paidamount_TextChanged);
            // 
            // returnamount
            // 
            this.returnamount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnamount.Location = new System.Drawing.Point(478, 677);
            this.returnamount.Name = "returnamount";
            this.returnamount.Size = new System.Drawing.Size(190, 28);
            this.returnamount.TabIndex = 90;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(885, 677);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 41);
            this.button1.TabIndex = 91;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(749, 514);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 25);
            this.label8.TabIndex = 92;
            this.label8.Text = "Customer Id";
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.Location = new System.Drawing.Point(973, 617);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(73, 24);
            this.cash.TabIndex = 94;
            this.cash.TabStop = true;
            this.cash.Text = "Cash";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(749, 613);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 25);
            this.label12.TabIndex = 95;
            this.label12.Text = "Payment Method";
            // 
            // card
            // 
            this.card.AutoSize = true;
            this.card.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card.Location = new System.Drawing.Point(1087, 618);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(70, 24);
            this.card.TabIndex = 94;
            this.card.TabStop = true;
            this.card.Text = "Card";
            this.card.UseVisualStyleBackColor = true;
            this.card.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cust_id
            // 
            this.cust_id.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_id.Location = new System.Drawing.Point(916, 515);
            this.cust_id.Name = "cust_id";
            this.cust_id.Size = new System.Drawing.Size(190, 28);
            this.cust_id.TabIndex = 96;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // bill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1272, 750);
            this.Controls.Add(this.cust_id);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.card);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.returnamount);
            this.Controls.Add(this.paidamount);
            this.Controls.Add(this.grandtot);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.subtot);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.quant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.N);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bill";
            this.Load += new System.EventHandler(this.bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bill_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_pic)).EndInit();
            this.logout_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_pic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox inventory_pic;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label dashboard_label;
        private System.Windows.Forms.PictureBox return_pic;
        private System.Windows.Forms.Label returns;
        private System.Windows.Forms.Panel logout_panel;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.Label generate_bill;
        private System.Windows.Forms.PictureBox customer_pic;
        private System.Windows.Forms.PictureBox bill_pic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inventory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown quant;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subtot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.TextBox grandtot;
        private System.Windows.Forms.TextBox paidamount;
        private System.Windows.Forms.TextBox returnamount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton cash;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton card;
        private System.Windows.Forms.TextBox cust_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn r;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}