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
    public partial class WarehouseSelector : Form
    {
        public static string From = "";
        public static int toWarehouseID = 0;
        public static int fromWarehouseID = 0;
        public static int MatID = 0;
        public static string Action = "";
        public WarehouseSelector()
        {
            InitializeComponent();
            DataTable dt = BAL.GetAllWarehouses();
           warehousesDG.DataSource = dt;
        }

        private void warehousesDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fromWarehouseID = Convert.ToInt32(warehousesDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            if (From.Equals("WithdrawFromAnotherWarehosue"))
            {



                MatSelector.WarehouseID = toWarehouseID;
                MatSelector.fromWarehouseID= fromWarehouseID;
                MatSelector.selectMatFromWarehouse = true;
                MatSelector.Action = Action;
                MatSelector.From = From;
                MatSelector matSelector = new MatSelector();

                matSelector.Show();
                this.Close();





            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
