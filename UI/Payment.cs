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
        private OrderService orderService; 
        List<Order> orders;
        Order order;
        private Employee loggedEmployee;

        public Payment(Table table, Employee loggedEmployee)
        {
            InitializeComponent();

            this.loggedEmployee = loggedEmployee;
            this.table = table;
            orderService = new OrderService();

            orders = new List<Order>();

            orders = orderService.GetOrderByTableNumber(table.Number);


            btnAddComment.Click += new EventHandler(btnAddComment_Click);
            btnPay.Click += new EventHandler(btnPay_Click);
        }

        private void Payment_Load(object sender, EventArgs e)
        {

            // Display a lable with the table number 
            lblTableNum.Text = $"Table Number {table.Number.ToString()}";

            // Display the bill in a listView
            ListViewItemsOnBill();

            PaymentDetails();

        }
        private void ListViewItemsOnBill()
        {

            try
            {

                orderService = new OrderService();
                List<OrderItem> bill = new List<OrderItem>();


                orders = orderService.GetOrderByTableNumber(table.Number);
                foreach (Order item in orders)
                {
                    bill = orderService.GetBill(item.OrderId);
                    order = item;
                }


                // clear the listview ITEMS before filling it again !!Using list.Clear() will remove the column headers too.
                listViewBill.Items.Clear();

                

                foreach (OrderItem item in bill)
                {

                    ListViewItem li = new ListViewItem(item.MenuItem.Name.ToString());
                    li.SubItems.Add(item.Quantity.ToString());
                    li.SubItems.Add($"€{item.MenuItem.Price.ToString("0.00")}");
                    li.SubItems.Add($"{item.MenuItem.VAT.ToString("#0.##%")}");
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

            LoadNewForm(new AddFeedback(order));
        }

        private void btnPay_Click(object sender, System.EventArgs e)
        {

            LoadNewForm(new Tip(order, loggedEmployee));
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
        private void PaymentDetails()
        {
            lblVatLow.Text = $"€{LowVAT().ToString("0.00")}";
            lblVatHigh.Text = $"€{HighVAT().ToString("0.00")}";
            lblVatTotal.Text = $"€{TotalVAT().ToString("0.00")}";
            lblPrice.Text = $"€{OrderPrice().ToString("0.00")}";
        }
        public decimal HighVAT()
        {

            List<OrderItem> orderItems = orderService.GetBill(order.OrderId);

            decimal highlVat = 0;
            foreach (OrderItem item in orderItems)
            {
                if (item.MenuItem.VAT == (decimal)0.21)
                {
                    highlVat += (item.MenuItem.Price * (decimal)0.21) * item.Quantity;
                }
            }
            return highlVat;

        }
        public decimal LowVAT()
        {
            List<OrderItem> orderItems = orderService.GetBill(order.OrderId);

            decimal lowVat = 0;
            foreach (OrderItem item in orderItems)
            {
                if (item.MenuItem.VAT == (decimal)0.06)
                {
                    lowVat += (item.MenuItem.Price * (decimal)0.06) * item.Quantity;
                }
            }
            return lowVat;

        }
        public decimal TotalVAT()
        {

            List<OrderItem> orderItems = orderService.GetBill(order.OrderId);

            decimal totalVat = 0;
            foreach (OrderItem item in orderItems)
            {
                totalVat += item.MenuItem.Price * item.MenuItem.VAT * item.Quantity;
            }
            return totalVat;

        }
        public decimal OrderPrice()
        {

            List<OrderItem> orderItems = orderService.GetBill(order.OrderId);

            decimal orderPrice = 0;
            foreach (OrderItem item in orderItems)
            {
                orderPrice += item.MenuItem.Price * item.Quantity;
            }
            return orderPrice;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
          


