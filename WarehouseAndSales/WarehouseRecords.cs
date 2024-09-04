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
    public partial class WarehouseRecords : Form
    {
        public static int WarehouseID = 0;
        public static int RecordID = 0;
        public WarehouseRecords()
        {
            InitializeComponent();
            if(WarehouseID != 0)
            {

                DataTable dt = BAL.GetAllMatToWarehouseRecords(WarehouseID);
                warehousesRecordsDG.DataSource= dt;

            }
        }

        private void warehousesMatsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (warehousesRecordsDG.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {

                DataGridViewButtonCell btn = (DataGridViewButtonCell)warehousesRecordsDG.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (btn.Value.Equals("تعديل"))
                {



                    RecordID = Convert.ToInt32(warehousesRecordsDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    MatToWarehouseAction.Edit = true;
                    MatToWarehouseAction.WarehouseID = WarehouseID;
                    MatToWarehouseAction.RecordID = RecordID;
                    MatToWarehouseAction.MatID = Convert.ToInt32(warehousesRecordsDG.Rows[e.RowIndex].Cells["MatID"].Value.ToString());
                    MatToWarehouseAction.Action = warehousesRecordsDG.Rows[e.RowIndex].Cells["MovingAction"].Value.ToString();
                    MatToWarehouseAction matToWarehouseAction = new MatToWarehouseAction();
                    matToWarehouseAction.Show();
                    this.Close();


                }


            }



        }
    }
}
