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

            matsDG.Columns["ID"].Visible = false;
        }

        private void warehousesDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
            DataGridViewButtonCell btn = (DataGridViewButtonCell)matsDG.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (btn.Value.Equals("تعديل"))
            {



                MatID = Convert.ToInt32(matsDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());
      

                MatsEditor.MatID = MatID;
                MatsEditor matsEditor = new MatsEditor();
                matsEditor.Show();
                this.Hide();
            }
            

            //MessageBox.Show(matsDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());




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

        private void Mats_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MatsEditor.MatID = 0;
            MatsEditor matsEditor = new MatsEditor();
            matsEditor.Show();
            this.Hide();
        }
    }
}
