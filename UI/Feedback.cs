﻿using System;
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
using System.Data.SqlClient;


namespace UI
{
    public partial class AddFeedback : Form
    {
        private OrderService orderService;
        private Order order;


        public AddFeedback()
        {
            InitializeComponent();

            btnSubmit.Click += new EventHandler(btnSubmit_Click);
        }
        private void btnSubmit_Click(object sender, System.EventArgs e)
        {
            orderService.AddFeedback(order);

            LoadNewForm(new Payment());
            
        }
        private void LoadNewForm(object Form)
        {
            Form frm = Form as Form;
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    } }