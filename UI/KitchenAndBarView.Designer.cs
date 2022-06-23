﻿namespace UI
{
    partial class KitchenAndBarView
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenAndBarView));
            this.lblKitchenAndBarView = new System.Windows.Forms.Label();
            this.btnCompletedOrder = new System.Windows.Forms.Button();
            this.btnKitchenReady = new System.Windows.Forms.Button();
            this.lstViewKitchenAndBar = new System.Windows.Forms.ListView();
            this.quantity = new System.Windows.Forms.ColumnHeader();
            this.itemName = new System.Windows.Forms.ColumnHeader();
            this.comment = new System.Windows.Forms.ColumnHeader();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.table = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRunningOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKitchenAndBarView
            // 
            this.lblKitchenAndBarView.AccessibleDescription = "";
            this.lblKitchenAndBarView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKitchenAndBarView.Font = new System.Drawing.Font("Calibri", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKitchenAndBarView.ForeColor = System.Drawing.Color.White;
            this.lblKitchenAndBarView.Location = new System.Drawing.Point(707, 16);
            this.lblKitchenAndBarView.Name = "lblKitchenAndBarView";
            this.lblKitchenAndBarView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKitchenAndBarView.Size = new System.Drawing.Size(399, 82);
            this.lblKitchenAndBarView.TabIndex = 0;
            this.lblKitchenAndBarView.Text = ".......";
            this.lblKitchenAndBarView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCompletedOrder
            // 
            this.btnCompletedOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(117)))), ((int)(((byte)(79)))));
            this.btnCompletedOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompletedOrder.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompletedOrder.ForeColor = System.Drawing.Color.Black;
            this.btnCompletedOrder.Location = new System.Drawing.Point(24, 878);
            this.btnCompletedOrder.Name = "btnCompletedOrder";
            this.btnCompletedOrder.Size = new System.Drawing.Size(410, 80);
            this.btnCompletedOrder.TabIndex = 4;
            this.btnCompletedOrder.Text = "Completed Orders";
            this.btnCompletedOrder.UseVisualStyleBackColor = false;
            this.btnCompletedOrder.Click += new System.EventHandler(this.btnCompletedOrder_Click_1);
            // 
            // btnKitchenReady
            // 
            this.btnKitchenReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(154)))), ((int)(((byte)(40)))));
            this.btnKitchenReady.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKitchenReady.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKitchenReady.ForeColor = System.Drawing.Color.Black;
            this.btnKitchenReady.Location = new System.Drawing.Point(1349, 878);
            this.btnKitchenReady.Name = "btnKitchenReady";
            this.btnKitchenReady.Size = new System.Drawing.Size(410, 80);
            this.btnKitchenReady.TabIndex = 5;
            this.btnKitchenReady.Text = "Ready";
            this.btnKitchenReady.UseVisualStyleBackColor = false;
            this.btnKitchenReady.Click += new System.EventHandler(this.btnKitchenReady_Click);
            // 
            // lstViewKitchenAndBar
            // 
            this.lstViewKitchenAndBar.BackColor = System.Drawing.Color.White;
            this.lstViewKitchenAndBar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.quantity,
            this.itemName,
            this.comment,
            this.time,
            this.table,
            this.status});
            this.lstViewKitchenAndBar.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstViewKitchenAndBar.ForeColor = System.Drawing.Color.Black;
            this.lstViewKitchenAndBar.FullRowSelect = true;
            this.lstViewKitchenAndBar.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "fgdfgdfgdfgdf";
            this.lstViewKitchenAndBar.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lstViewKitchenAndBar.HideSelection = false;
            this.lstViewKitchenAndBar.Location = new System.Drawing.Point(27, 180);
            this.lstViewKitchenAndBar.Name = "lstViewKitchenAndBar";
            this.lstViewKitchenAndBar.Size = new System.Drawing.Size(1735, 674);
            this.lstViewKitchenAndBar.TabIndex = 6;
            this.lstViewKitchenAndBar.UseCompatibleStateImageBehavior = false;
            this.lstViewKitchenAndBar.View = System.Windows.Forms.View.Details;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 150;
            // 
            // itemName
            // 
            this.itemName.Tag = "itemName";
            this.itemName.Text = "Item Name";
            this.itemName.Width = 400;
            // 
            // comment
            // 
            this.comment.Text = "Comment";
            this.comment.Width = 300;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 300;
            // 
            // table
            // 
            this.table.Text = "Table";
            this.table.Width = 285;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 295;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnLogOut.Location = new System.Drawing.Point(1608, 35);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(151, 52);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRunningOrder
            // 
            this.btnRunningOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(117)))), ((int)(((byte)(79)))));
            this.btnRunningOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRunningOrder.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRunningOrder.ForeColor = System.Drawing.Color.Black;
            this.btnRunningOrder.Location = new System.Drawing.Point(24, 878);
            this.btnRunningOrder.Name = "btnRunningOrder";
            this.btnRunningOrder.Size = new System.Drawing.Size(410, 80);
            this.btnRunningOrder.TabIndex = 9;
            this.btnRunningOrder.Text = "Running Orders";
            this.btnRunningOrder.UseVisualStyleBackColor = false;
            this.btnRunningOrder.Click += new System.EventHandler(this.btnRunningOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.lblKitchenAndBarView);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1810, 117);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblOrderType
            // 
            this.lblOrderType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(101)))), ((int)(((byte)(50)))));
            this.lblOrderType.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblOrderType.ForeColor = System.Drawing.Color.White;
            this.lblOrderType.Location = new System.Drawing.Point(782, 120);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(311, 42);
            this.lblOrderType.TabIndex = 13;
            this.lblOrderType.Text = "..............";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(707, 878);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(410, 80);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(101)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(0, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1810, 44);
            this.label2.TabIndex = 12;
            // 
            // KitchenAndBarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1792, 973);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRunningOrder);
            this.Controls.Add(this.lstViewKitchenAndBar);
            this.Controls.Add(this.btnKitchenReady);
            this.Controls.Add(this.btnCompletedOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitchenAndBarView";
            this.Text = "KitchenAndBarView";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKitchenAndBarView;
        private System.Windows.Forms.Button btnCompletedOrder;
        private System.Windows.Forms.Button btnKitchenReady;
        private System.Windows.Forms.ListView lstViewKitchenAndBar;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader comment;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader table;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Button btnRunningOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label label2;
    }
}