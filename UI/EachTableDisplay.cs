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
        private Employee employee;
        private List<OrderItem> SelectedOrderItems;
        private TableService tableService;
        private OrderService orderService;
        private Table selectedTable;
        private Color btnMarkASServedColor;
        private Color btnTakeorderColor;
        private Color btnCheckoutColor;
        private Color btnoccupyTableColor;
        private List<OrderItem> SelectedTableOrderItems { get { return orderService.ListOfOrderItemsInSelectedTable(selectedTable, PayementStatus.UnPaid); } }
        public EachTableDisplay(Table selectedTable, Employee employee)
        {
            // With passing Table and orders for specific table you can see the whole details for selected table 
            InitializeComponent();
            btnMarkASServedColor = btnMarkAsServed.BackColor;
            btnTakeorderColor = btnTakeOrder.BackColor;
            btnoccupyTableColor=btnOccupyTable.BackColor;
            btnCheckoutColor = BtnCheckout.BackColor;

            //making the new order service when eachdisplay form is called
            orderService = new OrderService();
            tableService = new TableService();
            this.selectedTable = selectedTable;
            this.employee = employee;
            RefreshDisplay(selectedTable);
            btnMakeTableFree.Hide();    

        }

        private void RefreshDisplay(Table selectedTable)
        {

            //At first disabling the button mark as served 
            btnMarkAsServed.Enabled = false;

            lblTableNumber.Text = "Table Number: " + $"{selectedTable.Number}";
            lblCurrentTableStatus.Text = $"{selectedTable.Status}";

            // making some default setting
            if (selectedTable.Status == TableStatus.Free || selectedTable.Status==TableStatus.Reserved)
            {
                btnMakeTableFree.Hide();
                btnTakeOrder.Enabled = false;
                BtnCheckout.Enabled = false;
                btnMarkAsServed.Enabled = false;
                btnOccupyTable.Enabled = true;
                SetEnabledColor(btnOccupyTable);
                SetColorForButtons(btnTakeOrder);
                SetColorForButtons(BtnCheckout);
                SetColorForButtons(btnMarkAsServed);
            }
            else if(selectedTable.Status == TableStatus.Occupied && SelectedTableOrderItems.Count==0)
            {
                btnMakeTableFree.Show();

                btnTakeOrder.Enabled = true; ;
                BtnCheckout.Enabled = false;
                btnMarkAsServed.Enabled = false;
                btnOccupyTable.Enabled = false;
                SetColorForButtons(btnOccupyTable);
                SetColorForButtons(BtnCheckout);
                SetColorForButtons(btnMarkAsServed);
                SetEnabledColor(btnTakeOrder);
            }
            else if (selectedTable.Status == TableStatus.Occupied && SelectedTableOrderItems.Count != 0)
            {
                btnOccupyTable.Enabled=false;
                SetColorForButtons(btnOccupyTable);
                btnMakeTableFree.Hide();
                FillListViewItems(SelectedTableOrderItems);
                DesiredColumnsOfListView();
                btnTakeOrder.Enabled = true;
                BtnCheckout.Enabled = true;
                btnMarkAsServed.Enabled = true;

                SetEnabledColor(btnTakeOrder);
                SetEnabledColor(BtnCheckout);
                SetEnabledColor(btnMarkAsServed);
            }
            else
            {
                btnMakeTableFree.Hide();
                FillListViewItems(SelectedTableOrderItems);
                DesiredColumnsOfListView();
                btnTakeOrder.Enabled = true;
                BtnCheckout.Enabled = true;
                btnMarkAsServed.Enabled = true;
                btnOccupyTable.Show();

                SetEnabledColor(btnTakeOrder);
                SetEnabledColor(BtnCheckout);
                SetEnabledColor(btnMarkAsServed);
                SetEnabledColor(btnOccupyTable);

            }

            
        }

        private void FillListViewItems(List<OrderItem> orderItems)
        {
            // All setting to Listview item 
            ListViewOfOrderItems.Items.Clear();
            ListViewOfOrderItems.View = View.Details;
            ListViewOfOrderItems.FullRowSelect = true;
            ListViewOfOrderItems.MultiSelect = true;

            for (int i = orderItems.Count-1; i >= 0; i--)
            {
                string dateTimeToShow;
                OrderItem item = orderItems[i];
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
                ListViewItem li = new ListViewItem(item.MenuItem.Name.ToString()); //first column
                li.SubItems.Add(item.Quantity.ToString());
                li.SubItems.Add(dateTimeToShow);
                //li.SubItems.Add(item.MenuItem.TypeMenuItem.ToString());
                //li.SubItems.Add(item.MenuItem.Category.ToString());
                li.SubItems.Add(JustDisplay(item));
                li.Tag = item;
                ListViewOfOrderItems.Items.Add(li);

            }
        }

        private void DesiredColumnsOfListView()
        {
            ListViewOfOrderItems.Columns.Add("Name", 370);
            ListViewOfOrderItems.Columns.Add("Qty", 80);
            ListViewOfOrderItems.Columns.Add("Time", 100);
            //ListViewOfOrderItems.Columns.Add("Menu Type", 100);
            //ListViewOfOrderItems.Columns.Add("Category", 100);
            ListViewOfOrderItems.Columns.Add("Status", 130);
        }

        //  checking if order is either preparing or ready to deliver 
        private bool CheckOrderTime(OrderItem orderItem)
        {
            return orderItem.OrderState == OrderItemState.PreparingOrder || orderItem.OrderState == OrderItemState.ReadyToDeliver;

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
            FillListViewItems(SelectedTableOrderItems);
        }

        private void ListViewOfOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Enabling the multiple select  and making list show that it selected orderItem can be changed 
            SelectedOrderItems = new List<OrderItem>();
            if (ListViewOfOrderItems.SelectedItems.Count > 0)
            {
                // When ever order item is selected then only button marked served can Workable and showing info for user
                btnMarkAsServed.Enabled = true;
                for (int i = 0; i < ListViewOfOrderItems.SelectedItems.Count; i++)
                {
                    OrderItem item = (OrderItem)ListViewOfOrderItems.SelectedItems[i].Tag;
                    // only adding to list which have state ready to deliver 
                    if (item.OrderState == OrderItemState.ReadyToDeliver)
                    {
                        // Changing the status of order and storing on list and preventing other state cannot be updated 
                        item.OrderState = OrderItemState.OrderServed;
                        SelectedOrderItems.Add(item);
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void BtnMakeTableFree_Click(object sender, EventArgs e)
        {
            // changing the status 
            selectedTable.Status = TableStatus.Free;
            // updating in database
            tableService.UpdateTheStatusOfTable(selectedTable);
            // refreshing the tab
            RefreshDisplay(selectedTable);
        }

        private void btnOccupyTable_Click(object sender, EventArgs e)
        {
            // changing the status 
            selectedTable.Status = TableStatus.Occupied;
            // updating in database
            tableService.UpdateTheStatusOfTable(selectedTable);
            // refreshing the tab
            RefreshDisplay(selectedTable);
        }

        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(selectedTable,employee);
            orderForm.Show();
            this.Close();
            orderForm.BringToFront();
            orderForm.StartPosition = this.StartPosition;
            orderForm.Location = this.Location;
            orderForm.Top = this.Top;
        }
        private string JustDisplay(OrderItem orderItem)
        {
            string message = "";
            switch (orderItem.OrderState)
            {
                case OrderItemState.OrderServed:
                    message = "Served";
                    break;
                case OrderItemState.ReadyToDeliver:
                    message = "Ready";
                    break;
                case OrderItemState.PreparingOrder:
                    message = "Preparing";
                    break;
                case OrderItemState.RunningOrder:
                    message = "Running";
                    break;
            }
           return message;
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            UI.Payment payment = new Payment(selectedTable, employee);
            payment.Show();
            this.Close();
            payment.BringToFront();
            payment.StartPosition = this.StartPosition;
            payment.Location = this.Location;
            payment.Top = this.Top;
        }
        private void SetColorForButtons(Button btn)
        {
            if (!btn.Enabled)
            {
                btn.BackColor = Color.Gray;
            }
        }
        private void SetEnabledColor(Button button)
        {
            if (button==btnMarkAsServed)
            {
                button.BackColor = btnMarkASServedColor;
            }else if (button == btnTakeOrder)
            {
                button.BackColor =btnTakeorderColor;
            }
            else if (button == BtnCheckout)
            {
                button.BackColor = btnCheckoutColor;
            }
            else if(button == btnOccupyTable)
            {
                button.BackColor = btnoccupyTableColor;
            }
        }

        private void btnMakeTableFree_Click_1(object sender, EventArgs e)
        {
            selectedTable.Status = TableStatus.Free;
            tableService.UpdateTheStatusOfTable(selectedTable);
            RefreshDisplay(selectedTable);
        }
    }
}
