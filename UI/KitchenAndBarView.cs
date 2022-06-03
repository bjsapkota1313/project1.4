using Model;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class KitchenAndBarView : Form
    {
        private Employee loggedEmployee;
        private TypeMenuItem typeMenuItem;

        private void KitchenAndBarView_Load(object sender, EventArgs e)
        {
           
        }
        public KitchenAndBarView(Employee employee)
        {
            loggedEmployee = employee;         
            checkEmployee();
            InitializeComponent();
        }
        private void FillInKitchenAndBarView()
        {
            lstViewKitchenAndBar.Items.Clear();
            lstViewKitchenAndBar.View = View.Details;
            OrderService orderService = new OrderService();
            List<Order> orders = orderService.ReadOrdersForKitchenBar(TypeMenuItem.Food, OrderState.RunningOrder);

            foreach (Order order in orders)
            {
                foreach (OrderItem item in order.OrderItems)
                {
                    ListViewItem li = new ListViewItem(item.OrderItemId.ToString()); //first column
                    li.SubItems.Add(item.MenuItem.Name);
                    li.SubItems.Add(item.Quantity.ToString());
                    li.SubItems.Add(item.Feedback.ToString());
                    li.SubItems.Add(item.DateTime.ToString("HH:mm"));
                    li.SubItems.Add(order.Table.ToString());
                    li.SubItems.Add(item.OrderState.ToString());    
                    //li.SubItems.Add(order.OrderItemsToString());
                    li.Tag = item;
                    lstViewKitchenAndBar.Items.Add(li);
                }
                
            }         
        }
        public void checkEmployee()
        {
            switch (loggedEmployee.EmployeeType)
            {
                case EmployeeType.Chef:
                    typeMenuItem = TypeMenuItem.Food;
                    break;
                case EmployeeType.BarTender:
                    typeMenuItem = TypeMenuItem.Drink;
                    break;
                default:
                    break;
            }
        }

        private void btnKitchenShowCmpltOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillInKitchenAndBarView();
        }

        private void btnKitchenReady_Click(object sender, EventArgs e)
        {

        }
    }
}
