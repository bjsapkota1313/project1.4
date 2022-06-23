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
            this.InStock = new System.Windows.Forms.ColumnHeader();
            this.MainCourseListName = new System.Windows.Forms.ColumnHeader();
            this.MainCourseListPrice = new System.Windows.Forms.ColumnHeader();
            this.CommentDrink = new System.Windows.Forms.TextBox();
            this.AddDrinksBtn = new System.Windows.Forms.Button();
            this.AllStarterMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DrinkListView
            // 
            this.DrinkListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InStock,
            this.MainCourseListName,
            this.MainCourseListPrice});
            this.DrinkListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DrinkListView.FullRowSelect = true;
            this.DrinkListView.HideSelection = false;
            this.DrinkListView.Location = new System.Drawing.Point(12, 58);
            this.DrinkListView.Name = "DrinkListView";
            this.DrinkListView.Size = new System.Drawing.Size(416, 615);
            this.DrinkListView.TabIndex = 3;
            this.DrinkListView.UseCompatibleStateImageBehavior = false;
            this.DrinkListView.View = System.Windows.Forms.View.Details;
            // 
            // InStock
            // 
            this.InStock.Text = "In Stock";
            this.InStock.Width = 70;
            // 
            // MainCourseListName
            // 
            this.MainCourseListName.Text = "Name";
            this.MainCourseListName.Width = 285;
            // 
            // MainCourseListPrice
            // 
            this.MainCourseListPrice.Text = "Price";
            this.MainCourseListPrice.Width = 55;
            // 
            // CommentDrink
            // 
            this.CommentDrink.ForeColor = System.Drawing.Color.Silver;
            this.CommentDrink.Location = new System.Drawing.Point(12, 679);
            this.CommentDrink.Multiline = true;
            this.CommentDrink.Name = "CommentDrink";
            this.CommentDrink.Size = new System.Drawing.Size(417, 66);
            this.CommentDrink.TabIndex = 5;
            this.CommentDrink.Text = "Comment...";
            this.CommentDrink.Enter += new System.EventHandler(this.CommentDrink_Enter);
            this.CommentDrink.Leave += new System.EventHandler(this.CommentDrink_Leave);
            // 
            // AddDrinksBtn
            // 
            this.AddDrinksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.AddDrinksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDrinksBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AddDrinksBtn.Location = new System.Drawing.Point(12, 751);
            this.AddDrinksBtn.Name = "AddDrinksBtn";
            this.AddDrinksBtn.Size = new System.Drawing.Size(417, 45);
            this.AddDrinksBtn.TabIndex = 6;
            this.AddDrinksBtn.Text = "Add";
            this.AddDrinksBtn.UseVisualStyleBackColor = false;
            this.AddDrinksBtn.Click += new System.EventHandler(this.AddDrinksBtn_Click);
            // 
            // AllStarterMenu
            // 
            this.AllStarterMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(207)))), ((int)(((byte)(175)))));
            this.AllStarterMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllStarterMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AllStarterMenu.Location = new System.Drawing.Point(12, 815);
            this.AllStarterMenu.Name = "AllStarterMenu";
            this.AllStarterMenu.Size = new System.Drawing.Size(247, 31);
            this.AllStarterMenu.TabIndex = 17;
            this.AllStarterMenu.Text = "Show Luch and Dinner menu";
            this.AllStarterMenu.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(162, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 46);
            this.label2.TabIndex = 18;
            this.label2.Text = "Drinks";
            // 
            // Drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(440, 927);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AllStarterMenu);
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
        private System.Windows.Forms.ColumnHeader InStock;
        private System.Windows.Forms.Button AddDrinksBtn;
        private System.Windows.Forms.Button AllStarterMenu;
        private System.Windows.Forms.Label label2;
    }
}