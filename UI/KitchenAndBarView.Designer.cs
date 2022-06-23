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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
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
            this.btnRunningOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLogOut = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblFOrDisplay = new System.Windows.Forms.Label();
            this.picBoxProfilePic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLogOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKitchenAndBarView
            // 
            this.lblKitchenAndBarView.AccessibleDescription = "";
            this.lblKitchenAndBarView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
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
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "fgdfgdfgdfgdf";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            this.lstViewKitchenAndBar.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lstViewKitchenAndBar.HideSelection = false;
            this.lstViewKitchenAndBar.Location = new System.Drawing.Point(27, 180);
            this.lstViewKitchenAndBar.Name = "lstViewKitchenAndBar";
            this.lstViewKitchenAndBar.ShowGroups = false;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
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
            // pnlLogOut
            // 
            this.pnlLogOut.BackColor = System.Drawing.Color.Gray;
            this.pnlLogOut.Controls.Add(this.label18);
            this.pnlLogOut.Controls.Add(this.lblEmployeeName);
            this.pnlLogOut.Controls.Add(this.pictureBox4);
            this.pnlLogOut.Controls.Add(this.lblEmployeeId);
            this.pnlLogOut.Controls.Add(this.btnLogOut);
            this.pnlLogOut.Location = new System.Drawing.Point(1541, 100);
            this.pnlLogOut.Name = "pnlLogOut";
            this.pnlLogOut.Size = new System.Drawing.Size(250, 121);
            this.pnlLogOut.TabIndex = 78;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(1, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(249, 10);
            this.label18.TabIndex = 5;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeName.Location = new System.Drawing.Point(59, 3);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(188, 30);
            this.lblEmployeeName.TabIndex = 3;
            this.lblEmployeeName.Text = "label18";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Gray;
            this.pictureBox4.Image = global::UI.Properties.Resources.output_onlinepngtools__7_;
            this.pictureBox4.Location = new System.Drawing.Point(3, 5);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 56);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.Location = new System.Drawing.Point(62, 35);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(181, 18);
            this.lblEmployeeId.TabIndex = 4;
            this.lblEmployeeId.Text = "label18";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(14, 77);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(225, 32);
            this.btnLogOut.TabIndex = 66;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFOrDisplay
            // 
            this.lblFOrDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.lblFOrDisplay.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFOrDisplay.Location = new System.Drawing.Point(0, 3);
            this.lblFOrDisplay.Name = "lblFOrDisplay";
            this.lblFOrDisplay.Size = new System.Drawing.Size(1810, 117);
            this.lblFOrDisplay.TabIndex = 79;
            // 
            // picBoxProfilePic
            // 
            this.picBoxProfilePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.picBoxProfilePic.Image = global::UI.Properties.Resources.output_onlinepngtools__7_;
            this.picBoxProfilePic.Location = new System.Drawing.Point(1712, 48);
            this.picBoxProfilePic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxProfilePic.Name = "picBoxProfilePic";
            this.picBoxProfilePic.Size = new System.Drawing.Size(50, 50);
            this.picBoxProfilePic.TabIndex = 80;
            this.picBoxProfilePic.TabStop = false;
            this.picBoxProfilePic.Click += new System.EventHandler(this.picBoxProfilePic_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KitchenAndBarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1792, 973);
            this.Controls.Add(this.picBoxProfilePic);
            this.Controls.Add(this.pnlLogOut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKitchenAndBarView);
            this.Controls.Add(this.lblFOrDisplay);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRunningOrder);
            this.Controls.Add(this.lstViewKitchenAndBar);
            this.Controls.Add(this.btnKitchenReady);
            this.Controls.Add(this.btnCompletedOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitchenAndBarView";
            this.Text = "KitchenAndBarView";
            this.Click += new System.EventHandler(this.KitchenAndBarView_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLogOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKitchenAndBarView;
        private System.Windows.Forms.Button btnCompletedOrder;
        private System.Windows.Forms.Button btnKitchenReady;
        private System.Windows.Forms.ListView lstViewKitchenAndBar;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader comment;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader table;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Button btnRunningOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblFOrDisplay;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlLogOut;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox picBoxProfilePic;
        private System.Windows.Forms.Timer timer1;
    }
}