using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public  class common: Form
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // common
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "common";
            this.Load += new System.EventHandler(this.common_Load);
            this.ResumeLayout(false);

        }

        private void common_Load(object sender, EventArgs e)
        {

        }
         protected virtual void showMessage()
        {
            MessageBox.Show("Login Succeeseful");
        }
       }
    }
