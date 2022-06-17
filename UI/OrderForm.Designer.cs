namespace UI
{
    partial class OrderForm
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
            this.BackBtnOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.StarterBtn = new System.Windows.Forms.Button();
            this.MainCourseBtn = new System.Windows.Forms.Button();
            this.DessertBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubmitOrder = new System.Windows.Forms.Button();
            this.OrderLIstView = new System.Windows.Forms.ListView();
            this.ItemId = new System.Windows.Forms.ColumnHeader();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.RemoveOrderBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.BackBtnOrder.Size = new System.Drawing.Size(206, 36);
            this.BackBtnOrder.TabIndex = 0;
            this.BackBtnOrder.Text = "Back to TableView";
            this.BackBtnOrder.UseVisualStyleBackColor = false;
            this.BackBtnOrder.Click += new System.EventHandler(this.BackBtnOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.BackBtnOrder);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 68);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(621, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StarterBtn
            // 
            this.StarterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(117)))), ((int)(((byte)(79)))));
            this.StarterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StarterBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.StarterBtn.Location = new System.Drawing.Point(18, 6);
            this.StarterBtn.Name = "StarterBtn";
            this.StarterBtn.Size = new System.Drawing.Size(159, 51);
            this.StarterBtn.TabIndex = 4;
            this.StarterBtn.Text = "Starter";
            this.StarterBtn.UseVisualStyleBackColor = false;
            this.StarterBtn.Click += new System.EventHandler(this.FoodBtn_Click);
            // 
            // MainCourseBtn
            // 
            this.MainCourseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(117)))), ((int)(((byte)(79)))));
            this.MainCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainCourseBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MainCourseBtn.Location = new System.Drawing.Point(198, 6);
            this.MainCourseBtn.Name = "MainCourseBtn";
            this.MainCourseBtn.Size = new System.Drawing.Size(159, 51);
            this.MainCourseBtn.TabIndex = 5;
            this.MainCourseBtn.Text = "Main Course";
            this.MainCourseBtn.UseVisualStyleBackColor = false;
            this.MainCourseBtn.Click += new System.EventHandler(this.MainCourseBtn_Click);
            // 
            // DessertBtn
            // 
            this.DessertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(117)))), ((int)(((byte)(79)))));
            this.DessertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DessertBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DessertBtn.Location = new System.Drawing.Point(378, 6);
            this.DessertBtn.Name = "DessertBtn";
            this.DessertBtn.Size = new System.Drawing.Size(159, 51);
            this.DessertBtn.TabIndex = 6;
            this.DessertBtn.Text = "Dessert";
            this.DessertBtn.UseVisualStyleBackColor = false;
            this.DessertBtn.Click += new System.EventHandler(this.DessertBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.SubmitOrder);
            this.panel1.Controls.Add(this.OrderLIstView);
            this.panel1.Controls.Add(this.RemoveOrderBtn);
            this.panel1.Location = new System.Drawing.Point(514, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 927);
            this.panel1.TabIndex = 7;
            // 
            // SubmitOrder
            // 
            this.SubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(154)))), ((int)(((byte)(40)))));
            this.SubmitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SubmitOrder.Location = new System.Drawing.Point(3, 379);
            this.SubmitOrder.Name = "SubmitOrder";
            this.SubmitOrder.Size = new System.Drawing.Size(208, 39);
            this.SubmitOrder.TabIndex = 12;
            this.SubmitOrder.Text = "Submit";
            this.SubmitOrder.UseVisualStyleBackColor = false;
            this.SubmitOrder.Click += new System.EventHandler(this.SubmitOrder_Click);
            // 
            // OrderLIstView
            // 
            this.OrderLIstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemId,
            this.Name,
            this.Price});
            this.OrderLIstView.FullRowSelect = true;
            this.OrderLIstView.HideSelection = false;
            this.OrderLIstView.Location = new System.Drawing.Point(3, 8);
            this.OrderLIstView.Name = "OrderLIstView";
            this.OrderLIstView.Size = new System.Drawing.Size(208, 320);
            this.OrderLIstView.TabIndex = 11;
            this.OrderLIstView.UseCompatibleStateImageBehavior = false;
            this.OrderLIstView.View = System.Windows.Forms.View.Details;
            this.OrderLIstView.SelectedIndexChanged += new System.EventHandler(this.OrderLIstView_SelectedIndexChanged);
            // 
            // ItemId
            // 
            this.ItemId.Text = "Id";
            this.ItemId.Width = 40;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 100;
            // 
            // Price
            // 
            this.Price.Text = "Quantity";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RemoveOrderBtn
            // 
            this.RemoveOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.RemoveOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveOrderBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.RemoveOrderBtn.Location = new System.Drawing.Point(3, 334);
            this.RemoveOrderBtn.Name = "RemoveOrderBtn";
            this.RemoveOrderBtn.Size = new System.Drawing.Size(208, 39);
            this.RemoveOrderBtn.TabIndex = 8;
            this.RemoveOrderBtn.Text = "Remove";
            this.RemoveOrderBtn.UseVisualStyleBackColor = false;
            this.RemoveOrderBtn.Click += new System.EventHandler(this.RemoveOrderBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(117)))), ((int)(((byte)(79)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(558, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Drink";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.StarterBtn);
            this.panel3.Controls.Add(this.MainCourseBtn);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.DessertBtn);
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 68);
            this.panel3.TabIndex = 3;
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.Transparent;
            this.mainpanel.Location = new System.Drawing.Point(0, 135);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(511, 568);
            this.mainpanel.TabIndex = 8;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(728, 1061);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainpanel);
            this.MaximumSize = new System.Drawing.Size(744, 1133);
           // this.Name = "OrderForm";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.OrderView_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtnOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button StarterBtn;
        private System.Windows.Forms.Button MainCourseBtn;
        private System.Windows.Forms.Button DessertBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveOrderBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView OrderLIstView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button SubmitOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader ItemId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel mainpanel;
    }
}