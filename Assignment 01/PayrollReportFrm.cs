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
    public partial class PayrollReportFrm : Form
    {
        public PayrollReportFrm()
        {
            InitializeComponent();
        }

        private void OnClickCalculateGrossPay(object sender, EventArgs e)
        {
            string fullName = txtName.Text;
            double hourlyRate = double.Parse(txtHourlyRate.Text);
            double hours = double.Parse(txtHoursWorked.Text);

            PayrollReport pr = new PayrollReport(fullName, hourlyRate, hours);
            double grossPay = pr.CalculatePay();

            label1.Text = grossPay.ToString();
        }
    }
}
