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
    public partial class PaymentConfirmation : Form
    {

        private OrderService orderService;
        private TableService tableService;
        private Order order;
        private Employee loggedEmployee;

        public PaymentConfirmation(Order order, Employee loggedEmployee)
        {
            InitializeComponent();

            orderService = new OrderService();
            tableService = new TableService();


            this.loggedEmployee = loggedEmployee;
            this.order = order;

        }      
        private void Paid()
        {

            orderService.ChangeOrderPaymentStatus(order.OrderId);

        }
        private void FreeTable()
        {

            tableService.ChangeTableToFree(order.Table.Number);
        }

        private void PaymentConfirmation_Load_1(object sender, EventArgs e)
        {
            lblConfirmation.Text = $"Order Nr. {order.OrderId.ToString()} was successfully paid";

            Paid();
            FreeTable();
        }

        private void btnBackTableView_Click(object sender, EventArgs e)
        {
            
            LoadNewForm(new TableView(loggedEmployee))
;        }
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
