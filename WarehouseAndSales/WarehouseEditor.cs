using System;
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
    public partial class WarehouseEditor : Form
    {
        public static int ID = 0; 

        public WarehouseEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {

                //insert and go
                BAL.InsertWarehouse(WarehouseName.Text,Note.Text);

                Warehouses warehouses = new Warehouses();
                warehouses.Show();
                this.Hide();

            }
            else
            {
                //update and go

                BAL.UpdateWarehouse(WarehouseName.Text, Note.Text,ID);




                WarehouseMats.WarehouseID = ID;
                WarehouseMats warehouseMats = new WarehouseMats();
                warehouseMats.Show();
                this.Hide();

        
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Warehouses warehouses = new Warehouses();
            warehouses.Show();
            this.Hide();
        }
        private void WarehouseEditor_Load(object sender, EventArgs e)
        {
            if (ID == 0)
            {

                WarehouseName.Text = "";
                Note.Text = "";
                DelBtn.Visible = false; 


            }
            else {

                DataTable dt = BAL.GetWarehouseByID(ID);
               foreach (DataRow dr in dt.Rows)
                {
                    WarehouseName.Text = dr["WarehouseName"].ToString();
                    Note.Text = dr["Notes"].ToString();



                }


                DelBtn.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //del and go
            BAL.DeleteWarehouse(ID);

        }
    }
}
