using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer;
using Model;

namespace UI
{   
    public partial class Payment : Form
    {
        private int id;
        private string description;
        public Payment(int id)
        {
            InitializeComponent();
            this.id = id;

            btnAddComment.Click += new EventHandler(btnAddComment_Click);
            btnCash.Click += new EventHandler(btnCash_Click);
            btnCreditCard.Click += new EventHandler(btnCreditCard_Click);
            btnPIN.Click += new EventHandler(btnPIN_Click);
        }

        private void btnAddComment_Click(object sender, System.EventArgs e)
        {
            var frm = new Feedback(description);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void btnCash_Click(object sender, System.EventArgs e)
        {
            var frm = new PaymentConfirmation();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void btnCreditCard_Click(object sender, System.EventArgs e)
        {
            var frm = new Tip(id);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void btnPIN_Click(object sender, System.EventArgs e)
        {
            var frm = new Tip(id);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

    }
}
