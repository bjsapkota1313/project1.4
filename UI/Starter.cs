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
using UI;

namespace UI
{
    public partial class StarterForm : Form
    {
        private OrderForm orderform;
        public StarterForm(OrderForm orderForm )
        {
            InitializeComponent();
            TimeSpan startLuch = new TimeSpan(10, 0, 0); //10 o'clock
            TimeSpan endLuch = new TimeSpan(17, 0, 0); //17 o'clock
            TimeSpan startDinner = new TimeSpan(17, 0, 0); //17 o'clock
            TimeSpan endDinner = new TimeSpan(22, 0, 0); //22 o'clock
            //Testing
           //TimeSpan now = new TimeSpan(18, 0, 0);

          TimeSpan now = DateTime.Now.TimeOfDay;
            string closed = "Restaurant is closed!";
            if ((now > startLuch) && (now < endLuch))
            {
                ShowMenu(MenuItemCategory.LuchStarter);

            }else if ((now >= startDinner) && (now <= endDinner))
            {
                ShowMenu(MenuItemCategory.DinnerStarter);
            }
            else
            {
                    LvStarterList.Items.Add(closed);
            }
            this.orderform = orderForm;
        }

        public void ShowMenu(MenuItemCategory category)
        {
           OrderService orderService = new OrderService(); ;
           List<MenuItem> items = orderService.GetAllStarters(category);

            LvStarterList.Items.Clear();

            foreach (MenuItem o in items)
            {
                ListViewItem li = new ListViewItem(o.Name.ToString());
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

            ListViewItem li = new ListViewItem(item.MenuItem.Name);
            li.Tag =item;
            li.SubItems.Add(item.Quantity.ToString());
            li.SubItems.Add(item.Feedback.ToString());

            orderform.OrderListView.Items.Add(li);
            

        }
        private string GetFeedback()
        {
            string feedback;

            if (CommentStarters.Text == "")
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
    }
}
