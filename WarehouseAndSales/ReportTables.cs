using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WarehouseAndSales
{
    public partial class ReportTables : Form
    {
        public static DataTable BuyingsTable = new DataTable();
        public static DataTable BuyingsTablePayments = new DataTable();
        public static DataTable SalesTable = new DataTable();
        public static DataTable SalesTablePayments = new DataTable();
        public static DataTable SalaryesTable = new DataTable();
        public static DataTable ExpencesTable = new DataTable();
        public static bool FromHome = false;
        public ReportTables()
        {
            InitializeComponent();
            BuyingsDG.DataSource = BuyingsTable;
            SalesDG.DataSource = SalesTable;
            BuyingsPayemtnsG.DataSource = BuyingsTablePayments;
            SalesPayemtntsG.DataSource = SalesTablePayments;
            SalaryG.DataSource = SalaryesTable;
            ExpencesG.DataSource = ExpencesTable;

            if (!FromHome)
            {
                tabControl1.TabPages.Remove(sumation);
                tabControl1.TabPages.Remove(ExpencesTap);
                tabControl1.TabPages.Remove(SalaryTap);
                tabControl1.TabPages.Remove(BuyingTap);
                tabControl1.TabPages.Remove(BuyingsPaymentsTap);
                tabControl1.TabPages.Remove(SalesTap);
                tabControl1.TabPages.Remove(SalesPaymentsTap);

                tabControl1.TabPages.Add(BuyingTap);
                tabControl1.TabPages.Add(BuyingsPaymentsTap);
                tabControl1.TabPages.Add(SalesTap);
                tabControl1.TabPages.Add(SalesPaymentsTap);
                tabControl1.TabPages.Add(SalaryTap);

                tabControl1.TabPages.Add(ExpencesTap);

                tabControl1.TabPages.Add(sumation);


                BuyingsPayemtnsCountLbl.Text = BuyingsTablePayments.Rows.Count + "";
                SalesPayemtnsCountLbl.Text = SalesTablePayments.Rows.Count + "";
                BuyingsSumLbl.Text = GetSumOfCoulmn(BuyingsTablePayments, "مبلغ_الدفعة");
                SalesSumLbl.Text = GetSumOfCoulmn(SalesTablePayments, "مبلغ_الدفعة");

                SalarySumLbl.Text = GetSumOfCoulmn(SalaryesTable, "المبلغ_المستلم");
                ExpencesSumLbl.Text = GetSumOfCoulmn(ExpencesTable, "المبلغ");



                TotalOutcutLbl.Text = (Convert.ToInt32(BuyingsSumLbl.Text) + Convert.ToInt32(SalarySumLbl.Text) + Convert.ToInt32(ExpencesSumLbl.Text)) + "";
                TotalIncomeLbl.Text = (Convert.ToInt32(SalarySumLbl.Text)) + "";
                ProfitLbl.Text = ((Convert.ToInt32(TotalIncomeLbl.Text)) - (Convert.ToInt32(TotalOutcutLbl.Text))) + "";
            }
            if (FromHome)
            {
               // MessageBox.Show("yes");

                tabControl1.TabPages.Remove(sumation);
                tabControl1.TabPages.Remove(ExpencesTap);
                tabControl1.TabPages.Remove(SalaryTap);
                tabControl1.TabPages.Remove(BuyingTap);
                tabControl1.TabPages.Remove(BuyingsPaymentsTap);
                tabControl1.TabPages.Remove(SalesTap);
                tabControl1.TabPages.Remove(SalesPaymentsTap);

           /*     tabControl1.TabPages[6].Visible = false;
                tabControl1.TabPages[5].Visible = false;
                tabControl1.TabPages[4].Visible = false;
                tabControl1.TabPages[3].Visible = false;
                tabControl1.TabPages[2].Visible = false;
                tabControl1.TabPages[1].Visible = false;
                tabControl1.TabPages[0].Visible = false;*/


                if(BuyingsTable.Rows.Count>0)
                {
                    tabControl1.TabPages.Add(BuyingTap);
                    tabControl1.TabPages.Add(BuyingsPaymentsTap);


             /*       tabControl1.TabPages[1].Visible = true;
                    tabControl1.TabPages[0].Visible = true;*/


                }
                if (SalesTable.Rows.Count > 0)
                {
                    tabControl1.TabPages.Add(SalesTap);
                    tabControl1.TabPages.Add(SalesPaymentsTap);

                   /* tabControl1.TabPages[2].Visible = true;
                    tabControl1.TabPages[3].Visible = true;*/


                }

            }

        }
        public void clearTables()
        {

             BuyingsTable = new DataTable();
         BuyingsTablePayments = new DataTable();
         SalesTable = new DataTable();
         SalesTablePayments = new DataTable();
        SalaryesTable = new DataTable();
       ExpencesTable = new DataTable();

            tabControl1.TabPages.Remove(sumation);
            tabControl1.TabPages.Remove(ExpencesTap);
            tabControl1.TabPages.Remove(SalaryTap);
            tabControl1.TabPages.Remove(BuyingTap);
            tabControl1.TabPages.Remove(BuyingsPaymentsTap);
            tabControl1.TabPages.Remove(SalesTap);
            tabControl1.TabPages.Remove(SalesPaymentsTap);

            tabControl1.TabPages.Add(BuyingTap);
            tabControl1.TabPages.Add(BuyingsPaymentsTap);
            tabControl1.TabPages.Add(SalesTap);
            tabControl1.TabPages.Add(SalesPaymentsTap);
            tabControl1.TabPages.Add(SalaryTap);

            tabControl1.TabPages.Add(ExpencesTap);

            tabControl1.TabPages.Add(sumation);
            FromHome = false;
        }
        public static void ExportBtnc(string PathToSaveTo)
        {

            string pathandname = "تقرير.xlsx";
            /*           public static DataTable BuyingsTable = null;
                 public static DataTable BuyingsTablePayments = null;
                 public static DataTable SalesTable = null;
                 public static DataTable SalesTablePayments = null;
                 public static DataTable SalaryesTable = null;
                 public static DataTable ExpencesTable = null;*/

            var wb = new XLWorkbook();
            int sheetCounter = 0;

            if (BuyingsTable.Rows.Count>0) { 
            DataTable BuyingsTable1 = BuyingsTable;
            BuyingsTable1.TableName = "المشتريات";
            wb.Worksheets.Add(BuyingsTable1);
            sheetCounter++;
            }



            if (BuyingsTablePayments.Rows.Count > 0)
            {

                DataTable BuyingsTablePayments1 = BuyingsTablePayments;
                BuyingsTablePayments1.TableName = "دفعات المشتريات";
                wb.Worksheets.Add(BuyingsTablePayments1);
                sheetCounter++;
            }

            if (SalesTable.Rows.Count > 0)
            {
                DataTable SalesTable1 = SalesTable;
                SalesTable1.TableName = "المبيعات";
                wb.Worksheets.Add(SalesTable1);
                sheetCounter++;
            }

            if (SalesTablePayments.Rows.Count > 0)
            {
                DataTable SalesTablePayments1 = SalesTablePayments;
                SalesTablePayments1.TableName = "دفعات المبيعات";
                wb.Worksheets.Add(SalesTablePayments1);
                sheetCounter++;
            }

            if (SalaryesTable.Rows.Count > 0)
            {
                DataTable SalaryesTable1 = SalaryesTable;
                SalaryesTable1.TableName = "صرفيات الرواتب";
                wb.Worksheets.Add(SalaryesTable1);
                sheetCounter++;
            }

            if (ExpencesTable.Rows.Count > 0)
            {
                DataTable ExpencesTable1 = ExpencesTable;
                ExpencesTable.TableName = "الصرفيات العامة";
                wb.Worksheets.Add(ExpencesTable);
                sheetCounter++;
            }




            wb.SaveAs(pathandname);





            byte[] bytes = GetBinaryFile(pathandname);

            DateTime dateTime = DateTime.UtcNow;




            System.IO.FileInfo file = new System.IO.FileInfo(pathandname);

            // MessageBox.Show(pathandname);
            // MessageBox.Show(PathToSaveTo+"\\" + dateTime.ToString("dd/MM/yyyy hh:mm") + " - " + pathandname);
            File.Copy(pathandname, PathToSaveTo);

            /*
                        HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                        HttpContext.Current.Response.AddHeader("Content-Length", file.Length.ToString());
                        HttpContext.Current.Response.ContentType = "text/plain";
                        HttpContext.Current.Response.TransmitFile(file.FullName);
                        HttpContext.Current.Response.End();*/




            MessageBox.Show("تم تصدير الملف بنجاح.");



        }
        public static byte[] GetBinaryFile(string filename)
        {
            byte[] bytes;
            using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[file.Length];
                file.Read(bytes, 0, (int)file.Length);
            }
            return bytes;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*  if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
              {
                  ExportBtnc(folderBrowserDialog1.SelectedPath);
              }*/

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx;";
            string sfdname = saveFileDialog1.FileName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Path.GetFullPath(sfd.FileName);
            }
            //  MessageBox.Show(sfd.FileName );
            ExportBtnc(sfd.FileName);

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            clearTables();
            Home HomeHome = new Home();
            HomeHome.Show();
            this.Hide();
        }

        private void ReportTables_Load(object sender, EventArgs e)
        {

        }
        public string GetSumOfCoulmn(DataTable dt, string CoulmnName)
        {
            int sum = 0;
            foreach (DataRow dr in dt.Rows)
            {
                sum += Convert.ToInt32(dr[CoulmnName].ToString());


            }
            return sum + "";

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TotalOutcutLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
