using ClosedXML.Excel;
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





    // green #08e4eb
    //header #242e3a
    // light bg #f4f4f4
    //dark bg #1b1d2a
    //redsh #fd4d52
    //orangesh #fdbd4d


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
            UserFullNameLbl.Text = Global.getfullname();

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
            SalaryManagment.Visible = Helper.UserHasRole("SalaryManagment");
            EmpManagment.Visible = Helper.UserHasRole("EmpManagment");
            Expense.Visible = Helper.UserHasRole("Expense");
            InvoicePrint.Visible = Helper.UserHasRole("InvoicePrint");
            PrinterNameSettingBtn.Visible = Helper.UserHasRole("InvoicePrint");
            Reports.Visible = Helper.UserHasRole("Reports");
            CustomerReport.Visible = Helper.UserHasRole("CustomerReport");
            ProviderReport.Visible = Helper.UserHasRole("ProviderReport");
            Backup.Visible = Helper.UserHasRole("Backup");

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Emps seth = new Emps();
            seth.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Salarys eth = new Salarys();
            eth.Show();
            this.Hide();

        }

        private void Expense_Click(object sender, EventArgs e)
        {
            Expense ex = new Expense();
            ex.Show();
            this.Hide();
        }

        private void InvoicePrint_Click(object sender, EventArgs e)
        {
            Invoices inv = new Invoices();
            inv.Show();
            this.Hide();
        }

        private void UsersManagment_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Show();
            this.Hide();
        }

        private void Mats_Click(object sender, EventArgs e)
        {
            Mats mats = new Mats();
            mats.Show();
            this.Hide();
        }

        private void Warehouses_Click(object sender, EventArgs e)
        {
            Warehouses warehouses = new Warehouses();
            warehouses.Show();
            this.Hide();
        }

        private void Buyings_Click(object sender, EventArgs e)
        {
            Buying b = new Buying();
            b.Show();
            this.Hide();
        }

        private void sellings_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }

        private void ProvidersAndBuyers2_Click(object sender, EventArgs e)
        {
            ProvidersAndCustomers.ProviderOrCustomer = "customer";
            ProvidersAndCustomers providersAndCustomers = new ProvidersAndCustomers();
            providersAndCustomers.Show();
            this.Hide();
        }

        private void ProvidersAndBuyers_Click(object sender, EventArgs e)
        {
            ProvidersAndCustomers.ProviderOrCustomer = "provider";
            ProvidersAndCustomers providersAndCustomers = new ProvidersAndCustomers();
            providersAndCustomers.Show();
            this.Hide();
        }

        private void Expense_Click_1(object sender, EventArgs e)
        {
            Expense ex = new Expense();
            ex.Show();
            this.Hide();
        }

        private void SalaryManagment_Click(object sender, EventArgs e)
        {
            Salarys eth = new Salarys();
            eth.Show();
            this.Hide();
        }

        private void EmpManagment_Click(object sender, EventArgs e)
        {
            Emps seth = new Emps();
            seth.Show();
            this.Hide();

        }

        private void CompanyInfo_Click(object sender, EventArgs e)
        {
            CompanyInfoEditor c = new CompanyInfoEditor();
            c.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            PrinterNameSetting p = new PrinterNameSetting();
            p.Show();
            this.Hide();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            Reports repor = new Reports();
            repor.Show();
            this.Hide();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void CustomerReport_Click(object sender, EventArgs e)
        {
            ProvidersAndCustomersSelector.From = "Home";
            ProvidersAndCustomersSelector.ProviderOrCustomer = "customer";
            ProvidersAndCustomersSelector pr = new ProvidersAndCustomersSelector();
            pr.Show();
            this.Hide();
        }

        private void ProviderReport_Click(object sender, EventArgs e)
        {
            ProvidersAndCustomersSelector.From = "Home";
            ProvidersAndCustomersSelector.ProviderOrCustomer = "provider";
            ProvidersAndCustomersSelector pr = new ProvidersAndCustomersSelector();
            pr.Show();
            this.Hide();
        }


        public void CreateExcelBackUpFile() {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx;";
            string sfdname = saveFileDialog1.FileName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Path.GetFullPath(sfd.FileName);
            }
            //  MessageBox.Show(sfd.FileName );
            ExportBtnc(sfd.FileName);

           // ExportBtnc(sfd.FileName);
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

            
                DataTable BuyingsTable1 = BAL.GetAllBuying();
                BuyingsTable1.TableName = "المشتريات";
                wb.Worksheets.Add(BuyingsTable1);
                sheetCounter++;

            DataTable BuyingsTablePayments = BAL.GetPaymentsOfRecID(Convert.ToInt32(BuyingsTable1.Rows[0]["ID"].ToString())).Clone();
            BuyingsTablePayments.Clear();
            foreach (DataRow dr in BuyingsTable1.Rows)
            {

                foreach (DataRow innerDR  in BAL.GetPaymentsOfRecID(Convert.ToInt32( dr["ID"].ToString())).Rows)
                {
                    BuyingsTablePayments.ImportRow(innerDR);


                }

            }

                DataTable BuyingsTablePayments1 = BuyingsTablePayments;
                BuyingsTablePayments1.TableName = "دفعات المشتريات";
                wb.Worksheets.Add(BuyingsTablePayments1);
                sheetCounter++;

                DataTable SalesTable1 = BAL.GetAllSales();
                SalesTable1.TableName = "المبيعات";
                wb.Worksheets.Add(SalesTable1);
                sheetCounter++;

            DataTable SalesTablePayments = BAL.GetPaymentsOfRecID(Convert.ToInt32(SalesTable1.Rows[0]["ID"].ToString())).Clone();
            SalesTablePayments.Clear();
            foreach (DataRow dr in SalesTable1.Rows)
            {

                foreach (DataRow innerDR in BAL.GetPaymentsOfRecID(Convert.ToInt32(dr["ID"].ToString())).Rows)
                {
                    SalesTablePayments.ImportRow(innerDR);


                }

            }


            DataTable SalesTablePayments1 = SalesTablePayments;
                SalesTablePayments1.TableName = "دفعات المبيعات";
                wb.Worksheets.Add(SalesTablePayments1);
                sheetCounter++;

                DataTable SalaryesTable1 = BAL.GetAllSalarys();
                SalaryesTable1.TableName = "صرفيات الرواتب";
                wb.Worksheets.Add(SalaryesTable1);
                sheetCounter++;

                DataTable ExpencesTable1 = BAL.GetAllExpense();
            ExpencesTable1.TableName = "الصرفيات العامة";
                wb.Worksheets.Add(ExpencesTable1);
                sheetCounter++;


            DataTable CustomersTable1 = BAL.GetAllCustomers();
            CustomersTable1.TableName = "العملاء";
            wb.Worksheets.Add(CustomersTable1);
            sheetCounter++;

            DataTable ProvidersTable1 = BAL.GetAllProviders();
            ProvidersTable1.TableName = "المزودين";
            wb.Worksheets.Add(ProvidersTable1);
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

        private void Backup_Click(object sender, EventArgs e)
        {
            CreateExcelBackUpFile();
        }

        private void UserFullNameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
