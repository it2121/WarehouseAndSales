
namespace WarehouseAndSales
{
    partial class BuyingEditor
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
            this.button3 = new System.Windows.Forms.Button();
            this.WithdrawGroup = new System.Windows.Forms.GroupBox();
            this.AutoDepo = new System.Windows.Forms.RadioButton();
            this.ManualDepo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Retail = new System.Windows.Forms.RadioButton();
            this.Wholesale = new System.Windows.Forms.RadioButton();
            this.DelBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BuyingDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SellingParty = new System.Windows.Forms.TextBox();
            this.Notes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Quant = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.quantlbl = new System.Windows.Forms.Label();
            this.MatName = new System.Windows.Forms.TextBox();
            this.WithdrawGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(192)))), ((int)(((byte)(119)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button3.Location = new System.Drawing.Point(10, 171);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 43);
            this.button3.TabIndex = 50;
            this.button3.Text = "تحديد العميل";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // WithdrawGroup
            // 
            this.WithdrawGroup.Controls.Add(this.AutoDepo);
            this.WithdrawGroup.Controls.Add(this.ManualDepo);
            this.WithdrawGroup.Location = new System.Drawing.Point(15, 377);
            this.WithdrawGroup.Name = "WithdrawGroup";
            this.WithdrawGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WithdrawGroup.Size = new System.Drawing.Size(567, 100);
            this.WithdrawGroup.TabIndex = 48;
            this.WithdrawGroup.TabStop = false;
            // 
            // AutoDepo
            // 
            this.AutoDepo.AutoSize = true;
            this.AutoDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AutoDepo.Location = new System.Drawing.Point(385, 10);
            this.AutoDepo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.AutoDepo.Name = "AutoDepo";
            this.AutoDepo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AutoDepo.Size = new System.Drawing.Size(172, 28);
            this.AutoDepo.TabIndex = 25;
            this.AutoDepo.Text = "ايداع الكمية بشكل تلقائي";
            this.AutoDepo.UseVisualStyleBackColor = true;
            // 
            // ManualDepo
            // 
            this.ManualDepo.AutoSize = true;
            this.ManualDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ManualDepo.Location = new System.Drawing.Point(339, 46);
            this.ManualDepo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ManualDepo.Name = "ManualDepo";
            this.ManualDepo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ManualDepo.Size = new System.Drawing.Size(218, 28);
            this.ManualDepo.TabIndex = 26;
            this.ManualDepo.Text = "ايداع الكمية يدوياً في وقت لاحق";
            this.ManualDepo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Retail);
            this.groupBox2.Controls.Add(this.Wholesale);
            this.groupBox2.Location = new System.Drawing.Point(442, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 35);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
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
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.ForeColor = System.Drawing.Color.White;
            this.DelBtn.Location = new System.Drawing.Point(155, 559);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(388, 43);
            this.DelBtn.TabIndex = 47;
            this.DelBtn.Text = "حذف";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(192)))), ((int)(((byte)(119)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(155, 499);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(388, 43);
            this.button2.TabIndex = 44;
            this.button2.Text = "التاكيد";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(588, 333);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = "اجمالي الكلفة";
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.Color.White;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(15, 326);
            this.TotalPrice.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(567, 35);
            this.TotalPrice.TabIndex = 42;
            this.TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(588, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "التاريخ";
            // 
            // BuyingDate
            // 
            this.BuyingDate.BackColor = System.Drawing.Color.White;
            this.BuyingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyingDate.Location = new System.Drawing.Point(12, 226);
            this.BuyingDate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BuyingDate.Name = "BuyingDate";
            this.BuyingDate.Size = new System.Drawing.Size(567, 35);
            this.BuyingDate.TabIndex = 40;
            this.BuyingDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(588, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "الملاحظات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(588, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 40);
            this.label3.TabIndex = 37;
            this.label3.Text = "جهة الشراء\r\n ( العميل )";
            // 
            // SellingParty
            // 
            this.SellingParty.BackColor = System.Drawing.Color.White;
            this.SellingParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingParty.Location = new System.Drawing.Point(220, 176);
            this.SellingParty.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.SellingParty.Name = "SellingParty";
            this.SellingParty.ReadOnly = true;
            this.SellingParty.Size = new System.Drawing.Size(358, 35);
            this.SellingParty.TabIndex = 36;
            this.SellingParty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.White;
            this.Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes.Location = new System.Drawing.Point(12, 276);
            this.Notes.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(567, 35);
            this.Notes.TabIndex = 38;
            this.Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "نوع قيد البيع";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "الكمية";
            // 
            // Quant
            // 
            this.Quant.BackColor = System.Drawing.Color.White;
            this.Quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quant.Location = new System.Drawing.Point(13, 76);
            this.Quant.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(567, 35);
            this.Quant.TabIndex = 33;
            this.Quant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(192)))), ((int)(((byte)(119)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(10, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 43);
            this.button1.TabIndex = 32;
            this.button1.Text = "تحديد المادة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quantlbl
            // 
            this.quantlbl.AutoSize = true;
            this.quantlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantlbl.Location = new System.Drawing.Point(588, 29);
            this.quantlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantlbl.Name = "quantlbl";
            this.quantlbl.Size = new System.Drawing.Size(40, 24);
            this.quantlbl.TabIndex = 31;
            this.quantlbl.Text = "المادة";
            // 
            // MatName
            // 
            this.MatName.BackColor = System.Drawing.Color.White;
            this.MatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MatName.Location = new System.Drawing.Point(220, 26);
            this.MatName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MatName.Name = "MatName";
            this.MatName.ReadOnly = true;
            this.MatName.Size = new System.Drawing.Size(360, 35);
            this.MatName.TabIndex = 30;
            this.MatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BuyingEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 618);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.WithdrawGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BuyingDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SellingParty);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quant);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantlbl);
            this.Controls.Add(this.MatName);
            this.MaximizeBox = false;
            this.Name = "BuyingEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyingEditor";
            this.WithdrawGroup.ResumeLayout(false);
            this.WithdrawGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox WithdrawGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Retail;
        private System.Windows.Forms.RadioButton Wholesale;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BuyingDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SellingParty;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Quant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label quantlbl;
        private System.Windows.Forms.TextBox MatName;
        private System.Windows.Forms.RadioButton AutoDepo;
        private System.Windows.Forms.RadioButton ManualDepo;
    }
}