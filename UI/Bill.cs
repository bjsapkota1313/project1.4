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
    public partial class Bill : Form
    {

        //private OrderService orderService;
        //private Order order;
        private int id;
        public Bill(int id)
        {
            InitializeComponent();

            //order = orderService.SearchByID(id);
            this.id = id;

            string[] menuItems = { "Food", "Drinks" };
            checkedListBill.Items.AddRange(menuItems);

            checkedListBill.CheckOnClick = true;
            checkedListBill.ItemCheck += new ItemCheckEventHandler(this.checkedListBill_ItemCheck);
            btnSelectAll.Click += new EventHandler(btnSelectAll_Click); //Adding handler for button click event
            //btnPay.Click += new EventHandler(btnPay_Click);

        }

        private void btnSelectAll_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < checkedListBill.Items.Count; i++)
            {
                checkedListBill.SetItemChecked(i, true);
            }
        }

        //private void btnPay_Click(object sender, System.EventArgs e)
        //{
        //    var frm = new Payment(id);
        //    frm.Location = this.Location;
        //    frm.StartPosition = FormStartPosition.Manual;
        //    frm.FormClosing += delegate { this.Show(); };
        //    frm.Show();
        //    this.Hide();
        //}

        // Activates the move button if there are checked items.
        private void checkedListBill_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                if (checkedListBill.CheckedItems.Count == 1)
                {
                    btnPay.Enabled = true;
                }
            }
            else
            {
                btnPay.Enabled = false;
            }
        }


    }
}
