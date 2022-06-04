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
    public partial class MainCourse : Form
    {
        public MainCourse()
        {
            InitializeComponent();
            ShowMenu(MenuItemCategory.LuchMainCourse);



        }
        private void ShowMenu(MenuItemCategory category)
        {
            OrderService orderService = new OrderService(); ;
            List<MenuItem> items = orderService.GetAllStarters(category);

            MainCourseList.Items.Clear();

            foreach (MenuItem o in items)
            {
                ListViewItem li = new ListViewItem(o.Name.ToString());
                li.SubItems.Add(o.Price.ToString());
                li.Tag = o;
                MainCourseList.Items.Add(li);
            }

        }
    }
}
