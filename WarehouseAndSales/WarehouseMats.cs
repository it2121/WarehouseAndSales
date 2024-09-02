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
            MatSelector.From = "Deposit";
            MatSelector.WarehouseID = WarehouseID;
            MatSelector.Action = "ايداع";
            MatSelector matsSelector = new MatSelector();
            matsSelector.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void warehousesMatsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (warehousesMatsDG.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {

                DataGridViewButtonCell btn = (DataGridViewButtonCell)warehousesMatsDG.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (btn.Value.Equals("سحب"))




                    MatID = Convert.ToInt32(warehousesMatsDG.Rows[e.RowIndex].Cells["MatID"].Value.ToString());
                MatToWarehouseAction.WarehouseID = WarehouseID;
                MatToWarehouseAction.MatID = MatID;
                MatToWarehouseAction.Action = "سحب";
                MatToWarehouseAction matToWarehouseAction = new MatToWarehouseAction();
                matToWarehouseAction.Show();
                this.Close();




            }
           //MessageBox.Show(warehousesMatsDG.Rows[e.RowIndex].Cells[e.ColumnIndex] .GetType()+ "");

        }
    }
}
