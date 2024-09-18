using System;
using ESC_POS_USB_NET.Printer;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = iTextSharp.text.Rectangle;
using Font = iTextSharp.text.Font;
using System.IO;
using ImageMagick;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace WarehouseAndSales
{
    public partial class Sales : Form
    {
        string kitchenPName = "";

        Printer Kprinter;

        public Sales()
        {
            InitializeComponent();
            DataTable dt = BAL.GetAllSales();
            SalesDG.DataSource = dt;


            
            SalesDG.Columns["ID"].Visible = false;


        }
        public void ReadPrintersStatsAndNames()
        {



          
            using (StreamReader readtext = new StreamReader("p2.txt"))
            {
                kitchenPName = readtext.ReadLine();

            }










        }
        private void button1_Click(object sender, EventArgs e)
        {
            SalesEditor.MatID = 0;
            SalesEditor.Edit = false;
            SalesEditor salesEditor = new SalesEditor();
            salesEditor.Show();
            this.Hide();

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
                    this.Hide();


                }  else if (btn.Value.Equals("الدفعات"))
                {



                    int ID = Convert.ToInt32(SalesDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    Payments.RecID = ID;
                    Payments.PaymentType = "Income";
                    Payments pp = new Payments();
                    pp.Show();
                    this.Hide();


                }
              


            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
