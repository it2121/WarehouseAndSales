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
    public partial class EmpEditor : Form
    {
        public static int ID = 0;

        public EmpEditor()
        {
            InitializeComponent();

            if (ID == 0)
            {


                DelBtn.Visible = false;
                ClearText();
            }
            else
            {

                DataTable dt = BAL.GetEmpByID(ID);

                foreach (DataRow dr in dt.Rows)
                {
                    EmpName.Text = dr["EmpName"].ToString();
                    EmpJob.Text = dr["EmpJob"].ToString();
                    EmpDep.Text = dr["EmpDep"].ToString();
                    EmpPhoneNumber.Text = dr["EmpPhoneNumber"].ToString();
                    EmpSalary.Text = dr["EmpSalary"].ToString();


                }


            }
        }
        void GetOut()
        {

            Emps Empss = new Emps();
            Empss.Show();
            this.Hide();
        }
        private void DelBtn_Click(object sender, EventArgs e)
        {
            BAL.DeleteEmp(ID);
            GetOut();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                BAL.InsertIntoEmps(

                    EmpName.Text,
                EmpJob.Text,
                EmpDep.Text,
                EmpPhoneNumber.Text,
              Convert.ToInt32(EmpSalary.Text)


                    );





            }
            else
            {

                BAL.UpdateEmps(

                     EmpName.Text,
                EmpJob.Text,
                EmpDep.Text,
                EmpPhoneNumber.Text,
              Convert.ToInt32(EmpSalary.Text),ID

                   );



            }
            GetOut();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            GetOut();
        }

        void ClearText()
        {

            EmpName.Text = "";
            EmpJob.Text = "";
            EmpDep.Text = "";
            EmpPhoneNumber.Text = "";
            EmpSalary.Text = "";

        }
    }
}
