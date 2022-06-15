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
using System.Data.SqlClient;


namespace UI
{
    public partial class AddFeedback : Form
    {
        private Model.Bill bill;
        private PaymentService paymentService;
        private Payment payment;
        private BillService billService;
        private int TableNr;
        OrderService orderService;
        Order order;
     


        public AddFeedback()
        {
            InitializeComponent();

            //this.TableNr = tableNr;
            //this.bill = billService.GetBill(TableNr);

            btnSubmit.Click += new EventHandler(btnSubmit_Click);
        }
        private void btnSubmit_Click(object sender, System.EventArgs e)
        {

            SubmitFeedback();

            LoadNewForm(new Payment(1));
            
        }
  
        private void SubmitFeedback()
        {
            orderService = new OrderService();
            orderService.AddFeedback(1, txtBoxComment.Text);
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
    }   }
