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


        public Tip(int tableNr, int billID)
        {
            InitializeComponent();

            //menuItem = orderService.getallor
            //this.TableNr = tableNr;
            //this.BillID = billID;


            //this.bill = billService.GetBill(TableNr);
            // this.payment = paymentService.GetPayment(BillID);

            //btnPay.Click += new EventHandler(btnPay_Click);

        }

        //private void btnSubmitTip_Click()
        //{

        //    paymentService.AddTip(bill.BillID, Convert.ToDecimal(txtTip.Text));

        //}
        //private void btnSubmitTotal_Click()
        //{

        //    paymentService.AddTotal(bill.BillID, Convert.ToDecimal(txtTotal.Text));

        //}
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


            //OrderService orderService = new OrderService();
            //List<OrderItem> bill = orderService.GetBill(1);

            menuItem = new MenuItem();

            lblVatLow.Text = $"€{menuItem.LowVAT.ToString("0.00")}";
            lblVatHigh.Text = $"€{menuItem.HighVAT.ToString("0.00")}";
            lblVatTotal.Text = $"€{menuItem.TotalVAT.ToString("0.00")}";
            lblPrice.Text = $"€{menuItem.OrderPrice.ToString("0.00")}";

            lblTip.Text = $"€";
            lblTotal.Text = $"€";
            



            //    tip = Convert.ToDecimal(txtTip.Text);
            //    total = tip + Convert.ToDecimal(txtTotal.Text);

            //    //oreach ()
            //    {

            //        ListViewItem li = new ListViewItem(vatLow.ToString());
            //        li.SubItems.Add(vatHigh.ToString());
            //        li.SubItems.Add(vatTotal.ToString());
            //        li.SubItems.Add(total.ToString());
            //        li.SubItems.Add(tip.ToString());
            //        li.SubItems.Add(totalToPay.ToString());
            //        //listViewTotal.Items.Add(li);
            //    }
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
