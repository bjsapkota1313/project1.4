namespace UI
{
    partial class Order
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("ID");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Name");
            this.BackBtnOrder = new System.Windows.Forms.Button();
            this.hamburgerMenu = new System.Windows.Forms.Panel();
            this.listViewDrinks = new System.Windows.Forms.ListView();
            this.listViewFood = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StarterBtn = new System.Windows.Forms.Button();
            this.MainCourseBtn = new System.Windows.Forms.Button();
            this.DessertBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BillOrderBtn = new System.Windows.Forms.Button();
            this.RemoveOrderBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.hamburgerMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackBtnOrder
            // 
            this.BackBtnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.BackBtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtnOrder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackBtnOrder.ForeColor = System.Drawing.Color.Snow;
            this.BackBtnOrder.Location = new System.Drawing.Point(12, 12);
            this.BackBtnOrder.Name = "BackBtnOrder";
            this.BackBtnOrder.Size = new System.Drawing.Size(172, 36);
            this.BackBtnOrder.TabIndex = 0;
            this.BackBtnOrder.Text = "Back to Home";
            this.BackBtnOrder.UseVisualStyleBackColor = false;
            // 
            // hamburgerMenu
            // 
            this.hamburgerMenu.BackColor = System.Drawing.Color.DarkGray;
            this.hamburgerMenu.Controls.Add(this.listViewDrinks);
            this.hamburgerMenu.Controls.Add(this.listViewFood);
            this.hamburgerMenu.Controls.Add(this.pictureBox1);
            this.hamburgerMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.hamburgerMenu.Location = new System.Drawing.Point(528, 0);
            this.hamburgerMenu.Name = "hamburgerMenu";
            this.hamburgerMenu.Size = new System.Drawing.Size(200, 1061);
            this.hamburgerMenu.TabIndex = 1;
            // 
            // listViewDrinks
            // 
            this.listViewDrinks.HideSelection = false;
            this.listViewDrinks.Location = new System.Drawing.Point(3, 171);
            this.listViewDrinks.Name = "listViewDrinks";
            this.listViewDrinks.Size = new System.Drawing.Size(194, 92);
            this.listViewDrinks.TabIndex = 3;
            this.listViewDrinks.UseCompatibleStateImageBehavior = false;
            // 
            // listViewFood
            // 
            this.listViewFood.HideSelection = false;
            this.listViewFood.Location = new System.Drawing.Point(3, 77);
            this.listViewFood.Name = "listViewFood";
            this.listViewFood.Size = new System.Drawing.Size(194, 92);
            this.listViewFood.TabIndex = 2;
            this.listViewFood.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(69, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.BackBtnOrder);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 68);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(672, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StarterBtn
            // 
            this.StarterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.StarterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StarterBtn.Location = new System.Drawing.Point(1, 36);
            this.StarterBtn.Name = "StarterBtn";
            this.StarterBtn.Size = new System.Drawing.Size(210, 51);
            this.StarterBtn.TabIndex = 4;
            this.StarterBtn.Text = "Starter";
            this.StarterBtn.UseVisualStyleBackColor = false;
            this.StarterBtn.Click += new System.EventHandler(this.FoodBtn_Click);
            // 
            // MainCourseBtn
            // 
            this.MainCourseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.MainCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainCourseBtn.Location = new System.Drawing.Point(1, 111);
            this.MainCourseBtn.Name = "MainCourseBtn";
            this.MainCourseBtn.Size = new System.Drawing.Size(210, 51);
            this.MainCourseBtn.TabIndex = 5;
            this.MainCourseBtn.Text = "Main Course";
            this.MainCourseBtn.UseVisualStyleBackColor = false;
            this.MainCourseBtn.Click += new System.EventHandler(this.MainCourseBtn_Click);
            // 
            // DessertBtn
            // 
            this.DessertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.DessertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DessertBtn.Location = new System.Drawing.Point(1, 180);
            this.DessertBtn.Name = "DessertBtn";
            this.DessertBtn.Size = new System.Drawing.Size(210, 51);
            this.DessertBtn.TabIndex = 6;
            this.DessertBtn.Text = "Dessert";
            this.DessertBtn.UseVisualStyleBackColor = false;
            this.DessertBtn.Click += new System.EventHandler(this.DessertBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.BillOrderBtn);
            this.panel1.Controls.Add(this.RemoveOrderBtn);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.StarterBtn);
            this.panel1.Controls.Add(this.MainCourseBtn);
            this.panel1.Controls.Add(this.DessertBtn);
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 993);
            this.panel1.TabIndex = 7;
            // 
            // BillOrderBtn
            // 
            this.BillOrderBtn.Location = new System.Drawing.Point(3, 611);
            this.BillOrderBtn.Name = "BillOrderBtn";
            this.BillOrderBtn.Size = new System.Drawing.Size(208, 23);
            this.BillOrderBtn.TabIndex = 9;
            this.BillOrderBtn.Text = "Bill";
            this.BillOrderBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveOrderBtn
            // 
            this.RemoveOrderBtn.Location = new System.Drawing.Point(3, 579);
            this.RemoveOrderBtn.Name = "RemoveOrderBtn";
            this.RemoveOrderBtn.Size = new System.Drawing.Size(208, 23);
            this.RemoveOrderBtn.TabIndex = 8;
            this.RemoveOrderBtn.Text = "Remove";
            this.RemoveOrderBtn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(1, 265);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(210, 299);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(212, 68);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(517, 993);
            this.mainpanel.TabIndex = 8;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(728, 1061);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.hamburgerMenu);
            this.Controls.Add(this.mainpanel);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.OrderView_Load);
            this.hamburgerMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtnOrder;
        private System.Windows.Forms.Panel hamburgerMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.ListView listViewFood;
        private System.Windows.Forms.Button StarterBtn;
        private System.Windows.Forms.Button MainCourseBtn;
        private System.Windows.Forms.Button DessertBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button BillOrderBtn;
        private System.Windows.Forms.Button RemoveOrderBtn;
    }
}