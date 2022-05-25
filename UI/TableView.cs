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
            FillTable(tables, LabelsDictionary());
        }
        private void ChangingTheStatusOfTable(Table table, Label lblTableNumber)
        {
            // using switch so that later on if table more status can be changed easily
            switch (table.Status)
            {
                case TableStatus.Reserved:
                    lblTableNumber.ForeColor = Color.Red;
                    break;
                case TableStatus.Unreserved:
                    lblTableNumber.ForeColor = Color.White;
                    break;
            }
        }
        private void FillTable(List<Table> tables, Dictionary<string, Label> labelsDictionary)
        {
            for (int i = 0; i < tables.Count; i++)
            {
                string labelName = "lblTableNr" + $"{i + 1}";
                ChangingTheStatusOfTable(tables[i], labelsDictionary[labelName]);
            }
        }
        private Dictionary<string,Label> LabelsDictionary()
        {
            Dictionary<string, Label> listOfLabel = new Dictionary<string, Label>();
            listOfLabel.Add("lblTableNr1", lblTableNr1);
            listOfLabel.Add("lblTableNr2", lblTableNr2);
            listOfLabel.Add("lblTableNr3", lblTableNr3);
            listOfLabel.Add("lblTableNr4", lblTableNr4);
            listOfLabel.Add("lblTableNr5", lblTableNr5);
            listOfLabel.Add("lblTableNr6", lblTableNr6);
            listOfLabel.Add("lblTableNr7", lblTableNr7);
            listOfLabel.Add("lblTableNr8", lblTableNr8);
            listOfLabel.Add("lblTableNr9", lblTableNr9);
            listOfLabel.Add("lblTableNr10", lblTableNr10);
            return listOfLabel; 
        }

        

       
    }
}
