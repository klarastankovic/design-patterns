using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Validator
{
    public class RegistrationValidator : IRegistrationValidator
    {
        IEmailValidatorService emailService;
        IPasswordValidatorService passwordService;
        public RegistrationValidator()
        {
            emailService = new EmailValidator();
            passwordService = new PasswordValidator(10);
        }
        public bool IsUserEntryValid(UserEntry entry)
        {
            return emailService.IsValidAddress(entry.Email) &&
                passwordService.IsValidPassword(entry.Password);
        }
    }
}
