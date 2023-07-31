using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        /*protected override void showMessage()
        {

        }*/

        private void picbox_FindDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Find_Doctor().Show();
        }

        private void pictureBox_BookApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Book_Appointment().Show();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_ViewApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new viewapp().Show();
        }

        private void pictureBox_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().Show();
        }
    }
}
