using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Validator
{
    public class EmailValidator : IEmailValidatorService  // klasa podsustava
    {
        private string at = "@";
        public bool IsValidAddress(String candidate)
        {
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
            return ContainsAtSymbol(candidate) && (EndsWithCom(candidate) || EndsWithHr(candidate));
        }
        private bool ContainsAtSymbol(String candidate)
        {
            return candidate.Contains("@");
        }
        private bool EndsWithCom(String candidate)
        {
            return candidate.EndsWith(".com");
        }
        private bool EndsWithHr(String candidate)
        {
            return candidate.EndsWith(".hr");
        }
    }
}
