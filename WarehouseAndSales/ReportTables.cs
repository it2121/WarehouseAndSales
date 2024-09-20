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
        public static DataTable BuyingsTable = null;
        public static DataTable BuyingsTablePayments = null;
        public static DataTable SalesTable = null;
        public static DataTable SalesTablePayments = null;
        public static DataTable SalaryesTable = null;
        public static DataTable ExpencesTable = null;
        public ReportTables()
        {
            InitializeComponent();
            BuyingsDG.DataSource = BuyingsTable;
            SalesDG.DataSource = SalesTable;
            BuyingsPayemtnsG.DataSource = BuyingsTablePayments;
            SalesPayemtntsG.DataSource = SalesTablePayments;
            SalesPayemtntsG.DataSource = SalesTablePayments;
            SalaryG.DataSource = SalaryesTable;
            ExpencesG.DataSource = ExpencesTable;



            BuyingsPayemtnsCountLbl.Text = BuyingsTablePayments.Rows.Count + "";
            SalesPayemtnsCountLbl.Text = SalesTablePayments.Rows.Count + "";
            BuyingsSumLbl.Text = GetSumOfCoulmn(BuyingsTablePayments, "مبلغ_الدفعة");
            SalesSumLbl.Text = GetSumOfCoulmn(SalesTablePayments, "مبلغ_الدفعة");

            SalarySumLbl.Text = GetSumOfCoulmn(SalaryesTable, "المبلغ_المستلم");
            ExpencesSumLbl.Text = GetSumOfCoulmn(ExpencesTable, "المبلغ");


            TotalOutcutLbl.Text = (Convert.ToInt32(BuyingsSumLbl.Text) + Convert.ToInt32(SalarySumLbl.Text) + Convert.ToInt32(ExpencesSumLbl.Text))+"" ;
            TotalIncomeLbl.Text = (Convert.ToInt32(SalarySumLbl.Text) )+"" ;
            ProfitLbl.Text = ((Convert.ToInt32(TotalIncomeLbl.Text) ) - (Convert.ToInt32(TotalOutcutLbl.Text))) +"";

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
            DataTable BuyingsTable1 = BuyingsTable;
            BuyingsTable1.TableName = "المشتريات";
            wb.Worksheets.Add(BuyingsTable1);
            sheetCounter++;

            DataTable BuyingsTablePayments1 = BuyingsTablePayments;
            BuyingsTablePayments1.TableName = "دفعات المشتريات";
            wb.Worksheets.Add(BuyingsTablePayments1);
            sheetCounter++;

            DataTable SalesTable1 = SalesTable;
            SalesTable1.TableName = "المبيعات";
            wb.Worksheets.Add(SalesTable1);
            sheetCounter++;

            DataTable SalesTablePayments1 = SalesTablePayments;
            SalesTablePayments1.TableName = "دفعات المبيعات";
            wb.Worksheets.Add(SalesTablePayments1);
            sheetCounter++;

            DataTable SalaryesTable1 = SalaryesTable;
            SalaryesTable1.TableName = "صرفيات الرواتب";
            wb.Worksheets.Add(SalaryesTable1);
            sheetCounter++;
            
            DataTable ExpencesTable1 = ExpencesTable;
            ExpencesTable.TableName = "الصرفيات العامة";
            wb.Worksheets.Add(ExpencesTable);
            sheetCounter++;


       


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

            Home HomeHome = new Home();
            HomeHome.Show();
            this.Hide();
        }

        private void ReportTables_Load(object sender, EventArgs e)
        {

        }
        public string GetSumOfCoulmn(DataTable dt , string CoulmnName)
        {
            int sum = 0;
            foreach(DataRow dr in dt.Rows)
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
