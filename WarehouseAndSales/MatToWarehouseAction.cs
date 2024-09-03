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
    public partial class MatToWarehouseAction : Form
    {
        public static int WarehouseID = 0;
        public static int fromWarehouseID = 0;
        public static int MatID = 0;
        public static string Action = "";
        public MatToWarehouseAction()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Action.Equals("سحب") || Action.Equals("ايداع")) { 
            BAL.InsertIntoMatToWarehouses(MatID, WarehouseID, Convert.ToInt32(Quant.Text), MovingDate.Text, Notes.Text, Action);


            WarehouseMats.WarehouseID = WarehouseID;
            WarehouseMats warehouseMats = new WarehouseMats();
            warehouseMats.Show();
            this.Close(); }
            else if (Action.Equals("سحب من مخزن اخر")) {
                string fromWarehouseName = BAL.GetWarehouseName(fromWarehouseID).Rows[0][0].ToString();
                string toWarehouseName = BAL.GetWarehouseName(WarehouseID).Rows[0][0].ToString();
              //سحب من مخزن الى مخزن جديد
                BAL.InsertIntoMatToWarehouses(MatID, fromWarehouseID, Convert.ToInt32(Quant.Text), MovingDate.Text, Notes.Text+" "+ toWarehouseName + " -  سحبت هذه المادة الى المخزن المعنون", "سحب");
              // ايداع الى الخزن الجديد
                BAL.InsertIntoMatToWarehouses(MatID, WarehouseID, Convert.ToInt32(Quant.Text), MovingDate.Text, Notes.Text + " " + fromWarehouseName + " -  سحبت هذه المادة من المخزن المعنون", "ايداع");





                WarehouseMats.WarehouseID = WarehouseID;
                WarehouseMats warehouseMats = new WarehouseMats();
                warehouseMats.Show();
                this.Close();
            


        }

        }
    }
}
