using Model;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class KitchenAndBarView : Form
    {
        private Employee loggedEmployee;
        private TypeMenuItem typeMenuItem;
        private OrderService orderService;
        private OrderItem orderItem = null;
        public KitchenAndBarView(Employee employee)
        {
            InitializeComponent();
            orderService = new OrderService();
            loggedEmployee = employee;
            checkEmployee();
            btnRunningOrder.Visible = false;
        }

        // Display Orders In Listview
        private void FillInKitchenAndBarView(List<Order> orders)
        {
            lstViewKitchenAndBar.Items.Clear();
            lstViewKitchenAndBar.View = View.Details;
            foreach (Order order in orders)
            {
                foreach (OrderItem item in order.OrderItems)
                {
                    ListViewItem li = new ListViewItem(item.MenuItem.Name);
                    li.SubItems.Add(item.Quantity.ToString());
                    li.SubItems.Add(item.Feedback.ToString());
                    li.SubItems.Add(item.DateTime.ToString("HH:mm"));
                    li.SubItems.Add(order.Table.Number.ToString());

                    if (item.OrderState == OrderState.ReadyToDeliver)
                    {
                        li.SubItems.Add("Ready");
                    }
                    else if (item.OrderState == OrderState.PreparingOrder)
                    {
                        li.SubItems.Add("Preparing");
                    }
                    li.Tag = item;
                    lstViewKitchenAndBar.Items.Add(li);
                }
            }
        }

        // Check if the employee is chef then show KitchenView and if the employee is Bartender then show BarView
        private  void checkEmployee()
        {
            List<Order> orders;
            switch (loggedEmployee.EmployeeType)
            {
                case EmployeeType.Chef:
                    typeMenuItem = TypeMenuItem.Food;
                    orders = orderService.ReadOrdersForKitchenBar(typeMenuItem, OrderState.PreparingOrder);
                    FillInKitchenAndBarView(orders);
                    lblKitchenAndBarView.Text = "Kitchen View";
                    break;
                case EmployeeType.BarTender:
                    typeMenuItem = TypeMenuItem.Drink;    
                    orders = orderService.ReadOrdersForKitchenBar(typeMenuItem, OrderState.PreparingOrder);
                    FillInKitchenAndBarView(orders);
                    lblKitchenAndBarView.Text = "Bar View";
                    break;
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            checkEmployee();
        }

        //Ready Button For kitchenandBar
        private void btnKitchenReady_Click(object sender, EventArgs e)
        {
            // enabling multiple selection true 
            foreach(ListViewItem lvI in lstViewKitchenAndBar.SelectedItems)
            {
                orderItem = (OrderItem)lvI.Tag;
                orderItem.OrderState = OrderState.ReadyToDeliver;
                orderService.UpdateStatusOfSpecficOrderItem(orderItem); 
            } 
            checkEmployee();    
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnRunningOrder_Click(object sender, EventArgs e)
        {
            List<Order> orders;
            orders = orderService.ReadOrdersForKitchenBar(typeMenuItem, OrderState.PreparingOrder);
            FillInKitchenAndBarView(orders);
            btnRunningOrder.Visible = false;
            btnCompletedOrder.Visible = true;
        }

        private void btnCompletedOrder_Click_1(object sender, EventArgs e)
        {
            btnRunningOrder.Visible = true;
            btnCompletedOrder.Visible = false;

            List<Order> orders;
            orders = orderService.ReadOrdersForKitchenBar(typeMenuItem, OrderState.ReadyToDeliver);
            FillInKitchenAndBarView(orders);
        }
    }
}
