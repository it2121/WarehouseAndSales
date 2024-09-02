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
        public static string From  = "";
        public static int WarehouseID = 0;
        public static int MatID = 0;
        public static string Action = "";
        public MatSelector()
        {
            InitializeComponent();

            DataTable dt = BAL.GetAllMats();
            matsDG.DataSource = dt;

        }

        private void matsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MatID = Convert.ToInt32(matsDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            if (From.Equals("Deposit") || From.Equals("Withdroaw"))
            {


                MatToWarehouseAction.WarehouseID= WarehouseID;
                MatToWarehouseAction.MatID= MatID;
                MatToWarehouseAction.Action= Action;
                MatToWarehouseAction matToWarehouseAction = new MatToWarehouseAction();
                matToWarehouseAction.Show();
                this.Close();


            }


        }
    }
}
