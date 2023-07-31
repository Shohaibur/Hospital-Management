using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management
{
    public partial class login : common
    {
        public login()
        {
            InitializeComponent();
        }
        string sqlConnection = (@"Data Source=DESKTOP-IP6C43K;Initial Catalog=HospitalManagement;Integrated Security=True");
        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new reg().Show();
        }

        protected override void showMessage()
        {
            base.showMessage();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_un_login.Text==""&& txt_pw_login.Text=="")
            {
                MessageBox.Show("Please Fill Username And Password");
            }
            else
            {
                SqlConnection con = new SqlConnection(sqlConnection);
                SqlCommand cmd = new SqlCommand("select * from login where u_name=@Uname and pass=@UPass", con);
                cmd.Parameters.AddWithValue("@UName", txt_un_login.Text);
                cmd.Parameters.AddWithValue("@UPass", txt_pw_login.Text);

                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                con.Close();

                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    showMessage();
                    this.Hide();
                    new home().Show();
                }
                else
                {
                    MessageBox.Show("login faied");
                   
                }
            }
        }

        private void btn_Reset_login_Click(object sender, EventArgs e)
        {
            txt_un_login.Clear();
            txt_pw_login.Clear();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
