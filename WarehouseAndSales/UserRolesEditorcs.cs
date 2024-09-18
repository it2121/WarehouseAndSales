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
    public partial class UserRolesEditorcs : Form
    {
        public static int UserID = 0;
        public UserRolesEditorcs()
        {
            InitializeComponent();


            if (UserID != 0)
            {
                DataTable dt = BAL.GetUserRolesByUserID(UserID);
                Mats.Checked = Helper.UserHasRole("Mats", dt);
                Warehouses.Checked = Helper.UserHasRole("Warehouses", dt);
                sellings.Checked = Helper.UserHasRole("sellings", dt);
                Buyings.Checked = Helper.UserHasRole("Buyings", dt);
                Expences.Checked = Helper.UserHasRole("Expences", dt);
                EmpsAndSalarys.Checked = Helper.UserHasRole("EmpsAndSalarys", dt);
                ProvidersAndBuyers.Checked = Helper.UserHasRole("ProvidersAndBuyers", dt);
                CompanyInfo.Checked = Helper.UserHasRole("CompanyInfo", dt);
                UsersManagment.Checked = Helper.UserHasRole("UsersManagment", dt);
                SalaryManagment.Checked = Helper.UserHasRole("SalaryManagment", dt);
                EmpManagment.Checked = Helper.UserHasRole("EmpManagment", dt);
                Expense.Checked = Helper.UserHasRole("Expense", dt);
                InvoicePrint.Checked = Helper.UserHasRole("InvoicePrint", dt);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UserID != 0)
            {
                BAL.DeleteAllRolesFromUser(UserID);

                if (Mats.Checked)
                    BAL.InsertRoleToUser(UserID, "Mats");

                if (Warehouses.Checked)
                    BAL.InsertRoleToUser(UserID, "Warehouses");

                if (sellings.Checked)
                    BAL.InsertRoleToUser(UserID, "sellings");

                if (Buyings.Checked)
                    BAL.InsertRoleToUser(UserID, "Buyings");

                if (Expences.Checked)
                    BAL.InsertRoleToUser(UserID, "Expences");

                if (EmpsAndSalarys.Checked)
                    BAL.InsertRoleToUser(UserID, "EmpsAndSalarys");

                if (ProvidersAndBuyers.Checked)
                    BAL.InsertRoleToUser(UserID, "ProvidersAndBuyers");

                if (CompanyInfo.Checked)
                    BAL.InsertRoleToUser(UserID, "CompanyInfo");

                if (UsersManagment.Checked)
                    BAL.InsertRoleToUser(UserID, "UsersManagment");

                if (EmpManagment.Checked)
                    BAL.InsertRoleToUser(UserID, "EmpManagment");

                if (SalaryManagment.Checked)
                    BAL.InsertRoleToUser(UserID, "SalaryManagment");

                
                if (Expense.Checked)
                    BAL.InsertRoleToUser(UserID, "Expense");


                    
                if (InvoicePrint.Checked)
                    BAL.InsertRoleToUser(UserID, "InvoicePrint");




            }

            Users u = new Users();
            u.Show();
            this.Hide();
        }

        private void UserRolesEditorcs_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Users u = new Users();
            u.Show();
            this.Hide();
        }

        private void Expense_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
