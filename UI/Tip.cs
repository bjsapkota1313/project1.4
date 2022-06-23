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

        PaymentService paymentService;
        private Order order;
        private OrderService orderService;
        private Employee loggedEmployee;
        private decimal tip;
        private decimal total;
        private decimal splitBill;

        public Tip(Order order, Employee loggedEmployee)
        {
            InitializeComponent();

            paymentService = new PaymentService();
            orderService = new OrderService();

            this.order = order;
            this.loggedEmployee = loggedEmployee;



            btnPay.Click += new EventHandler(btnPay_Click);
            btnSubmitTip.Click += new EventHandler(btnSubmitTip_Click);
            btnSubmitTotal.Click += new EventHandler(btnSubmitTotal_Click);

            txtTip.KeyPress += new KeyPressEventHandler(txtTip_KeyPress);
            txtTotal.KeyPress += new KeyPressEventHandler(txtTotal_KeyPress);
        }
      
        private void btnSubmitTip_Click(object sender, EventArgs e)
        {
            AddTip();

            if(lblTip.Text != "")
            {
                txtTip.Text = "";   
                            
            }
       

        }
        private void btnSubmitTotal_Click(object sender, EventArgs e)
        {
            AddTotal();

            if(lblTotal.Text != "")
            {
                txtTotal.Text = "";
              
            }
                                   
        }
        private void btnPay_Click(object sender, System.EventArgs e)
        {
            if (total >= OrderPrice())
            {
                SubmitPayment();

                LoadNewForm(new PaymentConfirmation(order, loggedEmployee));
            }
            else if(cBoxSplitBill.Checked == true)
            {


                SubmitPayment();

                
                
                splitBill = OrderPrice() - total;

               
                

                lblTotal.Text = $"€{splitBill.ToString("0.00")}";

                if (splitBill == 0)
                {
                    LoadNewForm(new PaymentConfirmation(order, loggedEmployee));
                }

            }
            else 
            {
                MessageBox.Show("Please choose the right amount to be paid", "Payment amount not sufficient.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
       
        private void SubmitPayment()
        {
            if (PaymentMethod() == 5)
            {
                MessageBox.Show("Please choose payment method");
            }

            paymentService.AddPayment(order.OrderId, total, tip, PaymentMethod());
        }
        public int PaymentMethod()
        {

            if (radBtnCash.Checked)
            {
                return 0;
            }
            else if (radBtnCreditCard.Checked)
            {
                return 1;
            }
            else if (radBtnPIN.Checked)
            {
                return 2;
            }

            return 5;
        }

        private void Tip_Load(object sender, EventArgs e)
        {
            FillBillOverview();

            cBoxSplitBill_CheckedChanged(sender, e);

        }
        private void FillBillOverview()
        {
            tip = 0;
            total = OrderPrice();

            
            lblTip.Text = $"€{tip.ToString("0.00")}";
            lblTotal.Text = $"€{total.ToString("0.00")}";
        }
        private void AddTip()
        {
            if (txtTip.Text != "")
            {

                tip = Convert.ToDecimal(txtTip.Text);

                lblTip.Text = $"€{tip.ToString("0.00")}";

                total = tip + OrderPrice();

                lblTotal.Text = $"€{total.ToString("0.00")}";          

            }

        }
        private void AddTotal()
        {
            if(txtTotal.Text != "")
            {

                total = Convert.ToDecimal(txtTotal.Text);
                lblTotal.Text = $"€{total.ToString("0.00")}";               
                tip = total - OrderPrice();                    
                lblTip.Text = $"€{tip.ToString("0.00")}";

                if (cBoxSplitBill.Checked == true)
                {
                    tip = 0;
                    lblTip.Text = $"€{tip.ToString("0.00")}";

                    //total = OrderPrice() - total;
                    //lblSplit.Text = $"€{total.ToString("0.00")}";


                }
                else
                {
                    MessageBox.Show("Please choose the right amount to be paid", "Payment amount not sufficient.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
      
        public decimal OrderPrice()
        {

            List<OrderItem> orderItems = orderService.GetBill(order.OrderId);

            decimal orderPrice = 0;
            foreach (OrderItem item in orderItems)
            {
                orderPrice += item.MenuItem.Price * item.Quantity;

                //if(cBoxSplitBill.Checked == true)
                //{
                //    orderPrice = orderPrice - total;
                //}

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBoxSplitBill_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxSplitBill.Checked == true)
            {
                lblSplitBill.Visible = true;
                lblSplit.Visible = true;
            }
            else
            {
                lblSplitBill.Visible = false;
                lblSplit.Visible = false;
            }
        }
    }
}
