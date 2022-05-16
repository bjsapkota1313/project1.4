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

namespace UI
{
    public partial class TableView : Form
    {
        private TableService service;
        public TableView()
        {
            service = new TableService();
            InitializeComponent();
        }
    }
}
