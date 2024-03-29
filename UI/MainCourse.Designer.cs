﻿namespace UI
{
    partial class MainCourse
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
            this.MainCourseList = new System.Windows.Forms.ListView();
            this.ItemId = new System.Windows.Forms.ColumnHeader();
            this.MainCourseListName = new System.Windows.Forms.ColumnHeader();
            this.MainCourseListPrice = new System.Windows.Forms.ColumnHeader();
            this.MainCourseAdd = new System.Windows.Forms.Button();
            this.CommentMainCourse = new System.Windows.Forms.TextBox();
            this.AllStarterMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 0;
            // 
            // MainCourseList
            // 
            this.MainCourseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemId,
            this.MainCourseListName,
            this.MainCourseListPrice});
            this.MainCourseList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainCourseList.FullRowSelect = true;
            this.MainCourseList.HideSelection = false;
            this.MainCourseList.Location = new System.Drawing.Point(12, 12);
            this.MainCourseList.Name = "MainCourseList";
            this.MainCourseList.Size = new System.Drawing.Size(494, 268);
            this.MainCourseList.TabIndex = 1;
            this.MainCourseList.UseCompatibleStateImageBehavior = false;
            this.MainCourseList.View = System.Windows.Forms.View.Details;
            this.MainCourseList.SelectedIndexChanged += new System.EventHandler(this.MainCourseList_SelectedIndexChanged);
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
            // MainCourseAdd
            // 
            this.MainCourseAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.MainCourseAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainCourseAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MainCourseAdd.Location = new System.Drawing.Point(11, 357);
            this.MainCourseAdd.Name = "MainCourseAdd";
            this.MainCourseAdd.Size = new System.Drawing.Size(494, 43);
            this.MainCourseAdd.TabIndex = 2;
            this.MainCourseAdd.Text = "Add";
            this.MainCourseAdd.UseVisualStyleBackColor = false;
            this.MainCourseAdd.Click += new System.EventHandler(this.MainCourseAdd_Click);
            // 
            // CommentMainCourse
            // 
            this.CommentMainCourse.ForeColor = System.Drawing.Color.DarkGray;
            this.CommentMainCourse.Location = new System.Drawing.Point(13, 286);
            this.CommentMainCourse.Multiline = true;
            this.CommentMainCourse.Name = "CommentMainCourse";
            this.CommentMainCourse.Size = new System.Drawing.Size(493, 65);
            this.CommentMainCourse.TabIndex = 3;
            this.CommentMainCourse.Text = "Comment...";
            // 
            // AllStarterMenu
            // 
            this.AllStarterMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.AllStarterMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllStarterMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AllStarterMenu.Location = new System.Drawing.Point(135, 407);
            this.AllStarterMenu.Name = "AllStarterMenu";
            this.AllStarterMenu.Size = new System.Drawing.Size(247, 31);
            this.AllStarterMenu.TabIndex = 16;
            this.AllStarterMenu.Text = "Show Luch and Dinner menu";
            this.AllStarterMenu.UseVisualStyleBackColor = false;
            // 
            // MainCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.AllStarterMenu);
            this.Controls.Add(this.CommentMainCourse);
            this.Controls.Add(this.MainCourseAdd);
            this.Controls.Add(this.MainCourseList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainCourse";
            this.Text = "MainCourse";
            this.Load += new System.EventHandler(this.MainCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView MainCourseList;
        private System.Windows.Forms.ColumnHeader MainCourseListName;
        private System.Windows.Forms.ColumnHeader MainCourseListPrice;
        private System.Windows.Forms.Button MainCourseAdd;
        private System.Windows.Forms.TextBox CommentMainCourse;
        private System.Windows.Forms.ColumnHeader ItemId;
        private System.Windows.Forms.Button AllStarterMenu;
    }
}