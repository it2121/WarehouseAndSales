
namespace WarehouseAndSales
{
    partial class Buying
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buyingDG = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.الدفعات = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Return = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.buyingDG)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buyingDG
            // 
            this.buyingDG.AllowUserToAddRows = false;
            this.buyingDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.buyingDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.buyingDG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buyingDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.buyingDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyingDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.الدفعات});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.buyingDG.DefaultCellStyle = dataGridViewCellStyle4;
            this.buyingDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buyingDG.Location = new System.Drawing.Point(0, 0);
            this.buyingDG.Name = "buyingDG";
            this.buyingDG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buyingDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.buyingDG.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.buyingDG.RowTemplate.DividerHeight = 2;
            this.buyingDG.RowTemplate.Height = 44;
            this.buyingDG.RowTemplate.ReadOnly = true;
            this.buyingDG.ShowEditingIcon = false;
            this.buyingDG.Size = new System.Drawing.Size(782, 581);
            this.buyingDG.TabIndex = 6;
            this.buyingDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.matsDG_CellContentClick);
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Select.DefaultCellStyle = dataGridViewCellStyle2;
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select.HeaderText = "تعديل";
            this.Select.MinimumWidth = 100;
            this.Select.Name = "Select";
            this.Select.Text = "تعديل";
            this.Select.ToolTipText = "تعديل";
            this.Select.UseColumnTextForButtonValue = true;
            // 
            // الدفعات
            // 
            this.الدفعات.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.الدفعات.DefaultCellStyle = dataGridViewCellStyle3;
            this.الدفعات.HeaderText = "الدفعات";
            this.الدفعات.MinimumWidth = 100;
            this.الدفعات.Name = "الدفعات";
            this.الدفعات.Text = "الدفعات";
            this.الدفعات.ToolTipText = "الدفعات";
            this.الدفعات.UseColumnTextForButtonValue = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(782, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(209, 662);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 64);
            this.flowLayoutPanel2.TabIndex = 6;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "اضافة قيد بيع جديد";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 153);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 222);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 64);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 291);
            this.button5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(212, 64);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(0, 360);
            this.button6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(212, 64);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Controls.Add(this.Return);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(782, 81);
            this.flowLayoutPanel3.TabIndex = 10;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(3, 3);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(183, 59);
            this.Return.TabIndex = 2;
            this.Return.Text = "الرجوع";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buyingDG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 581);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Buying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Buying";
            this.Text = "Buying";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Buying_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buyingDG)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView buyingDG;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.DataGridViewButtonColumn الدفعات;
    }
}