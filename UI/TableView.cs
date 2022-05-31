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
        public TableView()
        {
            InitializeComponent();

            tableService = new TableService();
            List<Table> tables= tableService.GetAllTables();

            DisplayTables(tables, ButtonsDictionary());
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
                string buttonName = "BtnTableNumber" + $"{i + 1}";
                DisplayingTheStatusOfTable(tables[i], labelsDictionary[buttonName]);
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


    }
}
