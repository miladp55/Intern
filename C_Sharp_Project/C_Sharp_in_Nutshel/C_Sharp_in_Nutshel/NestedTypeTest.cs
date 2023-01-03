using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_in_Nutshel
{
    public class OuterNestedTypeTest
    {
        public int id { get; set; }
        public string name { get; set; }
        public class InnerNestedClassTest
        {

            public static int x = 0;
            public static int y = 0;

            public int empId { get; set; }
            public string empName { get; set; }
        }
    }
}
