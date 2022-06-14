namespace UI
{
    partial class Dessert
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
            this.label1 = new System.Windows.Forms.Label();
            this.DessertListView = new System.Windows.Forms.ListView();
            this.MainCourseListName = new System.Windows.Forms.ColumnHeader();
            this.MainCourseListPrice = new System.Windows.Forms.ColumnHeader();
            this.DessertAddBtn = new System.Windows.Forms.Button();
            this.CommentDessert = new System.Windows.Forms.TextBox();
            this.ItemId = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DessertListView
            // 
            this.DessertListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemId,
            this.MainCourseListName,
            this.MainCourseListPrice});
            this.DessertListView.FullRowSelect = true;
            this.DessertListView.HideSelection = false;
            this.DessertListView.Location = new System.Drawing.Point(12, 12);
            this.DessertListView.Name = "DessertListView";
            this.DessertListView.Size = new System.Drawing.Size(494, 268);
            this.DessertListView.TabIndex = 2;
            this.DessertListView.UseCompatibleStateImageBehavior = false;
            this.DessertListView.View = System.Windows.Forms.View.Details;
            // 
            // MainCourseListName
            // 
            this.MainCourseListName.Text = "Name";
            this.MainCourseListName.Width = 395;
            // 
            // MainCourseListPrice
            // 
            this.MainCourseListPrice.Text = "Price";
            // 
            // DessertAddBtn
            // 
            this.DessertAddBtn.Location = new System.Drawing.Point(12, 357);
            this.DessertAddBtn.Name = "DessertAddBtn";
            this.DessertAddBtn.Size = new System.Drawing.Size(494, 43);
            this.DessertAddBtn.TabIndex = 3;
            this.DessertAddBtn.Text = "Add";
            this.DessertAddBtn.UseVisualStyleBackColor = true;
            this.DessertAddBtn.Click += new System.EventHandler(this.DessertAddBtn_Click);
            // 
            // CommentDessert
            // 
            this.CommentDessert.ForeColor = System.Drawing.Color.DarkGray;
            this.CommentDessert.Location = new System.Drawing.Point(12, 286);
            this.CommentDessert.Multiline = true;
            this.CommentDessert.Name = "CommentDessert";
            this.CommentDessert.Size = new System.Drawing.Size(494, 65);
            this.CommentDessert.TabIndex = 4;
            this.CommentDessert.Text = "Comment...";
            // 
            // ItemId
            // 
            this.ItemId.Text = "Id";
            this.ItemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemId.Width = 30;
            // 
            // Dessert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.CommentDessert);
            this.Controls.Add(this.DessertAddBtn);
            this.Controls.Add(this.DessertListView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dessert";
            this.Text = "Dessert";
            this.Load += new System.EventHandler(this.Dessert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView DessertListView;
        private System.Windows.Forms.ColumnHeader MainCourseListName;
        private System.Windows.Forms.ColumnHeader MainCourseListPrice;
        private System.Windows.Forms.Button DessertAddBtn;
        private System.Windows.Forms.TextBox CommentDessert;
        private System.Windows.Forms.ColumnHeader ItemId;
    }
}