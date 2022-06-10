namespace UI
{
    partial class OrderDisplay
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
            this.DBOrderListView = new System.Windows.Forms.ListView();
            this.ItemName = new System.Windows.Forms.ColumnHeader();
            this.OrderFeedback = new System.Windows.Forms.ColumnHeader();
            this.OrderTime = new System.Windows.Forms.ColumnHeader();
            this.OrderStatus = new System.Windows.Forms.ColumnHeader();
            this.OrderRemoveItemBtn = new System.Windows.Forms.Button();
            this.PayBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DBOrderListView
            // 
            this.DBOrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.OrderFeedback,
            this.OrderTime,
            this.OrderStatus});
            this.DBOrderListView.HideSelection = false;
            this.DBOrderListView.Location = new System.Drawing.Point(6, 12);
            this.DBOrderListView.Name = "DBOrderListView";
            this.DBOrderListView.Size = new System.Drawing.Size(496, 267);
            this.DBOrderListView.TabIndex = 1;
            this.DBOrderListView.UseCompatibleStateImageBehavior = false;
            this.DBOrderListView.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            this.ItemName.Width = 220;
            // 
            // OrderFeedback
            // 
            this.OrderFeedback.Text = "Feedback";
            this.OrderFeedback.Width = 150;
            // 
            // OrderTime
            // 
            this.OrderTime.Text = "Time";
            // 
            // OrderStatus
            // 
            this.OrderStatus.Text = "Status";
            // 
            // OrderRemoveItemBtn
            // 
            this.OrderRemoveItemBtn.Location = new System.Drawing.Point(6, 285);
            this.OrderRemoveItemBtn.Name = "OrderRemoveItemBtn";
            this.OrderRemoveItemBtn.Size = new System.Drawing.Size(496, 43);
            this.OrderRemoveItemBtn.TabIndex = 3;
            this.OrderRemoveItemBtn.Text = "Remove Item";
            this.OrderRemoveItemBtn.UseVisualStyleBackColor = true;
            // 
            // PayBtn
            // 
            this.PayBtn.Location = new System.Drawing.Point(6, 334);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(496, 43);
            this.PayBtn.TabIndex = 4;
            this.PayBtn.Text = "Pay";
            this.PayBtn.UseVisualStyleBackColor = true;
            // 
            // OrderDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(514, 435);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.OrderRemoveItemBtn);
            this.Controls.Add(this.DBOrderListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDisplay";
            this.Text = "OrderDisplay";
            this.Load += new System.EventHandler(this.OrderDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DBOrderListView;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader OrderFeedback;
        private System.Windows.Forms.ColumnHeader OrderTime;
        private System.Windows.Forms.ColumnHeader OrderStatus;
        private System.Windows.Forms.Button OrderRemoveItemBtn;
        private System.Windows.Forms.Button PayBtn;
    }
}