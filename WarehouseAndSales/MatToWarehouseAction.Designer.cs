namespace WarehouseAndSales
{
    partial class MatToWarehouseAction
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
            this.Quant = new System.Windows.Forms.TextBox();
            this.Notes = new System.Windows.Forms.TextBox();
            this.MovingDate = new System.Windows.Forms.TextBox();
            this.quantlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ActionList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lotus Linotype", 14.25F);
            this.button1.Location = new System.Drawing.Point(12, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(451, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "التاكيد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quant
            // 
            this.Quant.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quant.Location = new System.Drawing.Point(12, 67);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(451, 43);
            this.Quant.TabIndex = 1;
            // 
            // Notes
            // 
            this.Notes.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes.Location = new System.Drawing.Point(12, 260);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(451, 43);
            this.Notes.TabIndex = 2;
            // 
            // MovingDate
            // 
            this.MovingDate.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovingDate.Location = new System.Drawing.Point(12, 161);
            this.MovingDate.Name = "MovingDate";
            this.MovingDate.Size = new System.Drawing.Size(451, 43);
            this.MovingDate.TabIndex = 3;
            // 
            // quantlbl
            // 
            this.quantlbl.AutoSize = true;
            this.quantlbl.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantlbl.Location = new System.Drawing.Point(410, 27);
            this.quantlbl.Name = "quantlbl";
            this.quantlbl.Size = new System.Drawing.Size(53, 37);
            this.quantlbl.TabIndex = 4;
            this.quantlbl.Text = "الكمية";
            this.quantlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "التاريخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "الملاحظات";
            // 
            // ActionList
            // 
            this.ActionList.Font = new System.Drawing.Font("Lotus Linotype", 14.25F);
            this.ActionList.FormattingEnabled = true;
            this.ActionList.ItemHeight = 37;
            this.ActionList.Items.AddRange(new object[] {
            "سحب",
            "ايداع"});
            this.ActionList.Location = new System.Drawing.Point(12, 365);
            this.ActionList.Name = "ActionList";
            this.ActionList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ActionList.Size = new System.Drawing.Size(451, 45);
            this.ActionList.TabIndex = 7;
            this.ActionList.SelectedIndexChanged += new System.EventHandler(this.ActionList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lotus Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "العملية";
            // 
            // MatToWarehouseAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActionList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantlbl);
            this.Controls.Add(this.MovingDate);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.Quant);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(491, 493);
            this.Name = "MatToWarehouseAction";
            this.Text = "MatToWarehouseAction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Quant;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.TextBox MovingDate;
        private System.Windows.Forms.Label quantlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ActionList;
        private System.Windows.Forms.Label label1;
    }
}