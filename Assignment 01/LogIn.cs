using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class LogIn
    {
        private string _password;

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        public bool CheckPassword()
        {
            if(_password== "PayAdmin54")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
