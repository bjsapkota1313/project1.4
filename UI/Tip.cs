using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using ServiceLayer;

namespace UI
{
    public partial class Tip : Form
    {

        private BillService billService;

        public Tip()
        {
            InitializeComponent();

            btnPay.Click += new EventHandler(btnPay_Click);

            txtTip.TextChanged += new EventHandler(tipTextChanged);
           
        }

        private void tipTextChanged(object sender, System.EventArgs e)
        {
            double total = 3; //billService.SearchByID(id).Amount;
            txtTotal.Text = (total + Convert.ToDouble(txtTip.Text)).ToString();
        }

        private void btnPay_Click(object sender, System.EventArgs e)
        {
            //billService.AddTip(id, Convert.ToDouble(txtTip.Text));

            var frm = new PaymentConfirmation();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
