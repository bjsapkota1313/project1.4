namespace UI
{
    partial class Tip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tip));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmitTip = new System.Windows.Forms.Button();
            this.btnSubmitTotal = new System.Windows.Forms.Button();
            this.radBtnCreditCard = new System.Windows.Forms.RadioButton();
            this.radBtnCash = new System.Windows.Forms.RadioButton();
            this.radBtnPIN = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cBoxSplitBill = new System.Windows.Forms.CheckBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSplitBill = new System.Windows.Forms.Label();
            this.lblSplit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(101)))), ((int)(((byte)(50)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-15, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(411, 533);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(295, 39);
            this.txtTotal.TabIndex = 14;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(12, 533);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(295, 39);
            this.txtTip.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(411, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 39);
            this.label4.TabIndex = 17;
            this.label4.Text = "Enter           to be Paid";
            // 
            // btnSubmitTip
            // 
            this.btnSubmitTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(160)))), ((int)(((byte)(96)))));
            this.btnSubmitTip.Enabled = false;
            this.btnSubmitTip.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitTip.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitTip.Location = new System.Drawing.Point(158, 579);
            this.btnSubmitTip.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSubmitTip.Name = "btnSubmitTip";
            this.btnSubmitTip.Size = new System.Drawing.Size(149, 44);
            this.btnSubmitTip.TabIndex = 20;
            this.btnSubmitTip.Text = "Submit";
            this.btnSubmitTip.UseVisualStyleBackColor = false;
            this.btnSubmitTip.Click += new System.EventHandler(this.btnSubmitTip_Click);
            // 
            // btnSubmitTotal
            // 
            this.btnSubmitTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(160)))), ((int)(((byte)(96)))));
            this.btnSubmitTotal.Enabled = false;
            this.btnSubmitTotal.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitTotal.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitTotal.Location = new System.Drawing.Point(554, 579);
            this.btnSubmitTotal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSubmitTotal.Name = "btnSubmitTotal";
            this.btnSubmitTotal.Size = new System.Drawing.Size(149, 44);
            this.btnSubmitTotal.TabIndex = 21;
            this.btnSubmitTotal.Text = "Submit";
            this.btnSubmitTotal.UseVisualStyleBackColor = false;
            this.btnSubmitTotal.Click += new System.EventHandler(this.btnSubmitTotal_Click);
            // 
            // radBtnCreditCard
            // 
            this.radBtnCreditCard.AutoSize = true;
            this.radBtnCreditCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(154)))), ((int)(((byte)(40)))));
            this.radBtnCreditCard.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtnCreditCard.ForeColor = System.Drawing.Color.Black;
            this.radBtnCreditCard.Location = new System.Drawing.Point(257, 826);
            this.radBtnCreditCard.Name = "radBtnCreditCard";
            this.radBtnCreditCard.Size = new System.Drawing.Size(218, 49);
            this.radBtnCreditCard.TabIndex = 24;
            this.radBtnCreditCard.TabStop = true;
            this.radBtnCreditCard.Text = "Credit Card";
            this.radBtnCreditCard.UseVisualStyleBackColor = false;
            // 
            // radBtnCash
            // 
            this.radBtnCash.AutoSize = true;
            this.radBtnCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(154)))), ((int)(((byte)(40)))));
            this.radBtnCash.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtnCash.ForeColor = System.Drawing.Color.Black;
            this.radBtnCash.Location = new System.Drawing.Point(57, 826);
            this.radBtnCash.Name = "radBtnCash";
            this.radBtnCash.Size = new System.Drawing.Size(122, 49);
            this.radBtnCash.TabIndex = 25;
            this.radBtnCash.TabStop = true;
            this.radBtnCash.Text = "Cash";
            this.radBtnCash.UseVisualStyleBackColor = false;
            // 
            // radBtnPIN
            // 
            this.radBtnPIN.AutoSize = true;
            this.radBtnPIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(154)))), ((int)(((byte)(40)))));
            this.radBtnPIN.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtnPIN.ForeColor = System.Drawing.Color.Black;
            this.radBtnPIN.Location = new System.Drawing.Point(544, 826);
            this.radBtnPIN.Name = "radBtnPIN";
            this.radBtnPIN.Size = new System.Drawing.Size(103, 49);
            this.radBtnPIN.TabIndex = 26;
            this.radBtnPIN.TabStop = true;
            this.radBtnPIN.Text = "PIN";
            this.radBtnPIN.UseVisualStyleBackColor = false;
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
            this.btnBack.TabIndex = 28;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-15, -4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(744, 63);
            this.label5.TabIndex = 27;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(92, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 39);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(487, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 39);
            this.label6.TabIndex = 30;
            this.label6.Text = "Total";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(117)))), ((int)(((byte)(79)))));
            this.btnPay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(125, 949);
            this.btnPay.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(469, 52);
            this.btnPay.TabIndex = 31;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(101)))), ((int)(((byte)(50)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-15, 702);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(744, 47);
            this.label7.TabIndex = 32;
            this.label7.Text = "Payment Method";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxSplitBill
            // 
            this.cBoxSplitBill.AutoSize = true;
            this.cBoxSplitBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxSplitBill.Location = new System.Drawing.Point(15, 151);
            this.cBoxSplitBill.Name = "cBoxSplitBill";
            this.cBoxSplitBill.Size = new System.Drawing.Size(259, 43);
            this.cBoxSplitBill.TabIndex = 33;
            this.cBoxSplitBill.Text = "Add Bill Splitting";
            this.cBoxSplitBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cBoxSplitBill.UseVisualStyleBackColor = true;
            this.cBoxSplitBill.CheckedChanged += new System.EventHandler(this.cBoxSplitBill_CheckedChanged);
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.White;
            this.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl5.ForeColor = System.Drawing.Color.Black;
            this.lbl5.Location = new System.Drawing.Point(12, 217);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(521, 66);
            this.lbl5.TabIndex = 31;
            this.lbl5.Text = "Tip";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTip
            // 
            this.lblTip.BackColor = System.Drawing.Color.White;
            this.lblTip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTip.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTip.ForeColor = System.Drawing.Color.Black;
            this.lblTip.Location = new System.Drawing.Point(520, 217);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(193, 66);
            this.lblTip.TabIndex = 37;
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(520, 282);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(193, 67);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6
            // 
            this.lbl6.BackColor = System.Drawing.Color.White;
            this.lbl6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl6.ForeColor = System.Drawing.Color.Black;
            this.lbl6.Location = new System.Drawing.Point(12, 283);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(521, 66);
            this.lbl6.TabIndex = 32;
            this.lbl6.Text = "Total to be paid";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(154)))), ((int)(((byte)(40)))));
            this.label8.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 818);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 57);
            this.label8.TabIndex = 39;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(154)))), ((int)(((byte)(40)))));
            this.label9.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(481, 818);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 57);
            this.label9.TabIndex = 40;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(154)))), ((int)(((byte)(40)))));
            this.label10.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(243, 818);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 57);
            this.label10.TabIndex = 41;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSplitBill
            // 
            this.lblSplitBill.AutoSize = true;
            this.lblSplitBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSplitBill.ForeColor = System.Drawing.Color.Black;
            this.lblSplitBill.Location = new System.Drawing.Point(316, 384);
            this.lblSplitBill.Name = "lblSplitBill";
            this.lblSplitBill.Size = new System.Drawing.Size(210, 39);
            this.lblSplitBill.TabIndex = 43;
            this.lblSplitBill.Text = "Still to be Paid:";
            // 
            // lblSplit
            // 
            this.lblSplit.BackColor = System.Drawing.Color.White;
            this.lblSplit.Location = new System.Drawing.Point(532, 384);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(181, 37);
            this.lblSplit.TabIndex = 44;
            this.lblSplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(718, 1062);
            this.Controls.Add(this.lblSplit);
            this.Controls.Add(this.lblSplitBill);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.cBoxSplitBill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radBtnPIN);
            this.Controls.Add(this.radBtnCash);
            this.Controls.Add(this.radBtnCreditCard);
            this.Controls.Add(this.btnSubmitTotal);
            this.Controls.Add(this.btnSubmitTip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tip";
            this.Text = "Tip";
            this.Load += new System.EventHandler(this.Tip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmitTip;
        private System.Windows.Forms.Button btnSubmitTotal;
        private System.Windows.Forms.RadioButton radBtnCreditCard;
        private System.Windows.Forms.RadioButton radBtnCash;
        private System.Windows.Forms.RadioButton radBtnPIN;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cBoxSplitBill;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSplitBill;
        private System.Windows.Forms.Label lblSplit;
    }
}