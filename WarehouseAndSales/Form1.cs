﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAndSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            DataTable dt =  BAL.LogIn(username.Text, password.Text);
            if (dt.Rows.Count > 0)
            {
                Home home = new Home();
                home.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show("الرجاء التاكد من صحة المعلومات المدخلة.");


            }


        }
    }
}
