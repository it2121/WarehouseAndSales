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
    public partial class EmpSelector : Form
    {
        public static string From = "";
        public static int IDToBeReturned = 0;
        public EmpSelector()
        {
            InitializeComponent();
           DataTable dt = BAL.GetAllEmps();
            matsDG.DataSource = dt;


        }

        private void EmpSelector_Load(object sender, EventArgs e)
        {

        }

        private void matsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (From.Equals("Salarys") )
            {
                int EmpID = Convert.ToInt32(matsDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());


                SalaryEditor.EmpID = EmpID;
                SalaryEditor.ID = IDToBeReturned;
                SalaryEditor SalaryEditorr = new SalaryEditor();
                SalaryEditorr.Show();
                this.Hide();


            }
        }

        void GetOut()
        {

            Salarys Salaryss = new Salarys();
            Salaryss.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            GetOut();

        }


    }
}
