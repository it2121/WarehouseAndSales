
namespace WarehouseAndSales
{
    partial class PaymentEditor
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
            this.DelBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PaymentAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PaymentDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.ForeColor = System.Drawing.Color.White;
            this.DelBtn.Location = new System.Drawing.Point(128, 259);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(388, 43);
            this.DelBtn.TabIndex = 32;
            this.DelBtn.Text = "حذف";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(192)))), ((int)(((byte)(119)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(128, 199);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(388, 43);
            this.button2.TabIndex = 31;
            this.button2.Text = "التاكيد";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(543, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "مقدار الدفعة";
            // 
            // PaymentAmount
            // 
            this.PaymentAmount.BackColor = System.Drawing.Color.White;
            this.PaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentAmount.Location = new System.Drawing.Point(44, 41);
            this.PaymentAmount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.PaymentAmount.Name = "PaymentAmount";
            this.PaymentAmount.Size = new System.Drawing.Size(486, 35);
            this.PaymentAmount.TabIndex = 27;
            this.PaymentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "تاريخ الدفعة";
            // 
            // PaymentDate
            // 
            this.PaymentDate.BackColor = System.Drawing.Color.White;
            this.PaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentDate.Location = new System.Drawing.Point(44, 110);
            this.PaymentDate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.Size = new System.Drawing.Size(486, 35);
            this.PaymentDate.TabIndex = 25;
            this.PaymentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PaymentEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 328);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PaymentAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PaymentDate);
            this.MaximizeBox = false;
            this.Name = "PaymentEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentEditor";
            this.Load += new System.EventHandler(this.PaymentEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PaymentAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PaymentDate;
    }
}