namespace UI
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.Item = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnPIN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();

            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-9, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Table Number X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-9, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 51);
            this.label2.TabIndex = 8;
            this.label2.Text = "\'Hamb menu\'";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewBill
            // 
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.columnHeader1,
            this.Price,
            this.columnHeader2});
            this.listViewBill.HideSelection = false;

            this.listViewBill.Location = new System.Drawing.Point(12, 158);
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(694, 428);
            this.listViewBill.TabIndex = 9;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            this.listViewBill.View = System.Windows.Forms.View.Details;
            // 
            // Item
            // 
            this.Item.Text = "Item";


            this.Item.Width = 360;
            // 
            // Price
            // 
            this.Price.Text = "Total price";
            this.Price.Width = 130;
            // 
            // btnAddComment
            // 
            this.btnAddComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.btnAddComment.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddComment.ForeColor = System.Drawing.Color.Black;
            this.btnAddComment.Location = new System.Drawing.Point(74, 602);
            this.btnAddComment.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(289, 32);
            this.btnAddComment.TabIndex = 10;
            this.btnAddComment.Text = "Add comment";
            this.btnAddComment.UseVisualStyleBackColor = false;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.btnCash.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCash.ForeColor = System.Drawing.Color.Black;
            this.btnCash.Location = new System.Drawing.Point(74, 419);
            this.btnCash.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(289, 32);
            this.btnCash.TabIndex = 11;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.btnCreditCard.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreditCard.ForeColor = System.Drawing.Color.Black;
            this.btnCreditCard.Location = new System.Drawing.Point(74, 466);
            this.btnCreditCard.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(289, 32);
            this.btnCreditCard.TabIndex = 12;
            this.btnCreditCard.Text = "Credit Card";
            this.btnCreditCard.UseVisualStyleBackColor = false;
            // 
            // btnPIN
            // 
            this.btnPIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.btnPIN.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPIN.ForeColor = System.Drawing.Color.Black;
            this.btnPIN.Location = new System.Drawing.Point(74, 513);
            this.btnPIN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPIN.Name = "btnPIN";
            this.btnPIN.Size = new System.Drawing.Size(289, 32);
            this.btnPIN.TabIndex = 13;
            this.btnPIN.Text = "PIN";
            this.btnPIN.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-9, 375);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(458, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Payment method";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 


            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(387, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 16;
            // 

            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.label8.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-9, 559);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(458, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Feedback";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVAT
            //// 
            //this.txtVAT.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            //this.txtVAT.Location = new System.Drawing.Point(314, 305);
            //this.txtVAT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            //this.txtVAT.Multiline = true;
            //this.txtVAT.Name = "txtVAT";
            //this.txtVAT.Size = new System.Drawing.Size(86, 20);
            //this.txtVAT.TabIndex = 20;
            //// 
            //// txtTip
            //// 
            //this.txtTip.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            //this.txtTip.Location = new System.Drawing.Point(314, 325);
            //this.txtTip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            //this.txtTip.Multiline = true;
            //this.txtTip.Name = "txtTip";
            //this.txtTip.Size = new System.Drawing.Size(86, 20);
            //this.txtTip.TabIndex = 21;

            // columnHeader1

            // 
            this.columnHeader1.Text = "Quantity";
            this.columnHeader1.Width = 110;
            // 

            // columnHeader2
            // 
            this.columnHeader2.Text = "VAT";
            this.columnHeader2.Width = 90;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;

            this.ClientSize = new System.Drawing.Size(718, 1062);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPIN);
            this.Controls.Add(this.btnCreditCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.listViewBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnPIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}