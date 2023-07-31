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
    public partial class reg : common
    {
        public reg()
        {
            InitializeComponent();
        }
        protected override void showMessage()
        {
            MessageBox.Show("New User Succeesefully Register");
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-IP6C43K;Initial Catalog=HospitalManagement;Integrated Security=True");
        private void btn_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string queru = "INSERT INTO login (u_name, cont, gmail, pass) VALUES ('" + txt_un_reg.Text + "','" + txt_cont_reg.Text + "','" + txt_gmail_reg.Text + "','" + txt_pw_reg.Text + "') ";
                SqlDataAdapter sda = new SqlDataAdapter(queru, sqlConnection);
                sda.SelectCommand.ExecuteNonQuery();
                showMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in registering" + ex);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btn_Reset_reg_Click(object sender, EventArgs e)
        {
            txt_gmail_reg.Clear();
            txt_cont_reg.Clear();
            txt_un_reg.Clear();
            txt_pw_reg.Clear();
        }

        private void linkLabel_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new login().Show();
        }

        private void linkLabel_login_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new login().Show();
        }
    }
}
