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
using UI;

namespace UI
{

    public partial class OrderForm : Form
    {
        Table selectedTable;
        Employee employee;
       // TimeSpan now = DateTime.Now.TimeOfDay;
        TimeSpan startLuch = new TimeSpan(10, 0, 0); //10 o'clock
        TimeSpan endLuch = new TimeSpan(17, 0, 0); //17 o'clock
        TimeSpan startDinner = new TimeSpan(17, 0, 0); //17 o'clock
        TimeSpan endDinner = new TimeSpan(22, 0, 0); //22 o'clock
        string closed = "Restaurant is closed!";
        //Testing
         TimeSpan now = new TimeSpan(18, 0, 0);
        OrderService orderService = new OrderService();//global

        public OrderForm(Table selectedTable, Employee employee)
        {
            this.selectedTable = selectedTable;
            InitializeComponent();
            this.employee = employee;
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            ShowMenu(MenuItemCategory.Drink);
        }

        private void FoodBtn_Click(object sender, EventArgs e)
        {
            MenuPanel.Show();
            if ((now > startLuch) && (now < endLuch))
            {
                try
                {
                    FoodList.Items.Clear();
                    ShowMenu(MenuItemCategory.LuchStarter);
                    ShowMenu(MenuItemCategory.LuchMainCourse);
                    ShowMenu(MenuItemCategory.LuchDessert);
                }
                catch
                {
                    MessageBox.Show("Ups. Something when wrong. While loading the menu Items");
                }

            }
            else if ((now >= startDinner) && (now <= endDinner))
            {
                try 
                {
                    FoodList.Items.Clear();
                    ShowMenu(MenuItemCategory.DinnerStarter);
                    ShowMenu(MenuItemCategory.DinnerMainCourse);
                    ShowMenu(MenuItemCategory.DinnerDessert);
                }
                catch
                {
                    MessageBox.Show("Ups. Something when wrong. While loading the menu Items");
                }
            }
            else
            {
                MessageBox.Show(closed);
            }
        }
        private void DrinkBtn_Click(object sender, EventArgs e)
        {
            MenuPanel.Show();
            try
            {
                FoodList.Items.Clear();

                ShowMenu(MenuItemCategory.Drink);
            }
            catch
            {
                MessageBox.Show("Ups. Something when wrong. While loading the menu Items");
            }
        }

        private void RemoveOrderBtn_Click(object sender, EventArgs e)
        {
            int Item = OrderLIstView.SelectedItems[0].Index;

            DialogResult result = MessageBox.Show($"Are you sure?",
                                                  "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OrderLIstView.Items.RemoveAt(Item);
            }
        }

        private void SubmitOrder_Click(object sender, EventArgs e)
        {
            List<OrderItem> orders = new List<OrderItem>();
            foreach (ListViewItem item in OrderLIstView.Items)
            {
                OrderItem orderItem = (OrderItem)item.Tag;
                orderItem.Quantity = int.Parse(item.SubItems[2].Text);
               orderItem.DateTime= DateTime.Now;   
                orders.Add(orderItem);
            }

            try
            {
                orderService.GetIdFromUnpaied(orders, selectedTable,employee);
                orderService.UpdateStock(orders);
                OrderLIstView.Items.Clear();
                OrderLIstView.Refresh();

            }
            catch
            {
                MessageBox.Show("Ups something went wrong");
            }

        }

        private void BtnBackToTableView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowMenu(MenuItemCategory category)
        {
            List<MenuItem> items = orderService.GetMenuItems(category);
            foreach (MenuItem o in items)
            {
                ListViewItem li = new ListViewItem(o.ItemId.ToString());
                li.SubItems.Add(o.Name.ToString());
                li.SubItems.Add(o.Price.ToString());
                li.Tag = o;
                FoodList.Items.Add(li);
            }

        }
        private void AddToListOrderItems(OrderItem item)
        {
            try
            {
                ListViewItem li = new ListViewItem(item.MenuItem.Name.ToString());
                li.SubItems.Add(item.Feedback.ToString());
                li.SubItems.Add(item.Quantity.ToString());

                li.Tag = item;

                OrderLIstView.Items.Add(li);
            }
            catch
            {
                MessageBox.Show("Ups.Something went wrong. While adding the Item.");
            }

        }
        private string GetFeedback()
        {
            string feedback;

            if (CommentTb.Text == "")
            {
                feedback = "N/A";
            }
            else
            {
                feedback = CommentTb.Text;
            }
            return feedback;
        }

        private void AddBtn_CLick(object sender, EventArgs e)
        {
            int Quantity = 1;
            MenuItem menuItem = (MenuItem)FoodList.SelectedItems[0].Tag;
            OrderItem item = new OrderItem(Quantity, menuItem, GetFeedback());
            foreach(ListViewItem listViewItem in OrderLIstView.Items)
            {
                OrderItem orderItem = (OrderItem)listViewItem.Tag;
                if (item.MenuItem == orderItem.MenuItem && item.Feedback == orderItem.Feedback)
                {
                    listViewItem.SubItems[2].Text = (int.Parse(listViewItem.SubItems[2].Text)+1).ToString();
                    listViewItem.SubItems[1].Text = GetFeedback();
                    return;
                }

            }
            AddToListOrderItems(item);
        }

        private void ShowLunchAndDinner_Click(object sender, EventArgs e)
        {
            ShowAllMenu();
        }
        public void ShowAllMenu()
        {
            FoodList.Items.Clear();
            ShowMenu(MenuItemCategory.LuchStarter);
            ShowMenu(MenuItemCategory.LuchMainCourse);
            ShowMenu(MenuItemCategory.LuchDessert);
            ShowMenu(MenuItemCategory.DinnerStarter);
            ShowMenu(MenuItemCategory.DinnerMainCourse);
            ShowMenu(MenuItemCategory.DinnerDessert);
        }
    }
}


