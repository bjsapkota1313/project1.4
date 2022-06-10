namespace UI
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
            this.lblKitchenAndBar = new System.Windows.Forms.Label();
            this.btnKitchenReady = new System.Windows.Forms.Button();
            this.lstViewKitchenAndBar = new System.Windows.Forms.ListView();
            this.itemName = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Comment = new System.Windows.Forms.ColumnHeader();
            this.WaitTime = new System.Windows.Forms.ColumnHeader();
            this.TableNr = new System.Windows.Forms.ColumnHeader();
            this.OrderStatus = new System.Windows.Forms.ColumnHeader();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRunningOrder = new System.Windows.Forms.Button();
            this.btnCompletedOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKitchenAndBar
            // 
            this.lblKitchenAndBar.AutoSize = true;
            this.lblKitchenAndBar.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKitchenAndBar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblKitchenAndBar.Location = new System.Drawing.Point(777, 17);
            this.lblKitchenAndBar.Name = "lblKitchenAndBar";
            this.lblKitchenAndBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKitchenAndBar.Size = new System.Drawing.Size(194, 58);
            this.lblKitchenAndBar.TabIndex = 0;
            this.lblKitchenAndBar.Text = ".............";
            this.lblKitchenAndBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKitchenReady
            // 
            this.btnKitchenReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(121)))), ((int)(((byte)(7)))));
            this.btnKitchenReady.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKitchenReady.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKitchenReady.ForeColor = System.Drawing.Color.White;
            this.btnKitchenReady.Location = new System.Drawing.Point(1347, 871);
            this.btnKitchenReady.Name = "btnKitchenReady";
            this.btnKitchenReady.Size = new System.Drawing.Size(410, 80);
            this.btnKitchenReady.TabIndex = 5;
            this.btnKitchenReady.Text = "Ready";
            this.btnKitchenReady.UseVisualStyleBackColor = false;
            this.btnKitchenReady.Click += new System.EventHandler(this.btnKitchenReady_Click);
            // 
            // lstViewKitchenAndBar
            // 
            this.lstViewKitchenAndBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstViewKitchenAndBar.BackColor = System.Drawing.Color.White;
            this.lstViewKitchenAndBar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemName,
            this.Quantity,
            this.Comment,
            this.WaitTime,
            this.TableNr,
            this.OrderStatus});
            this.lstViewKitchenAndBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstViewKitchenAndBar.ForeColor = System.Drawing.Color.Black;
            this.lstViewKitchenAndBar.FullRowSelect = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "fgdfgdfgdfgdf";
            this.lstViewKitchenAndBar.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lstViewKitchenAndBar.HideSelection = false;
            this.lstViewKitchenAndBar.Location = new System.Drawing.Point(35, 145);
            this.lstViewKitchenAndBar.Name = "lstViewKitchenAndBar";
            this.lstViewKitchenAndBar.Size = new System.Drawing.Size(1722, 705);
            this.lstViewKitchenAndBar.TabIndex = 6;
            this.lstViewKitchenAndBar.UseCompatibleStateImageBehavior = false;
            this.lstViewKitchenAndBar.View = System.Windows.Forms.View.Details;
            // 
            // itemName
            // 
            this.itemName.Tag = "";
            this.itemName.Text = "Item Name";
            this.itemName.Width = 400;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 200;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.Width = 400;
            // 
            // WaitTime
            // 
            this.WaitTime.Text = "Time";
            this.WaitTime.Width = 200;
            // 
            // TableNr
            // 
            this.TableNr.Text = "Table";
            this.TableNr.Width = 200;
            // 
            // OrderStatus
            // 
            this.OrderStatus.Text = "Status";
            this.OrderStatus.Width = 200;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(716, 871);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(410, 80);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(1606, 23);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(151, 52);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "&Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(-7, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1810, 40);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnRunningOrder
            // 
            this.btnRunningOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(167)))));
            this.btnRunningOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRunningOrder.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRunningOrder.ForeColor = System.Drawing.Color.White;
            this.btnRunningOrder.Location = new System.Drawing.Point(35, 871);
            this.btnRunningOrder.Name = "btnRunningOrder";
            this.btnRunningOrder.Size = new System.Drawing.Size(410, 80);
            this.btnRunningOrder.TabIndex = 12;
            this.btnRunningOrder.Text = "Running Order";
            this.btnRunningOrder.UseVisualStyleBackColor = false;
            this.btnRunningOrder.Click += new System.EventHandler(this.btnRunningOrder_Click);
            // 
            // btnCompletedOrder
            // 
            this.btnCompletedOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(167)))));
            this.btnCompletedOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompletedOrder.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompletedOrder.ForeColor = System.Drawing.Color.White;
            this.btnCompletedOrder.Location = new System.Drawing.Point(35, 871);
            this.btnCompletedOrder.Name = "btnCompletedOrder";
            this.btnCompletedOrder.Size = new System.Drawing.Size(410, 80);
            this.btnCompletedOrder.TabIndex = 13;
            this.btnCompletedOrder.Text = "Completed Order";
            this.btnCompletedOrder.UseVisualStyleBackColor = false;
            this.btnCompletedOrder.Click += new System.EventHandler(this.btnCompletedOrder_Click);
            // 
            // KitchenAndBarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1792, 973);
            this.Controls.Add(this.btnCompletedOrder);
            this.Controls.Add(this.btnRunningOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstViewKitchenAndBar);
            this.Controls.Add(this.btnKitchenReady);
            this.Controls.Add(this.lblKitchenAndBar);
            this.Name = "KitchenAndBarView";
            this.Text = "KitchenAndBarView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKitchenAndBar;
        private System.Windows.Forms.Button btnKitchenReady;
        private System.Windows.Forms.ListView lstViewKitchenAndBar;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.ColumnHeader WaitTime;
        private System.Windows.Forms.ColumnHeader TableNr;
        private System.Windows.Forms.ColumnHeader OrderStatus;
        private System.Windows.Forms.ColumnHeader order_status;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRunningOrder;
        private System.Windows.Forms.Button btnCompletedOrder;
    }
}