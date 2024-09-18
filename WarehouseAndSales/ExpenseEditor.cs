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
    public partial class ExpenseEditor : Form
    {
        public static int ID = 0;

        public ExpenseEditor()
        {
            InitializeComponent();
            if (ID == 0)
            {


                DelBtn.Visible = false;
                ClearText();
                DateTime dateTime = DateTime.UtcNow.Date;


                ExpDate.Text = dateTime.ToString("dd/MM/yyyy");

            }
            else
            {

                DataTable dt = BAL.GetExpenseByID(ID);

                foreach (DataRow dr in dt.Rows)
                {
                    Reason.Text = dr["Reason"].ToString();
                    ExpDate.Text = dr["ExpDate"].ToString();
                    Amount.Text = dr["Amount"].ToString();
                    Note.Text = dr["Note"].ToString();


                }


            }
        }

        void GetOut()
        {

            Expense Epss = new Expense();
            Epss.Show();
            this.Hide();
        }
        private void DelBtn_Click(object sender, EventArgs e)
        {
            BAL.DeleteExpense(ID);
            GetOut();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                BAL.InsertExpense(

                    Reason.Text,
                ExpDate.Text,
              Convert.ToInt32(Amount.Text),
                Note.Text


                    );





            }
            else
            {

                BAL.UpdateExpense(

                    Reason.Text,
                ExpDate.Text,
              Convert.ToInt32(Amount.Text),
                Note.Text ,ID

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

             Reason.Text = "";
            ExpDate.Text = "";
            Amount.Text = "";
            Note.Text = "";

        }
    }
}
