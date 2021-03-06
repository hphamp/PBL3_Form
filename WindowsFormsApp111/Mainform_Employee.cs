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
    public partial class Mainform_Employee : Form
    {
        public Mainform_Employee()
        {
            InitializeComponent();
        }
        private Form currentFormBody;
        private void OpenFormBody(Form bodyForm)
        {
            if(currentFormBody != null)
            {
                currentFormBody.Close();
            }  
            currentFormBody = bodyForm;
            bodyForm.TopLevel = false;
            bodyForm.FormBorderStyle = FormBorderStyle.None;
            bodyForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(bodyForm);
            panel_body.Tag = bodyForm;
            bodyForm.BringToFront();
            bodyForm.Show();
        }

        private void butAccManager_Click(object sender, EventArgs e)
        {
            OpenFormBody(new AccManagement_Form());
            labelTop.Text = butAccManager.Text;
        }

        private void butServicePay_Click(object sender, EventArgs e)
        {
            OpenFormBody(new ServicePay_Form());
            labelTop.Text = butServicePay.Text;
        }

        private void butCheckIO_Click(object sender, EventArgs e)
        {
            OpenFormBody(new CheckIO_Form());
            labelTop.Text = butCheckIO.Text;
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            if (currentFormBody != null)
            {
                currentFormBody.Close();
            }
            labelTop.Text = null;
        }
    }
}
