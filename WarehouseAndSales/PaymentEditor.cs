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
    public partial class PaymentEditor : Form
    {
        public static int ID = 0;
        public static int RecID = 0;
        public static string PaymentType = "";
        public PaymentEditor()
        {
            InitializeComponent();
            if (ID != 0)
            {
                DataTable dt = BAL.GetOnePaymentByID(ID);
                foreach (DataRow dr in dt.Rows)
                {

                    PaymentAmount.Text = dr["PaymentAmount"].ToString();
                    PaymentDate.Text = dr["PaymentDate"].ToString();



                }
                DelBtn.Visible = true;
            }
            else
            {
                DateTime dateTime = DateTime.UtcNow.Date;

                PaymentAmount.Text = "";
                PaymentDate.Text = dateTime.ToString("dd/MM/yyyy");
                DelBtn.Visible = false;

            }

        }

        private void PaymentEditor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                BAL.InsertIntoPayments(Convert.ToInt32(PaymentAmount.Text), PaymentDate.Text,
                    RecID,PaymentType);
            }
            else
            {

                BAL.UpdatePayments(Convert.ToInt32(PaymentAmount.Text), PaymentDate.Text,
                 RecID, PaymentType,ID);
            }

            Payments.RecID = RecID;
            Payments.PaymentType = PaymentType;
            Payments p = new Payments();
            p.Show();
            this.Hide();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            BAL.DeletePayment(ID);
            Payments.RecID = RecID;
            Payments.PaymentType = PaymentType;
            Payments p = new Payments();
            p.Show();
            this.Hide();

        }
    }
}
