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
            this.SuspendLayout();
            // 
            // MatName
            // 
            this.MatName.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MatName.Location = new System.Drawing.Point(217, 34);
            this.MatName.Name = "MatName";
            this.MatName.Size = new System.Drawing.Size(361, 43);
            this.MatName.TabIndex = 2;
            // 
            // quantlbl
            // 
            this.quantlbl.AutoSize = true;
            this.quantlbl.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantlbl.Location = new System.Drawing.Point(620, 37);
            this.quantlbl.Name = "quantlbl";
            this.quantlbl.Size = new System.Drawing.Size(44, 37);
            this.quantlbl.TabIndex = 5;
            this.quantlbl.Text = "المادة";
            this.quantlbl.Click += new System.EventHandler(this.quantlbl_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lotus Linotype", 14.25F);
            this.button1.Location = new System.Drawing.Point(7, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "تحديد المادة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quant
            // 
            this.Quant.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quant.Location = new System.Drawing.Point(258, 102);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(320, 43);
            this.Quant.TabIndex = 7;
            this.Quant.TextChanged += new System.EventHandler(this.Quant_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(611, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "الكمية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "نوع قيد البيع";
            // 
            // Retail
            // 
            this.Retail.AutoSize = true;
            this.Retail.Font = new System.Drawing.Font("Lotus Linotype", 14.25F);
            this.Retail.Location = new System.Drawing.Point(76, 102);
            this.Retail.Name = "Retail";
            this.Retail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Retail.Size = new System.Drawing.Size(62, 41);
            this.Retail.TabIndex = 11;
            this.Retail.Text = "مفرد";
            this.Retail.UseVisualStyleBackColor = true;
            this.Retail.CheckedChanged += new System.EventHandler(this.Retail_CheckedChanged);
            // 
            // Wholesale
            // 
            this.Wholesale.AutoSize = true;
            this.Wholesale.Font = new System.Drawing.Font("Lotus Linotype", 14.25F);
            this.Wholesale.Location = new System.Drawing.Point(12, 103);
            this.Wholesale.Name = "Wholesale";
            this.Wholesale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Wholesale.Size = new System.Drawing.Size(58, 41);
            this.Wholesale.TabIndex = 12;
            this.Wholesale.Text = "جملة";
            this.Wholesale.UseVisualStyleBackColor = true;
            this.Wholesale.CheckedChanged += new System.EventHandler(this.Wholesale_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "جهة الشراء";
            // 
            // BuyingParty
            // 
            this.BuyingParty.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyingParty.Location = new System.Drawing.Point(7, 163);
            this.BuyingParty.Name = "BuyingParty";
            this.BuyingParty.Size = new System.Drawing.Size(571, 43);
            this.BuyingParty.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(586, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "الملاحظات";
            // 
            // Notes
            // 
            this.Notes.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes.Location = new System.Drawing.Point(7, 301);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(571, 43);
            this.Notes.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(607, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 37);
            this.label5.TabIndex = 18;
            this.label5.Text = "التاريخ";
            // 
            // SaleDate
            // 
            this.SaleDate.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleDate.Location = new System.Drawing.Point(7, 232);
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.Size = new System.Drawing.Size(571, 43);
            this.SaleDate.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(582, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 37);
            this.label6.TabIndex = 20;
            this.label6.Text = "اجمالي الكلفة";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(9, 388);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(571, 43);
            this.TotalPrice.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lotus Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(151, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(388, 43);
            this.button2.TabIndex = 21;
            this.button2.Text = "التاكيد";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SalesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 568);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaleDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuyingParty);
            this.Controls.Add(this.Wholesale);
            this.Controls.Add(this.Retail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quant);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantlbl);
            this.Controls.Add(this.MatName);
            this.Name = "SalesEditor";
            this.Text = "SalesEditor";
            this.Load += new System.EventHandler(this.SalesEditor_Load);
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
    }
}