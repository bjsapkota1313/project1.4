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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UI
{
    public partial class TableView : Form
    {
        private Employee loggedEmployee;
        private TableService tableService;
        private OrderService orderService;
        private Dictionary<string, PictureBox> dictionaryForPictureBoxDrink;
        private Dictionary<string, PictureBox> dictionaryForPictureBoxFood;
        private Dictionary<string, PictureBox> dictionaryForPictureBoxLate;
        private Dictionary<string, Button> dictionaryForButton;
        public TableView(Employee loggedEmployee)
        {
            InitializeComponent();
            this.loggedEmployee = loggedEmployee;
            tableService = new TableService();
            orderService = new OrderService();
            List<Table> tables = tableService.GetAllTables();

            // getting logged employee name 
            lblEmployeeName.Text = loggedEmployee.FullName;
            lblEmployeeId.Text=$"{loggedEmployee.Id}@Chapeau.nl";    
            // Filling all the dictionaries that i will be using 
            dictionaryForPictureBoxDrink = FillingDictionaryOfPictureBoxForDrink();
            dictionaryForPictureBoxFood = FillingDictionaryofPictureBoxForFood();
            dictionaryForButton = ButtonsDictionary();
            dictionaryForPictureBoxLate = FillingDictionaryofPictureBoxForLateServing();
            pnlLegenda.Visible = false;
            pnlLogOut.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();  
            label8.Hide();


            // filling up the diplays with notification color everything
            DisplayTables(tables);
        }
        private void DisplayingTheStatusOfTable(Table table, Button btnTable)
        {
            // using switch so that later on if table more status can be changed easily
            switch (table.Status)
            {
                case TableStatus.Reserved:
                    btnTable.BackColor = Color.FromArgb(210,83,43);
                    break;
                case TableStatus.Free:
                    btnTable.BackColor = Color.FromArgb(117, 154, 40);
                    break;
                case TableStatus.Occupied:
                    btnTable.BackColor = Color.FromArgb(229, 160, 96);
                    break;
            }
        }
        private void DisplayTables(List<Table> tables)
        {
            for (int i = 0; i < tables.Count; i++)
            {
                string PicboxNameForDrink = "PicBoxDrinkForTable" + $"{i + 1}";
                string PicboxNameForFood = "PicBoxFoodForTable" + $"{i + 1}";
                string buttonName = "BtnTableNumber" + $"{i + 1}";
                string picboxNameForLateServing = "PicBoxFoodForTable" + $"{i + 1}";

                DisplayingTheStatusOfTable(tables[i], dictionaryForButton[buttonName]);

                // always getting the unpaid orderItems and using the button's text   which have table number   
                List<OrderItem> getOrderItems = orderService.ListOfOrderItemsInSelectedTable(tables[i], PayementStatus.UnPaid);

                // setting up the color of picbox with their respective table status color
                dictionaryForPictureBoxDrink[PicboxNameForDrink].BackColor = dictionaryForButton[buttonName].BackColor;
                dictionaryForPictureBoxFood[PicboxNameForFood].BackColor = dictionaryForButton[buttonName].BackColor;
                dictionaryForPictureBoxLate[picboxNameForLateServing].BackColor = dictionaryForButton[buttonName].BackColor;

                ChangeTheNotificationsfOrderInTable(getOrderItems, dictionaryForPictureBoxDrink[PicboxNameForDrink], dictionaryForPictureBoxFood[PicboxNameForFood], dictionaryForPictureBoxLate[picboxNameForLateServing]);
            }
        }
        private Dictionary<string, Button> ButtonsDictionary()
        {
            Dictionary<string, Button> listOfLabel = new Dictionary<string, Button>();
            listOfLabel.Add("BtnTableNumber1", BtnTableNumber1);
            listOfLabel.Add("BtnTableNumber2", BtnTableNumber2);
            listOfLabel.Add("BtnTableNumber3", BtnTableNumber3);
            listOfLabel.Add("BtnTableNumber4", BtnTableNumber4);
            listOfLabel.Add("BtnTableNumber5", BtnTableNumber5);
            listOfLabel.Add("BtnTableNumber6", BtnTableNumber6);
            listOfLabel.Add("BtnTableNumber7", BtnTableNumber7);
            listOfLabel.Add("BtnTableNumber8", BtnTableNumber8);
            listOfLabel.Add("BtnTableNumber9", BtnTableNumber9);
            listOfLabel.Add("BtnTableNumber10", BtnTableNumber10);
            return listOfLabel;
        }
        private void ChangeTheNotificationsfOrderInTable(List<OrderItem> items, PictureBox pictureBoxDrink, PictureBox pictureBoxFood, PictureBox pictureBoxLateServing)
        {
            if (items.Count == 0)
            {
                pictureBoxFood.Hide();
                pictureBoxDrink.Hide();
                pictureBoxLateServing.Hide();
            }
            else
            {
                foreach (OrderItem item in items)
                {
                    DisplayNotification(item,  pictureBoxFood,  pictureBoxLateServing,  pictureBoxDrink);
                    //if (item.MenuItem.TypeMenuItem == TypeMenuItem.Drink)
                    //{
                    //    ChangingtheStatusOfDrink(item, pictureBoxDrink, pictureBoxLateServing);

                    //}
                    //else
                    //{
                    //    ChangingtheStatusOfFood(item, pictureBoxFood, pictureBoxLateServing);
                    //}
                }
            }
        }
        private void ChangingtheStatusOfDrink(OrderItem orderItem, PictureBox pictureBox, PictureBox pictureBoxLateServing)
        {
            pictureBox.Show();
            pictureBoxLateServing.Show();
            switch (orderItem.OrderState)
            {
                case OrderItemState.PreparingOrder:
                    pictureBox.Image = Properties.Resources.PrepCoffee5050;
                    pictureBoxLateServing.Hide();
                    break;

                case OrderItemState.ReadyToDeliver:
                    pictureBox.Image = Properties.Resources.coffeeReadyToDeliver;
                    if (CheckTimeForReadyToDeliverStatus(orderItem))
                    {
                        pictureBoxLateServing.Image = Properties.Resources.BellNotification;
                    }
                    else
                    {
                        pictureBoxLateServing.Hide();
                    }
                    break;
                case OrderItemState.RunningOrder:
                    pictureBox.Image = Properties.Resources.CoffeeRunning5050;
                    pictureBoxLateServing.Hide();
                    break;
                default:
                    pictureBox.Hide();
                    pictureBoxLateServing.Hide();
                    break;
            }
        }
        private bool CheckTimeForReadyToDeliverStatus(OrderItem orderItem)
        {
            TimeSpan dateTime = DateTime.Now.Subtract(orderItem.DateTime);
            // supposing that restaurant waitier should serve the rady order in 5 minutes  
            return dateTime.Minutes > 5;
        }
        private void DisplayNotification(OrderItem orderItem, PictureBox pictureBoxFood, PictureBox pictureBoxLateServing,PictureBox pictureBoxDrink)
        {

            if ( orderItem.MenuItem.TypeMenuItem== TypeMenuItem.Food && orderItem.OrderState==OrderItemState.ReadyToDeliver)
            {
                pictureBoxFood.Show();
                pictureBoxLateServing.Show();
                pictureBoxFood.Image = Properties.Resources.FoodReadyToDeliver50502;
                pictureBoxLateServing.Image= Properties.Resources.BellNotification;
                //pictureBoxDrink.Hide();
            }
            else if (orderItem.MenuItem.TypeMenuItem == TypeMenuItem.Drink && orderItem.OrderState == OrderItemState.ReadyToDeliver)
            {
                pictureBoxDrink.Show();
                pictureBoxLateServing.Show();
                pictureBoxLateServing.Image = Properties.Resources.BellNotification;
                pictureBoxDrink.Image= Properties.Resources.newDrinkReady;
                // pictureBoxFood.Image = Properties.Resources.FoodReadyToDeliver50502;
               // pictureBoxFood.Hide();
            }
            else
            {
                pictureBoxDrink.Hide();
                pictureBoxFood.Hide();
                pictureBoxLateServing.Hide();
            }
        }
        private void ChangingtheStatusOfFood(OrderItem orderItem, PictureBox pictureBox, PictureBox pictureBoxLateServing)
        {
            pictureBox.Show();
            pictureBoxLateServing.Show();   
            switch (orderItem.OrderState)
            {
                case OrderItemState.PreparingOrder:
                    pictureBox.Image = Properties.Resources.PrepOrder5050;
                    pictureBoxLateServing.Hide(); // Need to find a way to remove this duplicate code 
                    break;
                case OrderItemState.ReadyToDeliver:
                    pictureBox.Image = Properties.Resources.ReadyToDeliver5050;
                    if (CheckTimeForReadyToDeliverStatus(orderItem))
                    {
                        pictureBoxLateServing.Image = Properties.Resources.BellNotification;
                    }
                    else
                    {
                        pictureBoxLateServing.Hide();
                    }
                    break;
                case OrderItemState.RunningOrder:
                    pictureBox.Image = Properties.Resources.RunningOrder5050;
                    pictureBoxLateServing.Hide();
                    break;
                default:
                    pictureBox.Hide();
                    pictureBoxLateServing.Hide();
                    break;
            }
        }
        // Getting the table from database using this method because the list of table is only got when constructor is called 
        private Table GetDesireTable(int TableNr)
        {
            return tableService.SearchTable(TableNr);
        }
        private Dictionary<string, PictureBox> FillingDictionaryOfPictureBoxForDrink()
        {
            Dictionary<string, PictureBox> dictionaryPicBoxDrink = new Dictionary<string, PictureBox>();
            dictionaryPicBoxDrink.Add("PicBoxDrinkForTable1", picBoxDrinkTable1);
            dictionaryPicBoxDrink.Add("PicBoxDrinkForTable2", picBoxDrinkTable2);
            dictionaryPicBoxDrink.Add("PicBoxDrinkForTable3", picBoxDrinkTable3);
            dictionaryPicBoxDrink.Add("PicBoxDrinkForTable4", picBoxDrinkTable4);
            dictionaryPicBoxDrink.Add("PicBoxDrinkForTable5", picBoxDrinkTable5);
            dictionaryPicBoxDrink.Add("PicBoxDrinkForTable6", picBoxDrinkTable6);
            dictionaryPicBoxDrink.Add("PicBoxDrinkForTable7", picBoxDrinkTable7);
            dictionaryPicBoxDrink.Add("PicBoxDrinkForTable8", picBoxDrinkTable8);
            dictionaryPicBoxDrink.Add("PicBoxDrinkForTable9", picBoxDrinkTable9);
            dictionaryPicBoxDrink.Add("PicBoxDrinkForTable10", picBoxDrinkTable10);
            return dictionaryPicBoxDrink;
        }
        private Dictionary<string, PictureBox> FillingDictionaryofPictureBoxForFood()
        {
            Dictionary<string, PictureBox> dictionaryPicBoxFood = new Dictionary<string, PictureBox>();
            dictionaryPicBoxFood.Add("PicBoxFoodForTable1", picBoxFoodTable1);
            dictionaryPicBoxFood.Add("PicBoxFoodForTable2", picBoxFoodTable2);
            dictionaryPicBoxFood.Add("PicBoxFoodForTable3", picBoxFoodTable3);
            dictionaryPicBoxFood.Add("PicBoxFoodForTable4", picBoxFoodTable4);
            dictionaryPicBoxFood.Add("PicBoxFoodForTable5", picBoxFoodTable5);
            dictionaryPicBoxFood.Add("PicBoxFoodForTable6", picBoxFoodTable6);
            dictionaryPicBoxFood.Add("PicBoxFoodForTable7", picBoxFoodTable7);
            dictionaryPicBoxFood.Add("PicBoxFoodForTable8", picBoxFoodTable8);
            dictionaryPicBoxFood.Add("PicBoxFoodForTable9", picBoxFoodTable9);
            dictionaryPicBoxFood.Add("PicBoxFoodForTable10", picBoxFoodTable10);
            return dictionaryPicBoxFood;
        }
        private Dictionary<string, PictureBox> FillingDictionaryofPictureBoxForLateServing()
        {
            Dictionary<string, PictureBox> dictioDictionaryofPictureBoxForLateServing = new Dictionary<string, PictureBox>();
            dictioDictionaryofPictureBoxForLateServing.Add("PicBoxFoodForTable1", PicBoxLateTable1);
            dictioDictionaryofPictureBoxForLateServing.Add("PicBoxFoodForTable2", PicBoxLateTable2);
            dictioDictionaryofPictureBoxForLateServing.Add("PicBoxFoodForTable3", PicBoxLateTable3);
            dictioDictionaryofPictureBoxForLateServing.Add("PicBoxFoodForTable4", PicBoxLateTable4);
            dictioDictionaryofPictureBoxForLateServing.Add("PicBoxFoodForTable5", PicBoxLateTable5);
            dictioDictionaryofPictureBoxForLateServing.Add("PicBoxFoodForTable6", PicBoxLateTable6);
            dictioDictionaryofPictureBoxForLateServing.Add("PicBoxFoodForTable7", PicBoxLateTable7);
            dictioDictionaryofPictureBoxForLateServing.Add("PicBoxFoodForTable8", PicBoxLateTable8);
            dictioDictionaryofPictureBoxForLateServing.Add("PicBoxFoodForTable9", PicBoxLateTable9);
            dictioDictionaryofPictureBoxForLateServing.Add("PicBoxFoodForTable10", PicBoxLateTable10);
            return dictioDictionaryofPictureBoxForLateServing;
        }
        // opening each selected table to see its 

        private void BtnTableNumber1_Click(object sender, EventArgs e)
        {

            OpenEachTableDisplay(GetDesireTable(int.Parse(BtnTableNumber1.Text)));
        }

        private void BtnTableNumber2_Click(object sender, EventArgs e)
        {
            OpenEachTableDisplay(GetDesireTable(int.Parse(BtnTableNumber2.Text)));
        }

        private void BtnTableNumber3_Click(object sender, EventArgs e)
        {
            OpenEachTableDisplay(GetDesireTable(int.Parse(BtnTableNumber3.Text)));
        }

        private void BtnTableNumber4_Click(object sender, EventArgs e)
        {
            OpenEachTableDisplay(GetDesireTable(int.Parse(BtnTableNumber4.Text)));
        }

        private void BtnTableNumber5_Click(object sender, EventArgs e)
        {

            OpenEachTableDisplay(GetDesireTable(int.Parse(BtnTableNumber5.Text)));
        }

        private void BtnTableNumber6_Click(object sender, EventArgs e)
        {

            OpenEachTableDisplay(GetDesireTable(int.Parse(BtnTableNumber6.Text)));
        }

        private void BtnTableNumber7_Click(object sender, EventArgs e)
        {
            OpenEachTableDisplay(GetDesireTable(int.Parse(BtnTableNumber7.Text)));

        }

        private void BtnTableNumber8_Click(object sender, EventArgs e)
        {
            OpenEachTableDisplay(GetDesireTable(int.Parse(BtnTableNumber8.Text)));
        }

        private void BtnTableNumber9_Click(object sender, EventArgs e)
        {
            OpenEachTableDisplay(GetDesireTable(int.Parse(BtnTableNumber9.Text)));
        }

        private void BtnTableNumber10_Click(object sender, EventArgs e)
        {
            OpenEachTableDisplay(GetDesireTable(int.Parse(BtnTableNumber10.Text)));
        }
        private void OpenEachTableDisplay(Table table)
        {
            EachTableDisplay eachTableDisplay = new EachTableDisplay(table, loggedEmployee);
            eachTableDisplay.Show();
            FormAppearnce(eachTableDisplay);
        }

        private void TimerForTableView_Tick(object sender, EventArgs e)
        {
            // refreshing it in timers interval
            DisplayTables(tableService.GetAllTables());
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
           // DialogResult dialog = MessageBox.Show("Are you sure you want to log out?", "Log out",MessageBoxButtons.YesNo);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            FormAppearnce(loginForm);
            this.Close();
        }

        private void FormAppearnce(Form loginForm)
        {
            loginForm.StartPosition= FormStartPosition.Manual;  
            loginForm.Location = this.Location;
            loginForm.Top = this.Top;
            loginForm.Left=this.Left;
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlLegenda.Visible = true;
           // pnlLegenda.Show();
           
        }

        private void TableView_Click(object sender, EventArgs e)
        {
            pnlLegenda.Hide();
            pnlLogOut.Hide();
        }

        private void picBoxProfilePic_Click(object sender, EventArgs e)
        {
            pnlLogOut.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlLegenda.Hide();
        }
    }
}