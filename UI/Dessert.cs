﻿using System;
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
    public partial class Dessert : Form
    {
        private OrderForm orderform;

        public Dessert(OrderForm orderform)
        {
            InitializeComponent();
            TimeSpan startLuch = new TimeSpan(10, 0, 0); //10 o'clock
            TimeSpan endLuch = new TimeSpan(17, 0, 0); //17 o'clock
            TimeSpan startDinner = new TimeSpan(17, 0, 0); //17 o'clock
            TimeSpan endDinner = new TimeSpan(22, 0, 0); //22 o'clock
                                                         //Testing
                                                         // TimeSpan now = new TimeSpan(18, 0, 0);

            TimeSpan now = DateTime.Now.TimeOfDay;

            if ((now > startLuch) && (now < endLuch))
            {
                ShowMenu(MenuItemCategory.LuchDessert);

            }
            else if ((now >= startDinner) && (now <= endDinner))
            {
                ShowMenu(MenuItemCategory.DinnerDessert);
            }


            this.orderform = orderform;


        }
        private void ShowMenu(MenuItemCategory category)
        {
            OrderService orderService = new OrderService(); ;
            List<MenuItem> items = orderService.GetAllStarters(category);

            DessertListView.Items.Clear();

            foreach (MenuItem o in items)
            {
                ListViewItem li = new ListViewItem(o.Name.ToString());
                li.SubItems.Add(o.Price.ToString());
                li.Tag = o;
                DessertListView.Items.Add(li);
            }

        }


        private void Dessert_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DessertAddBtn_Click(object sender, EventArgs e)
        {
            int Quantity = 1;
            MenuItem menuItem = (MenuItem)DessertListView.SelectedItems[0].Tag;
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

            if (CommentDessert.Text == "")
            {
                feedback = "N/A";
            }
            else
            {
                feedback = CommentDessert.Text;
            }
            return feedback;
        }


    }
}
