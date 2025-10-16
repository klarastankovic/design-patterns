using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Checker
{
    public class StringLengthChecker : StringChecker
    {
        private int length;
        public StringLengthChecker(int lenght)
        {
            this.length = lenght;
        }
        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Length >= this.length;
        }
    }
}
