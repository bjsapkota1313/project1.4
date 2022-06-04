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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UI
{
    public partial class TableView : Form
    {
        private TableService tableService;
        private OrderService orderService;
        private Dictionary<string, PictureBox> dictionaryForPictureBoxDrink; 
        private Dictionary<string, PictureBox> dictionaryForPictureBoxFood; 
        public TableView()
        {
            InitializeComponent();

            tableService = new TableService();
            orderService = new OrderService();  
            List<Table> tables= tableService.GetAllTables();
            //Order order= new Order();
            //order.Table.Number = 1;
            //order.PayementStatus = 0;
           dictionaryForPictureBoxDrink= FillingDictionaryOfPictureBoxForDrink();
            dictionaryForPictureBoxFood= FillingDictionaryofPictureBoxForFood();

           // Order getOrder = orderService.GetOrderForSpecificTableWhichisNotPaidYet(2, PayementStatus.UnPaid);

            // List<OrderItem> items = orderService.ListOfOrderItemsInOneOrder(6);

            DisplayTables(tables, ButtonsDictionary());
           // DoSomething(GetOrder.OrderItems);
            //picBoxDishTable1.BackColor = BtnTableNumber1.BackColor;
            //  picBoxDishTable1.Image = Properties.Resources.ReadyToServed;
            //pictureBox21.BackColor = BtnTableNumber2.BackColor;
            ////pictureBox21.Image = null;
            //pictureBox21.Hide();
            //picBoxDrinkTable1.Image = Properties.Resources.prepDrink3030;


        }
        private void DisplayingTheStatusOfTable(Table table, Button btnTable)
        {
            // using switch so that later on if table more status can be changed easily
            switch (table.Status)
            {
                case TableStatus.Reserved:
                    btnTable.BackColor = Color.DarkRed;
                    break;
                case TableStatus.Unreserved:
                    btnTable.BackColor = Color.FromArgb(67, 165, 51);
                    break;
                case TableStatus.Occupied:
                    btnTable.BackColor = Color.FromArgb(172, 115, 73);
                    break;
            }
        }
        private void DisplayTables(List<Table> tables, Dictionary<string, Button> labelsDictionary)
        {
            for (int i = 0; i < tables.Count; i++)
            {
                string PicboxnameForDrink = "PicBoxDrinkForTable" +$"{i+1}";
                string PicboxnameForFood = "PicBoxFoodForTable" + $"{i+1}";
                string buttonName = "BtnTableNumber" + $"{i+1}";
                DisplayingTheStatusOfTable(tables[i], labelsDictionary[buttonName]);
                // always getting the unpaid order and using the button's text   which have table number   
                Order getOrder = orderService.GetOrderForSpecificTableWhichisNotPaidYet(int.Parse(labelsDictionary[buttonName].Text),PayementStatus.UnPaid);
                // setting up the color of picbox with their respective table status color
                dictionaryForPictureBoxDrink[PicboxnameForDrink].BackColor = labelsDictionary[buttonName].BackColor;
                dictionaryForPictureBoxFood[PicboxnameForFood].BackColor = labelsDictionary[buttonName].BackColor;
                ChangeTheStatusOfOrderInTable(getOrder.OrderItems, dictionaryForPictureBoxDrink[PicboxnameForDrink], dictionaryForPictureBoxFood[PicboxnameForFood]);
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
        private void ChangeTheStatusOfOrderInTable(List<OrderItem> items, PictureBox pictureBoxDrink, PictureBox pictureBoxFood)
        {
            if (items.Count == 0)
            {
                pictureBoxFood.Hide();
                 pictureBoxDrink.Hide();
            }
            else
            {
                foreach (OrderItem item in items)
                {
                    if (item.MenuItem.TypeMenuItem == TypeMenuItem.Drink)
                    {
                        ChangingtheStatusOfDrink(item, pictureBoxDrink);
                        
                    }
                    else 
                    {
                        ChangingtheStatusOfFood(item, pictureBoxFood);
                    }
                }
            }
        }
        private void ChangingtheStatusOfDrink(OrderItem orderItem,PictureBox pictureBox)
        {
            switch (orderItem.OrderState)
            {
                case OrderState.PreparingOrder:
                    pictureBox.Image = Properties.Resources.prepDrink3030;
                    break;
                case OrderState.ReadyToDeliver:
                    pictureBox.Image = Properties.Resources.ReadyToBeServedDrink30x30;
                    break;
                case OrderState.RunningOrder:
                    pictureBox.Image = Properties.Resources.GotOrder;
                    break;
                    default:
                    pictureBox.Hide();
                    break;
            }
        }
        private void ChangingtheStatusOfFood(OrderItem orderItem, PictureBox pictureBox)
        {
            switch (orderItem.OrderState)
            {
                case OrderState.PreparingOrder:
                    pictureBox.Image = Properties.Resources.prepOrder3030;
                    break;
                case OrderState.ReadyToDeliver:
                    pictureBox.Image = Properties.Resources.OrderRunning3030;
                    break;
                case OrderState.RunningOrder:
                    pictureBox.Image = Properties.Resources.RunningOrder3030;
                    break;
                default:
                    pictureBox.Hide();
                    break;
               
            }
        }
        // Getting the table from database 
        private Table GetDesireTable(int TableNr)
        {
           return  tableService.SearchTable(TableNr);
        }
        private Dictionary<string,PictureBox> FillingDictionaryOfPictureBoxForDrink()
        {
            Dictionary<string,PictureBox> dictionaryPicBoxDrink = new Dictionary<string,PictureBox>();
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
        private Dictionary<string,PictureBox> FillingDictionaryofPictureBoxForFood()
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
        // opening each selected table to see its 

        private void BtnTableNumber1_Click(object sender, EventArgs e)
        {
            
             OpenEachTableDisplay(orderService.GetOrderForSpecificTableWhichisNotPaidYet(int.Parse(BtnTableNumber1.Text), PayementStatus.UnPaid),GetDesireTable(int.Parse(BtnTableNumber1.Text)));
        }

        private void BtnTableNumber2_Click(object sender, EventArgs e)
        {
                OpenEachTableDisplay(orderService.GetOrderForSpecificTableWhichisNotPaidYet(int.Parse(BtnTableNumber2.Text), PayementStatus.UnPaid), GetDesireTable(int.Parse(BtnTableNumber2.Text)));
        }

        private void BtnTableNumber3_Click(object sender, EventArgs e)
        {
            OpenEachTableDisplay(orderService.GetOrderForSpecificTableWhichisNotPaidYet(int.Parse(BtnTableNumber3.Text), PayementStatus.UnPaid), GetDesireTable(int.Parse(BtnTableNumber3.Text)));
        }

        private void BtnTableNumber4_Click(object sender, EventArgs e)
        {
             OpenEachTableDisplay(orderService.GetOrderForSpecificTableWhichisNotPaidYet(int.Parse(BtnTableNumber4.Text), PayementStatus.UnPaid), GetDesireTable(int.Parse(BtnTableNumber4.Text)));
        }

        private void BtnTableNumber5_Click(object sender, EventArgs e)
        {

            OpenEachTableDisplay(orderService.GetOrderForSpecificTableWhichisNotPaidYet(int.Parse(BtnTableNumber5.Text), PayementStatus.UnPaid), GetDesireTable(int.Parse(BtnTableNumber5.Text)));
        }

        private void BtnTableNumber6_Click(object sender, EventArgs e)
        {

            OpenEachTableDisplay(orderService.GetOrderForSpecificTableWhichisNotPaidYet(int.Parse(BtnTableNumber6.Text), PayementStatus.UnPaid), GetDesireTable(int.Parse(BtnTableNumber6.Text)));
        }

        private void BtnTableNumber7_Click(object sender, EventArgs e)
        {
            OpenEachTableDisplay(orderService.GetOrderForSpecificTableWhichisNotPaidYet(int.Parse(BtnTableNumber7.Text), PayementStatus.UnPaid), GetDesireTable(int.Parse(BtnTableNumber7.Text)));

        }

        private void BtnTableNumber8_Click(object sender, EventArgs e)
        {
            OpenEachTableDisplay(orderService.GetOrderForSpecificTableWhichisNotPaidYet(int.Parse(BtnTableNumber8.Text), PayementStatus.UnPaid), GetDesireTable(int.Parse(BtnTableNumber8.Text)));
        }

        private void BtnTableNumber9_Click(object sender, EventArgs e)
        {
            OpenEachTableDisplay(orderService.GetOrderForSpecificTableWhichisNotPaidYet(int.Parse(BtnTableNumber9.Text), PayementStatus.UnPaid), GetDesireTable(int.Parse(BtnTableNumber9.Text)));
        }

        private void BtnTableNumber10_Click(object sender, EventArgs e)
        {
            OpenEachTableDisplay(orderService.GetOrderForSpecificTableWhichisNotPaidYet(int.Parse(BtnTableNumber10.Text), PayementStatus.UnPaid), GetDesireTable(int.Parse(BtnTableNumber10.Text)));
        }
        private void OpenEachTableDisplay(Order order,Table table)
        {
            EachTableDisplay eachTableDisplay = new EachTableDisplay(order,table);
            eachTableDisplay.Show();
        }
    }
}