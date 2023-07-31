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
    public partial class Book_Appointment : Form
    {
        public Book_Appointment()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-IP6C43K;Initial Catalog=HospitalManagement;Integrated Security=True");
        private void btn_ba_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string queru = "INSERT INTO Appointment (Date, Time, Department, Doctor, Name, Phone) VALUES ('" + dateTimePicker_ba.Text + "','" + comboBox_ba_Time.Text + "','" + comboBox_ba_Dep.Text + "','" + txt_ba_Doc.Text + "','" + txt_ba_Name.Text + "','" + txt_ba_Phone.Text + "') ";
                SqlDataAdapter sda = new SqlDataAdapter(queru, sqlConnection);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Appointment Complete");
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

        private void btn_ba_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string queru = "UPDATE Appointment set Date = '"+ dateTimePicker_ba.Text+ "', Time = '"+ comboBox_ba_Time.Text+ "', Department = '" + comboBox_ba_Dep.Text+ "', Doctor = '"+ txt_ba_Doc.Text+ "', Name = '"+ txt_ba_Name.Text+ "' WHERE Phone = '"+ txt_ba_Phone.Text+ "'";
                SqlDataAdapter sda = new SqlDataAdapter(queru, sqlConnection);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Edit Complete");
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

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }
    }
}
