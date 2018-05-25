using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_01
{
    public partial class LogInFrm : Form
    {
        private int attemptNo=0;
        public LogInFrm()
        {
            InitializeComponent();
        }

        private void OnClickSubmit(object sender, EventArgs e)
        {
            attemptNo++;
            string password = txtPassword.Text;
            LogIn li = new LogIn();
            li.Password = password;
            bool result = li.CheckPassword();
            if (result == true)
            {
                attemptNo = 0;
                this.Hide();
                PayrollReportFrm prf = new PayrollReportFrm();
                prf.Show();
            }
            else
            {
                lblInfo.Text = "Wrong password. Only " + (3 - attemptNo) + " left. Then program will terminate Automatically.";
            }
            if (attemptNo >= 3)
            {
                lblInfo.Text = "Program will terminate. Number of attempts is exceeded!";
                this.Close();
            }
        }
    }
}
