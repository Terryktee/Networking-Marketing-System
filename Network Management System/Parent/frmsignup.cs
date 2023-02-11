using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Network_Management_System;
using Connection_DB;
namespace Network_Management_System.Parent
{
    public partial class frmsignup : Form
    {
        DataTable dt = new DataTable();
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;uid=root;" +
             "pwd='';database=VorwerkDB");
        MySqlCommand cmd;
        connection con = new connection();

        public frmsignup()
        {
            InitializeComponent();

            try
            {
                bool conn=con.Open();

                if (conn == true)
                {
                    MessageBox.Show("Connected!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
        private void btnchange(object sender, EventArgs e)
        {
           /* string username;
            string password;
            string name;
            string email;
            int phone_number;
            int experience;
            string country;
            string plan;*/

            try
            {
                con.Open();
                cmd = new MySqlCommand("Insert INTO distributors(name,username,password,email,phone_number,experience,plan,country,UserId) values " +
                "('" + txtname.Text + "','" + txtusername.Text + "','" + txtPassword.Text + "','" + txtEmail.Text + "','" + txtphone.Text + "','" + txtexp.Text + "','" + txtplan.Text + "','" + txtcountry.Text + "')", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You are now part of Vowerk Inc");
                //con.Close();
                this.Hide();
                Form frm_login = new frm_login();
                frm_login.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
