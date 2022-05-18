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

    public partial class OrderView : Form
    {
        bool control;
        int menu_with;
        public OrderView()
        {
            InitializeComponent();
            control = false;
            menu_with = hamburgerMenu.Width;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
                    control=true;
                    this.Refresh();
                }
            }
        }

        private void OrderView_Load(object sender, EventArgs e)
        {

        }
    }
}
