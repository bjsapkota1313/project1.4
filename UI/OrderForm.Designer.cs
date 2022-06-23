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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBackToTableView = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.StarterBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubmitOrder = new System.Windows.Forms.Button();
            this.OrderLIstView = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Feedback = new System.Windows.Forms.ColumnHeader();
            this.RemoveOrderBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.BtnBackToTableView);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 68);
            this.panel2.TabIndex = 2;
            // 
            // BtnBackToTableView
            // 
            this.BtnBackToTableView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.BtnBackToTableView.FlatAppearance.BorderSize = 0;
            this.BtnBackToTableView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBackToTableView.Font = new System.Drawing.Font("Calibri", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBackToTableView.ForeColor = System.Drawing.Color.Black;
            this.BtnBackToTableView.Image = global::UI.Properties.Resources.ArrowFatLeftNew;
            this.BtnBackToTableView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBackToTableView.Location = new System.Drawing.Point(18, 12);
            this.BtnBackToTableView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBackToTableView.Name = "BtnBackToTableView";
            this.BtnBackToTableView.Size = new System.Drawing.Size(112, 38);
            this.BtnBackToTableView.TabIndex = 4;
            this.BtnBackToTableView.Text = "Back";
            this.BtnBackToTableView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBackToTableView.UseVisualStyleBackColor = false;
            this.BtnBackToTableView.Click += new System.EventHandler(this.BtnBackToTableView_Click);
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
            this.StarterBtn.Size = new System.Drawing.Size(329, 51);
            this.StarterBtn.TabIndex = 4;
            this.StarterBtn.Text = "Food";
            this.StarterBtn.UseVisualStyleBackColor = false;
            this.StarterBtn.Click += new System.EventHandler(this.FoodBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.SubmitOrder);
            this.panel1.Controls.Add(this.OrderLIstView);
            this.panel1.Controls.Add(this.RemoveOrderBtn);
            this.panel1.Location = new System.Drawing.Point(443, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 927);
            this.panel1.TabIndex = 7;
            // 
            // SubmitOrder
            // 
            this.SubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(154)))), ((int)(((byte)(40)))));
            this.SubmitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SubmitOrder.Location = new System.Drawing.Point(3, 379);
            this.SubmitOrder.Name = "SubmitOrder";
            this.SubmitOrder.Size = new System.Drawing.Size(270, 39);
            this.SubmitOrder.TabIndex = 12;
            this.SubmitOrder.Text = "Submit";
            this.SubmitOrder.UseVisualStyleBackColor = false;
            this.SubmitOrder.Click += new System.EventHandler(this.SubmitOrder_Click);
            // 
            // OrderLIstView
            // 
            this.OrderLIstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Feedback});
            this.OrderLIstView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderLIstView.FullRowSelect = true;
            this.OrderLIstView.HideSelection = false;
            this.OrderLIstView.Location = new System.Drawing.Point(3, 8);
            this.OrderLIstView.Name = "OrderLIstView";
            this.OrderLIstView.Size = new System.Drawing.Size(270, 320);
            this.OrderLIstView.TabIndex = 11;
            this.OrderLIstView.UseCompatibleStateImageBehavior = false;
            this.OrderLIstView.View = System.Windows.Forms.View.Details;
            this.OrderLIstView.SelectedIndexChanged += new System.EventHandler(this.OrderLIstView_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 165;
            // 
            // Feedback
            // 
            this.Feedback.Text = "Comment";
            this.Feedback.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Feedback.Width = 100;
            // 
            // RemoveOrderBtn
            // 
            this.RemoveOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.RemoveOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveOrderBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.RemoveOrderBtn.Location = new System.Drawing.Point(3, 334);
            this.RemoveOrderBtn.Name = "RemoveOrderBtn";
            this.RemoveOrderBtn.Size = new System.Drawing.Size(270, 39);
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
            this.button1.Location = new System.Drawing.Point(387, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Drink";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.StarterBtn);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 68);
            this.panel3.TabIndex = 3;
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.Transparent;
            this.mainpanel.Controls.Add(this.pictureBox1);
            this.mainpanel.Location = new System.Drawing.Point(0, 135);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(440, 927);
            this.mainpanel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 274);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button StarterBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveOrderBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView OrderLIstView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Feedback;
        private System.Windows.Forms.Button SubmitOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button BtnBackToTableView;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}