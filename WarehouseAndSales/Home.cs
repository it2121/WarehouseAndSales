using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAndSales
{
    // dark #33334d
    // darker #009788
    // green #009788
    // gray #f0f0f0
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

          

          
            LogoPanel.BackgroundImage = returnLogo();
            DataTable dt = BAL.GetCompanyInfo();
            foreach (DataRow dr in dt.Rows)
            {
                CompanyName.Text = dr["CompanyName"].ToString();
                SubName.Text = dr["SubName"].ToString();

            }

            SetBtnsVisibility();
        }
        public void SetBtnsVisibility() {


            Mats.Visible = Helper.UserHasRole("Mats");
            Warehouses.Visible = Helper.UserHasRole("Warehouses");
            sellings.Visible = Helper.UserHasRole("sellings");
            Buyings.Visible = Helper.UserHasRole("Buyings");
           // Expences.Visible = Helper.UserHasRole("Expences");
           // EmpsAndSalarys.Visible = Helper.UserHasRole("EmpsAndSalarys");
            ProvidersAndBuyers.Visible = Helper.UserHasRole("ProvidersAndBuyers");
            ProvidersAndBuyers2.Visible = Helper.UserHasRole("ProvidersAndBuyers");
            CompanyInfo.Visible = Helper.UserHasRole("CompanyInfo");
            UsersManagment.Visible = Helper.UserHasRole("UsersManagment");

        }
        public Image returnLogo()
        {
            DataTable dt  = BAL.GetLogo();
            byte[] imageBA = (byte[])dt.Rows[0][0];
   
            try
            {
                MemoryStream ms = new MemoryStream(imageBA, 0, imageBA.Length);
                ms.Write(imageBA, 0, imageBA.Length);
                return Image.FromStream(ms, true);
            }
            catch { 
            
            }
            return null;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Warehouses warehouses = new Warehouses();   
            warehouses.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mats mats = new Mats();
            mats.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProvidersAndCustomers.ProviderOrCustomer = "provider";
            ProvidersAndCustomers providersAndCustomers = new ProvidersAndCustomers();
            providersAndCustomers.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProvidersAndCustomers.ProviderOrCustomer = "customer";
            ProvidersAndCustomers providersAndCustomers = new ProvidersAndCustomers();
            providersAndCustomers.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Buying b = new Buying();
            b.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CompanyInfoEditor c = new CompanyInfoEditor();
            c.Show();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CompanyName_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Show();
            this.Hide();

        }
    }
}
