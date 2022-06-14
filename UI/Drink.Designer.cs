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
            this.DrinkAddBtn = new System.Windows.Forms.Button();
            this.CommentDrink = new System.Windows.Forms.TextBox();
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
            this.DrinkListView.Location = new System.Drawing.Point(4, 13);
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
            // DrinkAddBtn
            // 
            this.DrinkAddBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DrinkAddBtn.Location = new System.Drawing.Point(4, 359);
            this.DrinkAddBtn.Name = "DrinkAddBtn";
            this.DrinkAddBtn.Size = new System.Drawing.Size(494, 40);
            this.DrinkAddBtn.TabIndex = 6;
            this.DrinkAddBtn.Text = "Add";
            this.DrinkAddBtn.UseVisualStyleBackColor = false;
            this.DrinkAddBtn.Click += new System.EventHandler(this.DrinkAddBtn_Click_1);
            // 
            // CommentDrink
            // 
            this.CommentDrink.Location = new System.Drawing.Point(4, 287);
            this.CommentDrink.Multiline = true;
            this.CommentDrink.Name = "CommentDrink";
            this.CommentDrink.Size = new System.Drawing.Size(495, 66);
            this.CommentDrink.TabIndex = 5;
            this.CommentDrink.Text = "Comment...";
            // 
            // Drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(503, 411);
            this.Controls.Add(this.CommentDrink);
            this.Controls.Add(this.DrinkAddBtn);
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
        private System.Windows.Forms.Button DrinkAddBtn;
        private System.Windows.Forms.TextBox CommentDrink;
        private System.Windows.Forms.ColumnHeader ItemId;
    }
}