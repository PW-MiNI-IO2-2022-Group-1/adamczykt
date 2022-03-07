using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOGitFlow
{
    public class Calculator
    {
        public int add(int a, int b) => a + b;

        public int divide(int a, int b)
        {
            if (b != 0) return a / b;
            else return Int32.MaxValue;
        }
    }
}
