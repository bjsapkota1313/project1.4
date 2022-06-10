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
        OrderService orderService;
        Order orderSeectedTable;
        PaymentType paymentType;
        PaymentTypeService paymentTypeService;



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


                // For each Order object in the list, create a new List Item and fill details before adding it
                //foreach (Order o in orderItems)
                //{
                //    ListViewItem li = new ListViewItem(o.OrderItems.ToString());
                //    li.SubItems.Add(o.TotalPrice.ToString());
                //    listViewBill.Items.Add(li);
                //}
            
            //catch (Exception ex)
            //{
            //    // Write error to log and get file path
            //    string filePath = ErrorLogger.LogError(ex);

            //    // Display message box when an error occured with the appropiate error
            //    MessageBox.Show("Something went wrong while loading the Bill: " + ex.Message + Environment.NewLine
            //        + Environment.NewLine + "Error log location: " + filePath);
            //}

        
       
        private void btnAddComment_Click(object sender, System.EventArgs e)
        {
           // LoadNewForm(new AddFeedback());
        }

        private void btnCash_Click(object sender, System.EventArgs e)
        {
            paymentTypeService.Type(0);
            LoadNewForm(new PaymentConfirmation());       
        }

        private void btnCreditCard_Click(object sender, System.EventArgs e)
        {
            paymentTypeService.Type(1);
            LoadNewForm(new PaymentConfirmation());
        }

        private void btnPIN_Click(object sender, System.EventArgs e)
        {
            paymentTypeService.Type(2);
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
            ListViewItemsOnBill();

        }
        private void ListViewItemsOnBill()
        {

            orderService = new OrderService();

            orderSeectedTable = orderService.GetOrderForSpecificTableWhichisNotPaidYet(1, PayementStatus.UnPaid);


            foreach (OrderItem item in orderSeectedTable.OrderItems)
            {

                ListViewItem li = new ListViewItem(item.MenuItem.Name.ToString());
                li.SubItems.Add(item.Quantity.ToString());
                li.SubItems.Add(item.MenuItem.Price.ToString());
                li.SubItems.Add(item.MenuItem.VAT.ToString("0.00"));
                listViewBill.Items.Add(li);
            }
        }
    }
          
}

