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
        public static SalesEditor SailsForm ;
        public static BuyingEditor BuyingForm;
        public  Reports ReportsForm;
        public WarehouseSelector()
        {
            InitializeComponent();
            if (From.Equals("WithdrawFromAnotherWarehosue")) {
                DataTable dt = BAL.GetAllWarehouses();
                warehousesDG.DataSource = dt;
            } else if (From.Equals("AutoSalesWithdraw")) {
                DataTable dt = BAL.GetInstockItemsOfAllWarehousesAndOneMat(MatID);
                warehousesDG.DataSource = dt;


            } else if (From.Equals("AutoBuyingDepo")) {
                DataTable dt = BAL.GetAllWarehouses();
                warehousesDG.DataSource = dt;


            } else if (From.Equals("Reports")) {
                DataTable dt = BAL.GetAllWarehouses();
                warehousesDG.DataSource = dt;


            }
        }

        private void warehousesDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (From.Equals("WithdrawFromAnotherWarehosue"))
            {
                fromWarehouseID = Convert.ToInt32(warehousesDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());



                MatSelector.WarehouseID = toWarehouseID;
                MatSelector.fromWarehouseID= fromWarehouseID;
                MatSelector.selectMatFromWarehouse = true;
                MatSelector.Action = Action;
                MatSelector.From = From;
                MatSelector matSelector = new MatSelector();

                matSelector.Show();
                this.Hide();





            } else  if (From.Equals("AutoSalesWithdraw"))
            {
                fromWarehouseID = Convert.ToInt32(warehousesDG.Rows[e.RowIndex].Cells["WarehouseID"].Value.ToString());
                Global.setWarehousID(fromWarehouseID);
              //  SailsForm.WarehouseID = toWarehouseID;
                SailsForm.Show();
                SailsForm.AutoWithdrawNow();


                this.Hide();





            }
            else  if (From.Equals("AutoBuyingDepo"))
            {
                fromWarehouseID = Convert.ToInt32(warehousesDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                Global.setWarehousID(fromWarehouseID);
              //  SailsForm.WarehouseID = toWarehouseID;
                BuyingForm.Show();
                BuyingForm.AutoDepoNow();


                this.Hide();





            }  else  if (From.Equals("Reports"))
            {
                ReportsForm.WarehouseID = Convert.ToInt32(warehousesDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                ReportsForm.CheckAndSetNames();
                ReportsForm.Show();
               


                this.Hide();






            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WarehouseSelector_Load(object sender, EventArgs e)
        {

        }
    }
}
