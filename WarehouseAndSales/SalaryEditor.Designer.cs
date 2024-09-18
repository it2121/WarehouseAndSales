
namespace WarehouseAndSales
{
    partial class SalaryEditor
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
            this.button1 = new System.Windows.Forms.Button();
            this.quantlbl = new System.Windows.Forms.Label();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RecAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SalaryRecDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.TextBox();
            this.DelBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(192)))), ((int)(((byte)(119)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(36, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "تحديد الموظف";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quantlbl
            // 
            this.quantlbl.AutoSize = true;
            this.quantlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantlbl.Location = new System.Drawing.Point(570, 60);
            this.quantlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantlbl.Name = "quantlbl";
            this.quantlbl.Size = new System.Drawing.Size(59, 24);
            this.quantlbl.TabIndex = 8;
            this.quantlbl.Text = "الموظف";
            // 
            // EmpName
            // 
            this.EmpName.BackColor = System.Drawing.Color.White;
            this.EmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmpName.Location = new System.Drawing.Point(261, 53);
            this.EmpName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(291, 35);
            this.EmpName.TabIndex = 7;
            this.EmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "مبلغ المرتب";
            // 
            // RecAmount
            // 
            this.RecAmount.BackColor = System.Drawing.Color.White;
            this.RecAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecAmount.Location = new System.Drawing.Point(36, 107);
            this.RecAmount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.RecAmount.Name = "RecAmount";
            this.RecAmount.Size = new System.Drawing.Size(516, 35);
            this.RecAmount.TabIndex = 10;
            this.RecAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "التاريخ";
            // 
            // SalaryRecDate
            // 
            this.SalaryRecDate.BackColor = System.Drawing.Color.White;
            this.SalaryRecDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryRecDate.Location = new System.Drawing.Point(36, 162);
            this.SalaryRecDate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.SalaryRecDate.Name = "SalaryRecDate";
            this.SalaryRecDate.Size = new System.Drawing.Size(516, 35);
            this.SalaryRecDate.TabIndex = 12;
            this.SalaryRecDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "الملاحظات";
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.White;
            this.Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes.Location = new System.Drawing.Point(36, 226);
            this.Notes.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(516, 35);
            this.Notes.TabIndex = 14;
            this.Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.ForeColor = System.Drawing.Color.White;
            this.DelBtn.Location = new System.Drawing.Point(142, 381);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(388, 43);
            this.DelBtn.TabIndex = 26;
            this.DelBtn.Text = "حذف";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(192)))), ((int)(((byte)(119)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(142, 321);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(388, 43);
            this.button2.TabIndex = 25;
            this.button2.Text = "التاكيد";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SalaryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 498);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalaryRecDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecAmount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantlbl);
            this.Controls.Add(this.EmpName);
            this.Name = "SalaryEditor";
            this.Text = "SalaryEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label quantlbl;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RecAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SalaryRecDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button button2;
    }
}