namespace UI
{
    partial class EachTableDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EachTableDisplay));
            this.lblFormName = new System.Windows.Forms.Label();
            this.BtnBackToTableView = new System.Windows.Forms.Button();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.btnMarkAsServed = new System.Windows.Forms.Button();
            this.BtnCheckout = new System.Windows.Forms.Button();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.lblCurrentTableStatus = new System.Windows.Forms.Label();
            this.btnOccupyTable = new System.Windows.Forms.Button();
            this.ListViewOfOrderItems = new System.Windows.Forms.ListView();
            this.btnMakeTableFree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormName
            // 
            this.lblFormName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(101)))), ((int)(((byte)(50)))));
            this.lblFormName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormName.Location = new System.Drawing.Point(1, 68);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(730, 47);
            this.lblFormName.TabIndex = 2;
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
            this.BtnBackToTableView.Location = new System.Drawing.Point(4, 8);
            this.BtnBackToTableView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBackToTableView.Name = "BtnBackToTableView";
            this.BtnBackToTableView.Size = new System.Drawing.Size(128, 51);
            this.BtnBackToTableView.TabIndex = 3;
            this.BtnBackToTableView.Text = "Back";
            this.BtnBackToTableView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBackToTableView.UseVisualStyleBackColor = false;
            this.BtnBackToTableView.Click += new System.EventHandler(this.BtnBackToTableView_Click);
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(101)))), ((int)(((byte)(50)))));
            this.lblTableNumber.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTableNumber.ForeColor = System.Drawing.Color.White;
            this.lblTableNumber.Location = new System.Drawing.Point(24, 74);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(256, 40);
            this.lblTableNumber.TabIndex = 4;
            this.lblTableNumber.Text = "Table Nr";
            // 
            // btnMarkAsServed
            // 
            this.btnMarkAsServed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnMarkAsServed.FlatAppearance.BorderSize = 0;
            this.btnMarkAsServed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarkAsServed.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMarkAsServed.ForeColor = System.Drawing.Color.Black;
            this.btnMarkAsServed.Location = new System.Drawing.Point(410, 823);
            this.btnMarkAsServed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarkAsServed.Name = "btnMarkAsServed";
            this.btnMarkAsServed.Size = new System.Drawing.Size(293, 80);
            this.btnMarkAsServed.TabIndex = 7;
            this.btnMarkAsServed.Text = "Mark as Served";
            this.btnMarkAsServed.UseVisualStyleBackColor = false;
            this.btnMarkAsServed.Click += new System.EventHandler(this.btnMarkAsServed_Click);
            // 
            // BtnCheckout
            // 
            this.BtnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(167)))));
            this.BtnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCheckout.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCheckout.ForeColor = System.Drawing.Color.Black;
            this.BtnCheckout.Location = new System.Drawing.Point(25, 938);
            this.BtnCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCheckout.Name = "BtnCheckout";
            this.BtnCheckout.Size = new System.Drawing.Size(293, 80);
            this.BtnCheckout.TabIndex = 8;
            this.BtnCheckout.Text = "Check Out";
            this.BtnCheckout.UseVisualStyleBackColor = false;
            this.BtnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(22)))), ((int)(((byte)(172)))));
            this.btnTakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakeOrder.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTakeOrder.ForeColor = System.Drawing.Color.Black;
            this.btnTakeOrder.Location = new System.Drawing.Point(410, 938);
            this.btnTakeOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(293, 80);
            this.btnTakeOrder.TabIndex = 9;
            this.btnTakeOrder.Text = "Take Order";
            this.btnTakeOrder.UseVisualStyleBackColor = false;
            this.btnTakeOrder.Click += new System.EventHandler(this.btnTakeOrder_Click);
            // 
            // lblCurrentTableStatus
            // 
            this.lblCurrentTableStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(101)))), ((int)(((byte)(50)))));
            this.lblCurrentTableStatus.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentTableStatus.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTableStatus.Location = new System.Drawing.Point(487, 71);
            this.lblCurrentTableStatus.Name = "lblCurrentTableStatus";
            this.lblCurrentTableStatus.Size = new System.Drawing.Size(220, 40);
            this.lblCurrentTableStatus.TabIndex = 11;
            this.lblCurrentTableStatus.Text = "Table Status";
            // 
            // btnOccupyTable
            // 
            this.btnOccupyTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(115)))), ((int)(((byte)(73)))));
            this.btnOccupyTable.FlatAppearance.BorderSize = 0;
            this.btnOccupyTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOccupyTable.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOccupyTable.ForeColor = System.Drawing.Color.Black;
            this.btnOccupyTable.Location = new System.Drawing.Point(25, 823);
            this.btnOccupyTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOccupyTable.Name = "btnOccupyTable";
            this.btnOccupyTable.Size = new System.Drawing.Size(293, 80);
            this.btnOccupyTable.TabIndex = 10;
            this.btnOccupyTable.Text = "Occupy This Table";
            this.btnOccupyTable.UseVisualStyleBackColor = false;
            this.btnOccupyTable.Click += new System.EventHandler(this.btnOccupyTable_Click);
            // 
            // ListViewOfOrderItems
            // 
            this.ListViewOfOrderItems.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListViewOfOrderItems.HideSelection = false;
            this.ListViewOfOrderItems.Location = new System.Drawing.Point(24, 153);
            this.ListViewOfOrderItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListViewOfOrderItems.Name = "ListViewOfOrderItems";
            this.ListViewOfOrderItems.Size = new System.Drawing.Size(679, 608);
            this.ListViewOfOrderItems.TabIndex = 13;
            this.ListViewOfOrderItems.UseCompatibleStateImageBehavior = false;
            this.ListViewOfOrderItems.SelectedIndexChanged += new System.EventHandler(this.ListViewOfOrderItems_SelectedIndexChanged);
            // 
            // btnMakeTableFree
            // 
            this.btnMakeTableFree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(154)))), ((int)(((byte)(40)))));
            this.btnMakeTableFree.FlatAppearance.BorderSize = 0;
            this.btnMakeTableFree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakeTableFree.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMakeTableFree.ForeColor = System.Drawing.Color.Black;
            this.btnMakeTableFree.Location = new System.Drawing.Point(25, 823);
            this.btnMakeTableFree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeTableFree.Name = "btnMakeTableFree";
            this.btnMakeTableFree.Size = new System.Drawing.Size(293, 80);
            this.btnMakeTableFree.TabIndex = 14;
            this.btnMakeTableFree.Text = "Free This Table";
            this.btnMakeTableFree.UseVisualStyleBackColor = false;
            this.btnMakeTableFree.Click += new System.EventHandler(this.btnMakeTableFree_Click_1);
            // 
            // EachTableDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(726, 1055);
            this.Controls.Add(this.btnMakeTableFree);
            this.Controls.Add(this.btnOccupyTable);
            this.Controls.Add(this.lblCurrentTableStatus);
            this.Controls.Add(this.btnTakeOrder);
            this.Controls.Add(this.BtnCheckout);
            this.Controls.Add(this.btnMarkAsServed);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.BtnBackToTableView);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.ListViewOfOrderItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EachTableDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button BtnBackToTableView;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Button btnMarkAsServed;
        private System.Windows.Forms.Button BtnCheckout;
        private System.Windows.Forms.Button btnTakeOrder;
        private System.Windows.Forms.Label lblCurrentTableStatus;
        private System.Windows.Forms.ListView ListViewOfOrderItems;
        private System.Windows.Forms.Button btnOccupyTable;
        private System.Windows.Forms.Button btnMakeTableFree;
    }
}