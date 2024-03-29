﻿using Model;
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
using UI;

namespace UI
{
    public partial class StarterForm : Form
    {
        private OrderForm orderform;
        private List<OrderItem> orders;
        public StarterForm(OrderForm orderForm, List<OrderItem> orderItems)
        {
            orders = orderItems;
        }
        public StarterForm(OrderForm orderForm)
        {
            InitializeComponent();
            TimeSpan startLuch = new TimeSpan(9, 0, 0); //10 o'clock
            TimeSpan endLuch = new TimeSpan(17, 0, 0); //17 o'clock
            TimeSpan startDinner = new TimeSpan(17, 0, 0); //17 o'clock
            TimeSpan endDinner = new TimeSpan(23, 0, 0); //22 o'clock
          TimeSpan now = DateTime.Now.TimeOfDay;
            string closed = "Restaurant is closed!";
            if ((now > startLuch) && (now < endLuch))
            {
                try
                {
                    ListViewItem startersHeader = new ListViewItem("---");
                    startersHeader.SubItems.Add("Starters");
                    startersHeader.SubItems.Add("---");
                    LvStarterList.Items.Add(startersHeader);

                    ShowMenu(MenuItemCategory.LuchStarter);

                    ListViewItem MainCourseHeader = new ListViewItem("---");
                    MainCourseHeader.SubItems.Add("Main Course");
                    MainCourseHeader.SubItems.Add("---");
                    LvStarterList.Items.Add(MainCourseHeader);

                    ShowMenu(MenuItemCategory.LuchMainCourse);

                    ListViewItem DessertHeader = new ListViewItem("---");
                    DessertHeader.SubItems.Add("Dessert");
                    DessertHeader.SubItems.Add("---");
                    LvStarterList.Items.Add(DessertHeader);

                    ShowMenu(MenuItemCategory.LuchDessert);

                }
                catch
                {
                    MessageBox.Show("Ups. Something when wrong. While loading the menu Items");
                }
            }else if ((now >= startDinner) && (now <= endDinner))
            {
                try
                {
                    ListViewItem startersHeader = new ListViewItem("---");
                    startersHeader.SubItems.Add("Starters");
                    startersHeader.SubItems.Add("---");
                    LvStarterList.Items.Add(startersHeader);

                    ShowMenu(MenuItemCategory.DinnerStarter);
                    ListViewItem MainCourseHeader = new ListViewItem("---");
                    MainCourseHeader.SubItems.Add("Main Course");
                    MainCourseHeader.SubItems.Add("---");
                    LvStarterList.Items.Add(MainCourseHeader);

                    ShowMenu(MenuItemCategory.DinnerMainCourse);
                    ListViewItem DessertHeader = new ListViewItem("---");
                    DessertHeader.SubItems.Add("Dessert");
                    DessertHeader.SubItems.Add("---");
                    LvStarterList.Items.Add(DessertHeader);

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
            this.orderform = orderForm;
        }

        public void ShowMenu(MenuItemCategory category)
        {
           OrderService orderService = new OrderService(); ;
           List<MenuItem> items = orderService.GetMenuItems(category);

            //LvStarterList.Items.Clear();

            foreach (MenuItem o in items)
            {
                ListViewItem li = new ListViewItem(o.InStock.ToString());
                li.SubItems.Add(o.Name.ToString());
                li.SubItems.Add(o.Price.ToString());
                li.Tag = o;
                LvStarterList.Items.Add(li);
            }
            

        }


        private void StarterForm_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StarterList_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void StarterAddBtn_Click(object sender, EventArgs e)
        {
            int Quantity = 1;
            MenuItem menuItem = (MenuItem)LvStarterList.SelectedItems[0].Tag;
            string feedback = GetFeedback();

            OrderItem item = new OrderItem(Quantity, menuItem, feedback);
            AddToListOrderItems(item);

        }
        private void  AddToListOrderItems(OrderItem item)
        {            try
            {
                ListViewItem li = new ListViewItem(item.MenuItem.Name);
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

            if (CommentStarters.Text == "Comment...")
            {
                feedback = "N/A";
            }
            else
            {
                feedback = CommentStarters.Text;
            }
            return feedback;
        }

        private void StarterForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LvStarterList.Items.Clear();
            ListViewItem startersHeader = new ListViewItem("---");
            startersHeader.SubItems.Add("Starters");
            startersHeader.SubItems.Add("---");
            LvStarterList.Items.Add(startersHeader);

            ShowMenu(MenuItemCategory.LuchStarter);
            ShowMenu(MenuItemCategory.DinnerStarter);
            ListViewItem MainCourseHeader = new ListViewItem("---");
            MainCourseHeader.SubItems.Add("Main Course");
            MainCourseHeader.SubItems.Add("---");
            LvStarterList.Items.Add(MainCourseHeader);

            ShowMenu(MenuItemCategory.LuchMainCourse);
            ShowMenu(MenuItemCategory.DinnerMainCourse);
            ListViewItem DessertHeader = new ListViewItem("---");
            DessertHeader.SubItems.Add("Dessert");
            DessertHeader.SubItems.Add("---");
            LvStarterList.Items.Add(DessertHeader);

            ShowMenu(MenuItemCategory.LuchDessert);
            ShowMenu(MenuItemCategory.DinnerDessert);

        }

        private void CommentStarters_Enter(object sender, EventArgs e)
        {
            if(CommentStarters.Text == "Comment...")
            {
                CommentStarters.Text = "";

                CommentStarters.ForeColor = Color.Black;
            }
        }

        private void CommentStarters_Leave(object sender, EventArgs e)
        {
            if (CommentStarters.Text == "")
            {
                CommentStarters.Text = "Comment...";

                CommentStarters.ForeColor = Color.Silver;
            }

        }
    }
}
