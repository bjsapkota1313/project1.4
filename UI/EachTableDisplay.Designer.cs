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
            this.lblFormName = new System.Windows.Forms.Label();
            this.BtnBackToTableView = new System.Windows.Forms.Button();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.lblForUserInfoTomarkServe = new System.Windows.Forms.Label();
            this.btnMarkAsServed = new System.Windows.Forms.Button();
            this.BtnCheckout = new System.Windows.Forms.Button();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.lblCurrentTableStatus = new System.Windows.Forms.Label();
            this.pnlForOccupyingTable = new System.Windows.Forms.Panel();
            this.lblJustInfo = new System.Windows.Forms.Label();
            this.BtnMakeTableFree = new System.Windows.Forms.Button();
            this.labelInfoPayement = new System.Windows.Forms.Label();
            this.labelInPaneInfo = new System.Windows.Forms.Label();
            this.LabelnPanel = new System.Windows.Forms.Label();
            this.ListViewOfOrderItems = new System.Windows.Forms.ListView();
            this.pnlForOccupyingTable.SuspendLayout();
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
            this.BtnBackToTableView.Location = new System.Drawing.Point(6, 12);
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
            this.lblForUserInfoTomarkServe.Text = "You can select the order that is already served";
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
            // pnlForOccupyingTable
            // 
            this.pnlForOccupyingTable.Controls.Add(this.lblJustInfo);
            this.pnlForOccupyingTable.Controls.Add(this.BtnMakeTableFree);
            this.pnlForOccupyingTable.Controls.Add(this.labelInfoPayement);
            this.pnlForOccupyingTable.Controls.Add(this.labelInPaneInfo);
            this.pnlForOccupyingTable.Controls.Add(this.LabelnPanel);
            this.pnlForOccupyingTable.Location = new System.Drawing.Point(12, 153);
            this.pnlForOccupyingTable.Name = "pnlForOccupyingTable";
            this.pnlForOccupyingTable.Size = new System.Drawing.Size(683, 341);
            this.pnlForOccupyingTable.TabIndex = 12;
            // 
            // lblJustInfo
            // 
            this.lblJustInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJustInfo.ForeColor = System.Drawing.Color.White;
            this.lblJustInfo.Location = new System.Drawing.Point(99, 245);
            this.lblJustInfo.Name = "lblJustInfo";
            this.lblJustInfo.Size = new System.Drawing.Size(386, 39);
            this.lblJustInfo.TabIndex = 9;
            this.lblJustInfo.Text = "If you take the order , it is going to be occupied.";
            // 
            // BtnMakeTableFree
            // 
            this.BtnMakeTableFree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(50)))), ((int)(((byte)(27)))));
            this.BtnMakeTableFree.FlatAppearance.BorderSize = 0;
            this.BtnMakeTableFree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMakeTableFree.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMakeTableFree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMakeTableFree.Location = new System.Drawing.Point(176, 124);
            this.BtnMakeTableFree.Name = "BtnMakeTableFree";
            this.BtnMakeTableFree.Size = new System.Drawing.Size(293, 80);
            this.BtnMakeTableFree.TabIndex = 8;
            this.BtnMakeTableFree.Text = "Make Table Free ";
            this.BtnMakeTableFree.UseVisualStyleBackColor = false;
            // 
            // labelInfoPayement
            // 
            this.labelInfoPayement.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfoPayement.ForeColor = System.Drawing.Color.White;
            this.labelInfoPayement.Location = new System.Drawing.Point(109, 309);
            this.labelInfoPayement.Name = "labelInfoPayement";
            this.labelInfoPayement.Size = new System.Drawing.Size(472, 39);
            this.labelInfoPayement.TabIndex = 2;
            this.labelInfoPayement.Text = "Note:  \" Check out \" button only will work when there is an order in a table.";
            // 
            // labelInPaneInfo
            // 
            this.labelInPaneInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInPaneInfo.ForeColor = System.Drawing.Color.White;
            this.labelInPaneInfo.Location = new System.Drawing.Point(54, 71);
            this.labelInPaneInfo.Name = "labelInPaneInfo";
            this.labelInPaneInfo.Size = new System.Drawing.Size(559, 35);
            this.labelInPaneInfo.TabIndex = 1;
            this.labelInPaneInfo.Text = "Did you made the table status ocupied mistakenly?";
            // 
            // LabelnPanel
            // 
            this.LabelnPanel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelnPanel.ForeColor = System.Drawing.Color.White;
            this.LabelnPanel.Location = new System.Drawing.Point(43, 12);
            this.LabelnPanel.Name = "LabelnPanel";
            this.LabelnPanel.Size = new System.Drawing.Size(551, 46);
            this.LabelnPanel.TabIndex = 0;
            this.LabelnPanel.Text = "There are no orders in this table currently. ";
            // 
            // ListViewOfOrderItems
            // 
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
            this.Controls.Add(this.pnlForOccupyingTable);
            this.Controls.Add(this.ListViewOfOrderItems);
            this.Name = "EachTableDisplay";
            this.pnlForOccupyingTable.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlForOccupyingTable;
        private System.Windows.Forms.Label LabelnPanel;
        private System.Windows.Forms.Label lblJustInfo;
        private System.Windows.Forms.Button BtnMakeTableFree;
        private System.Windows.Forms.Label labelInfoPayement;
        private System.Windows.Forms.Label labelInPaneInfo;
        private System.Windows.Forms.ListView ListViewOfOrderItems;
    }
}