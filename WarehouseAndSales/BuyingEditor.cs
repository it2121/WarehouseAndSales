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
    public partial class BuyingEditor : Form
    {
        public static int ID = 0;
        public int ProviderID = 0;
        public int MatID = 0;
        public BuyingEditor()
        {
            InitializeComponent();

             if (ID ==0 )
            {

                Retail.Checked = true;
                DelBtn.Visible = false;
                DateTime dateTime = DateTime.UtcNow.Date;


                BuyingDate.Text = dateTime.ToString("dd/MM/yyyy");

            }
            else
            {
                DelBtn.Visible = true;

                DataTable dt = BAL.GetBuyingByID(ID);

                foreach (DataRow dr in dt.Rows)
                {

                    MatID = Convert.ToInt32(dr["MatID"].ToString());
                    ProviderID = Convert.ToInt32(dr["SellerID"].ToString());
                    Quant.Text = dr["Quant"].ToString();
                    BuyingDate.Text = dr["BuyingDate"].ToString();
                    TotalPrice.Text = dr["TotalPrice"].ToString();
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





            }

            if (ID != 0 )
            {
                DelBtn.Visible = true;

                WithdrawGroup.Visible = false;

            }
            else {
                DelBtn.Visible = false;
                WithdrawGroup.Visible = true;

            }
                            AutoDepo.Checked = true;


        }
        public void setProviderName()
        {

            SellingParty.Text = BAL.GetProviderOrCustomerByID(ProviderID).Rows[0]["FullName"].ToString();

        }
        public void setMatName()
        {

            MatName.Text = BAL.GetMatByID(MatID).Rows[0]["MatName"].ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MatSelector.From = "BuyingEditor";
            MatSelector.buyingForm = this;
            MatSelector matSelector = new MatSelector();

            matSelector.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProvidersAndCustomersSelector.From = "Buying";
            ProvidersAndCustomersSelector.ProviderOrCustomer = "provider";
            ProvidersAndCustomersSelector.buyingForm = this;
            ProvidersAndCustomersSelector providersAndCustomersSelector = new ProvidersAndCustomersSelector();
            providersAndCustomersSelector.Show();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {

            BAL.DeleteFromBuying(ID

                );





            Buying b = new Buying();
            b.Show();
            this.Hide();
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

            if (ID == 0)
            {


                BAL.InsertIntoBuying(MatID, ProviderID, Convert.ToInt32(Quant.Text), BuyingDate.Text,
                    Convert.ToInt32(TotalPrice.Text), TypeOfSale,
             Notes.Text

                    );

                if (AutoDepo.Checked)
                {

                    WarehouseSelector.From = "AutoBuyingDepo";
                    WarehouseSelector.MatID = MatID;
                    WarehouseSelector.BuyingForm = this;
                    WarehouseSelector warehouseSelector = new WarehouseSelector();
                    warehouseSelector.Show();
                    this.Hide();





                }else
                {

                    Buying b = new Buying();
                    b.Show();
                    this.Hide();

                }

            }
            else
            {


                BAL.UpdateBuying(MatID, ProviderID, Convert.ToInt32(Quant.Text), BuyingDate.Text,
                    Convert.ToInt32(TotalPrice.Text), TypeOfSale,
             Notes.Text, ID

                    );

                Buying b = new Buying();
                b.Show();
                this.Hide();


            }
        

        }
        public void AutoDepoNow()
        {

          

                BAL.InsertIntoMatToWarehouses(MatID, Global.getWarehousID(), Convert.ToInt32(Quant.Text), BuyingDate.Text,
                            " :اودع تلقائياً لقيد الشراء ذو الرقم" + BAL.GetLatBuyingID().Rows[0][0].ToString()
                            , "ايداع");


                MessageBox.Show("تم ايداع الكمية الى المخزن بنجاح");
            Buying b = new Buying();
            b.Show();
            this.Hide();




        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Buying b = new Buying();
            b.Show();
            this.Hide();
        }

        private void BuyingEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
