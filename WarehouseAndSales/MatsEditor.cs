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
    public partial class MatsEditor : Form
    {
        public static int MatID = 0 ;
        public MatsEditor()
        {
            InitializeComponent();
            if (MatID == 0)
            {


                DelBtn.Visible = false;
                ClearText();
            }
            else {

                DataTable dt = BAL.GetMatByID(MatID);
                
                foreach(DataRow dr in dt.Rows)
                {
                    MatName.Text = dr["MatName"].ToString();
                    MatType.Text = dr["MatType"].ToString();
                    MatUnitWeight.Text = dr["MatUnitWeight"].ToString();
                    MatUnitSize.Text = dr["MatUnitSize"].ToString();
                    StorageType.Text = dr["StorageType"].ToString();
                    Notes.Text = dr["Notes"].ToString();
                    RetailPrice.Text = dr["RetailPrice"].ToString();
                    WholesalePrice.Text = dr["WholesalePrice"].ToString();


                }


            }
        }
        void ClearText() {

            MatName.Text = "";
            MatType.Text = "";
            MatUnitWeight.Text = "";
            MatUnitSize.Text = "";
            StorageType.Text = "";
            Notes.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MatID == 0) {
                BAL.InsertMat(

                    MatName.Text ,
                MatType.Text ,
              Convert.ToInt32(  MatUnitWeight.Text) ,
             Convert.ToInt32(MatUnitSize.Text) ,
                StorageType.Text ,
                Notes.Text 
                    ,Convert.ToInt32(RetailPrice.Text),
                Convert.ToInt32(WholesalePrice.Text)
                    
                    
                    );



            
            
            }else
            {

                BAL.UpdateMat(

                   MatName.Text,
               MatType.Text,
             Convert.ToInt32(MatUnitWeight.Text),
            Convert.ToInt32(MatUnitSize.Text),
               StorageType.Text,
               Notes.Text,
              MatID

               , Convert.ToInt32(RetailPrice.Text),
                Convert.ToInt32(WholesalePrice.Text)

                   );



            }
            GetOut();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            BAL.DeleteMat(MatID);
            GetOut();
        }
        void GetOut() {

            Mats mats = new Mats();
            mats.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Mats mats = new Mats();
            mats.Show();
            this.Hide();
        }

        private void MatsEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
