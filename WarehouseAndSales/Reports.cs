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
    public partial class Reports : Form
    {
        public  int MatID = 0; 
        public  int WarehouseID = 0; 
        public  int ProviderOrCustomerID = 0; 
        public  string StartDateStr =   ""; 
        public  string EndDateStr =   ""; 
        public  string TypeStr =   ""; 
        public Reports()
        {
            InitializeComponent();
            CheckAndSetNames();

        }
        public  void CheckAndSetNames()
        {
            if (WarehouseID != 0)
                WarehouseName.Text = BAL.GetWarehouseName(WarehouseID).Rows[0][0].ToString();

            if (MatID != 0)
                MatName.Text = BAL.GetMatByID(MatID).Rows[0]["MatName"].ToString();

            if (ProviderOrCustomerID != 0)
                ProviderOrcustomerName.Text = BAL.GetProviderOrCustomerByID(ProviderOrCustomerID).Rows[0]["FullName"].ToString();

        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            WarehousBtn.Enabled = WarehouseCheck.Checked;
            if(!WarehouseCheck.Checked)
                WarehouseID= 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ProviderOrcustomerBtn.Enabled = ProviderOrcustomerCheck.Checked;
            if (!ProviderOrcustomerCheck.Checked)
                ProviderOrCustomerID = 0;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MatBtn.Enabled = MatCheck.Checked;
            if (!MatCheck.Checked)
                MatID = 0;

         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportTables.SalaryesTable = BAL.GetAllSalarys();
            ReportTables.ExpencesTable = BAL.GetAllExpense();
         


            ReportTables.BuyingsTable = BAL.GetFilterBuying(MatID, WarehouseID, ProviderOrCustomerID, TypeStr);
            ReportTables.BuyingsTablePayments = BAL.GetFilterBuyingPayments(MatID, WarehouseID, ProviderOrCustomerID, TypeStr);
            ReportTables.SalesTable = BAL.GetFilterSales(MatID, WarehouseID, ProviderOrCustomerID, TypeStr);
            ReportTables.SalesTablePayments = BAL.GetFilterSalesPayments(MatID, WarehouseID, ProviderOrCustomerID, TypeStr);

            if (DateCheck.Checked)
            {
                ReportTables.BuyingsTable = Helper.GetTableAfterDateCheck(ReportTables.BuyingsTable, StartDate.Value.ToString("dd/MM/yyyy"), EndDate.Value.ToString("dd/MM/yyyy"), "التاريخ");
                ReportTables.SalesTable = Helper.GetTableAfterDateCheck(ReportTables.SalesTable, StartDate.Value.ToString("dd/MM/yyyy"), EndDate.Value.ToString("dd/MM/yyyy"), "التاريخ");
                ReportTables.SalaryesTable = Helper.GetTableAfterDateCheck(ReportTables.SalaryesTable, StartDate.Value.ToString("dd/MM/yyyy"), EndDate.Value.ToString("dd/MM/yyyy"), "التاريخ");
                ReportTables.ExpencesTable = Helper.GetTableAfterDateCheck(ReportTables.ExpencesTable, StartDate.Value.ToString("dd/MM/yyyy"), EndDate.Value.ToString("dd/MM/yyyy"), "التاريخ");

            }

            ReportTables r = new ReportTables();
            r.Show();
            this.Hide();

        }

        private void DateCheck_CheckedChanged(object sender, EventArgs e)
        {
            StartDate.Enabled = DateCheck.Enabled;
            EndDate.Enabled = DateCheck.Enabled;
            if (!DateCheck.Checked) { 
                StartDateStr = "";
                EndDateStr = "";
            }

            if (DateCheck.Checked)
            {
                StartDateStr = StartDate.Text;
                EndDateStr = EndDate.Text;
            }
        }

        private void TypeCheck_CheckedChanged(object sender, EventArgs e)
        {
            Type.Enabled = TypeCheck.Enabled;
            if (!TypeCheck.Checked)
                TypeStr = "";

            if (TypeCheck.Checked)
                TypeStr = Type.Text;
        }

        private void WarehousBtn_Click(object sender, EventArgs e)
        {
            WarehouseSelector.From = "Reports";
            WarehouseSelector ws = new WarehouseSelector();

            ws.ReportsForm = this;
            ws.Show();
            this.Hide();
        }

        private void ProviderOrcustomerBtn_Click(object sender, EventArgs e)
        {
            ProvidersAndCustomersSelector.From = "Reports";
            ProvidersAndCustomersSelector ws = new ProvidersAndCustomersSelector();

            ws.ReportsForm = this;
            ws.Show();
            this.Hide();
        }

        private void MatBtn_Click(object sender, EventArgs e)
        {
            MatSelector.From = "Reports";
            MatSelector ws = new MatSelector();

            ws.ReportsForm = this;
            ws.Show();
            this.Hide();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Home HomeHome = new Home();
            HomeHome.Show();
            this.Hide();
        }
    }
}
