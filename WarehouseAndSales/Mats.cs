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
    public partial class Mats : Form
    {
        public static string From = "";
        public static int WarehouseID = 0;
        public static int MatID = 0;
        public Mats()
        {
            InitializeComponent();


            DataTable dt = BAL.GetAllMats();
            matsDG.DataSource= dt;


        }

        private void warehousesDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (From.Equals("Deposit") || From.Equals("Withdroaw")) { 

            WarehouseMats.WarehouseID = Convert.ToInt32(matsDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            WarehouseMats warehouseMats = new WarehouseMats();
            warehouseMats.Show();
            this.Close();
            }
            else
            {





            }

            


            //MessageBox.Show(matsDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());




        }
    }
}
