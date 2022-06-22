namespace UI
{
    partial class PaymentConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentConfirmation));
            this.btnBackTableView = new System.Windows.Forms.Button();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackTableView
            // 
            this.btnBackTableView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(117)))), ((int)(((byte)(79)))));
            this.btnBackTableView.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackTableView.ForeColor = System.Drawing.Color.Black;
            this.btnBackTableView.Location = new System.Drawing.Point(140, 669);
            this.btnBackTableView.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnBackTableView.Name = "btnBackTableView";
            this.btnBackTableView.Size = new System.Drawing.Size(436, 52);
            this.btnBackTableView.TabIndex = 14;
            this.btnBackTableView.Text = "Back to Table View";
            this.btnBackTableView.UseVisualStyleBackColor = false;
            this.btnBackTableView.Click += new System.EventHandler(this.btnBackTableView_Click);
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.BackColor = System.Drawing.Color.White;
            this.lblConfirmation.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmation.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmation.Location = new System.Drawing.Point(70, 266);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(583, 353);
            this.lblConfirmation.TabIndex = 15;
            this.lblConfirmation.Text = "Order nr. XXXX was successfully paid";
            this.lblConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 514);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 90);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // PaymentConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(718, 1062);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.btnBackTableView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentConfirmation";
            this.Text = "PaymentConfirmation";
            this.Load += new System.EventHandler(this.PaymentConfirmation_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackTableView;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}