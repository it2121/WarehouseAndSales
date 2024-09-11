
namespace WarehouseAndSales
{
    partial class CompanyInfoEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SubName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CompanyEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CompanyWebSite = new System.Windows.Forms.TextBox();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(280, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "تغيير الشعار";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "اسم الشركة";
            // 
            // CompanyName
            // 
            this.CompanyName.BackColor = System.Drawing.Color.White;
            this.CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName.Location = new System.Drawing.Point(37, 42);
            this.CompanyName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(397, 35);
            this.CompanyName.TabIndex = 31;
            this.CompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "العنوان الفرعي";
            // 
            // SubName
            // 
            this.SubName.BackColor = System.Drawing.Color.White;
            this.SubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubName.Location = new System.Drawing.Point(37, 85);
            this.SubName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.SubName.Name = "SubName";
            this.SubName.Size = new System.Drawing.Size(397, 35);
            this.SubName.TabIndex = 29;
            this.SubName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "عنوان مقر الشركة";
            // 
            // CompanyAddress
            // 
            this.CompanyAddress.BackColor = System.Drawing.Color.White;
            this.CompanyAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyAddress.Location = new System.Drawing.Point(37, 128);
            this.CompanyAddress.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CompanyAddress.Name = "CompanyAddress";
            this.CompanyAddress.Size = new System.Drawing.Size(397, 35);
            this.CompanyAddress.TabIndex = 35;
            this.CompanyAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "رقم الهاتف";
            // 
            // CompanyPhone
            // 
            this.CompanyPhone.BackColor = System.Drawing.Color.White;
            this.CompanyPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyPhone.Location = new System.Drawing.Point(37, 171);
            this.CompanyPhone.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CompanyPhone.Name = "CompanyPhone";
            this.CompanyPhone.Size = new System.Drawing.Size(397, 35);
            this.CompanyPhone.TabIndex = 33;
            this.CompanyPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "البريد الالكتروني";
            // 
            // CompanyEmail
            // 
            this.CompanyEmail.BackColor = System.Drawing.Color.White;
            this.CompanyEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyEmail.Location = new System.Drawing.Point(37, 220);
            this.CompanyEmail.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CompanyEmail.Name = "CompanyEmail";
            this.CompanyEmail.Size = new System.Drawing.Size(397, 35);
            this.CompanyEmail.TabIndex = 39;
            this.CompanyEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "الموقع الالكتروني";
            // 
            // CompanyWebSite
            // 
            this.CompanyWebSite.BackColor = System.Drawing.Color.White;
            this.CompanyWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyWebSite.Location = new System.Drawing.Point(37, 263);
            this.CompanyWebSite.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CompanyWebSite.Name = "CompanyWebSite";
            this.CompanyWebSite.Size = new System.Drawing.Size(397, 35);
            this.CompanyWebSite.TabIndex = 37;
            this.CompanyWebSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.White;
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPanel.Location = new System.Drawing.Point(37, 305);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(209, 111);
            this.LogoPanel.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(161, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 40);
            this.button2.TabIndex = 42;
            this.button2.Text = "التاكيد";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CompanyInfoEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CompanyEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CompanyWebSite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompanyAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CompanyPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubName);
            this.Controls.Add(this.button1);
            this.Name = "CompanyInfoEditor";
            this.Text = "CompanyInfoEditor";
            this.Load += new System.EventHandler(this.CompanyInfoEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SubName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CompanyAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CompanyPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CompanyEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CompanyWebSite;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Button button2;
    }
}