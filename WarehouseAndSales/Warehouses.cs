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
            WarehouseEditor.ID = 0;
               WarehouseEditor warehouseEditor = new WarehouseEditor();
            warehouseEditor.Show();
            this.Hide();
        }

        private void warehousesDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            WarehouseMats.WarehouseID = Convert.ToInt32(warehousesDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            WarehouseMats warehouseMats = new WarehouseMats();
            warehouseMats.Show();
            this .Hide();


            //MessageBox.Show(warehousesDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());


        }

        private void Return_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
