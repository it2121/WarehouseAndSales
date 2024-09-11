using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAndSales
{
    public partial class CompanyInfoEditor : Form
    {
        public CompanyInfoEditor()
        {
            InitializeComponent();

            LogoPanel.BackgroundImage = returnLogo();


            DataTable dt = BAL.GetCompanyInfo();
            foreach (DataRow dr in dt.Rows)
            {
                CompanyName.Text = dr["CompanyName"].ToString();
                SubName.Text = dr["SubName"].ToString();
                CompanyAddress.Text = dr["CompanyAddress"].ToString();
                CompanyPhone.Text = dr["CompanyPhone"].ToString();
                CompanyEmail.Text = dr["CompanyEmail"].ToString();
                CompanyWebSite.Text = dr["CompanyWebSite"].ToString();

            }
        }
        public Image returnLogo()
        {
            DataTable dt = BAL.GetLogo();
            byte[] imageBA = (byte[])dt.Rows[0][0];

            try
            {
                MemoryStream ms = new MemoryStream(imageBA, 0, imageBA.Length);
                ms.Write(imageBA, 0, imageBA.Length);
                return Image.FromStream(ms, true);
            }
            catch
            {

            }
            return null;

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
          /*  string st = openFileDialog1.FileName;
            MessageBox.Show(st);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                // string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true      
                byte[] data = System.IO.File.ReadAllBytes(sFileName);
                BAL.ChangeLogo(data);
            }


            LogoPanel.BackgroundImage = returnLogo();

        }

        private void CompanyInfoEditor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BAL.UpdateCompanyInfo(CompanyName.Text,SubName.Text,CompanyAddress.Text,CompanyPhone.Text,CompanyEmail.Text,CompanyWebSite.Text);

            Home h = new Home();
            h.Show();
            this.Hide();
        
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            Home h = new Home();
            h.Show();
            this.Hide();
        }

    }
}
