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
        private Table table;
        private OrderService orderService = new OrderService();
        private int OrderID;
        private int tablenr;
        private Order order;
       
        public Payment(int tablenr)//Table table)
        {
            InitializeComponent();

            this.tablenr = tablenr;
            //orderService = new OrderService();

            order = orderService.GetOrderByTableNumber(tablenr);

            //orderService.GetOrderByTableNumber(table.Number);

            btnAddComment.Click += new EventHandler(btnAddComment_Click);
            btnPay.Click += new EventHandler(btnPay_Click);
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            //this.bill = billService.GetBill(TableNr);

            // Display a lable with the table number 
            lblTableNum.Text = $"Table Number {tablenr.ToString()}";

            // Display the bill in a listView
            ListViewItemsOnBill();

        }
        private void ListViewItemsOnBill()
        {

            try
            {
                //orderService = new OrderService();

                order = orderService.GetOrderByTableNumber(tablenr);






                List<OrderItem> bill = orderService.GetBill(order.OrderId);


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
            //orderService = new OrderService();

            //order = orderService.GetOrderByTableNumber(tablenr);
            LoadNewForm(new AddFeedback(order));
        }

        private void btnPay_Click(object sender, System.EventArgs e)
        {
            //orderService = new OrderService();

            //order = orderService.GetOrderByTableNumber(tablenr);

            LoadNewForm(new Tip(order));
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
          


