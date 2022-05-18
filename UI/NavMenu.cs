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
    public partial class NavMenu : Form
    {
        bool control;
        int menu_with;
        public NavMenu()
        {
            InitializeComponent();
            InitializeComponent();
            control = false;
            menu_with = hamburgerMenu.Width;

        }

        private void NavMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
