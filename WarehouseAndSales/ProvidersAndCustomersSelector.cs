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
    public partial class ProvidersAndCustomersSelector : Form
    {
        public static string ProviderOrCustomer = "";
        public static string From = "";
        public static SalesEditor sailsForm;
        public static BuyingEditor buyingForm;
        public Reports ReportsForm;

        public ProvidersAndCustomersSelector()
        {
            InitializeComponent();
            if (ProviderOrCustomer.Equals("customer"))
            {

                ProviderOrCustomerDG.DataSource = BAL.GetAllCustomers();
            } else if (ProviderOrCustomer.Equals("provider")) {
                ProviderOrCustomerDG.DataSource = BAL.GetAllProviders();


            }
             if (From.Equals("Reports")) {
                DataTable provtbl = BAL.GetAllProviders();
                DataTable CusTbl = BAL.GetAllCustomers();
                foreach (DataRow dr in CusTbl.Rows) {

                    provtbl.ImportRow(dr);
                }
                ProviderOrCustomerDG.DataSource = provtbl;


            } 

        }

        private void matsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          int id   = Convert.ToInt32(ProviderOrCustomerDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            if (From.Equals("Sails") )
            {

                sailsForm.CustomerID = id;
                sailsForm.setCustomerName();
                sailsForm.Show();
                this.Hide();


            }
            else if (From.Equals("Buying"))
            {

                buyingForm.ProviderID = id;
                buyingForm.setProviderName();
                buyingForm.Show();
                this.Hide();

      
            }  else if (From.Equals("Reports"))
            {

                
                ReportsForm.ProviderOrCustomerID = id;

                ReportsForm.CheckAndSetNames();
                ReportsForm.Show();



                this.Hide();
            }else if (From.Equals("Home"))
            {


             //   ReportTables.SalaryesTable = BAL.GetAllSalarys();
            //    ReportTables.ExpencesTable = BAL.GetAllExpense();



             

                if (ProviderOrCustomer.Equals("customer"))
                {

                    ReportTables.SalesTable = BAL.GetFilterSales(0, 0, id, "");
                    ReportTables.SalesTablePayments = BAL.GetFilterSalesPayments(0, 0, id, "");
                }
                else if (ProviderOrCustomer.Equals("provider"))
                {
                    ReportTables.BuyingsTable = BAL.GetFilterBuying(0, 0, id, "");
                    ReportTables.BuyingsTablePayments = BAL.GetFilterBuyingPayments(0, 0, id, "");

                }
                ReportTables.FromHome = true;
                ReportTables r = new ReportTables();
                r.Show();
                this.Hide();

            }

        }

        private void ProvidersAndCustomersSelector_Load(object sender, EventArgs e)
        {

        }
    }
}
