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



            }
            else
            {
                DataTable dt = BAL.GetSalesRecordByID(ID);

                foreach (DataRow dr in dt.Rows)
                {

                    MatID = Convert.ToInt32(dr["MatID"].ToString());
                    Quant.Text = dr["Quant"].ToString();
                    SaleDate.Text = dr["SaleDate"].ToString();
                    TotalPrice.Text = dr["TotalPrice"].ToString();
                    BuyingParty.Text = dr["BuyingParty"].ToString();
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


                }

                if (MatID != 0)
                {
                    EffectChanges();



                }





            }



        }

        private void quantlbl_Click(object sender, EventArgs e)
        {

        }

        private void SalesEditor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatSelector.From = "SalesEditor";
            MatSelector matSelector = new MatSelector();

            matSelector.Show();
            this.Close();
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
            MaxQuantInStock.Text = MaxQuant+"";

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
                 BuyingParty.Text,
                 Notes.Text

                        );



                }
                else
                {


                    BAL.UpdateSales(MatID, 0, Convert.ToInt32(Quant.Text), SaleDate.Text, Convert.ToInt32(TotalPrice.Text), TypeOfSale,
                 BuyingParty.Text,
                 Notes.Text, ID

                        );




                }

                Sales sales = new Sales();
                sales.Show();
                this.Close();
            }
            else {


                MessageBox.Show("يجب ان تكون الكمية المحددة اقل من الكمية المتوفرة في المخازن!");
            
            
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
    }
}
