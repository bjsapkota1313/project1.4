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
            this.MainCourseListName = new System.Windows.Forms.ColumnHeader();
            this.MainCourseListPrice = new System.Windows.Forms.ColumnHeader();
            this.DrinkAddBtn = new System.Windows.Forms.Button();
            this.CommentDrink = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DrinkListView
            // 
            this.DrinkListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MainCourseListName,
            this.MainCourseListPrice});
            this.DrinkListView.FullRowSelect = true;
            this.DrinkListView.HideSelection = false;
            this.DrinkListView.Location = new System.Drawing.Point(5, 17);
            this.DrinkListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DrinkListView.Name = "DrinkListView";
            this.DrinkListView.Size = new System.Drawing.Size(564, 356);
            this.DrinkListView.TabIndex = 3;
            this.DrinkListView.UseCompatibleStateImageBehavior = false;
            this.DrinkListView.View = System.Windows.Forms.View.Details;
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
            // DrinkAddBtn
            // 
            this.DrinkAddBtn.Location = new System.Drawing.Point(5, -11);
            this.DrinkAddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DrinkAddBtn.Name = "DrinkAddBtn";
            this.DrinkAddBtn.Size = new System.Drawing.Size(86, 31);
            this.DrinkAddBtn.TabIndex = 6;
            // 
            // CommentDrink
            // 
            this.CommentDrink.Location = new System.Drawing.Point(5, 383);
            this.CommentDrink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CommentDrink.Multiline = true;
            this.CommentDrink.Name = "CommentDrink";
            this.CommentDrink.Size = new System.Drawing.Size(565, 87);
            this.CommentDrink.TabIndex = 5;
            this.CommentDrink.Text = "Comment...";
            // 
            // Drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(575, 548);
            this.Controls.Add(this.CommentDrink);
            this.Controls.Add(this.DrinkAddBtn);
            this.Controls.Add(this.DrinkListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Drink";
            this.Text = "Drink";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DrinkListView;
        private System.Windows.Forms.ColumnHeader MainCourseListName;
        private System.Windows.Forms.ColumnHeader MainCourseListPrice;
        private System.Windows.Forms.Button DrinkAddBtn;
        private System.Windows.Forms.TextBox CommentDrink;
    }
}