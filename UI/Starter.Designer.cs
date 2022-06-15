namespace UI
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
            this.LvStarterList = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.StarterListName = new System.Windows.Forms.ColumnHeader("(none)");
            this.StarterListPrice = new System.Windows.Forms.ColumnHeader();
            this.CommentStarters = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.StarterForm_Click);
            // 
            // StarterAddBtn
            // 
            this.StarterAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.StarterAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StarterAddBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.StarterAddBtn.Location = new System.Drawing.Point(11, 357);
            this.StarterAddBtn.Name = "StarterAddBtn";
            this.StarterAddBtn.Size = new System.Drawing.Size(494, 43);
            this.StarterAddBtn.TabIndex = 2;
            this.StarterAddBtn.Text = "Add";
            this.StarterAddBtn.UseVisualStyleBackColor = false;
            this.StarterAddBtn.Click += new System.EventHandler(this.StarterAddBtn_Click);
            // 
            // LvStarterList
            // 
            this.LvStarterList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.StarterListName,
            this.StarterListPrice});
            this.LvStarterList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvStarterList.FullRowSelect = true;
            this.LvStarterList.HideSelection = false;
            this.LvStarterList.Location = new System.Drawing.Point(12, 12);
            this.LvStarterList.Name = "LvStarterList";
            this.LvStarterList.Size = new System.Drawing.Size(494, 268);
            this.LvStarterList.TabIndex = 3;
            this.LvStarterList.UseCompatibleStateImageBehavior = false;
            this.LvStarterList.View = System.Windows.Forms.View.Details;
            this.LvStarterList.SelectedIndexChanged += new System.EventHandler(this.StarterList_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 30;
            // 
            // StarterListName
            // 
            this.StarterListName.Text = "Name";
            this.StarterListName.Width = 395;
            // 
            // StarterListPrice
            // 
            this.StarterListPrice.Text = "Price";
            // 
            // CommentStarters
            // 
            this.CommentStarters.ForeColor = System.Drawing.Color.Silver;
            this.CommentStarters.Location = new System.Drawing.Point(12, 286);
            this.CommentStarters.Multiline = true;
            this.CommentStarters.Name = "CommentStarters";
            this.CommentStarters.Size = new System.Drawing.Size(493, 65);
            this.CommentStarters.TabIndex = 4;
            this.CommentStarters.Text = "Comment...";
            // 
            // StarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(530, 474);
            this.Controls.Add(this.CommentStarters);
            this.Controls.Add(this.LvStarterList);
            this.Controls.Add(this.StarterAddBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StarterForm";
            this.Text = "Starter";
            this.Load += new System.EventHandler(this.StarterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StarterAddBtn;
        private System.Windows.Forms.ListView LvStarterList;
        private System.Windows.Forms.ColumnHeader StarterListName;
        private System.Windows.Forms.ColumnHeader StarterListPrice;
        private System.Windows.Forms.TextBox CommentStarters;
        private System.Windows.Forms.ColumnHeader ItemId;
        private System.Windows.Forms.ColumnHeader Id;
    }
}