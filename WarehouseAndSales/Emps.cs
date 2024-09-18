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
    public partial class Emps : Form
    {
        public Emps()
        {
            InitializeComponent();

            DataTable dt = BAL.GetAllEmps();
            matsDG.DataSource = dt;
            matsDG.Columns["ID"].Visible = false;

        }

        private void matsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewButtonCell btn = (DataGridViewButtonCell)matsDG.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (btn.Value.Equals("تعديل"))
            {



               int ID = Convert.ToInt32(matsDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());


                EmpEditor.ID = ID;
                EmpEditor ee = new EmpEditor();
                ee.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmpEditor.ID = 0;
            EmpEditor ee = new EmpEditor();
            ee.Show();
            this.Hide();

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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
