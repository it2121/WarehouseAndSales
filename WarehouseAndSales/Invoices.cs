using System;
using ESC_POS_USB_NET.Printer;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = iTextSharp.text.Rectangle;
using Font = iTextSharp.text.Font;
using System.IO;
using ImageMagick;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace WarehouseAndSales
{
    public partial class Invoices : Form
    {
        string kitchenPName = "";

        Printer Kprinter;
        public List<int> CheksList = new List<int>();
        public Invoices()
        {
            InitializeComponent();


            DataTable dt = BAL.GetAllSales();
            InvDG.DataSource = dt;
            InvDG.Columns["ID"].Visible = false;


            // Kprinter = new Printer(kitchenPName);
        }

        private void matsDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCheckBoxCell check = ((DataGridViewCheckBoxCell)InvDG.Rows[e.RowIndex].Cells[e.ColumnIndex]);


            ((DataGridViewCheckBoxCell)InvDG.Rows[e.RowIndex].Cells[e.ColumnIndex]).Value = 1;
            ((DataGridViewCheckBoxCell)InvDG.Rows[e.RowIndex].Cells[e.ColumnIndex]).Selected = true;

            if (!CheksList.Contains(e.RowIndex))
            {
                CheksList.Add(e.RowIndex);
            }
            else
            {
                ((DataGridViewCheckBoxCell)InvDG.Rows[e.RowIndex].Cells[e.ColumnIndex]).Value = 0;
                ((DataGridViewCheckBoxCell)InvDG.Rows[e.RowIndex].Cells[e.ColumnIndex]).Selected = false;
                CheksList.Remove(e.RowIndex);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CheksList.Count + "");
             Print(CheksList);

            /*    foreach (int index in CheksList)
                {

                    int ID = Convert.ToInt32(InvDG.Rows[index].Cells["ID"].Value.ToString());
                   // IDListMessageBox.Show(ID +"");

                }*/

        }

        public System.Drawing.Image returnLogo()
        {
            DataTable dt = BAL.GetLogo();
            byte[] imageBA = (byte[])dt.Rows[0][0];

            try
            {
                MemoryStream ms = new MemoryStream(imageBA, 0, imageBA.Length);
                ms.Write(imageBA, 0, imageBA.Length);
                return System.Drawing.Image.FromStream(ms, true);
            }
            catch
            {

            }
            return null;

        }
        void checkIfLogoExistForPriting()
        {
            // if (!File.Exists("logo.png"))
            // {

            returnLogo().Save("logo.png");

            //}



        }
        public void Print(List<int> IDList)
        {

            checkIfLogoExistForPriting();


            PdfPTable ImageTable = new PdfPTable(1);

            ImageTable.WidthPercentage = 100;

            ImageTable.HorizontalAlignment = Element.ALIGN_CENTER;
            ImageTable.SetWidths(new float[] { 600 });
            ImageTable.SpacingBefore = 0f;
            ImageTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            ImageTable.TotalWidth = 380f;
            ImageTable.LockedWidth = false;



            PdfPTable table = new PdfPTable(2);

            table.WidthPercentage = 100;

            table.HorizontalAlignment = Element.ALIGN_CENTER;
            table.SetWidths(new float[] { 200f, 100f });
            table.SpacingBefore = 2f;
            table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            table.TotalWidth = 380f;
            table.LockedWidth = true;

            PdfPTable argyTableShort = new PdfPTable(3);
            argyTableShort.WidthPercentage = 100;

            argyTableShort.HorizontalAlignment = Element.ALIGN_CENTER;
            argyTableShort.SetWidths(new float[] { 200, 200, 200});
            argyTableShort.SpacingBefore = 0f;
            argyTableShort.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            argyTableShort.TotalWidth = 380f;
            argyTableShort.LockedWidth = true;



            PdfPTable CompanyInfoTable = new PdfPTable(1);
            CompanyInfoTable.WidthPercentage = 100;

            CompanyInfoTable.HorizontalAlignment = Element.ALIGN_CENTER;
            CompanyInfoTable.SetWidths(new float[] { 600 });
            CompanyInfoTable.SpacingBefore = 0f;
            CompanyInfoTable.SpacingAfter = 0f;
            CompanyInfoTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            CompanyInfoTable.TotalWidth = 380f;
            CompanyInfoTable.LockedWidth = true;



            PdfPTable ContactTable = new PdfPTable(2);
            ContactTable.WidthPercentage = 100;

            ContactTable.HorizontalAlignment = Element.ALIGN_CENTER;
            ContactTable.SetWidths(new float[] { 300, 300 });
            ContactTable.SpacingBefore = 0f;
            ContactTable.SpacingAfter = 0f;
            ContactTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            ContactTable.TotalWidth = 380f;
            ContactTable.LockedWidth = true;











          




            // foreach (int row in ArgyID)
            // {


            int price = 123;


            // argyTable.AddCell(CreateCell(ArgyListName.ElementAt(iiii).ToString(), PdfPCell.ALIGN_CENTER));
            int counter = 1;
            foreach (int ID in IDList)

            {
                DataTable datatable = BAL.GetSaleRecordForPrint(ID);
                foreach (DataRow dr in datatable.Rows)
                {
                    argyTableShort.AddCell(CreateCell(  "المادة رقم : " + counter, PdfPCell.ALIGN_LEFT, 8, 0));
                    argyTableShort.AddCell(CreateCell("", PdfPCell.ALIGN_LEFT, 8, 0));
                    argyTableShort.AddCell(CreateCell("", PdfPCell.ALIGN_CENTER, 8, 0));


                    argyTableShort.AddCell(CreateCell("الاسم", PdfPCell.ALIGN_CENTER, 12, 2));
                    argyTableShort.AddCell(CreateCell("اسم المادة", PdfPCell.ALIGN_CENTER, 12, 2));
                    argyTableShort.AddCell(CreateCell("التاريخ", PdfPCell.ALIGN_CENTER, 12, 2));


                    argyTableShort.AddCell(CreateCell(dr["FullName"].ToString(), PdfPCell.ALIGN_CENTER, 11, 1));
                    argyTableShort.AddCell(CreateCell(dr["MatName"].ToString(), PdfPCell.ALIGN_CENTER, 11, 1));
                    argyTableShort.AddCell(CreateCell(dr["SaleDate"].ToString(), PdfPCell.ALIGN_CENTER, 11, 1));




                    argyTableShort.AddCell(CreateCell("الكمية", PdfPCell.ALIGN_CENTER, 12, 2));
                    argyTableShort.AddCell(CreateCell("المبلغ", PdfPCell.ALIGN_CENTER, 12, 2));
                    argyTableShort.AddCell(CreateCell("نوع البيع", PdfPCell.ALIGN_CENTER, 12, 2));

                    argyTableShort.AddCell(CreateCell(dr["Quant"].ToString(), PdfPCell.ALIGN_CENTER, 12, 1));
                    argyTableShort.AddCell(CreateCell(dr["TotalPrice"].ToString(), PdfPCell.ALIGN_CENTER, 11, 1));
                    argyTableShort.AddCell(CreateCell(dr["TypeOfSale"].ToString(), PdfPCell.ALIGN_CENTER, 11, 1));
                    counter++;


                }
            }

            DateTime dateTime = DateTime.Now;
            

            argyTableShort.AddCell(CreateCell("", PdfPCell.ALIGN_CENTER, 15, 0));
            argyTableShort.AddCell(CreateCell("", PdfPCell.ALIGN_CENTER, 15, 0));
            argyTableShort.AddCell(CreateCell("", PdfPCell.ALIGN_CENTER, 15, 0));

            argyTableShort.AddCell(CreateCell("تاريخ سحب الفاتورة", PdfPCell.ALIGN_LEFT, 12, 0));
            argyTableShort.AddCell(CreateCell(dateTime.ToString("hh:mm:ss tt"), PdfPCell.ALIGN_CENTER, 12, 0));

            argyTableShort.AddCell(CreateCell(dateTime.ToString("dd/MM/yyyy"), PdfPCell.ALIGN_RIGHT, 12, 0));




            argyTableShort.AddCell(CreateCell("", PdfPCell.ALIGN_CENTER, 15, 0));
            argyTableShort.AddCell(CreateCell("", PdfPCell.ALIGN_CENTER, 15, 0));
            argyTableShort.AddCell(CreateCell("", PdfPCell.ALIGN_CENTER, 15, 0));


            DataTable dt = BAL.GetCompanyInfo();
            foreach (DataRow dr in dt.Rows)
            {


                CompanyInfoTable.AddCell(CreateFooterCell(dr["CompanyName"].ToString(), PdfPCell.ALIGN_LEFT, 15, 0));
                CompanyInfoTable.AddCell(CreateFooterCell(dr["SubName"].ToString(), PdfPCell.ALIGN_LEFT, 11, 0));
                CompanyInfoTable.AddCell(CreateFooterCell(dr["CompanyAddress"].ToString(), PdfPCell.ALIGN_LEFT, 11, 0));
                CompanyInfoTable.AddCell(CreateFooterCell(dr["CompanyPhone"].ToString(), PdfPCell.ALIGN_LEFT, 11, 0));
                ContactTable.AddCell(CreateFooterCell(dr["CompanyEmail"].ToString(), PdfPCell.ALIGN_CENTER, 11, 0));
                ContactTable.AddCell(CreateFooterCell(dr["CompanyWebSite"].ToString(), PdfPCell.ALIGN_CENTER, 11, 0));

            }


            // argyTable.AddCell(CreateCell(ArgyAmount.ElementAt(iiii).ToString(), PdfPCell.ALIGN_CENTER, 22));



            //  iiii++;
            // }


            PdfPTable tabhead = new PdfPTable(1);
            PdfPCell celllogo;
            tabhead.SpacingAfter = 2F;
            tabhead.TotalWidth = 380f;
            tabhead.WidthPercentage = 100;

            tabhead.LockedWidth = true;
            tabhead.SetWidths(new float[] { 1f });
            float h = tabhead.TotalHeight;


            string path = "logo.png";
            celllogo = ImageCell(path, 15f, PdfPCell.ALIGN_CENTER);
            ImageTable.AddCell(celllogo);

            //  MessageBox.Show(System.IO.Path.GetDirectoryName(Application.ExecutablePath)); 

            System.IO.FileStream Argyfs = new FileStream("Invoice.pdf", FileMode.OpenOrCreate);

            float h3 = 0;
            h3 += ImageTable.TotalHeight;
            h3 += table.TotalHeight;
            h3 += argyTableShort.TotalHeight;
            h3 += CompanyInfoTable.TotalHeight;
            h3 += ContactTable.TotalHeight;


            // h3 += timeTbl.TotalHeight;
            var newdockArgy = new Rectangle(390, h3 + 20);
            //  MessageBox.Show(newdock1.Width+"-"+ newdock1.Height);
            // MessageBox.Show(table.TotalHeight + "- "+ table.TotalWidth);
            newdockArgy.BackgroundColor = new BaseColor(Color.White);


            iTextSharp.text.Document Argydocument = new iTextSharp.text.Document(newdockArgy, 10, 10, 0, 0);

            /*       iTextSharp.text.Rectangle rec = new iTextSharp.text.Rectangle(iTextSharp.text.PageSize.A7);
             rec.BackgroundColor = new BaseColor(Color.White);
             iTextSharp.text.Document Kdocument = new iTextSharp.text.Document(rec, 15, 15, 20, 20);*/


            PdfWriter Argywriter = PdfWriter.GetInstance(Argydocument, Argyfs);








            Argywriter.Open();
            Argydocument.Open();

            Argydocument.Add(ImageTable);







            Argydocument.Add(table);

            Argydocument.Add(argyTableShort);
            Argydocument.Add(CompanyInfoTable);
            Argydocument.Add(ContactTable);



            //  Argydocument.Add(timeTbl);


            Argydocument.Close();
            Argywriter.Close();

            Argyfs.Close();







            var Asettings = new MagickReadSettings();
            Asettings.Density = new Density(300, 300);
            var ApageE = 0;

            using (var images = new MagickImageCollection())
            {
                images.Read("Invoice.pdf", Asettings);


                foreach (var image3 in images)
                {
                    image3.WriteAsync("Invoice.bmp");

                    ApageE++;
                }
            }



            // Bitmap b = (Bitmap)System.Drawing.Image.FromFile("Invoice.bmp");


            /*    Bitmap image22;
                using (var bitmap = new Bitmap("Invoice.bmp"))
                {
                    image22 = new Bitmap(bitmap);

                }
    */

            //  Kprinter.Image(image22);


            //  Kprinter.FullPaperCut();











        }
        private static PdfPCell CreateFooterCell(string text, int align, int textSize = 0, int gray = 0)
        {


            string fontLoc = "font.ttf"; // make sure to have the correct path to the font file
            BaseFont bf = BaseFont.CreateFont(fontLoc, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font f;
            if (textSize == 0)
            {
                if (text.Length <= 7)
                {
                    f = new Font(bf, Convert.ToInt16((23 + 4)));
                }
                else if (text.Length > 7 && text.Length <= 12)
                {
                    f = new Font(bf, Convert.ToInt16((21 + 4)));

                }
                else if (text.Length > 12 && text.Length <= 17)

                { f = new Font(bf, Convert.ToInt16((20 + 4))); }
                else

                { f = new Font(bf, Convert.ToInt16((18 + 4))); }
            }
            else
            {
                f = new Font(bf, textSize + 4);

            }
            Phrase phrase = new Phrase(text, f);
            PdfPCell cell = new PdfPCell(phrase);

            if (gray == 2)
            {
                cell.BackgroundColor = GrayColor.GRAY;
                cell.BorderWidth = 1.5f;

            }
            else if (gray == 1)
            {
                cell.BackgroundColor = GrayColor.WHITE;
                cell.BorderWidth = 1.5f;

            }
            else if (gray == 0)
            {
                cell.BackgroundColor = GrayColor.WHITE;
                cell.BorderWidth = 0f;

            }
            cell.FixedHeight = 25f;
            cell.HorizontalAlignment = align;
            cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

            return cell;


        }

        private static PdfPCell CreateCell(string text, int align, int textSize = 0, int gray = 0)
        {


            string fontLoc = "font.ttf"; // make sure to have the correct path to the font file
            BaseFont bf = BaseFont.CreateFont(fontLoc, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font f;
            if (textSize == 0)
            {
                if (text.Length <= 7)
                {
                    f = new Font(bf, Convert.ToInt16((23 + 4)));
                }
                else if (text.Length > 7 && text.Length <= 12)
                {
                    f = new Font(bf, Convert.ToInt16((21 + 4)));

                }
                else if (text.Length > 12 && text.Length <= 17)

                { f = new Font(bf, Convert.ToInt16((20 + 4))); }
                else

                { f = new Font(bf, Convert.ToInt16((18 + 4))); }
            }
            else
            {
                f = new Font(bf, textSize + 4);

            }
            Phrase phrase = new Phrase(text, f);
            PdfPCell cell = new PdfPCell(phrase);

            if (gray == 2)
            {
                cell.BackgroundColor = GrayColor.LIGHT_GRAY;
                cell.BorderWidth = 1.5f;

            }
            else if (gray == 1)
            {
                cell.BackgroundColor = GrayColor.WHITE;
                cell.BorderWidth = 1.5f;

            }
            else if (gray == 0)
            {
                cell.BackgroundColor = GrayColor.WHITE;
                cell.BorderWidth = 0f;

            }
            cell.FixedHeight = 30f;
            cell.HorizontalAlignment = align;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;

            return cell;


        }

        private static PdfPCell ImageCell(string path, float scale, int align)
        {

            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(path);
            image.ScalePercent(scale);
            PdfPCell cell = new PdfPCell(image);
            cell.BorderColor = BaseColor.WHITE;
            cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
            cell.HorizontalAlignment = align;
            cell.PaddingBottom = 0f;
            cell.PaddingTop = 0f;



            return cell;
        }

        private void Invoices_Load(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }

    }
}
