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
            BAL.InsertIntoMatToWarehouses(MatID, WarehouseID, Convert.ToInt32(Quant.Text), MovingDate.Text, Notes.Text, Action);


            WarehouseMats.WarehouseID = WarehouseID;
            WarehouseMats warehouseMats = new WarehouseMats();
            warehouseMats.Show();
            this.Close();

        }
    }
}
