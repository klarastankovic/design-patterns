using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Validator
{
    public class PasswordValidator : IPasswordValidatorService  // klasa podsustava
    {
        public int MinLenght { get; private set; }
        public PasswordValidator(int minLenght)
        {
            MinLenght = minLenght;
        }
        public bool IsValidPassword(String candidate)
        {
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
            return IsLongEnough(candidate) && ContainsDifferentCharacterTypes(candidate);
        }
        private bool IsLongEnough(String candidate)
        {
            return candidate.Length >= MinLenght;
        }
        private bool ContainsDifferentCharacterTypes(string candidate)
        {
            bool hasLower = false, hasUpper = false, hasNumber = false;
            foreach (char c in candidate)
            {
                if (char.IsDigit(c)) hasNumber = true;
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
            }
            return (hasLower && hasUpper && hasNumber);
        }
    }
}
