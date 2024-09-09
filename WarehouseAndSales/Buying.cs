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
    public partial class Buying : Form
    {
        public static string From = "";
        public static int WarehouseID = 0;
        public static int MatID = 0;
        public Buying()
        {
            InitializeComponent();
            DataTable dt = BAL.GetAllBuying();
            buyingDG.DataSource = dt;
        }

        private void matsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewButtonCell btn = (DataGridViewButtonCell)buyingDG.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (btn.Value.Equals("تعديل"))
            {



                MatID = Convert.ToInt32(buyingDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());


                BuyingEditor.ID = MatID;
                BuyingEditor bb = new BuyingEditor();
                bb.Show();
                this.Hide();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void Return_Click(object sender, EventArgs e)
        {

          
                Home home = new Home();
                home.Show();
                this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuyingEditor.ID = 0;
            BuyingEditor buyingEditor = new BuyingEditor();
            buyingEditor.Show();
            this.Hide();
        }
    }
}
