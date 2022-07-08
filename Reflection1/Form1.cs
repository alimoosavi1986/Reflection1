using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflection1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.CustomerCode = "12345678901";

            Type objtype = obj.GetType();
            foreach (PropertyInfo p in objtype.GetProperties())
            {
                foreach (Attribute a in p.GetCustomAttributes(false))
                {
                    Check c = (Check)a;
                    if (p.Name == "CustomerCode")
                    {
                        if (obj.CustomerCode.Length > c.MaxLength)
                        {
                            throw new Exception(" Max length issues ");
                        }
                    }
                }
            }
        }
    }
}
