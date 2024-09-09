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
    public partial class ProvidersAndCustomersEditor : Form
    {
        public static int ID = 0;
        public static string ProviderOrCustomer = "";
        public ProvidersAndCustomersEditor()
        {
            InitializeComponent();
            if(ID != 0)
            {
                DataTable dt = BAL.GetProviderOrCustomerByID(ID);
                foreach(DataRow row in dt.Rows)
                {
                    FullName.Text = row["FullName"].ToString();
                    PhoneNumber.Text = row["PhoneNumber"].ToString();
                    LivingAddress.Text = row["LivingAddress"].ToString();
                    Note.Text = row["Note"].ToString();


                }
                

            }
            else
            {

                FullName.Text = "";
                PhoneNumber.Text = "";
                LivingAddress.Text = "";
                Note.Text = "";
                DelBtn.Visible = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //okay btn

            if (ID != 0)
            {

                BAL.UpdateProviderOrCustomer(FullName.Text,
                       PhoneNumber.Text,
                       LivingAddress.Text,
                       Note.Text, ProviderOrCustomer,ID);

            }
            else {


                BAL.InsertProviderOrCustomer(FullName.Text,
                      PhoneNumber.Text,
                      LivingAddress.Text,
                      Note.Text, ProviderOrCustomer);


            }
            ProvidersAndCustomers.ProviderOrCustomer = ProviderOrCustomer;
            ProvidersAndCustomers providersAndCustomers = new ProvidersAndCustomers();
            providersAndCustomers.Show();
            this.Hide();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            //del btn
            BAL.DeleteProviderOrCustomer(ID);

            FullName.Text = "";
            PhoneNumber.Text = "";
            LivingAddress.Text = "";
            Note.Text = "";
            DelBtn.Visible = false;
            ProvidersAndCustomers.ProviderOrCustomer = ProviderOrCustomer;
            ProvidersAndCustomers providersAndCustomers = new ProvidersAndCustomers();
            providersAndCustomers.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            ProvidersAndCustomers.ProviderOrCustomer = ProviderOrCustomer;
            ProvidersAndCustomers providersAndCustomers = new ProvidersAndCustomers();
            providersAndCustomers.Show();
            this.Hide();
        }
        private void ProvidersAndCustomersEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
