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
            try
            {
            ShowMenu(MenuItemCategory.Drink);
            }
            catch
            {
                MessageBox.Show("Ups. Something when wrong. While loading the Drinks");
            }
            this.orderform = orderform;


        }
        private void ShowMenu(MenuItemCategory category)
        {
            OrderService orderService = new OrderService(); ;
            List<MenuItem> items = orderService.GetMenuItems(category);

            DrinkListView.Items.Clear();

            foreach (MenuItem o in items)
            {
                ListViewItem li = new ListViewItem(o.InStock.ToString());
                li.SubItems.Add(o.Name.ToString());
                li.SubItems.Add(o.Price.ToString());
                li.Tag = o;
                DrinkListView.Items.Add(li);
            }

        }


        private void AddDrinksBtn_Click(object sender, EventArgs e)
        {
            int Quantity = 1;
            MenuItem menuItem = (MenuItem)DrinkListView.SelectedItems[0].Tag;
            string feedback = GetFeedback();

            OrderItem item = new OrderItem(Quantity, menuItem, feedback);
            AddToListOrderItems(item);

        }
        private void AddToListOrderItems(OrderItem item)
        {
            try
            {
                ListViewItem li = new ListViewItem(item.MenuItem.Name.ToString());
                li.SubItems.Add(item.Feedback.ToString());
                li.Tag = item;

                orderform.OrderListView.Items.Add(li);
            }
            catch
            {
                MessageBox.Show("Ups.Something went wrong. While adding the Item.");
            }
        }
        private string GetFeedback()
        {
            string feedback;

            if (CommentDrink.Text == "Comment...")
            {
                feedback = "N/A";
            }
            else
            {
                feedback = CommentDrink.Text;
            }
            return feedback;


        }

        private void CommentDrink_Enter(object sender, EventArgs e)
        {
            if (CommentDrink.Text == "Comment...")
            {
                CommentDrink.Text = "";

                CommentDrink.ForeColor = Color.Black;
            }

        }

        private void CommentDrink_Leave(object sender, EventArgs e)
        {
            if (CommentDrink.Text == "")
            {
                CommentDrink.Text = "Comment..";

                CommentDrink.ForeColor = Color.Silver;
            }

        }
    }
}

