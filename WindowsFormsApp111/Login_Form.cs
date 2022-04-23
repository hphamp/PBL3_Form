using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp111
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void but_Login_Click(object sender, EventArgs e)
        {
           Mainform_Employee f = new Mainform_Employee();
            f.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgottenpass_Form f = new Forgottenpass_Form();
            f.ShowDialog();
        }
    }
}
