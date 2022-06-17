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
        private PaymentService paymentService;
        private Model.Bill bill;
        private BillService billService;
        private int TableNr;
        private int BillID;
        private Model.Payment payment;
        private int Type;
        OrderService orderService;
        Order order;
        private MenuItem menuItem;
        private decimal tip;


        public Tip(int tableNr, int billID)
        {
            InitializeComponent();

            //menuItem = orderService.getallor
            //this.TableNr = tableNr;
            //this.BillID = billID;


            //this.bill = billService.GetBill(TableNr);
            // this.payment = paymentService.GetPayment(BillID);

            //btnPay.Click += new EventHandler(btnPay_Click);
            btnSubmitTip.Click += new EventHandler(btnSubmitTip_Click);

        }

        private void btnSubmitTip_Click(object sender, EventArgs e)
        {
            if (txtTip != null)
            {
                lblTip.Text = txtTip.Text;
            }
            else
                btnSubmitTip.Enabled = false;

            //paymentService.AddTip(bill.BillID, Convert.ToDecimal(txtTip.Text));

        }
        private void btnSubmitTotal_Click(object sender, EventArgs e)
        {
            if (txtTotal != null)
            {
                lblTotal.Text = txtTotal.Text;
            }
            else
                btnSubmitTotal.Enabled = false;

            //paymentService.AddTotal(bill.BillID, Convert.ToDecimal(txtTotal.Text));

        }
        //private void btnPay_Click(object sender, System.EventArgs e)
        //{
        //    if (Convert.ToDecimal(txtTotal.Text) >= payment.Total)
        //    {
        //        SubmitPayment();
        //        Paid();
        //        LoadNewForm(new PaymentConfirmation());
        //    }
        //    else if(Convert.ToDecimal(txtTotal.Text) < payment.Total)
        //    {
        //        //LoadNewForm(new Payment(TableNr));
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error");
        //    }          
        //}
        //private void Paid()
        //{

        //    //order = orderService.GetOrderForSpecificTableWhichisNotPaidYet(1, PayementStatus.Paid);
        //    paymentService.ChangePaymentStatus(BillID, true);

        //}
        //private void SubmitPayment()
        //{
        //    paymentService.AddPayment(BillID, Convert.ToDecimal(txtTotal.Text), Convert.ToDecimal(txtTip.Text), Type);
        //}

        private void Tip_Load(object sender, EventArgs e)
        {

            lblVatLow.Text = $"€{LowVAT().ToString("0.00")}";
            lblVatHigh.Text = $"€{HighVAT().ToString("0.00")}";
            lblVatTotal.Text = $"€{TotalVAT().ToString("0.00")}";
            lblPrice.Text = $"€{OrderPrice().ToString("0.00")}";
            //lblTotal.Text = $"€{OrderPrice + }";

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
        public decimal HighVAT()
        {

            OrderService orderService = new OrderService();
            List<OrderItem> orderItems = orderService.GetBill(1);

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

            OrderService orderService = new OrderService();
            List<OrderItem> orderItems = orderService.GetBill(1);

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


            OrderService orderService = new OrderService();
            List<OrderItem> orderItems = orderService.GetBill(1);

            decimal totalVat = 0;
            foreach (OrderItem item in orderItems)
            {
                totalVat += item.MenuItem.Price * item.MenuItem.VAT * item.Quantity;
            }
            return totalVat;

        }
        public decimal OrderPrice()
        {

            OrderService orderService = new OrderService();
            List<OrderItem> orderItems = orderService.GetBill(1);

            decimal orderPrice = 0;
            foreach (OrderItem item in orderItems)
            {
                orderPrice += item.MenuItem.Price * item.Quantity;
            }
            return orderPrice;

        }
        private void txtTip_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbersInput(sender, e);
        }
        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbersInput(sender, e);

        }
        private void OnlyNumbersInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
    }
}
