using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Checker
{
    public class StringDigitChecker : StringChecker
    {
        private StringChecker next;
        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Any(char.IsDigit);
        }
    }
}
