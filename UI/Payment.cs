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
        OrderService orderService;
        List<Order> orderItems;
        Bill bill;
        double total;
        double tip;
        double vat;

        public Payment()
        {
            InitializeComponent();

            //ListOrderedItems();

            AddTip();

            btnAddComment.Click += new EventHandler(btnAddComment_Click);
            btnCash.Click += new EventHandler(btnCash_Click);
            btnCreditCard.Click += new EventHandler(btnCreditCard_Click);
            btnPIN.Click += new EventHandler(btnPIN_Click);
        }
        private void ListOrderedItems()
        {
            try
            {
                // fill the bill listview with a list of ordered items
                orderService = new OrderService();
                //orderItems = orderService.GetAll...;

                // clear the listview items before filling it again
                listViewBill.Items.Clear();

                // For each Order object in the list, create a new List Item and fill details before adding it
                foreach (Order o in orderItems)
                {
                    ListViewItem li = new ListViewItem(o.OrderItems.ToString());
                    li.SubItems.Add(o.TotalPrice.ToString());
                    listViewBill.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                // Write error to log and get file path
                string filePath = ErrorLogger.LogError(ex);

                // Display message box when an error occured with the appropiate error
                MessageBox.Show("Something went wrong while loading the Bill: " + ex.Message + Environment.NewLine
                    + Environment.NewLine + "Error log location: " + filePath);
            }

        }
        private void AddTip()
        {
            //total = 10;
            //txtTotal.Text = (total + Convert.ToDouble(txtTip.Text)).ToString();

        }
        private void btnAddComment_Click(object sender, System.EventArgs e)
        {
            LoadNewForm(new AddFeedback());
        }

        private void btnCash_Click(object sender, System.EventArgs e)
        {
            LoadNewForm(new PaymentConfirmation());       
        }

        private void btnCreditCard_Click(object sender, System.EventArgs e)
        {
            LoadNewForm(new PaymentConfirmation());
        }

        private void btnPIN_Click(object sender, System.EventArgs e)
        {
            LoadNewForm(new PaymentConfirmation());
        }
        private void LoadNewForm(object Form)
        {
            Form frm = Form as Form;
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
        //private void txtTip_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        //}
        //private void txtVAT_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        //}
        //private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        //}

    }
}
