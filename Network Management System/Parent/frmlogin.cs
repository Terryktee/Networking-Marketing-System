using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Network_Management_System;

namespace Network_Management_System.Parent
{
    public partial class Frmlogin : Form
    {
        private Panel panel1;
        private SQLABC_ModernUI.SQLABC_Button btnsignup;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private SQLABC_ModernUI.SQLABC_Button btnlogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Label label5;
        private Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Label label1;
        private Label label6;
        private SQLABC_ModernUI.SQLABC_ControlMax sqlabC_ControlMax1;
        private SQLABC_ModernUI.SQLABC_ControlClose sqlabC_ControlClose1;
        private SQLABC_ModernUI.SQLABC_ControlMini sqlabC_ControlMini1;
        private SQLABC_ModernUI.SQLABC_Button sqlabC_Button3;

        public Frmlogin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsignup = new SQLABC_ModernUI.SQLABC_Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlogin = new SQLABC_ModernUI.SQLABC_Button();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlabC_Button3 = new SQLABC_ModernUI.SQLABC_Button();
            this.sqlabC_ControlMax1 = new SQLABC_ModernUI.SQLABC_ControlMax();
            this.sqlabC_ControlClose1 = new SQLABC_ModernUI.SQLABC_ControlClose();
            this.sqlabC_ControlMini1 = new SQLABC_ModernUI.SQLABC_ControlMini();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsignup);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 806);
            this.panel1.TabIndex = 0;
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.Transparent;
            this.btnsignup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsignup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnsignup.Location = new System.Drawing.Point(150, 742);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Rounded = true;
            this.btnsignup.Size = new System.Drawing.Size(410, 41);
            this.btnsignup.TabIndex = 2;
            this.btnsignup.Text = "SIGNUP";
            this.btnsignup.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnsignup.Click += new System.EventHandler(this.SqlabC_Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(529, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 64);
            this.label4.TabIndex = 0;
            this.label4.Text = "System";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(9, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(324, 64);
            this.label6.TabIndex = 0;
            this.label6.Text = "Welcome To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(175, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(567, 64);
            this.label3.TabIndex = 0;
            this.label3.Text = "Network Management ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.btnlogin);
            this.panel2.Controls.Add(this.bunifuMaterialTextbox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(764, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 650);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Humnst777 Cn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(188, 475);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Rounded = true;
            this.btnlogin.Size = new System.Drawing.Size(239, 41);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnlogin.Click += new System.EventHandler(this.SqlabC_Button2_Click);
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Imprint MT Shadow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(87, 265);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(421, 33);
            this.bunifuMaterialTextbox2.TabIndex = 1;
            this.bunifuMaterialTextbox2.Text = "Email";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "ATREZTECH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(338, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Forgot Password";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Imprint MT Shadow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(87, 335);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(421, 33);
            this.bunifuMaterialTextbox1.TabIndex = 1;
            this.bunifuMaterialTextbox1.Text = "Password";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN TO YOUR ACCOUNT";
            // 
            // sqlabC_Button3
            // 
            this.sqlabC_Button3.BackColor = System.Drawing.Color.Transparent;
            this.sqlabC_Button3.BaseColor = System.Drawing.Color.Transparent;
            this.sqlabC_Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sqlabC_Button3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sqlabC_Button3.Location = new System.Drawing.Point(1242, 766);
            this.sqlabC_Button3.Name = "sqlabC_Button3";
            this.sqlabC_Button3.Rounded = true;
            this.sqlabC_Button3.Size = new System.Drawing.Size(106, 32);
            this.sqlabC_Button3.TabIndex = 2;
            this.sqlabC_Button3.Text = "Exit";
            this.sqlabC_Button3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // sqlabC_ControlMax1
            // 
            this.sqlabC_ControlMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlabC_ControlMax1.BackColor = System.Drawing.Color.White;
            this.sqlabC_ControlMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.sqlabC_ControlMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.sqlabC_ControlMax1.Location = new System.Drawing.Point(1300, -1);
            this.sqlabC_ControlMax1.Name = "sqlabC_ControlMax1";
            this.sqlabC_ControlMax1.Size = new System.Drawing.Size(18, 18);
            this.sqlabC_ControlMax1.TabIndex = 3;
            this.sqlabC_ControlMax1.Text = "sqlabC_ControlMax1";
            this.sqlabC_ControlMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // sqlabC_ControlClose1
            // 
            this.sqlabC_ControlClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlabC_ControlClose1.BackColor = System.Drawing.Color.White;
            this.sqlabC_ControlClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.sqlabC_ControlClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.sqlabC_ControlClose1.Location = new System.Drawing.Point(1324, -1);
            this.sqlabC_ControlClose1.Name = "sqlabC_ControlClose1";
            this.sqlabC_ControlClose1.Size = new System.Drawing.Size(24, 24);
            this.sqlabC_ControlClose1.TabIndex = 4;
            this.sqlabC_ControlClose1.Text = "sqlabC_ControlClose1";
            this.sqlabC_ControlClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // sqlabC_ControlMini1
            // 
            this.sqlabC_ControlMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlabC_ControlMini1.BackColor = System.Drawing.Color.White;
            this.sqlabC_ControlMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.sqlabC_ControlMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.sqlabC_ControlMini1.Location = new System.Drawing.Point(1276, -1);
            this.sqlabC_ControlMini1.Name = "sqlabC_ControlMini1";
            this.sqlabC_ControlMini1.Size = new System.Drawing.Size(18, 18);
            this.sqlabC_ControlMini1.TabIndex = 5;
            this.sqlabC_ControlMini1.Text = "sqlabC_ControlMini1";
            this.sqlabC_ControlMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // Frmlogin
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1348, 810);
            this.Controls.Add(this.sqlabC_ControlMini1);
            this.Controls.Add(this.sqlabC_Button3);
            this.Controls.Add(this.sqlabC_ControlMax1);
            this.Controls.Add(this.sqlabC_ControlClose1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmlogin";
            this.Load += new System.EventHandler(this.Frmlogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SqlabC_Button2_Click(object sender, EventArgs e)
        {
            Form frm_memberstartup = new Member.frm_memberstartup();
            frm_memberstartup.Show();
           // Application.Exit();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void SqlabC_Button1_Click(object sender, EventArgs e)
        {
            Form frmsignup = new frmsignup();
            frmsignup.Show();
            //Application.Exit();
        }
    }
}
