using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17Module.Types
{
    internal class SalaryAccount : Account, ITypeAccount
    {
        public void SetInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
