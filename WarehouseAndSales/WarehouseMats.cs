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
    public partial class WarehouseMats : Form
    {
        public static int WarehouseID = 0;
        public static int MatID = 0;

        public WarehouseMats()
        {
            InitializeComponent();
            if (WarehouseID != 0) { 
            DataTable dt = BAL.GetMatsOfAWarehouse(WarehouseID);

                warehousesMatsDG.DataSource= dt;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatSelector.FromAddingMatToWarehouse = true;
            MatSelector.WarehouseID = WarehouseID;
            MatSelector.Action = "ايداع";
            MatSelector matsSelector = new MatSelector();
            matsSelector.Show();
            this.Close();
        }
    }
}
