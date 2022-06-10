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
    public partial class OrderDisplay : Form
    {
        public OrderDisplay()
        {
            InitializeComponent();
        }

        private void OrderDisplay_Load(object sender, EventArgs e)
        {

        }
        public void ShowOrder(Table table)
        {
            OrderService orderService = new OrderService(); ;
            List<OrderItem> orders = orderService.GetOrderTableNotPayed(table);

            DBOrderListView.Items.Clear();

            foreach (OrderItem o in orders)
            {
                ListViewItem li = new ListViewItem(o.MenuItem.ToString());
                li.SubItems.Add(o.Feedback.ToString());
                li.SubItems.Add(o.DateTime.ToString());
                li.SubItems.Add(o.OrderState.ToString());
                li.Tag = o;
                DBOrderListView.Items.Add(li);
            }

        }
    }
}
