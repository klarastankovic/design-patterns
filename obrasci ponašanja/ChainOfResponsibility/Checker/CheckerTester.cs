using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Checker
{
    public static class CheckerTester
    {
        public static void Test()
        {
            /*string password = "Password12345";
            StringChecker digitChecker = new StringDigitChecker();
            StringChecker lengthChecker = new StringLengthChecker(10);
            StringChecker upperCaseChecker = new StringUpperCaseChecker();
            StringChecker lowerCaseChecker = new StringLowerCaseChecker();
            digitChecker.SetNext(upperCaseChecker);
            upperCaseChecker.SetNext(lowerCaseChecker);
            lowerCaseChecker.SetNext(lengthChecker);
            Console.WriteLine("Password is valid: " + digitChecker.Check(password));
            */

            StringChecker digitChecker = new StringDigitChecker();
            StringChecker lengthChecker = new StringLengthChecker(10);
            StringChecker upperCaseChecker = new StringUpperCaseChecker();
            StringChecker lowerCaseChecker = new StringLowerCaseChecker();

            PasswordValidator validator = new PasswordValidator(digitChecker);
            string password = "Password12345";

            validator.Add(upperCaseChecker);
            validator.Add(lowerCaseChecker);
            validator.Add(lengthChecker);
            bool isValid = validator.Check(password);
            Console.WriteLine("Password is valid: " + isValid);
        }
    }
}
