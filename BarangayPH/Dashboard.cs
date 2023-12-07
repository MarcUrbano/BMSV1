using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarangayPH
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            
        }

        public void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResidentInformation residentInformation = new ResidentInformation();
            residentInformation.TopLevel = false;
            residentInformation.AutoScroll = true;
            panel1.Controls.Add(residentInformation);
            residentInformation.Show();
        }
    }
}
