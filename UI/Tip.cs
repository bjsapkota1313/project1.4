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

        public Tip(int tableNr, int billID)
        {
            InitializeComponent();

            this.TableNr = tableNr;
            this.BillID = billID;

            this.bill = billService.GetBill(TableNr);
            this.payment = paymentService.GetPayment(BillID);

            btnPay.Click += new EventHandler(btnPay_Click);
           
        }

        private void AddTip()
        {

            paymentService.AddTip(bill.BillID, Convert.ToDecimal(txtTip.Text));

        }
        private void AddTotal()
        {

            paymentService.AddTotal(bill.BillID, Convert.ToDecimal(txtTotal.Text));

        }
        private void btnPay_Click(object sender, System.EventArgs e)
        {
            if (Convert.ToDecimal(txtTotal.Text) >= payment.Total)
            {
                SubmitPayment();
                Paid();
                LoadNewForm(new PaymentConfirmation());
            }
            else if(Convert.ToDecimal(txtTotal.Text) < payment.Total)
            {
                LoadNewForm(new Payment(TableNr));
            }
            else
            {
                MessageBox.Show("Error");
            }          
        }
        private void Paid()
        {
            
            order = orderService.GetOrderForSpecificTableWhichisNotPaidYet(1, PayementStatus.Paid);
            paymentService.ChangePaymentStatus(BillID, true);

        }
        private void SubmitPayment()
        {
            paymentService.AddPayment(BillID, Convert.ToDecimal(txtTotal.Text), Convert.ToDecimal(txtTip.Text), Type);
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
