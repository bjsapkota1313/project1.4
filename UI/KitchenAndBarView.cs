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
                    ListViewItem li = new ListViewItem(item.OrderItemId.ToString()); //first column
                    li.SubItems.Add(item.MenuItem.Name);
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
            List<Order> orders;
            switch (loggedEmployee.EmployeeType)
            {
                case EmployeeType.Chef:
                    orders = orderService.ReadOrdersForKitchenBar(TypeMenuItem.Food, OrderState.PreparingOrder);
                    FillInKitchenAndBarView(orders);
                    break;
                case EmployeeType.BarTender:
                    orders = orderService.ReadOrdersForKitchenBar(TypeMenuItem.Drink, OrderState.PreparingOrder);
                    FillInKitchenAndBarView(orders);
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

        private void btnKitchenShowCmpltOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            checkEmployee();
        }

        //Ready Button For kitchenandBar
        private void btnKitchenReady_Click(object sender, EventArgs e)
        {
            if (lstViewKitchenAndBar.SelectedItems.Count > 0)
            {
                ListViewItem lvItem = lstViewKitchenAndBar.SelectedItems[0];
                orderItem = (OrderItem)lvItem.Tag;
                orderService.UpdateOrderStatusReadyToDeliver(orderItem.OrderItemId);
            }
            checkEmployee();
        }


    }
}
