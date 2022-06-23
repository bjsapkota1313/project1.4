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
        OrderService orderService;
        private Order order;


        public AddFeedback(Order order)
        {
            InitializeComponent();

            this.order = order;

            btnSubmit.Click += new EventHandler(btnSubmit_Click);
        }
        private void btnSubmit_Click(object sender, System.EventArgs e)
        {

            SubmitFeedback();

            
        }
  
        private void SubmitFeedback()
        {
            orderService = new OrderService();
            orderService.AddFeedback(order.OrderId, txtBoxComment.Text);

            txtBoxComment.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   }
