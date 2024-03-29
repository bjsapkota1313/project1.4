﻿using Model;
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
            btnRunningOrder.Visible = false;
            lblEmployeeName.Text = loggedEmployee.FullName;
            lblEmployeeId.Text = $"{loggedEmployee.Id}@Chapeau.nl";
            pnlLogOut.Hide();

            DisplayKitchenBarView();
        }

        private void DisplayKitchenBarView()
        {
            lblOrderType.Text = "Running Orders";
            //Display screen title based on employee type
            if (loggedEmployee.EmployeeType == EmployeeType.Chef)
            {
                lblKitchenAndBarView.Text = "Kitchen View";
            }
            else
            {
                lblKitchenAndBarView.Text = "Bar View";
            }

            //Get orders by for kitchen or bar, depends on employee type
            List<Order> orders = GetOrders(loggedEmployee);

            //Fill in the listview with orders
            FillInKitchenAndBarView(orders);
        }
        
        //Get orders for kitchen or bar based on employee type
        private List<Order> GetOrders(Employee employee)
        {
            List<Order> orders = new List<Order>();

            switch (employee.EmployeeType)
            {
                case EmployeeType.Chef:
                    typeMenuItem = TypeMenuItem.Food;
                    orders = orderService.ReadOrdersForKitchenBar(typeMenuItem, OrderItemState.PreparingOrder);
                    break;
                case EmployeeType.BarTender:
                    typeMenuItem = TypeMenuItem.Drink;
                    orders = orderService.ReadOrdersForKitchenBar(typeMenuItem, OrderItemState.PreparingOrder);
                    break;
            }
            return orders;
        }

        // Display Orders In Listview
        private void FillInKitchenAndBarView(List<Order> orders)
        {
            lstViewKitchenAndBar.Items.Clear();
            lstViewKitchenAndBar.View = View.Details;
            
            //Create listview item for each orderitem in every order
            foreach (Order order in orders)
            {
                foreach (OrderItem item in order.OrderItems)
                {
                    string dateTimeToShow;
                    if (CheckOrderTime(item))
                    {
                        TimeSpan dateTime = DateTime.Now.Subtract(item.DateTime);
                        dateTimeToShow = dateTime.Minutes.ToString() + " min ago";
                    }
                    else
                    {
                        dateTimeToShow = item.DateTime.ToString("HH:mm");
                    }
                    ListViewItem li = new ListViewItem(item.Quantity.ToString());
                    li.SubItems.Add(item.MenuItem.Name);
                    li.SubItems.Add(item.Feedback.ToString());
                    li.SubItems.Add(dateTimeToShow);
                    li.SubItems.Add(order.Table.Number.ToString());

                   
                    if (item.OrderState == OrderItemState.ReadyToDeliver)
                    {
                        li.SubItems.Add("Completed");
                    }
                    else if (item.OrderState == OrderItemState.PreparingOrder)
                    {
                        li.SubItems.Add("Running");
                    }
                    li.Tag = item;
                    lstViewKitchenAndBar.Items.Add(li);
                }
            }
        }
        private bool CheckOrderTime(OrderItem orderItem)
        {
            return orderItem.OrderState == OrderItemState.PreparingOrder ;

        }

        //Ready Button For kitchenandBar
        private void btnKitchenReady_Click(object sender, EventArgs e)
        {
            // enabling multiple selection true 
            foreach(ListViewItem lvI in lstViewKitchenAndBar.SelectedItems)
            {
                orderItem = (OrderItem)lvI.Tag;
                orderItem.OrderState = OrderItemState.ReadyToDeliver;
                orderService.UpdateStatusOfSpecficOrderItem(orderItem); 
            }
            DisplayKitchenBarView();    
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
            orders = orderService.ReadOrdersForKitchenBar(typeMenuItem, OrderItemState.PreparingOrder);
            FillInKitchenAndBarView(orders);
            timer1.Enabled = true;

            btnRunningOrder.Visible = false;
            btnCompletedOrder.Visible = true;
            btnKitchenReady.Visible = true;
            btnRefresh.Visible = true;
            lblOrderType.Text = "Running Orders";
        }

        private void btnCompletedOrder_Click_1(object sender, EventArgs e)
        {
            btnRunningOrder.Visible = true;
            btnCompletedOrder.Visible = false;
            btnKitchenReady.Visible = false;
            btnRefresh.Visible = false;
            timer1.Enabled = false;
            lblOrderType.Text = "Completed Orders";

            List<Order> orders;
            orders = orderService.ReadOrdersForKitchenBar(typeMenuItem, OrderItemState.ReadyToDeliver);
            FillInKitchenAndBarView(orders);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayKitchenBarView();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void picBoxProfilePic_Click(object sender, EventArgs e)
        {
            pnlLogOut.Show();
        }

        private void KitchenAndBarView_Click(object sender, EventArgs e)
        {
            pnlLogOut.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayKitchenBarView();
        }
    }
}
