namespace Network_Management_System.Admin
{
    partial class frm_members
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sqlabC_Button2 = new SQLABC_ModernUI.SQLABC_Button();
            this.sqlabC_Button1 = new SQLABC_ModernUI.SQLABC_Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sqlabC_Button2);
            this.panel1.Controls.Add(this.sqlabC_Button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 673);
            this.panel1.TabIndex = 0;
            // 
            // sqlabC_Button2
            // 
            this.sqlabC_Button2.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Button2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.sqlabC_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sqlabC_Button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sqlabC_Button2.Location = new System.Drawing.Point(799, 87);
            this.sqlabC_Button2.Name = "sqlabC_Button2";
            this.sqlabC_Button2.Rounded = false;
            this.sqlabC_Button2.Size = new System.Drawing.Size(148, 32);
            this.sqlabC_Button2.TabIndex = 2;
            this.sqlabC_Button2.Text = "Print";
            this.sqlabC_Button2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // sqlabC_Button1
            // 
            this.sqlabC_Button1.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Button1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.sqlabC_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sqlabC_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sqlabC_Button1.Location = new System.Drawing.Point(687, 87);
            this.sqlabC_Button1.Name = "sqlabC_Button1";
            this.sqlabC_Button1.Rounded = false;
            this.sqlabC_Button1.Size = new System.Drawing.Size(106, 32);
            this.sqlabC_Button1.TabIndex = 2;
            this.sqlabC_Button1.Text = "Export";
            this.sqlabC_Button1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(944, 548);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(149)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 81);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Members";
            // 
            // frm_members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 676);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_members";
            this.Text = "frm_members";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private SQLABC_ModernUI.SQLABC_Button sqlabC_Button2;
        private SQLABC_ModernUI.SQLABC_Button sqlabC_Button1;
    }
}