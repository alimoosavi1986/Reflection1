using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection1
{
    public class Customer
    {
        private string customerCode;

        [Check(MaxLength = 10)]
        public string CustomerCode
        {
            get { return customerCode; }
            set { customerCode = value; }
        }
    }
}
