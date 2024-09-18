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
    public partial class Salarys : Form
    {
        public Salarys()
        {
            InitializeComponent();
            DataTable dt = BAL.GetAllSalarys();
            matsDG.DataSource = dt;
            matsDG.Columns["ID"].Visible = false;
            matsDG.Columns["EmpID"].Visible = false;

        }

        private void matsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewButtonCell btn = (DataGridViewButtonCell)matsDG.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (btn.Value.Equals("تعديل"))
            {



                int ID = Convert.ToInt32(matsDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());


                SalaryEditor.ID = ID;
                SalaryEditor ee = new SalaryEditor();
                ee.Show();
                this.Hide();
            }
            
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

        private void button2_Click(object sender, EventArgs e)
        {

            SalaryEditor.ID = 0;
            SalaryEditor.EmpID = 0;
            SalaryEditor ee = new SalaryEditor();
            ee.Show();
            this.Hide();
        }
    }
}
