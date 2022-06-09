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
        PaymentService paymentService;
        BillService billService;
        Model.Bill bill;
        Model.Payment payment;
        List<OrderItem> orderItems;
        private int TableNr;



        public Payment(int tableNr)
        {
            InitializeComponent();

            //ListOrderedItems();
            this.TableNr = tableNr;

            btnAddComment.Click += new EventHandler(btnAddComment_Click);
            btnCash.Click += new EventHandler(btnCash_Click);
            btnCreditCard.Click += new EventHandler(btnCreditCard_Click);
            btnPIN.Click += new EventHandler(btnPIN_Click);
        }


       
        private void btnAddComment_Click(object sender, System.EventArgs e)
        {
            LoadNewForm(new AddFeedback(TableNr));
        }

        private void btnCash_Click(object sender, System.EventArgs e)
        {
            payment.Type = 0;
            LoadNewForm(new PaymentConfirmation());       
        }

        private void btnCreditCard_Click(object sender, System.EventArgs e)
        {
            payment.Type = 1;
            LoadNewForm(new PaymentConfirmation());
        }

        private void btnPIN_Click(object sender, System.EventArgs e)
        {
            payment.Type = 3;
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

        private void Payment_Load(object sender, EventArgs e)
        {
            this.bill = billService.GetBill(TableNr);
            lblTableNum.Text = $"Table Number {bill.TableNr.ToString()}";
            //FillListViewItemsOnBill();

        }
        private void ListViewItemsOnBill(List<MenuItem> menuItems)
        {

            menuItems = new List<MenuItem>();

            foreach (MenuItem item in menuItems)
            {

                ListViewItem li = new ListViewItem(item.Name.ToString());
                //li.SubItems.Add(item.Quantity.ToString());
                li.SubItems.Add(item.Price.ToString());
                li.SubItems.Add(item.VAT.ToString());
                listViewBill.Items.Add(li);
            }
        }
    }
          
}

