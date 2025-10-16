using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Validator
{
    public static class ValidatorTester
    {
        public static void Test()
        {
            /*
            String password = "password";
            String email = "info@ferit.hr";
            IPasswordValidatorService passwordService = new PasswordValidator(5);
            IEmailValidatorService emailService = new EmailValidator();
            Console.WriteLine("Password is valid: " + passwordService.IsValidPassword(password));
            Console.WriteLine("Email is valid: " + emailService.IsValidAddress(email));
            */
            UserEntry entry;
            IRegistrationValidator validator = new RegistrationValidator();
            do
            {
                entry = UserEntry.ReadUserFromConsole();
                if (!validator.IsUserEntryValid(entry))
                {
                    Console.WriteLine("Try again.");
                }
            } while (!validator.IsUserEntryValid(entry));
            Console.WriteLine("Registration completed successfully.");
        }
    }
}
