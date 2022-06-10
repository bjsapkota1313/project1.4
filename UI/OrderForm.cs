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

    public partial class OrderForm : Form
    {
        bool control;
        int menu_with;
        private List<OrderItem> orders;
        public OrderForm( Table selectedTable)
        {
            InitializeComponent();
            control = false;
            orders = new List<OrderItem>();
           // menu_with = hamburgerMenu.Width;

            //BillOrderBtn.Click += new EventHandler(BillOrderBtn_Click);

        }
       /* private void ShowMenu(MenuItemCategory category)
        {
            OrderService orderService = new OrderService(); ;
            List<Order> orders = orderService.GetOrderTableNotPayed(table);

            OrderListView.Items.Clear();

            foreach (Order o in orders)
            {
                ListViewItem li = new ListViewItem(o.);
                li.SubItems.Add(o.Price.ToString());
                li.Tag = o;
                DessertList.Items.Add(li);
            }

        }*/
        public void loadform(object Form)
        {
            if(this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }
        //hamburger
       /* private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                // Expand hamburger menu
                if (control)
                {
                    hamburgerMenu.Width = hamburgerMenu.Width + 10;
                    if (hamburgerMenu.Width >= menu_with)
                    {
                        timer1.Stop();
                        control = false;
                        this.Refresh();
                    }
                }
                // close the hamburger menu
                else
                {
                    hamburgerMenu.Width = hamburgerMenu.Width - 10;
                    if (hamburgerMenu.Width <= 0)
                    {
                        timer1.Stop();
                        control = true;
                        this.Refresh();
                        hamburgerMenu.Visible = true;

                    }
         
            }

        }*/

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
        private void OrderDBView_Click(object sender, EventArgs e)
        {
            //loadform(new OrderDisplay(this));
        }
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

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
           /*     {
            OrderItem order = (OrderItem)OrderLIstView.SelectedItems[0].Tag;

        DialogResult result = MessageBox.Show($"Are you sure?",
                                              "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OrderService orders = new OrderService();
        orders.RemoveFromOrder(order);
            }
        }*/
private void OrderLIstView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        /*public void ShowOrder(int tablenr, PayementStatus payementStatus)
        {
            OrderService orderService = new OrderService(); ;
            List<Order> orders = orderService.GetOrderForSpecificTableWhichisNotPaidYet(tablenr, payementStatus);

            OrderLIstView.Items.Clear();

            foreach (Order o in orders)
            {
                ListViewItem li = new ListViewItem(o.Menu.ToString());
                li.SubItems.Add(o.TotalPrice.ToString());
                li.Tag = o;
                LvStarterList.Items.Add(li);
            }


        }*/

        private void SubmitOrder_Click(object sender, EventArgs e)
        {

            List<OrderItem> orders = new List<OrderItem>();
           // orders.Add();


           Order order = new Order(TotalPrice,OrderItems,OrderId,Time, Table, PayementStatus.UnPaid,Feedback);


        }
        public List<OrderItem> GetOrderItem()
        {
            List<OrderItem> orders = new List<OrderItem>();

            foreach(ListViewItem item in OrderLIstView.Items)
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

        }


        }


    }
