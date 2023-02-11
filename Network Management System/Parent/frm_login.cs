using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Network_Management_System;
using MySql.Data;
using MySql.Data.Types;
using Connection_DB;
using MySql.Data.MySqlClient;



    namespace Network_Management_System.Parent
    {
        public partial class frm_login : Form
        {
         DataTable dt = new DataTable();
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;uid=root;" +
             "pwd='';database=VorwerkDB");
public frm_login()
        {
            InitializeComponent();

            //MySqlConnection con = new MySqlConnection("server=127.0.0.1;uid=root;"+ "pwd='';database=vowerkdb");

            
        }

       /* public  void checkkUsertype()
        {
            if (dt.Columns.Contains("admin"))
            {
                this.Hide();
                Form frm_adminstartup = new Admin.frm_adminstartup();
                frm_adminstartup.Show();

            }

            else if (dt.Columns.Contains("Client"))
            {
                this.Hide();
                Form frm_memberstartup = new Member.frm_memberstartup();
                frm_memberstartup.Show();
            }
            else
            {
                MessageBox.Show("User not Found");
            }
        }*/

            private void Btnsignup_Click(object sender, EventArgs e)
            {
                Form frmsignup = new Form();
                frmsignup.Show();
            }

        private void Label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction!");
        }

        private void btnLogin(object sender, EventArgs e)
        {

            string email;
            string password;
            //assinging the variables to the textboxes
            email = txtEmail.Text;
            password = txtPassword.Text;
            connection con = new connection();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @email and `password` = @pass" ,conn);

            cmd.Parameters.Add("@email",  MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = cmd;

            adapter.Fill(dt);

            // check if the user exists or not
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Form frm_memberstartup = new Member.frm_memberstartup();
                frm_memberstartup.Show();
                //checkkUsertype();
               
            }

            else
            {
                MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
    }

