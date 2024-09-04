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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            DataTable dt = BAL.GetAllSales();
            SalesDG.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            SalesEditor salesEditor = new SalesEditor();
            salesEditor.Show();
            this.Close();

        }

        private void SalesDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SalesDG.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {

                DataGridViewButtonCell btn = (DataGridViewButtonCell)SalesDG.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (btn.Value.Equals("تعديل"))
                {



                    int ID = Convert.ToInt32(SalesDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    SalesEditor.ID = ID;
                    SalesEditor.Edit = true;
                    SalesEditor salesEditor = new SalesEditor();
                    salesEditor.Show();
                    this.Close();


                }


            }
        }
    }
}
