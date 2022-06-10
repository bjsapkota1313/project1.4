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

namespace UI
{
    public partial class Drink : Form
    {
        private OrderForm orderform;

        public Drink(OrderForm orderform)
        {
            InitializeComponent();
            ShowMenu(MenuItemCategory.Drink);
            this.orderform = orderform;


        }
        private void ShowMenu(MenuItemCategory category)
        {
            OrderService orderService = new OrderService(); ;
            List<MenuItem> items = orderService.GetAllStarters(category);

            DrinkListView.Items.Clear();

            foreach (MenuItem o in items)
            {
                ListViewItem li = new ListViewItem(o.Name.ToString());
                li.SubItems.Add(o.Price.ToString());
                li.Tag = o;
                DrinkListView.Items.Add(li);
            }

        }

        private void DessertAddBtn_Click(object sender, EventArgs e)
        {
            int Quantity = 1;
            MenuItem menuItem = (MenuItem)DrinkListView.SelectedItems[0].Tag;
            string feedback = GetFeedback();

            OrderItem item = new OrderItem(Quantity, menuItem, feedback);

            ListViewItem li = new ListViewItem(item.MenuItem.Name);
            li.Tag = item;
            li.SubItems.Add(item.Quantity.ToString());
            li.SubItems.Add(item.Feedback.ToString());

            orderform.OrderListView.Items.Add(li);


        }
        private string GetFeedback()
        {
            string feedback;

            if (CommentDrink.Text == "")
            {
                feedback = "N/A";
            }
            else
            {
                feedback = CommentDrink.Text;
            }
            return feedback;
        }


    }
}

