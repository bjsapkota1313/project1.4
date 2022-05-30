﻿namespace UI
{
    partial class StarterForm
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
            this.StarterAddBtn = new System.Windows.Forms.Button();
            this.StarterList = new System.Windows.Forms.ListView();
            this.StarterListName = new System.Windows.Forms.ColumnHeader("(none)");
            this.StarterListPrice = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starter";
            this.label1.Click += new System.EventHandler(this.StarterForm_Click);
            // 
            // StarterAddBtn
            // 
            this.StarterAddBtn.Location = new System.Drawing.Point(12, 395);
            this.StarterAddBtn.Name = "StarterAddBtn";
            this.StarterAddBtn.Size = new System.Drawing.Size(494, 43);
            this.StarterAddBtn.TabIndex = 2;
            this.StarterAddBtn.Text = "Add";
            this.StarterAddBtn.UseVisualStyleBackColor = true;
            // 
            // StarterList
            // 
            this.StarterList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StarterListName,
            this.StarterListPrice});
            this.StarterList.HideSelection = false;
            this.StarterList.Location = new System.Drawing.Point(12, 103);
            this.StarterList.Name = "StarterList";
            this.StarterList.Size = new System.Drawing.Size(494, 268);
            this.StarterList.TabIndex = 3;
            this.StarterList.UseCompatibleStateImageBehavior = false;
            this.StarterList.View = System.Windows.Forms.View.Details;
            this.StarterList.SelectedIndexChanged += new System.EventHandler(this.StarterList_SelectedIndexChanged);
            // 
            // StarterListName
            // 
            this.StarterListName.Text = "Name";
            this.StarterListName.Width = 395;
            // 
            // StarterListPrice
            // 
            this.StarterListPrice.Text = "Price";
            this.StarterListPrice.Width = 95;
            // 
            // StarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.StarterList);
            this.Controls.Add(this.StarterAddBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StarterForm";
            this.Text = "Starter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StarterAddBtn;
        private System.Windows.Forms.ListView StarterList;
        private System.Windows.Forms.ColumnHeader StarterListName;
        private System.Windows.Forms.ColumnHeader StarterListPrice;
    }
}