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
    public partial class EachTableDisplay : Form
    {
        private List<OrderItem> SelectedOrderItems;
        private TableService tableService;
        private OrderService orderService;
        private Table selectedTable;
        public  Order selectedTableOrder { get { return orderService.GetOrderForSpecificTableWhichisNotPaidYet(selectedTable.Number, PayementStatus.UnPaid); } }
        public EachTableDisplay(Order order,Table selectedTable)
        {
            // With passing Table and orders for specific table you can see the whole details for e=selected table 
            InitializeComponent();

            //making the new order service when eachdisplay form is called
            orderService= new OrderService();   
           this.selectedTable  = selectedTable;

            //At first disabling the button mark as served and hiding the info
            btnMarkAsServed.Enabled = false;
            lblForUserInfoTomarkServe.Hide();

            lblTableNumber.Text = "Table Number: " + $"{selectedTable.Number}";
            lblCurrentTableStatus.Text = $"{selectedTable.Status}";

            if (selectedTable.Status==TableStatus.Occupied && order.OrderItems.Count == 0)
            {
                pnlForOccupyingTable.Visible = true;
                btnMarkAsServed.Hide();
            }
            else if(selectedTable.Status==TableStatus.Reserved && order.OrderItems.Count ==0 )
            {
                pnlForOccupyingTable.Visible = true;
                BtnMakeTableFree.Hide();
                btnMarkAsServed.Hide();
                labelInPaneInfo.Text = "Nice! Guest is here. Let's take some orders now !!";
                lblJustInfo.Hide();
            }
            else
            {
                pnlForOccupyingTable.Visible = false;
                FillListViewItems(selectedTableOrder.OrderItems);
                DesiredColumnsOfListView();
            }
           

        }
        private void FillListViewItems(List<OrderItem> orderItems)
        {
            // All setting to Listview item 
            ListViewOfOrderItems.Items.Clear();
            ListViewOfOrderItems.View = View.Details;
            ListViewOfOrderItems.FullRowSelect = true;
            ListViewOfOrderItems.MultiSelect = true;

            foreach (OrderItem item in orderItems)
            {
                string dateTimeToShow;
                // showing the waiting time if order is preparing or ready to serve and if it is serve then showiing the full time
                if (CheckOrderTime(item))
                {
                    TimeSpan dateTime = DateTime.Now.Subtract(item.DateTime);
                    dateTimeToShow = dateTime.Minutes.ToString() + " min";
                }
                else
                {
                    dateTimeToShow = item.DateTime.ToString("HH:mm");
                }

                // )
                ListViewItem li = new ListViewItem(item.MenuItem.Name.ToString()); //first column
                li.SubItems.Add(item.Quantity.ToString());
                li.SubItems.Add(dateTimeToShow);
                li.SubItems.Add(item.OrderState.ToString());
                li.SubItems.Add(item.MenuItem.TypeMenuItem.ToString());
                li.SubItems.Add(item.MenuItem.Category.ToString());
                li.Tag = item;
                ListViewOfOrderItems.Items.Add(li);
            }
        }

        private void DesiredColumnsOfListView()
        {
            ListViewOfOrderItems.Columns.Add("Name", 150);
            ListViewOfOrderItems.Columns.Add("Quantity", 80);
            ListViewOfOrderItems.Columns.Add("Ordered Time", 100);
            ListViewOfOrderItems.Columns.Add("Order State", 130);
            ListViewOfOrderItems.Columns.Add("Menu Type", 100);
            ListViewOfOrderItems.Columns.Add("Category", 100);
        }

        //  checking if order is either preparing or ready to deliver 
        private bool CheckOrderTime(OrderItem orderItem)
        {
           return orderItem.OrderState==OrderState.PreparingOrder || orderItem.OrderState == OrderState.ReadyToDeliver;
           
        }

        private void BtnBackToTableView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void btnMarkAsServed_Click(object sender, EventArgs e)
        {
            foreach (OrderItem item in SelectedOrderItems)
            {
                orderService.UpdateStatusOfSpecficOrderItem(item);  
            }

            // showing again new listr view 
            FillListViewItems(selectedTableOrder.OrderItems);
        }

        private void ListViewOfOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Enabling the multiple select  and making list show that it selected orderItem can be changed 
            SelectedOrderItems = new List<OrderItem>();
            if (ListViewOfOrderItems.SelectedItems.Count > 0)
            {
                // When ever order item is selected then only button marked served can Workable and showing info for user
                btnMarkAsServed.Enabled = true;
                lblForUserInfoTomarkServe.Show();
                for (int i = 0; i < ListViewOfOrderItems.SelectedItems.Count; i++)
                {
                    OrderItem item = (OrderItem)ListViewOfOrderItems.SelectedItems[i].Tag;
                    // Changing the status of order and storing ton list 
                    item.OrderState = OrderState.OrderServed;
                    // Getting all the list that is added 
                    SelectedOrderItems.Add(item);
                }
                //MessageBox.Show(SelectedOrderItems.Count.ToString());
            }
            else
            {
                return;
            }
        }
    }
}
