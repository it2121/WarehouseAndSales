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
    public partial class MatSelector : Form
    {
        public static string From = "";
        public static int WarehouseID = 0;
        public static int fromWarehouseID = 0;
        public static int MatID = 0;
        public static string Action = "";
        public static bool selectMatFromWarehouse = false;
        public MatSelector()
        {
            InitializeComponent();
            DataTable dt;
            if (!selectMatFromWarehouse)
            {
                dt = BAL.GetAllMats();
            }
            else
            {

                dt = BAL.GetAllRemMatsOfAWarehouse(fromWarehouseID);
                selectMatFromWarehouse = false;

            }   
            
            
            if (From.Equals("SalesEditor"))
            {

                dt = BAL.GetAllItemsWithInStock();
                dt = Helper.RemoveDuplicateRows(dt, "ID");

            }

            matsDG.DataSource = dt;

        }

        private void matsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MatID = Convert.ToInt32(matsDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            if (From.Equals("Deposit") || From.Equals("Withdroaw"))
            {


                MatToWarehouseAction.WarehouseID = WarehouseID;
                MatToWarehouseAction.MatID = MatID;
                MatToWarehouseAction.Action = Action;
                MatToWarehouseAction matToWarehouseAction = new MatToWarehouseAction();
                matToWarehouseAction.Show();
                this.Close();


            }
            else if (From.Equals("WithdrawFromAnotherWarehosue"))
            {


                MatToWarehouseAction.WarehouseID = WarehouseID;
                MatToWarehouseAction.fromWarehouseID = fromWarehouseID;
                MatToWarehouseAction.MatID = MatID;
                MatToWarehouseAction.Action = Action;
                MatToWarehouseAction matToWarehouseAction = new MatToWarehouseAction();
                matToWarehouseAction.Show();
                this.Close();
            }
            else if (From.Equals("SalesEditor"))
            {


                SalesEditor.MatID = MatID;
                SalesEditor salesEditor = new SalesEditor ();
                salesEditor.Show();
                this.Close();

            }


        }
    }
}
