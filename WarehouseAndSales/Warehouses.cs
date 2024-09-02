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
    public partial class Warehouses : Form
    {
        public Warehouses()
        {
            InitializeComponent();

            DataTable dt =  BAL.GetAllWarehouses();

            warehousesDG.DataSource = dt;
            warehousesDG.Columns["ID"].Visible= false;
  
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void warehousesDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            WarehouseMats.WarehouseID = Convert.ToInt32(warehousesDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            WarehouseMats warehouseMats = new WarehouseMats();
            warehouseMats.Show();
            this .Close();


            //MessageBox.Show(warehousesDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());


        }
    }
}
