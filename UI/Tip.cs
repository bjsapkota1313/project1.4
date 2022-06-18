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

        //private Model.Payment payment;
        PaymentService paymentService;
        PaymentTypeService paymentTypeService;
        private decimal tip;
        private decimal total;


        public Tip(int tableNr, int billID)
        {
            InitializeComponent();

            //menuItem = orderService.getallor
            //this.TableNr = tableNr;
            //this.BillID = billID;


            //this.bill = billService.GetBill(TableNr);
            // this.payment = paymentService.GetPayment(BillID);

            btnPay.Click += new EventHandler(btnPay_Click);
            btnSubmitTip.Click += new EventHandler(btnSubmitTip_Click);
            btnSubmitTotal.Click += new EventHandler(btnSubmitTotal_Click);

            txtTip.KeyPress += new KeyPressEventHandler(txtTip_KeyPress);
            txtTotal.KeyPress += new KeyPressEventHandler(txtTotal_KeyPress);

        }

        private void btnSubmitTip_Click(object sender, EventArgs e)
        {
            AddTip();

            
        }
        private void btnSubmitTotal_Click(object sender, EventArgs e)
        {
            AddTotal();
                        
            
        }
        private void btnPay_Click(object sender, System.EventArgs e)
        {
            if (total >= OrderPrice())
            {
                SubmitPayment();

                LoadNewForm(new PaymentConfirmation());
            }
            else if(total < OrderPrice())
            {
                total = OrderPrice() - total;
            }
            else
            {
                MessageBox.Show("Error");
            }          
        }
       
        private void SubmitPayment()
        {
            paymentService = new PaymentService();

            paymentService.AddPayment(1, total, tip, PaymentMethod());
        }
        public int PaymentMethod()
        {
            paymentService = new PaymentService();

            int value = 0;

            if (radBtnCash.Checked)
            {

                paymentService.GetPaymentMethod(value);
            }
            else if (radBtnCreditCard.Checked)
            {
                value = 1;
                paymentService.GetPaymentMethod(value);
            }
            else if (radBtnPIN.Checked)
            {
                value = 2;
                paymentService.GetPaymentMethod(value);
            }
            else
                MessageBox.Show("Please choose payment method");

            return value;
        }

        private void Tip_Load(object sender, EventArgs e)
        {
            FillBillOverview();

        }
        private void FillBillOverview()
        {
            tip = 0;
            total = OrderPrice();

            lblVatLow.Text = $"€{LowVAT().ToString("0.00")}";
            lblVatHigh.Text = $"€{HighVAT().ToString("0.00")}";
            lblVatTotal.Text = $"€{TotalVAT().ToString("0.00")}";
            lblPrice.Text = $"€{OrderPrice().ToString("0.00")}";
            lblTip.Text = $"€{tip.ToString("0.00")}";
            lblTotal.Text = $"€{total.ToString("0.00")}";
        }
        private void AddTip()
        {

            tip = Convert.ToDecimal(txtTip.Text);

            lblTip.Text = $"€{tip.ToString("0.00")}";

            total = tip + OrderPrice();

            lblTotal.Text = $"€{total.ToString("0.00")}";

        }
        private void AddTotal()
        {
            total = Convert.ToDecimal(txtTotal.Text);

            lblTotal.Text = $"€{total.ToString("0.00")}";

            tip = total - OrderPrice();

            lblTip.Text = $"€{tip.ToString("0.00")}";

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

            if(txtTip.Text != null && (char.IsDigit(e.KeyChar)))
            {
                btnSubmitTip.Enabled = true;
            }
        }
        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbersInput(sender, e);

            if ((txtTotal.Text != null ) && (char.IsDigit(e.KeyChar)))
            {
                btnSubmitTotal.Enabled = true;
            }

        }

        //ADD COMMENTS
        private void OnlyNumbersInput(object sender, KeyPressEventArgs e)
        {
            string senderText = (sender as TextBox).Text;
            string senderName = (sender as TextBox).Name;
            string[] splitByDecimal = senderText.Split('.');
            int cursorPosition = (sender as TextBox).SelectionStart;

            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.'
                && senderText.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


            if (!char.IsControl(e.KeyChar)
                && senderText.IndexOf('.') < cursorPosition
                && splitByDecimal.Length > 1
                && splitByDecimal[1].Length == 2)
            {
                e.Handled = true;
            }

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
