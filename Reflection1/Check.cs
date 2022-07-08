using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection1
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Check : Attribute
    {
        public int MaxLength { get; set; }
    }
}
