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

namespace UI
{
    public partial class StarterForm : Form
    {
        public StarterForm()
        {
            InitializeComponent();
            ShowMenu(MenuItemCategory.LuchStarter);

        }
        public void MainCourse()
        {
            InitializeComponent();
            ShowMenu(MenuItemCategory.LuchMainCourse);

        }
        public void Dessert()
        {
            InitializeComponent();
            ShowMenu(MenuItemCategory.LuchDessert);

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
    }
}
