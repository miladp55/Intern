﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_in_Nutshel
{
    class Program
    {
        static void Main(string[] args)
        {
            Nested();
        }

        public static void Nested()
        {
            OuterNestedTypeTest outerNestedTypeTest = new OuterNestedTypeTest();
            OuterNestedTypeTest.InnerNestedClassTest innerNestedClassTest = new OuterNestedTypeTest.InnerNestedClassTest();
        }
    }
}
