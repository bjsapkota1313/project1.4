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
            this.lstViewKitchen = new System.Windows.Forms.ListView();
            this.order_Id = new System.Windows.Forms.ColumnHeader();
            this.item_Name = new System.Windows.Forms.ColumnHeader();
            this.quantity = new System.Windows.Forms.ColumnHeader();
            this.table_number = new System.Windows.Forms.ColumnHeader();
            this.state = new System.Windows.Forms.ColumnHeader();
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
            this.btnKitchenShowCmpltOrder.Size = new System.Drawing.Size(578, 80);
            this.btnKitchenShowCmpltOrder.TabIndex = 4;
            this.btnKitchenShowCmpltOrder.Text = "Show Completed Order";
            this.btnKitchenShowCmpltOrder.UseVisualStyleBackColor = false;
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
            // 
            // lstViewKitchen
            // 
            this.lstViewKitchen.BackColor = System.Drawing.Color.Black;
            this.lstViewKitchen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.order_Id,
            this.item_Name,
            this.quantity,
            this.table_number,
            this.state});
            this.lstViewKitchen.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstViewKitchen.ForeColor = System.Drawing.Color.Red;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "fgdfgdfgdfgdf";
            this.lstViewKitchen.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lstViewKitchen.HideSelection = false;
            this.lstViewKitchen.Location = new System.Drawing.Point(0, 221);
            this.lstViewKitchen.Name = "lstViewKitchen";
            this.lstViewKitchen.Size = new System.Drawing.Size(1810, 621);
            this.lstViewKitchen.TabIndex = 6;
            this.lstViewKitchen.UseCompatibleStateImageBehavior = false;
            this.lstViewKitchen.View = System.Windows.Forms.View.Details;
            // 
            // order_Id
            // 
            this.order_Id.Text = "ID";
            this.order_Id.Width = 225;
            // 
            // item_Name
            // 
            this.item_Name.Text = "Item Name";
            this.item_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item_Name.Width = 890;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity.Width = 225;
            // 
            // table_number
            // 
            this.table_number.Text = "Table";
            this.table_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.table_number.Width = 225;
            // 
            // state
            // 
            this.state.Text = "State";
            this.state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.state.Width = 225;
            // 
            // KitchenAndBarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1792, 973);
            this.Controls.Add(this.lstViewKitchen);
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
        private System.Windows.Forms.ListView lstViewKitchen;
        private System.Windows.Forms.ColumnHeader order_Id;
        private System.Windows.Forms.ColumnHeader item_Name;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader table_number;
        private System.Windows.Forms.ColumnHeader state;
    }
}