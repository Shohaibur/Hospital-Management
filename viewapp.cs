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
    public partial class viewapp : Form
    {
        public viewapp()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-IP6C43K;Initial Catalog=HospitalManagement;Integrated Security=True");
        private void btn_view_app_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Appointment where Phone ='" + txt_va_phone.Text + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();

        }

        private void btn_delete_app_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("delete from Appointment where Phone='" + txt_va_phone.Text + "'", sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deleted successfully");
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }
    }
}
