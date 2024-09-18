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
    public partial class ProvidersAndCustomers : Form
    {
        public static string ProviderOrCustomer = "";
        public static DataTable dt;
        public ProvidersAndCustomers()
        {
            InitializeComponent();
            if (ProviderOrCustomer.Equals("provider"))
            {
                dt = BAL.GetAllProviders();
            }
            else {
                dt = BAL.GetAllCustomers();

            }

            ProvidersAndCustomersDG.DataSource = dt;
            ProvidersAndCustomersDG.Columns["ID"].Visible = false;

        }

        private void ProvidersAndCustomers_Load(object sender, EventArgs e)
        {

        }

        private void ProvidersAndCustomersDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell btn = (DataGridViewButtonCell)ProvidersAndCustomersDG.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (btn.Value.Equals("تعديل"))
            {



                int ID  = Convert.ToInt32(ProvidersAndCustomersDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());


                ProvidersAndCustomersEditor.ID = ID;
                ProvidersAndCustomersEditor.ProviderOrCustomer = ProviderOrCustomer;
                ProvidersAndCustomersEditor providersAndCustomersEditor = new ProvidersAndCustomersEditor();
                providersAndCustomersEditor.Show();
                this.Hide();
            }


            //MessageBox.Show(matsDG.Rows[e.RowIndex].Cells["ID"].Value.ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProvidersAndCustomersEditor.ID = 0;
            ProvidersAndCustomersEditor.ProviderOrCustomer = ProviderOrCustomer;
            ProvidersAndCustomersEditor providersAndCustomersEditor = new ProvidersAndCustomersEditor();
            providersAndCustomersEditor.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void Return_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
