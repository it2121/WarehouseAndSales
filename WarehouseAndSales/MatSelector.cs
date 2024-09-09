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
        public static BuyingEditor buyingForm;
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

            }   if (From.Equals("BuyingEditor"))
            {

                dt = BAL.GetAllMats();
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
                this.Hide();


            }
            else if (From.Equals("WithdrawFromAnotherWarehosue"))
            {


                MatToWarehouseAction.WarehouseID = WarehouseID;
                MatToWarehouseAction.fromWarehouseID = fromWarehouseID;
                MatToWarehouseAction.MatID = MatID;
                MatToWarehouseAction.Action = Action;
                MatToWarehouseAction matToWarehouseAction = new MatToWarehouseAction();
                matToWarehouseAction.Show();
                this.Hide();
            }
            else if (From.Equals("SalesEditor"))
            {


                SalesEditor.MatID = MatID;
                SalesEditor salesEditor = new SalesEditor ();
                salesEditor.Show();
                this.Hide();

            }      else if (From.Equals("BuyingEditor"))
            {


                buyingForm.MatID = MatID;
                buyingForm.setMatName();
                buyingForm.Show();
                this.Hide();

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MatSelector_Load(object sender, EventArgs e)
        {

        }
    }
}
