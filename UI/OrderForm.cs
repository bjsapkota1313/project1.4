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

    public partial class OrderForm : Form
    {
        bool control;
        int menu_with;
        public OrderForm()
        {
            InitializeComponent();
            control = false;
            menu_with = hamburgerMenu.Width;

        }
        public void loadform(object Form)
        {
            if(this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

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
                        control = true;
                        this.Refresh();
                        hamburgerMenu.Visible = true;

                    }
         
            }

        }

        private void OrderView_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FoodBtn_Click(object sender, EventArgs e)
        {
            loadform(new StarterForm());
        }

        private void MainCourseBtn_Click(object sender, EventArgs e)
        {
            loadform(new MainCourse());

        }

        private void DessertBtn_Click(object sender, EventArgs e)
        {
            loadform(new StarterForm());
        }
    }
}
