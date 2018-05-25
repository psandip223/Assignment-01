using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class PayrollReport
    {
        private string _fullName;
        private double _hourlyRate;
        private double _hours;

        public PayrollReport(string _fullName, double _hourlyRate, double _hours)
        {
            this._fullName = _fullName;
            this._hourlyRate = _hourlyRate;
            this._hours = _hours;
        }

        public double CalculatePay()
        {
            if(_hours>40)
            {
                return ((40*_hourlyRate)+((_hours-40)*(_hourlyRate*1.5)));
            }
            else
            {
                return (40 * _hourlyRate);
            }
        }
    }
}
