using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuoliZhou_CSharp_HW4.DataModel
{
    public class Product
    {
        private int pid;

        public int Id
        {
            get { return pid; }
            set { pid = value; }
        }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
