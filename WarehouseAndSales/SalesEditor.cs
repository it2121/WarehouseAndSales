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
    public partial class SalesEditor : Form
    {
        public static int MatID = 0;
        public static int RetailPrice = 0;
        public static int WholeSalePrice = 0;
        public static int MaxQuant = 0;
        public static int ID = 0;
        public int WarehouseID = 0;
        public int CustomerID = 0;
        public static bool Edit = false;
        
        public SalesEditor()
        {
            InitializeComponent();
            MaxQuant = 0;

            if (!Edit)
            {

                Retail.Checked = true;
                if (MatID != 0)
                {
                    EffectChanges();



                }
                DateTime dateTime = DateTime.UtcNow.Date;


                SaleDate.Text = dateTime.ToString("dd/MM/yyyy");

            }
            else
            {
                DataTable dt = BAL.GetSalesRecordByID(ID);

                foreach (DataRow dr in dt.Rows)
                {
                    CustomerID = Convert.ToInt32(dr["BuyerID"].ToString());

                    MatID = Convert.ToInt32(dr["MatID"].ToString());
                    Quant.Text = dr["Quant"].ToString();
                    SaleDate.Text = dr["SaleDate"].ToString();
                    TotalPrice.Text = dr["TotalPrice"].ToString();
                   // BuyingParty.Text = dr["BuyingParty"].ToString();
                    Notes.Text = dr["Notes"].ToString();
                    Wholesale.Checked = false;
                    Retail.Checked = false;
                    if (dr["TypeOfSale"].ToString().Equals("مفرد"))
                    {
                        Retail.Checked = true;
                    }
                    else
                    {
                        Wholesale.Checked = true;

                    }
                    setMatName();
                    setProviderName();
                }

                if (MatID != 0)
                {
                    EffectChanges();



                }





            }

            if (Edit)
            {
                DelBtn.Visible = true;

                WithdrawGroup.Visible = false;

            }
            else {
                DelBtn.Visible = false;
                WithdrawGroup.Visible = true;

            }
                            AutoWithdraw.Checked = true;

        }
        public void setProviderName()
        {

            BuyingParty.Text = BAL.GetProviderOrCustomerByID(CustomerID).Rows[0]["FullName"].ToString();

        }
        public void setMatName()
        {

            MatName.Text = BAL.GetMatByID(MatID).Rows[0]["MatName"].ToString();

        }
        private void quantlbl_Click(object sender, EventArgs e)
        {

        }
        public void setCustomerName() {
            BuyingParty.Text = BAL.GetProviderOrCustomerByID(CustomerID).Rows[0]["FullName"].ToString();



        }
        private void SalesEditor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatSelector.From = "SalesEditor";
            MatSelector matSelector = new MatSelector();

            matSelector.Show();
            this.Hide();
        }
        public void EffectChanges()
        {
            DataTable MatDT = BAL.GetMatByID(MatID);
            MatName.Text = MatDT.Rows[0]["MatName"].ToString();
            RetailPrice = Convert.ToInt32(MatDT.Rows[0]["RetailPrice"].ToString());
           WholeSalePrice = Convert.ToInt32(MatDT.Rows[0]["WholesalePrice"].ToString());
            DataTable InStock = BAL.GetAllInStockOfAMat(MatID);
            foreach (DataRow Row in InStock.Rows)
            {
                MaxQuant += Convert.ToInt32(Row["InStock"].ToString());

            }
            MaxQuantInStock.Text = MaxQuant + "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            string TypeOfSale = "جملة";
            if (Retail.Checked == true)
            {
                TypeOfSale = "مفرد";

            }
            else if (Wholesale.Checked == true)
            {
                TypeOfSale = "جملة";


            }
            if (Convert.ToInt32(Quant.Text) <= MaxQuant)
            {
                if (!Edit)
                {


                    BAL.InsertIntoSales(MatID, 0, Convert.ToInt32(Quant.Text), SaleDate.Text, Convert.ToInt32(TotalPrice.Text), TypeOfSale,
                 Notes.Text
                 ,CustomerID
                        );

                    if (AutoWithdraw.Checked) {

                        WarehouseSelector.From = "AutoSalesWithdraw";
                        WarehouseSelector.MatID = MatID;
                        WarehouseSelector.SailsForm = this;
                        WarehouseSelector warehouseSelector = new WarehouseSelector();
                        warehouseSelector.Show();
                        this.Hide();





                    }

                }
                else
                {


                    BAL.UpdateSales(MatID, 0, Convert.ToInt32(Quant.Text), SaleDate.Text, Convert.ToInt32(TotalPrice.Text), TypeOfSale,
                 Notes.Text, ID, CustomerID

                        );




                }
                if (!AutoWithdraw.Checked)
                {

                    Sales sales = new Sales();
                    sales.Show();
                    this.Hide();
                }
            }
            else {


                MessageBox.Show("يجب ان تكون الكمية المحددة اقل من الكمية المتوفرة في المخازن!");


            }

        }

        public void AutoWithdrawNow (){

            int RemInStock = Convert.ToInt32(BAL.GetOneRemMatsOfAWarehouseByMatID(Global.getWarehousID(), MatID).Rows[0]["InStock"].ToString());
            if (RemInStock > Convert.ToInt32(Quant.Text)) {

                BAL.InsertIntoMatToWarehouses(MatID, Global.getWarehousID(), Convert.ToInt32(Quant.Text), SaleDate.Text,
                            " :سحبت تلقائياً لقيد البيع ذو الرقم" + BAL.GetLastSailID().Rows[0][0].ToString()
                            , "سحب");


                MessageBox.Show("تم سحب الكمية من المخزن بنجاح");
                Sales sales = new Sales();
                sales.Show();
                this.Hide();


            }
            else {

                MessageBox.Show("تعذر السحب من المخزف لعدم احتواء المخزن المحدد على الكمية المطلوبة يرجى سحب الكميات من المخازن بشكل يدوي");

            }
        }
        public void EffectChangesToTotalCost()
        {

            if (Retail.Checked == true)
            {
                if (Quant.Text.Length > 0)
                    TotalPrice.Text = Convert.ToInt32(Quant.Text) * RetailPrice + "";

            }
            else if (Wholesale.Checked == true)
            {
                if (Quant.Text.Length > 0)
                    TotalPrice.Text = Convert.ToInt32(Quant.Text) * WholeSalePrice + "";


            }

        }

        private void Retail_CheckedChanged(object sender, EventArgs e)
        {

            EffectChangesToTotalCost();
        }

        private void Wholesale_CheckedChanged(object sender, EventArgs e)
        {
            EffectChangesToTotalCost();


        }

        private void Quant_TextChanged(object sender, EventArgs e)
        {
            EffectChangesToTotalCost();

        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            BAL.DeleteSales( ID

                );




     
        Sales sales = new Sales();
        sales.Show();
                this.Hide();
    }

        private void AutoWithdraw_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ManualWithdraw_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ProvidersAndCustomersSelector.From = "Sails";
            ProvidersAndCustomersSelector.ProviderOrCustomer = "customer";
            ProvidersAndCustomersSelector.sailsForm = this;
            ProvidersAndCustomersSelector providersAndCustomersSelector = new ProvidersAndCustomersSelector();
            providersAndCustomersSelector.Show();


        }

        private void MatName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BuyingParty_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Notes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SaleDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MaxQuantInStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void WithdrawGroup_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
