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
            this.lblForUserInfoTomarkServe = new System.Windows.Forms.Label();
            this.btnMarkAsServed = new System.Windows.Forms.Button();
            this.BtnCheckout = new System.Windows.Forms.Button();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.lblCurrentTableStatus = new System.Windows.Forms.Label();
            this.pnlForOtherInfo = new System.Windows.Forms.Panel();
            this.lblInfoOccupyTable = new System.Windows.Forms.Label();
            this.btnOccupyTable = new System.Windows.Forms.Button();
            this.LblInfoAboveButton = new System.Windows.Forms.Label();
            this.BtnMakeTableFree = new System.Windows.Forms.Button();
            this.ListViewOfOrderItems = new System.Windows.Forms.ListView();
            this.pnlForOtherInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormName
            // 
            this.lblFormName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.lblFormName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormName.Location = new System.Drawing.Point(1, 66);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(730, 47);
            this.lblFormName.TabIndex = 2;
            // 
            // BtnBackToTableView
            // 
            this.BtnBackToTableView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(133)))), ((int)(((byte)(114)))));
            this.BtnBackToTableView.FlatAppearance.BorderSize = 0;
            this.BtnBackToTableView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBackToTableView.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBackToTableView.ForeColor = System.Drawing.Color.White;
            this.BtnBackToTableView.Image = global::UI.Properties.Resources.ArrowFatLeftNew;
            this.BtnBackToTableView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBackToTableView.Location = new System.Drawing.Point(4, 8);
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
            this.lblTableNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.lblTableNumber.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTableNumber.ForeColor = System.Drawing.Color.White;
            this.lblTableNumber.Location = new System.Drawing.Point(1, 66);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(256, 40);
            this.lblTableNumber.TabIndex = 4;
            this.lblTableNumber.Text = "Table Nr";
            // 
            // lblForUserInfoTomarkServe
            // 
            this.lblForUserInfoTomarkServe.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblForUserInfoTomarkServe.ForeColor = System.Drawing.Color.White;
            this.lblForUserInfoTomarkServe.Location = new System.Drawing.Point(12, 533);
            this.lblForUserInfoTomarkServe.Name = "lblForUserInfoTomarkServe";
            this.lblForUserInfoTomarkServe.Size = new System.Drawing.Size(365, 71);
            this.lblForUserInfoTomarkServe.TabIndex = 6;
            this.lblForUserInfoTomarkServe.Text = "Selected order will change their  order status to served";
            // 
            // btnMarkAsServed
            // 
            this.btnMarkAsServed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.btnMarkAsServed.FlatAppearance.BorderSize = 0;
            this.btnMarkAsServed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarkAsServed.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMarkAsServed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMarkAsServed.Location = new System.Drawing.Point(402, 524);
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
            this.BtnCheckout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCheckout.Location = new System.Drawing.Point(12, 629);
            this.BtnCheckout.Name = "BtnCheckout";
            this.BtnCheckout.Size = new System.Drawing.Size(293, 76);
            this.BtnCheckout.TabIndex = 8;
            this.BtnCheckout.Text = "Check Out";
            this.BtnCheckout.UseVisualStyleBackColor = false;
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(22)))), ((int)(((byte)(172)))));
            this.btnTakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakeOrder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTakeOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTakeOrder.Location = new System.Drawing.Point(402, 628);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(293, 76);
            this.btnTakeOrder.TabIndex = 9;
            this.btnTakeOrder.Text = "Take Order";
            this.btnTakeOrder.UseVisualStyleBackColor = false;
            // 
            // lblCurrentTableStatus
            // 
            this.lblCurrentTableStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.lblCurrentTableStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentTableStatus.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTableStatus.Location = new System.Drawing.Point(475, 67);
            this.lblCurrentTableStatus.Name = "lblCurrentTableStatus";
            this.lblCurrentTableStatus.Size = new System.Drawing.Size(220, 40);
            this.lblCurrentTableStatus.TabIndex = 11;
            this.lblCurrentTableStatus.Text = "Table Status";
            // 
            // pnlForOtherInfo
            // 
            this.pnlForOtherInfo.Controls.Add(this.lblInfoOccupyTable);
            this.pnlForOtherInfo.Controls.Add(this.btnOccupyTable);
            this.pnlForOtherInfo.Controls.Add(this.LblInfoAboveButton);
            this.pnlForOtherInfo.Controls.Add(this.BtnMakeTableFree);
            this.pnlForOtherInfo.Location = new System.Drawing.Point(12, 153);
            this.pnlForOtherInfo.Name = "pnlForOtherInfo";
            this.pnlForOtherInfo.Size = new System.Drawing.Size(683, 341);
            this.pnlForOtherInfo.TabIndex = 12;
            // 
            // lblInfoOccupyTable
            // 
            this.lblInfoOccupyTable.BackColor = System.Drawing.Color.Black;
            this.lblInfoOccupyTable.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoOccupyTable.ForeColor = System.Drawing.Color.White;
            this.lblInfoOccupyTable.Location = new System.Drawing.Point(114, 63);
            this.lblInfoOccupyTable.Name = "lblInfoOccupyTable";
            this.lblInfoOccupyTable.Size = new System.Drawing.Size(444, 46);
            this.lblInfoOccupyTable.TabIndex = 11;
            // 
            // btnOccupyTable
            // 
            this.btnOccupyTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(115)))), ((int)(((byte)(73)))));
            this.btnOccupyTable.FlatAppearance.BorderSize = 0;
            this.btnOccupyTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOccupyTable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOccupyTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOccupyTable.Location = new System.Drawing.Point(192, 239);
            this.btnOccupyTable.Name = "btnOccupyTable";
            this.btnOccupyTable.Size = new System.Drawing.Size(293, 80);
            this.btnOccupyTable.TabIndex = 10;
            this.btnOccupyTable.Text = "Occupy this Table";
            this.btnOccupyTable.UseVisualStyleBackColor = false;
            this.btnOccupyTable.Click += new System.EventHandler(this.btnOccupyTable_Click);
            // 
            // LblInfoAboveButton
            // 
            this.LblInfoAboveButton.BackColor = System.Drawing.Color.Black;
            this.LblInfoAboveButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblInfoAboveButton.ForeColor = System.Drawing.Color.White;
            this.LblInfoAboveButton.Location = new System.Drawing.Point(50, 63);
            this.LblInfoAboveButton.Name = "LblInfoAboveButton";
            this.LblInfoAboveButton.Size = new System.Drawing.Size(561, 46);
            this.LblInfoAboveButton.TabIndex = 9;
            this.LblInfoAboveButton.Text = "There are no orders currently in this table ";
            // 
            // BtnMakeTableFree
            // 
            this.BtnMakeTableFree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(129)))), ((int)(((byte)(36)))));
            this.BtnMakeTableFree.FlatAppearance.BorderSize = 0;
            this.BtnMakeTableFree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMakeTableFree.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMakeTableFree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMakeTableFree.Location = new System.Drawing.Point(180, 153);
            this.BtnMakeTableFree.Name = "BtnMakeTableFree";
            this.BtnMakeTableFree.Size = new System.Drawing.Size(293, 80);
            this.BtnMakeTableFree.TabIndex = 8;
            this.BtnMakeTableFree.Text = "Make Table Free ";
            this.BtnMakeTableFree.UseVisualStyleBackColor = false;
            this.BtnMakeTableFree.Click += new System.EventHandler(this.BtnMakeTableFree_Click);
            // 
            // ListViewOfOrderItems
            // 
            this.ListViewOfOrderItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListViewOfOrderItems.HideSelection = false;
            this.ListViewOfOrderItems.Location = new System.Drawing.Point(26, 153);
            this.ListViewOfOrderItems.Name = "ListViewOfOrderItems";
            this.ListViewOfOrderItems.Size = new System.Drawing.Size(669, 341);
            this.ListViewOfOrderItems.TabIndex = 13;
            this.ListViewOfOrderItems.UseCompatibleStateImageBehavior = false;
            this.ListViewOfOrderItems.SelectedIndexChanged += new System.EventHandler(this.ListViewOfOrderItems_SelectedIndexChanged);
            // 
            // EachTableDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(726, 729);
            this.Controls.Add(this.lblCurrentTableStatus);
            this.Controls.Add(this.btnTakeOrder);
            this.Controls.Add(this.BtnCheckout);
            this.Controls.Add(this.btnMarkAsServed);
            this.Controls.Add(this.lblForUserInfoTomarkServe);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.BtnBackToTableView);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.pnlForOtherInfo);
            this.Controls.Add(this.ListViewOfOrderItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EachTableDisplay";
            this.pnlForOtherInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button BtnBackToTableView;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Label lblForUserInfoTomarkServe;
        private System.Windows.Forms.Button btnMarkAsServed;
        private System.Windows.Forms.Button BtnCheckout;
        private System.Windows.Forms.Button btnTakeOrder;
        private System.Windows.Forms.Label lblCurrentTableStatus;
        private System.Windows.Forms.Panel pnlForOtherInfo;
        private System.Windows.Forms.Button BtnMakeTableFree;
        private System.Windows.Forms.ListView ListViewOfOrderItems;
        private System.Windows.Forms.Label LblInfoAboveButton;
        private System.Windows.Forms.Button btnOccupyTable;
        private System.Windows.Forms.Label lblInfoOccupyTable;
    }
}