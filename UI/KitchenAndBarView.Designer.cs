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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenAndBarView));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.lblKitchenView = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKitchenShowCmpltOrder = new System.Windows.Forms.Button();
            this.btnKitchenReady = new System.Windows.Forms.Button();
            this.lstViewKitchenAndBar = new System.Windows.Forms.ListView();
            this.orderId = new System.Windows.Forms.ColumnHeader();
            this.item_Name = new System.Windows.Forms.ColumnHeader();
            this.item_quantity = new System.Windows.Forms.ColumnHeader();
            this.item_Comment = new System.Windows.Forms.ColumnHeader();
            this.wait_time = new System.Windows.Forms.ColumnHeader();
            this.table_nr = new System.Windows.Forms.ColumnHeader();
            this.order_status = new System.Windows.Forms.ColumnHeader();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKitchenView
            // 
            this.lblKitchenView.AutoSize = true;
            this.lblKitchenView.Font = new System.Drawing.Font("Calibri", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKitchenView.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblKitchenView.Location = new System.Drawing.Point(752, 33);
            this.lblKitchenView.Name = "lblKitchenView";
            this.lblKitchenView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblKitchenView.Size = new System.Drawing.Size(399, 82);
            this.lblKitchenView.TabIndex = 0;
            this.lblKitchenView.Text = "Kitchen View";
            this.lblKitchenView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 73);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "You are logged in as:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1810, 47);
            this.button1.TabIndex = 3;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnKitchenShowCmpltOrder
            // 
            this.btnKitchenShowCmpltOrder.BackColor = System.Drawing.Color.Blue;
            this.btnKitchenShowCmpltOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKitchenShowCmpltOrder.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKitchenShowCmpltOrder.ForeColor = System.Drawing.Color.White;
            this.btnKitchenShowCmpltOrder.Location = new System.Drawing.Point(47, 878);
            this.btnKitchenShowCmpltOrder.Name = "btnKitchenShowCmpltOrder";
            this.btnKitchenShowCmpltOrder.Size = new System.Drawing.Size(410, 80);
            this.btnKitchenShowCmpltOrder.TabIndex = 4;
            this.btnKitchenShowCmpltOrder.Text = "Completed Order";
            this.btnKitchenShowCmpltOrder.UseVisualStyleBackColor = false;
            this.btnKitchenShowCmpltOrder.Click += new System.EventHandler(this.btnKitchenShowCmpltOrder_Click);
            // 
            // btnKitchenReady
            // 
            this.btnKitchenReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(121)))), ((int)(((byte)(7)))));
            this.btnKitchenReady.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKitchenReady.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKitchenReady.ForeColor = System.Drawing.Color.White;
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
            this.orderId,
            this.item_Name,
            this.item_quantity,
            this.item_Comment,
            this.wait_time,
            this.table_nr,
            this.order_status});
            this.lstViewKitchenAndBar.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstViewKitchenAndBar.ForeColor = System.Drawing.Color.Black;
            this.lstViewKitchenAndBar.FullRowSelect = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "fgdfgdfgdfgdf";
            this.lstViewKitchenAndBar.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lstViewKitchenAndBar.HideSelection = false;
            this.lstViewKitchenAndBar.Location = new System.Drawing.Point(0, 221);
            this.lstViewKitchenAndBar.Name = "lstViewKitchenAndBar";
            this.lstViewKitchenAndBar.Size = new System.Drawing.Size(1810, 621);
            this.lstViewKitchenAndBar.TabIndex = 6;
            this.lstViewKitchenAndBar.UseCompatibleStateImageBehavior = false;
            this.lstViewKitchenAndBar.View = System.Windows.Forms.View.Details;
            //this.lstViewKitchenAndBar.SelectedIndexChanged += new System.EventHandler(this.lstViewKitchenAndBar_SelectedIndexChanged);
            // 
            // orderId
            // 
            this.orderId.Tag = "orderId";
            this.orderId.Text = "OrderID";
            this.orderId.Width = 200;
            // 
            // item_Name
            // 
            this.item_Name.Text = "Item Name";
            this.item_Name.Width = 400;
            // 
            // item_quantity
            // 
            this.item_quantity.Text = "Quantity";
            this.item_quantity.Width = 200;
            // 
            // item_Comment
            // 
            this.item_Comment.Text = "Comment";
            this.item_Comment.Width = 400;
            // 
            // wait_time
            // 
            this.wait_time.Text = "Time";
            this.wait_time.Width = 200;
            // 
            // table_nr
            // 
            this.table_nr.Text = "Table";
            this.table_nr.Width = 200;
            // 
            // order_status
            // 
            this.order_status.Text = "Status";
            this.order_status.Width = 200;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(741, 878);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(410, 80);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1573, 45);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(151, 52);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "&Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // KitchenAndBarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1792, 973);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstViewKitchenAndBar);
            this.Controls.Add(this.btnKitchenReady);
            this.Controls.Add(this.btnKitchenShowCmpltOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKitchenView);
            this.Name = "KitchenAndBarView";
            this.Text = "KitchenAndBarView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKitchenView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKitchenShowCmpltOrder;
        private System.Windows.Forms.Button btnKitchenReady;
        private System.Windows.Forms.ListView lstViewKitchenAndBar;
        private System.Windows.Forms.ColumnHeader orderId;
        private System.Windows.Forms.ColumnHeader item_Name;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader item_quantity;
        private System.Windows.Forms.ColumnHeader item_Comment;
        private System.Windows.Forms.ColumnHeader wait_time;
        private System.Windows.Forms.ColumnHeader table_nr;
        private System.Windows.Forms.ColumnHeader order_status;
        private System.Windows.Forms.Button btnLogOut;
    }
}