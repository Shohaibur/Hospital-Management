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
    public partial class Find_Doctor : Form
    {
        public Find_Doctor()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-IP6C43K;Initial Catalog=HospitalManagement;Integrated Security=True");
        private void btn_fDbyname_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from doctor where d_name ='" + txt_f_Dname.Text + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from doctor where specialist ='" + comboBox_f_Dep.Text + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void txt_f_Dname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }
    }
}
