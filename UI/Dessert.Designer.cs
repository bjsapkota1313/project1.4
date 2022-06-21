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
            this.ItemId = new System.Windows.Forms.ColumnHeader();
            this.MainCourseListName = new System.Windows.Forms.ColumnHeader();
            this.MainCourseListPrice = new System.Windows.Forms.ColumnHeader();
            this.DessertAddBtn = new System.Windows.Forms.Button();
            this.CommentDessert = new System.Windows.Forms.TextBox();
            this.AllStarterMenu = new System.Windows.Forms.Button();
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
            this.DessertListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DessertListView.FullRowSelect = true;
            this.DessertListView.HideSelection = false;
            this.DessertListView.Location = new System.Drawing.Point(12, 12);
            this.DessertListView.Name = "DessertListView";
            this.DessertListView.Size = new System.Drawing.Size(494, 268);
            this.DessertListView.TabIndex = 2;
            this.DessertListView.UseCompatibleStateImageBehavior = false;
            this.DessertListView.View = System.Windows.Forms.View.Details;
            // 
            // ItemId
            // 
            this.ItemId.Text = "Id";
            this.ItemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // DessertAddBtn
            // 
            this.DessertAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.DessertAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DessertAddBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DessertAddBtn.Location = new System.Drawing.Point(12, 357);
            this.DessertAddBtn.Name = "DessertAddBtn";
            this.DessertAddBtn.Size = new System.Drawing.Size(494, 43);
            this.DessertAddBtn.TabIndex = 3;
            this.DessertAddBtn.Text = "Add";
            this.DessertAddBtn.UseVisualStyleBackColor = false;
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
            // AllStarterMenu
            // 
            this.AllStarterMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.AllStarterMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllStarterMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AllStarterMenu.Location = new System.Drawing.Point(140, 407);
            this.AllStarterMenu.Name = "AllStarterMenu";
            this.AllStarterMenu.Size = new System.Drawing.Size(247, 31);
            this.AllStarterMenu.TabIndex = 17;
            this.AllStarterMenu.Text = "Show Luch and Dinner menu";
            this.AllStarterMenu.UseVisualStyleBackColor = false;
            // 
            // Dessert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.AllStarterMenu);
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
        private System.Windows.Forms.Button AllStarterMenu;
    }
}