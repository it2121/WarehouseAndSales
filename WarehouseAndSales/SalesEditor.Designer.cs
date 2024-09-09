namespace WarehouseAndSales
{
    partial class SalesEditor
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
            this.MatName = new System.Windows.Forms.TextBox();
            this.quantlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Quant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Retail = new System.Windows.Forms.RadioButton();
            this.Wholesale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.BuyingParty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SaleDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxQuantInStock = new System.Windows.Forms.TextBox();
            this.DelBtn = new System.Windows.Forms.Button();
            this.ManualWithdraw = new System.Windows.Forms.RadioButton();
            this.AutoWithdraw = new System.Windows.Forms.RadioButton();
            this.WithdrawGroup = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.WithdrawGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatName
            // 
            this.MatName.BackColor = System.Drawing.Color.White;
            this.MatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MatName.Location = new System.Drawing.Point(217, 34);
            this.MatName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MatName.Name = "MatName";
            this.MatName.ReadOnly = true;
            this.MatName.Size = new System.Drawing.Size(360, 35);
            this.MatName.TabIndex = 2;
            this.MatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MatName.TextChanged += new System.EventHandler(this.MatName_TextChanged);
            // 
            // quantlbl
            // 
            this.quantlbl.AutoSize = true;
            this.quantlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantlbl.Location = new System.Drawing.Point(620, 37);
            this.quantlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantlbl.Name = "quantlbl";
            this.quantlbl.Size = new System.Drawing.Size(40, 24);
            this.quantlbl.TabIndex = 5;
            this.quantlbl.Text = "المادة";
            this.quantlbl.Click += new System.EventHandler(this.quantlbl_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(192)))), ((int)(((byte)(119)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(7, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "تحديد المادة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quant
            // 
            this.Quant.BackColor = System.Drawing.Color.White;
            this.Quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quant.Location = new System.Drawing.Point(8, 102);
            this.Quant.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(567, 35);
            this.Quant.TabIndex = 7;
            this.Quant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Quant.TextChanged += new System.EventHandler(this.Quant_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(611, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "الكمية";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "نوع قيد البيع";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Retail
            // 
            this.Retail.AutoSize = true;
            this.Retail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Retail.Location = new System.Drawing.Point(78, 2);
            this.Retail.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Retail.Name = "Retail";
            this.Retail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Retail.Size = new System.Drawing.Size(55, 28);
            this.Retail.TabIndex = 11;
            this.Retail.Text = "مفرد";
            this.Retail.UseVisualStyleBackColor = true;
            this.Retail.CheckedChanged += new System.EventHandler(this.Retail_CheckedChanged);
            // 
            // Wholesale
            // 
            this.Wholesale.AutoSize = true;
            this.Wholesale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Wholesale.Location = new System.Drawing.Point(14, 3);
            this.Wholesale.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Wholesale.Name = "Wholesale";
            this.Wholesale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Wholesale.Size = new System.Drawing.Size(56, 28);
            this.Wholesale.TabIndex = 12;
            this.Wholesale.Text = "جملة";
            this.Wholesale.UseVisualStyleBackColor = true;
            this.Wholesale.CheckedChanged += new System.EventHandler(this.Wholesale_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(588, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "جهة الشراء\r\n ( العميل )";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BuyingParty
            // 
            this.BuyingParty.BackColor = System.Drawing.Color.White;
            this.BuyingParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyingParty.Location = new System.Drawing.Point(217, 239);
            this.BuyingParty.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BuyingParty.Name = "BuyingParty";
            this.BuyingParty.ReadOnly = true;
            this.BuyingParty.Size = new System.Drawing.Size(358, 35);
            this.BuyingParty.TabIndex = 13;
            this.BuyingParty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BuyingParty.TextChanged += new System.EventHandler(this.BuyingParty_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(588, 381);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "الملاحظات";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.White;
            this.Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes.Location = new System.Drawing.Point(8, 377);
            this.Notes.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(567, 35);
            this.Notes.TabIndex = 15;
            this.Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Notes.TextChanged += new System.EventHandler(this.Notes_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(608, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "التاريخ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SaleDate
            // 
            this.SaleDate.BackColor = System.Drawing.Color.White;
            this.SaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleDate.Location = new System.Drawing.Point(8, 308);
            this.SaleDate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.Size = new System.Drawing.Size(567, 35);
            this.SaleDate.TabIndex = 17;
            this.SaleDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SaleDate.TextChanged += new System.EventHandler(this.SaleDate_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(584, 454);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "اجمالي الكلفة";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.Color.White;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(11, 451);
            this.TotalPrice.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(567, 35);
            this.TotalPrice.TabIndex = 19;
            this.TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalPrice.TextChanged += new System.EventHandler(this.TotalPrice_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(192)))), ((int)(((byte)(119)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(153, 615);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(388, 43);
            this.button2.TabIndex = 21;
            this.button2.Text = "التاكيد";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "الكمية المتوفرة في المخازن";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // MaxQuantInStock
            // 
            this.MaxQuantInStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MaxQuantInStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxQuantInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxQuantInStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaxQuantInStock.Location = new System.Drawing.Point(8, 171);
            this.MaxQuantInStock.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaxQuantInStock.Name = "MaxQuantInStock";
            this.MaxQuantInStock.ReadOnly = true;
            this.MaxQuantInStock.Size = new System.Drawing.Size(236, 35);
            this.MaxQuantInStock.TabIndex = 23;
            this.MaxQuantInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MaxQuantInStock.TextChanged += new System.EventHandler(this.MaxQuantInStock_TextChanged);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.ForeColor = System.Drawing.Color.White;
            this.DelBtn.Location = new System.Drawing.Point(153, 675);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(388, 43);
            this.DelBtn.TabIndex = 24;
            this.DelBtn.Text = "حذف";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManualWithdraw
            // 
            this.ManualWithdraw.AutoSize = true;
            this.ManualWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ManualWithdraw.Location = new System.Drawing.Point(273, 46);
            this.ManualWithdraw.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ManualWithdraw.Name = "ManualWithdraw";
            this.ManualWithdraw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ManualWithdraw.Size = new System.Drawing.Size(294, 28);
            this.ManualWithdraw.TabIndex = 26;
            this.ManualWithdraw.Text = "سحب الكمية من المخزن يدوياً في وقت لاحق";
            this.ManualWithdraw.UseVisualStyleBackColor = true;
            this.ManualWithdraw.CheckedChanged += new System.EventHandler(this.ManualWithdraw_CheckedChanged);
            // 
            // AutoWithdraw
            // 
            this.AutoWithdraw.AutoSize = true;
            this.AutoWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AutoWithdraw.Location = new System.Drawing.Point(357, 10);
            this.AutoWithdraw.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.AutoWithdraw.Name = "AutoWithdraw";
            this.AutoWithdraw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AutoWithdraw.Size = new System.Drawing.Size(209, 28);
            this.AutoWithdraw.TabIndex = 25;
            this.AutoWithdraw.Text = "سحب الكمية من المخزن تلقائيا";
            this.AutoWithdraw.UseVisualStyleBackColor = true;
            this.AutoWithdraw.CheckedChanged += new System.EventHandler(this.AutoWithdraw_CheckedChanged);
            // 
            // WithdrawGroup
            // 
            this.WithdrawGroup.Controls.Add(this.AutoWithdraw);
            this.WithdrawGroup.Controls.Add(this.ManualWithdraw);
            this.WithdrawGroup.Location = new System.Drawing.Point(11, 493);
            this.WithdrawGroup.Name = "WithdrawGroup";
            this.WithdrawGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WithdrawGroup.Size = new System.Drawing.Size(567, 100);
            this.WithdrawGroup.TabIndex = 27;
            this.WithdrawGroup.TabStop = false;
            this.WithdrawGroup.Enter += new System.EventHandler(this.WithdrawGroup_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Retail);
            this.groupBox2.Controls.Add(this.Wholesale);
            this.groupBox2.Location = new System.Drawing.Point(437, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 35);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(192)))), ((int)(((byte)(119)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button3.Location = new System.Drawing.Point(7, 237);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 43);
            this.button3.TabIndex = 29;
            this.button3.Text = "تحديد العميل";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // SalesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(678, 749);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.WithdrawGroup);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.MaxQuantInStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaleDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuyingParty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quant);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantlbl);
            this.Controls.Add(this.MatName);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "SalesEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesEditor";
            this.Load += new System.EventHandler(this.SalesEditor_Load);
            this.WithdrawGroup.ResumeLayout(false);
            this.WithdrawGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MatName;
        private System.Windows.Forms.Label quantlbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Quant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Retail;
        private System.Windows.Forms.RadioButton Wholesale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BuyingParty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SaleDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MaxQuantInStock;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.RadioButton ManualWithdraw;
        private System.Windows.Forms.RadioButton AutoWithdraw;
        private System.Windows.Forms.GroupBox WithdrawGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
    }
}