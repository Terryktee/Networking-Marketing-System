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

namespace Network_Management_System.Member
{
    public partial class frm_memberstartup : Form
    {
        public frm_memberstartup()
        {
            InitializeComponent();
        }

        //function to show windows form in a panel

        public void loadform(object Form)
        {
            if (this.panelshow.Controls.Count > 0)
                this.panelshow.Controls.RemoveAt(0);
            Form forms = Form as Form;
            forms.TopLevel = false;
            forms.Dock = DockStyle.Fill;
            this.panelshow.Controls.Add(forms);
            this.panelshow.Tag = forms;
            forms.Show();
        }
        private void GunaButton1_Click(object sender, EventArgs e)
        {
            loadform(new frm_memberdashboard());
        }

        private void Panelshow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaButton11_Click(object sender, EventArgs e)
        {
            loadform(new frm_product_ordering());
        }

        private void Btnewallet_Click(object sender, EventArgs e)
        {
            loadform(new frm_E_wallet());
        }

        private void Btncommission_Click(object sender, EventArgs e)
        {
            loadform(new frm_commission());
        }

        private void BtnCenter_Click(object sender, EventArgs e)
        {
            loadform(new Parent.frm_support());
        }

        private void Btnsettings_Click(object sender, EventArgs e)
        {
            loadform(new frm_settings());
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            loadform(new frm_logout());
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
