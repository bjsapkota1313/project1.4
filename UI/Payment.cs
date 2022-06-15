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
        //OrderService orderService;
        Order orderSeectedTable;
        PaymentType paymentType;
        PaymentTypeService paymentTypeService;
        Order order;
        private int PaymentMethod;



        public Payment(int tableNr)
        {
            InitializeComponent();

            this.TableNr = tableNr;

            btnAddComment.Click += new EventHandler(btnAddComment_Click);
            btnCash.Click += new EventHandler(btnCash_Click);
            btnCreditCard.Click += new EventHandler(btnCreditCard_Click);
            btnPIN.Click += new EventHandler(btnPIN_Click);
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            //this.bill = billService.GetBill(TableNr);

            // Display a lable with the table number 
            lblTableNum.Text = $"Table Number {TableNr.ToString()}";

            // Display the bill in a listView
            ListViewItemsOnBill();

        }
        private void ListViewItemsOnBill()
        {

            try
            {
                OrderService orderService = new OrderService();
                List<OrderItem> bill = orderService.GetBill(1);


                // clear the listview ITEMS before filling it again !!Using list.Clear() will remove the column headers too.
                listViewBill.Items.Clear();

                

                foreach (OrderItem item in bill)
                {

                    ListViewItem li = new ListViewItem(item.MenuItem.Name.ToString());
                    li.SubItems.Add(item.Quantity.ToString());
                    li.SubItems.Add(item.MenuItem.Price.ToString());
                    li.SubItems.Add(item.MenuItem.VAT.ToString());
                    listViewBill.Items.Add(li);
                }

            }
            catch (Exception ex)
            {
                // Write error to log and get file path
                string filePath = ErrorLogger.LogError(ex);

                // Display message box when an error occured with the appropiate error
                MessageBox.Show("Something went wrong while loading the bill: " + ex.Message + Environment.NewLine
                    + Environment.NewLine + "Error log location: " + filePath);
            }
        }
        private void btnAddComment_Click(object sender, System.EventArgs e)
        {
             LoadNewForm(new AddFeedback());
        }

        private void btnCash_Click(object sender, System.EventArgs e)
        {
            //payment.Type = 0;

            //paymentService.AddPaymentMethod(1, payment.Type);


            LoadNewForm(new PaymentConfirmation());
        }

        private void btnCreditCard_Click(object sender, System.EventArgs e)
        {
            //paymentService = new PaymentService();

            //paymentService.AddPaymentMethod(1, 1);
            //paymentTypeService.GetType(1);
            LoadNewForm(new PaymentConfirmation());
        }

        private void btnPIN_Click(object sender, System.EventArgs e)
        {
            //payment.Type = 2;

            //paymentService.AddPaymentMethod(1, payment.Type);
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
    }
    }
          


