using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaculatorLib
{
    public static class Calculator
    {
        public static int? Calc(int n1, int n2, char op)
        {
            int? result = null;
            try
            {
                if (op == '+')
                {
                    result = n1 + n2;
                }
                else if (op == '-')
                {
                    result = n1 - n2;
                }
                else if (op == '*')
                {
                    result = n1 * n2;
                }
                else if (op == '/')
                {
                    result = n1 / n2;
                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Division by zero is not possible");
            }
            return result;
        }
    }
}
