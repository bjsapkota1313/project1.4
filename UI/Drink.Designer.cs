namespace UI
{
    partial class Drink
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
            this.DessertList = new System.Windows.Forms.ListView();
            this.MainCourseListName = new System.Windows.Forms.ColumnHeader();
            this.MainCourseListPrice = new System.Windows.Forms.ColumnHeader();
            this.DessertAddBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DessertList
            // 
            this.DessertList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MainCourseListName,
            this.MainCourseListPrice});
            this.DessertList.HideSelection = false;
            this.DessertList.Location = new System.Drawing.Point(4, 13);
            this.DessertList.Name = "DessertList";
            this.DessertList.Size = new System.Drawing.Size(494, 268);
            this.DessertList.TabIndex = 3;
            this.DessertList.UseCompatibleStateImageBehavior = false;
            this.DessertList.View = System.Windows.Forms.View.Details;
            // 
            // MainCourseListName
            // 
            this.MainCourseListName.Text = "Name";
            this.MainCourseListName.Width = 395;
            // 
            // MainCourseListPrice
            // 
            this.MainCourseListPrice.Text = "Price";
            this.MainCourseListPrice.Width = 95;
            // 
            // DessertAddBtn
            // 
            this.DessertAddBtn.Location = new System.Drawing.Point(3, 359);
            this.DessertAddBtn.Name = "DessertAddBtn";
            this.DessertAddBtn.Size = new System.Drawing.Size(494, 43);
            this.DessertAddBtn.TabIndex = 4;
            this.DessertAddBtn.Text = "Add";
            this.DessertAddBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 287);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(495, 66);
            this.textBox1.TabIndex = 5;
            // 
            // Drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(503, 411);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DessertAddBtn);
            this.Controls.Add(this.DessertList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Drink";
            this.Text = "Drink";
            this.Load += new System.EventHandler(this.Drink_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DessertList;
        private System.Windows.Forms.ColumnHeader MainCourseListName;
        private System.Windows.Forms.ColumnHeader MainCourseListPrice;
        private System.Windows.Forms.Button DessertAddBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}