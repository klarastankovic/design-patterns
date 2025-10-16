using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Checker
{
    public class PasswordValidator
    {
        private StringChecker checker;
        public PasswordValidator(StringChecker checker)
        {
            this.checker = checker;
        }
        public void Add(StringChecker newChecker)
        {
            checker.SetNext(newChecker);
            
        }
        public bool Check(string password)
        {
            return checker.Check(password);
        }
    }
}
