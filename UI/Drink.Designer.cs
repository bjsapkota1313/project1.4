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
            this.DrinkListView = new System.Windows.Forms.ListView();
            this.ItemId = new System.Windows.Forms.ColumnHeader();
            this.MainCourseListName = new System.Windows.Forms.ColumnHeader();
            this.MainCourseListPrice = new System.Windows.Forms.ColumnHeader();
            this.CommentDrink = new System.Windows.Forms.TextBox();
            this.AddDrinksBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrinkListView
            // 
            this.DrinkListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemId,
            this.MainCourseListName,
            this.MainCourseListPrice});
            this.DrinkListView.FullRowSelect = true;
            this.DrinkListView.HideSelection = false;
            this.DrinkListView.Location = new System.Drawing.Point(12, 13);
            this.DrinkListView.Name = "DrinkListView";
            this.DrinkListView.Size = new System.Drawing.Size(494, 268);
            this.DrinkListView.TabIndex = 3;
            this.DrinkListView.UseCompatibleStateImageBehavior = false;
            this.DrinkListView.View = System.Windows.Forms.View.Details;
            // 
            // ItemId
            // 
            this.ItemId.Text = "Id";
            this.ItemId.Width = 30;
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
            // CommentDrink
            // 
            this.CommentDrink.ForeColor = System.Drawing.Color.Silver;
            this.CommentDrink.Location = new System.Drawing.Point(12, 287);
            this.CommentDrink.Multiline = true;
            this.CommentDrink.Name = "CommentDrink";
            this.CommentDrink.Size = new System.Drawing.Size(495, 66);
            this.CommentDrink.TabIndex = 5;
            this.CommentDrink.Text = "Comment...";
            // 
            // AddDrinksBtn
            // 
            this.AddDrinksBtn.Location = new System.Drawing.Point(12, 359);
            this.AddDrinksBtn.Name = "AddDrinksBtn";
            this.AddDrinksBtn.Size = new System.Drawing.Size(495, 40);
            this.AddDrinksBtn.TabIndex = 6;
            this.AddDrinksBtn.Text = "Add";
            this.AddDrinksBtn.UseVisualStyleBackColor = true;
            this.AddDrinksBtn.Click += new System.EventHandler(this.AddDrinksBtn_Click);
            // 
            // Drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.AddDrinksBtn);
            this.Controls.Add(this.CommentDrink);
            this.Controls.Add(this.DrinkListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Drink";
            this.Text = "Drink";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DrinkListView;
        private System.Windows.Forms.ColumnHeader MainCourseListName;
        private System.Windows.Forms.ColumnHeader MainCourseListPrice;
        private System.Windows.Forms.TextBox CommentDrink;
        private System.Windows.Forms.ColumnHeader ItemId;
        private System.Windows.Forms.Button AddDrinksBtn;
    }
}