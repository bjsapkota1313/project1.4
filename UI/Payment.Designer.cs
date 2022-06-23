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
            this.lblTableNum = new System.Windows.Forms.Label();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblVatTotal = new System.Windows.Forms.Label();
            this.lblVatHigh = new System.Windows.Forms.Label();
            this.lblVatLow = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTableNum
            // 
            this.lblTableNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(101)))), ((int)(((byte)(50)))));
            this.lblTableNum.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTableNum.ForeColor = System.Drawing.Color.White;
            this.lblTableNum.Location = new System.Drawing.Point(-15, 86);
            this.lblTableNum.Name = "lblTableNum";
            this.lblTableNum.Size = new System.Drawing.Size(744, 46);
            this.lblTableNum.TabIndex = 6;
            this.lblTableNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddComment
            // 
            this.btnAddComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(154)))), ((int)(((byte)(40)))));
            this.btnAddComment.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddComment.ForeColor = System.Drawing.Color.Black;
            this.btnAddComment.Location = new System.Drawing.Point(503, 558);
            this.btnAddComment.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(200, 50);
            this.btnAddComment.TabIndex = 10;
            this.btnAddComment.Text = "Add feedback";
            this.btnAddComment.UseVisualStyleBackColor = false;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(117)))), ((int)(((byte)(79)))));
            this.btnPay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(124, 979);
            this.btnPay.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(469, 52);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "Payment";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(629, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 16;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 360;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quantity";
            this.columnHeader1.Width = 110;
            // 
            // Price
            // 
            this.Price.Text = "Total price";
            this.Price.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "VAT";
            this.columnHeader2.Width = 90;
            // 
            // listViewBill
            // 
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.columnHeader1,
            this.Price,
            this.columnHeader2});
            this.listViewBill.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewBill.HideSelection = false;
            this.listViewBill.Location = new System.Drawing.Point(-2, 159);
            this.listViewBill.Margin = new System.Windows.Forms.Padding(5);
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(731, 381);
            this.listViewBill.TabIndex = 9;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            this.listViewBill.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-15, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 63);
            this.label1.TabIndex = 17;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(133)))), ((int)(((byte)(114)))));
            this.btnBack.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(15, 7);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 29;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(101)))), ((int)(((byte)(50)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-15, 625);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(744, 46);
            this.label2.TabIndex = 35;
            this.label2.Text = "Payment Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(527, 890);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(193, 66);
            this.lblPrice.TabIndex = 44;
            this.lblPrice.Text = "0.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVatTotal
            // 
            this.lblVatTotal.BackColor = System.Drawing.Color.White;
            this.lblVatTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVatTotal.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVatTotal.ForeColor = System.Drawing.Color.Black;
            this.lblVatTotal.Location = new System.Drawing.Point(527, 824);
            this.lblVatTotal.Name = "lblVatTotal";
            this.lblVatTotal.Size = new System.Drawing.Size(193, 66);
            this.lblVatTotal.TabIndex = 43;
            this.lblVatTotal.Text = "0.00";
            this.lblVatTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVatHigh
            // 
            this.lblVatHigh.BackColor = System.Drawing.Color.White;
            this.lblVatHigh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVatHigh.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVatHigh.ForeColor = System.Drawing.Color.Black;
            this.lblVatHigh.Location = new System.Drawing.Point(527, 757);
            this.lblVatHigh.Name = "lblVatHigh";
            this.lblVatHigh.Size = new System.Drawing.Size(193, 67);
            this.lblVatHigh.TabIndex = 42;
            this.lblVatHigh.Text = "0.00";
            this.lblVatHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVatLow
            // 
            this.lblVatLow.BackColor = System.Drawing.Color.White;
            this.lblVatLow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVatLow.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVatLow.ForeColor = System.Drawing.Color.Black;
            this.lblVatLow.Location = new System.Drawing.Point(527, 690);
            this.lblVatLow.Name = "lblVatLow";
            this.lblVatLow.Size = new System.Drawing.Size(193, 67);
            this.lblVatLow.TabIndex = 41;
            this.lblVatLow.Text = "0.00";
            this.lblVatLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(12, 690);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(521, 67);
            this.lbl1.TabIndex = 37;
            this.lbl1.Text = "VAT low (6%)";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.White;
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl2.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(12, 757);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(521, 67);
            this.lbl2.TabIndex = 38;
            this.lbl2.Text = "VAT high (21%)";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl3.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(12, 824);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(521, 66);
            this.lbl3.TabIndex = 39;
            this.lbl3.Text = "VAT total";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.White;
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl4.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl4.ForeColor = System.Drawing.Color.Black;
            this.lbl4.Location = new System.Drawing.Point(12, 890);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(521, 66);
            this.lbl4.TabIndex = 40;
            this.lbl4.Text = "Price";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(718, 1062);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblVatTotal);
            this.Controls.Add(this.lblVatHigh);
            this.Controls.Add(this.lblVatLow);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.listViewBill);
            this.Controls.Add(this.lblTableNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableNum;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblVatTotal;
        private System.Windows.Forms.Label lblVatHigh;
        private System.Windows.Forms.Label lblVatLow;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
    }
}