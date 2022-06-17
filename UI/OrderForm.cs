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
        bool control;
        int menu_with;
        private List<OrderItem> orders;
        Table selectedTable;
        TimeSpan time = DateTime.Now.TimeOfDay;
        OrderService orderService1 = new OrderService();
        DateTime dateTime = DateTime.Now;

        public OrderForm(Table selectedTable)
        {
            this.selectedTable = selectedTable;
            InitializeComponent();
            control = false;
            orders = new List<OrderItem>();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }

        private void OrderView_Load(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FoodBtn_Click(object sender, EventArgs e)
        {

           loadform(new StarterForm(this));


        }

        private void MainCourseBtn_Click(object sender, EventArgs e)
        {
            loadform(new MainCourse(this));

        }

        private void DessertBtn_Click(object sender, EventArgs e)
        {
            loadform(new Dessert(this));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Drink(this));
        }
        private void BillOrderBtn_Click(object sender, EventArgs e)
        {
            var frm = new Payment();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();

        }

        private void RemoveOrderBtn_Click(object sender, EventArgs e)
        {
            int Item = OrderLIstView.SelectedItems[0].Index;

            DialogResult result = MessageBox.Show($"Are you sure?",
                                                  "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OrderListView.Items.RemoveAt(Item);
            }
        }
        private void OrderLIstView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void SubmitOrder_Click(object sender, EventArgs e)
        {
            //List<Order> orders = new List<Order>();
            //OrderService orderService = new OrderService();
            //foreach (ListViewItem item in OrderListView.Items)
            //{
            //    OrderItem orderItem = (OrderItem)item.Tag;

            //    orderService.AddToOrderItem(orderItem);
            //}
            CreateOrder();
           // OrderLIstView.Clear();

        }
        private void CreateOrder()
        {
            List<OrderItem> orders = new List<OrderItem>();

            //try
            //{
                orderService1.GetIdFromUnpaied(orders, selectedTable);

            //}
            //catch
            //{
            //    MessageBox.Show("Ups something went wrong");
            //}
        }
        public List<OrderItem> GetOrderItem()
        {
            List<OrderItem> orders = new List<OrderItem>();

            foreach (ListViewItem item in OrderLIstView.Items)
            {
                OrderItem order = (OrderItem)item.Tag;
                orders.Add(order);
            }
            return orders;
        }
        public ListView OrderListView
        {
            get { return OrderLIstView; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); 
        }

        private void BackBtnOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
