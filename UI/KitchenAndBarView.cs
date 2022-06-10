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
        private List<Order> orders;
        public KitchenAndBarView(Employee employee)
        {
            InitializeComponent();
            orderService = new OrderService();
            loggedEmployee = employee;
            checkEmployee();
            orders = new List<Order>();
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
                    //ListViewItem li = new ListViewItem(item.OrderItemId.ToString()); //first column
                    ListViewItem li = new ListViewItem(item.MenuItem.Name);
                    //li.SubItems.Add(item.MenuItem.Name);
                    li.SubItems.Add(item.Quantity.ToString());
                    li.SubItems.Add(item.Feedback.ToString());
                    li.SubItems.Add(item.DateTime.ToString("HH:mm"));
                    li.SubItems.Add(order.Table.Number.ToString());
                    li.SubItems.Add(item.OrderState.ToString());
                    //li.SubItems.Add(order.OrderItemsToString());
                    li.Tag = item;
                    lstViewKitchenAndBar.Items.Add(li);
                }
            }
        }

        // Check if the employee is chef then show KitchenView and if the employee is Bartender then show BarView
        public void checkEmployee()
        { 
            switch (loggedEmployee.EmployeeType)
            {
                case EmployeeType.Chef:
                    typeMenuItem = TypeMenuItem.Food;
                    orders = orderService.ReadOrdersForKitchenBar(typeMenuItem, OrderState.PrepairingOrder);
                    FillInKitchenAndBarView(orders);
                    lblKitchenAndBar.Text = "Kitchen View";
                    break;
                case EmployeeType.BarTender:
                    typeMenuItem = TypeMenuItem.Drink;
                    orders = orderService.ReadOrdersForKitchenBar(TypeMenuItem.Drink, OrderState.PrepairingOrder);
                    FillInKitchenAndBarView(orders);
                    lblKitchenAndBar.Text = "Bar View";
                    break;
                default:
                    break;
            }
        }

        //Select orderItem from the listview
      /*  List<ListViewItem> listViewItems;
        private void lstViewKitchenAndBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            *//* if (lstViewKitchenAndBar.SelectedItems.Count > 0)
             {
                 ListViewItem lvItem = lstViewKitchenAndBar.SelectedItems[0];
                 *//*MessageBox.Show(lvItem.ToString());*//*

                 //MessageBox.Show(listViewItem.ToString());
                 *//*listViewItems = new List<ListViewItem>();

                 foreach (ListViewItem item in lstViewKitchenAndBar.SelectedItems)
                 {
                     listViewItems.Add(item);
                 }*//*
             }*//*
        }*/

        //private void btnKitchenShowCmpltOrder_Click(object sender, EventArgs e)
        //{
        //    //btnKitchenReady.Visible= false; 
        //    //btnKitchenShowCmpltOrder.Visible= false;
        //    //btnShowRunningOrder.Visible = true;
        //    //lstViewKitchenAndBar.Hide();    


        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            checkEmployee();
        }

        //Ready Button For kitchenandBar
        private void btnKitchenReady_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvI in lstViewKitchenAndBar.SelectedItems)
            {
                orderItem = (OrderItem)lvI.Tag;
                orderService.UpdateOrderStatusReadyToDeliver(orderItem.OrderItemId, OrderState.ReadyToDeliver);
            }
            /*if (lstViewKitchenAndBar.SelectedItems.Count > 0)
            {
                ListViewItem lvItem = lstViewKitchenAndBar.SelectedItems[0];
                orderItem = (OrderItem)lvItem.Tag;
                orderService.UpdateOrderStatusReadyToDeliver(orderItem.OrderItemId);
            }*/
            checkEmployee();
        }


        private void btnRunningOrder_Click(object sender, EventArgs e)
        {
            checkEmployee();
            FillInKitchenAndBarView(orders);
            lstViewKitchenAndBar.Show();
            btnRunningOrder.Visible = false;
            btnCompletedOrder.Visible = true;
        }

        private void btnCompletedOrder_Click(object sender, EventArgs e)
        {
            checkEmployee();
            btnRunningOrder.Visible = true;
            btnCompletedOrder.Visible = false;

            orders = orderService.ReadOrdersForKitchenBar(typeMenuItem, OrderState.ReadyToDeliver);
            FillInKitchenAndBarView(orders);

            lstViewKitchenAndBar.Items.Clear();
            lstViewKitchenAndBar.View = View.Details;
            foreach (Order order in orders)
            {
                foreach (OrderItem item in order.OrderItems)
                {
                    //ListViewItem li = new ListViewItem(item.OrderItemId.ToString()); //first column
                    ListViewItem li = new ListViewItem(item.MenuItem.Name);
                    //li.SubItems.Add(item.MenuItem.Name);
                    li.SubItems.Add(item.Quantity.ToString());
                    li.SubItems.Add(item.Feedback.ToString());
                    li.SubItems.Add(item.DateTime.ToString("HH:mm"));
                    li.SubItems.Add(order.Table.Number.ToString());
                    li.SubItems.Add(item.OrderState.ToString());
                    //li.SubItems.Add(order.OrderItemsToString());
                    li.Tag = item;
                    lstViewKitchenAndBar.Items.Add(li);
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        //private void btnShowRunningOrder_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Bijay");
        //    //btnShowRunningOrder.Visible = false;
        //    //btnKitchenReady.Visible = true;
        //    //btnKitchenShowCmpltOrder.Visible = true;

        //    FillInKitchenAndBarView(orders);
        //}
    }
}
