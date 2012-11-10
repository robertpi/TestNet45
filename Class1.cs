using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestNet45
{
    public sealed class Class1
    {
        int field1;
        string field2;
        double field3;

        public Class1() { }
        public Class1(int a, string b, double c)
        {
            field1 = a;
            field2 = b;
            field3 = c;
        }

        public void Method1() { }
        public void Method1(int a) { }
        public void Method1(string a, int b) { }

        public int Prop1 { get; set; }
        public string Prop2 { get; set; }
        public double Prop3 { get; set; }

    }
}
