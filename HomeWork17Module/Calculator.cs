using HomeWork17Module.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17Module
{
    public static class Calculator
    {
        public static void CalculateInterest(ITypeAccount account)
        {
            account.SetInterest();
        }
    }
}
