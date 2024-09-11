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
    public partial class Payments : Form
    {
        public static int RecID = 0;
        public static string PaymentType = "";
        public Payments()
        {
            InitializeComponent();

            DataTable dt = BAL.GetPaymentsOfRecID(RecID);
            buyingDG.DataSource = dt;

        }

        private void Return_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaymentEditor.ID = 0;
            PaymentEditor.RecID = RecID;
            PaymentEditor.PaymentType = PaymentType;
            PaymentEditor paymentEditor = new PaymentEditor();
            paymentEditor.Show();
            this.Hide();
        }

        private void buyingDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell btn = (DataGridViewButtonCell)buyingDG.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (btn.Value.Equals("تعديل"))
            {



                int id = Convert.ToInt32(buyingDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());


              

                PaymentEditor.ID = id;
                PaymentEditor.RecID = RecID;
                PaymentEditor.PaymentType = PaymentType;
                PaymentEditor paymentEditor = new PaymentEditor();
                paymentEditor.Show();
                this.Hide();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
