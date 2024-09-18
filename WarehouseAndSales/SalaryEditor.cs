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
    public partial class SalaryEditor : Form
    {
        public static int ID = 0;
        public static int EmpID = 0;

        public SalaryEditor()
        {


            InitializeComponent();
            if (ID == 0)
            {


                DelBtn.Visible = false;
                ClearText();

                DateTime dateTime = DateTime.UtcNow.Date;

                SalaryRecDate.Text = "";
                SalaryRecDate.Text = dateTime.ToString("dd/MM/yyyy");

                if (EmpID != 0) {

                    RecAmount.Text = BAL.GetEmpByID(EmpID).Rows[0]["EmpSalary"].ToString();
                }

            }
            else
            {

                DataTable dt = BAL.GetSalaryByID(ID);

                foreach (DataRow dr in dt.Rows)
                {
                    SalaryRecDate.Text = dr["SalaryRecDate"].ToString();
                    Notes.Text = dr["Notes"].ToString();
                    RecAmount.Text = dr["RecAmount"].ToString();
                    EmpID = Convert.ToInt32(dr["EmpID"].ToString());
                }


            }
            if(EmpID != 0)
                EmpName.Text = BAL.GetEmpByID(EmpID).Rows[0]["EmpName"].ToString();



        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            BAL.DeleteSalary(ID);
            GetOut();
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
        void ClearText()
        {

            SalaryRecDate.Text = "";
            Notes.Text = "";
            SalaryRecDate.Text = "";
            EmpName.Text = "";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                BAL.InsertIntoSalary(
                EmpID, SalaryRecDate.Text, Notes.Text,Convert.ToInt32(RecAmount.Text)


                    );





            }
            else
            {

                BAL.UpdateSalary(

                                 EmpID, SalaryRecDate.Text, Notes.Text, Convert.ToInt32(RecAmount.Text),ID

                   );



            }
            GetOut();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpSelector.From = "Salarys";
            EmpSelector.IDToBeReturned = ID;
            EmpSelector EmpSelectorr = new EmpSelector();

            EmpSelectorr.Show();
            this.Hide();


        }
    }
}
