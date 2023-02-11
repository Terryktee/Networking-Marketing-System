using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Network_Management_System.Member;

namespace Network_Management_System.Admin
{
    public partial class frm_adminstartup : Form
    {
        public frm_adminstartup()
        {
            InitializeComponent();
        }
        //function to show windows form in a panel

        public void loadform(object Form)
        {
            if (this.panelShow.Controls.Count > 0)
                this.panelShow.Controls.RemoveAt(0);
            Form forms = Form as Form;
            forms.TopLevel = false;
            forms.Dock = DockStyle.Fill;
            this.panelShow.Controls.Add(forms);
            this.panelShow.Tag = forms;
            forms.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
           // frm_adminstartup frm2 = new frm_logout();
           // frm2.Show();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            loadform(new frm_admindashboard());
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            loadform(new frm_sales());
        }

        private void BtnMembers_Click(object sender, EventArgs e)
        {
            loadform(new frm_members());
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            loadform(new frm_product());
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            loadform(new frm_register());
        }

        private void BtnDepo_Click(object sender, EventArgs e)
        {
           // loadform(new);
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            loadform(new frm_reports());
        }

        private void Btnconfig_Click(object sender, EventArgs e)
        {
            loadform(new frm_config());
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnProducts_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnSales_Click_1(object sender, EventArgs e)
        {

        }
    }
}
