using System;

namespace UI
{
    partial class OrderForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBackToTableView = new System.Windows.Forms.Button();
            this.FoodBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubmitOrder = new System.Windows.Forms.Button();
            this.OrderLIstView = new System.Windows.Forms.ListView();
            this.Comment = new System.Windows.Forms.ColumnHeader();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.RemoveOrderBtn = new System.Windows.Forms.Button();
            this.DrinkBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ShowLunchAndDinner = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CommentMainCourse = new System.Windows.Forms.TextBox();
            this.FoodList = new System.Windows.Forms.ListView();
            this.ItemId = new System.Windows.Forms.ColumnHeader();
            this.MainCourseListName = new System.Windows.Forms.ColumnHeader();
            this.MainCourseListPrice = new System.Windows.Forms.ColumnHeader();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.BtnBackToTableView);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 68);
            this.panel2.TabIndex = 2;
            // 
            // BtnBackToTableView
            // 
            this.BtnBackToTableView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.BtnBackToTableView.FlatAppearance.BorderSize = 0;
            this.BtnBackToTableView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBackToTableView.Font = new System.Drawing.Font("Calibri", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBackToTableView.ForeColor = System.Drawing.Color.Black;
            this.BtnBackToTableView.Image = global::UI.Properties.Resources.ArrowFatLeftNew;
            this.BtnBackToTableView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBackToTableView.Location = new System.Drawing.Point(18, 12);
            this.BtnBackToTableView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBackToTableView.Name = "BtnBackToTableView";
            this.BtnBackToTableView.Size = new System.Drawing.Size(112, 38);
            this.BtnBackToTableView.TabIndex = 4;
            this.BtnBackToTableView.Text = "Back";
            this.BtnBackToTableView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBackToTableView.UseVisualStyleBackColor = false;
            this.BtnBackToTableView.Click += new System.EventHandler(this.BtnBackToTableView_Click);
            // 
            // FoodBtn
            // 
            this.FoodBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(117)))), ((int)(((byte)(79)))));
            this.FoodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FoodBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FoodBtn.Location = new System.Drawing.Point(18, 6);
            this.FoodBtn.Name = "FoodBtn";
            this.FoodBtn.Size = new System.Drawing.Size(329, 51);
            this.FoodBtn.TabIndex = 4;
            this.FoodBtn.Text = "Food";
            this.FoodBtn.UseVisualStyleBackColor = false;
            this.FoodBtn.Click += new System.EventHandler(this.FoodBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.SubmitOrder);
            this.panel1.Controls.Add(this.OrderLIstView);
            this.panel1.Controls.Add(this.RemoveOrderBtn);
            this.panel1.Location = new System.Drawing.Point(443, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 927);
            this.panel1.TabIndex = 7;
            // 
            // SubmitOrder
            // 
            this.SubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(154)))), ((int)(((byte)(40)))));
            this.SubmitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SubmitOrder.Location = new System.Drawing.Point(3, 379);
            this.SubmitOrder.Name = "SubmitOrder";
            this.SubmitOrder.Size = new System.Drawing.Size(270, 39);
            this.SubmitOrder.TabIndex = 12;
            this.SubmitOrder.Text = "Submit";
            this.SubmitOrder.UseVisualStyleBackColor = false;
            this.SubmitOrder.Click += new System.EventHandler(this.SubmitOrder_Click);
            // 
            // OrderLIstView
            // 
            this.OrderLIstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Comment,
            this.Name});
            this.OrderLIstView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderLIstView.FullRowSelect = true;
            this.OrderLIstView.HideSelection = false;
            this.OrderLIstView.Location = new System.Drawing.Point(3, 8);
            this.OrderLIstView.Name = "OrderLIstView";
            this.OrderLIstView.Size = new System.Drawing.Size(270, 320);
            this.OrderLIstView.TabIndex = 11;
            this.OrderLIstView.UseCompatibleStateImageBehavior = false;
            this.OrderLIstView.View = System.Windows.Forms.View.Details;
            this.OrderLIstView.SelectedIndexChanged += new System.EventHandler(this.OrderLIstView_SelectedIndexChanged);
            // 
            // Comment
            // 
            this.Comment.DisplayIndex = 1;
            this.Comment.Text = "Comment";
            this.Comment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Comment.Width = 100;
            // 
            // Name
            // 
            this.Name.DisplayIndex = 0;
            this.Name.Text = "Name";
            this.Name.Width = 165;
            // 
            // RemoveOrderBtn
            // 
            this.RemoveOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.RemoveOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveOrderBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.RemoveOrderBtn.Location = new System.Drawing.Point(3, 334);
            this.RemoveOrderBtn.Name = "RemoveOrderBtn";
            this.RemoveOrderBtn.Size = new System.Drawing.Size(270, 39);
            this.RemoveOrderBtn.TabIndex = 8;
            this.RemoveOrderBtn.Text = "Remove";
            this.RemoveOrderBtn.UseVisualStyleBackColor = false;
            this.RemoveOrderBtn.Click += new System.EventHandler(this.RemoveOrderBtn_Click);
            // 
            // DrinkBtn
            // 
            this.DrinkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(117)))), ((int)(((byte)(79)))));
            this.DrinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DrinkBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DrinkBtn.Location = new System.Drawing.Point(387, 6);
            this.DrinkBtn.Name = "DrinkBtn";
            this.DrinkBtn.Size = new System.Drawing.Size(329, 51);
            this.DrinkBtn.TabIndex = 10;
            this.DrinkBtn.Text = "Drink";
            this.DrinkBtn.UseVisualStyleBackColor = false;
            this.DrinkBtn.Click += new System.EventHandler(this.DrinkBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.FoodBtn);
            this.panel3.Controls.Add(this.DrinkBtn);
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 68);
            this.panel3.TabIndex = 3;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.ShowLunchAndDinner);
            this.MenuPanel.Controls.Add(this.AddBtn);
            this.MenuPanel.Controls.Add(this.CommentMainCourse);
            this.MenuPanel.Controls.Add(this.FoodList);
            this.MenuPanel.Location = new System.Drawing.Point(6, 142);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(434, 573);
            this.MenuPanel.TabIndex = 1;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // ShowLunchAndDinner
            // 
            this.ShowLunchAndDinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.ShowLunchAndDinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLunchAndDinner.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ShowLunchAndDinner.Location = new System.Drawing.Point(87, 473);
            this.ShowLunchAndDinner.Name = "ShowLunchAndDinner";
            this.ShowLunchAndDinner.Size = new System.Drawing.Size(247, 31);
            this.ShowLunchAndDinner.TabIndex = 17;
            this.ShowLunchAndDinner.Text = "Show Luch and Dinner menu";
            this.ShowLunchAndDinner.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(6, 411);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(416, 43);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_CLick);
            // 
            // CommentMainCourse
            // 
            this.CommentMainCourse.ForeColor = System.Drawing.Color.DarkGray;
            this.CommentMainCourse.Location = new System.Drawing.Point(6, 340);
            this.CommentMainCourse.Multiline = true;
            this.CommentMainCourse.Name = "CommentMainCourse";
            this.CommentMainCourse.Size = new System.Drawing.Size(416, 65);
            this.CommentMainCourse.TabIndex = 4;
            this.CommentMainCourse.Text = "Comment...";
            // 
            // FoodList
            // 
            this.FoodList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemId,
            this.MainCourseListName,
            this.MainCourseListPrice});
            this.FoodList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FoodList.FullRowSelect = true;
            this.FoodList.HideSelection = false;
            this.FoodList.Location = new System.Drawing.Point(6, 3);
            this.FoodList.Name = "FoodList";
            this.FoodList.Size = new System.Drawing.Size(416, 331);
            this.FoodList.TabIndex = 2;
            this.FoodList.UseCompatibleStateImageBehavior = false;
            this.FoodList.View = System.Windows.Forms.View.Details;
            this.FoodList.SelectedIndexChanged += new System.EventHandler(this.MainCourseList_SelectedIndexChanged);
            // 
            // ItemId
            // 
            this.ItemId.Text = "Id";
            this.ItemId.Width = 30;
            // 
            // MainCourseListName
            // 
            this.MainCourseListName.Text = "Name";
            this.MainCourseListName.Width = 300;
            // 
            // MainCourseListPrice
            // 
            this.MainCourseListPrice.Text = "Price";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(728, 954);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuPanel);
            this.MaximumSize = new System.Drawing.Size(744, 1131);
            this.Name = "OrderForm";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.OrderView_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FoodBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveOrderBtn;
        private System.Windows.Forms.Button DrinkBtn;
        private System.Windows.Forms.ListView OrderLIstView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.Button SubmitOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnBackToTableView;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button ShowLunchAndDinner;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox CommentMainCourse;
        private System.Windows.Forms.ListView FoodList;
        private System.Windows.Forms.ColumnHeader ItemId;
        private System.Windows.Forms.ColumnHeader MainCourseListName;
        private System.Windows.Forms.ColumnHeader MainCourseListPrice;
    }
}