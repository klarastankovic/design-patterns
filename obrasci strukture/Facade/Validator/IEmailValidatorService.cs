using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Validator
{
    public interface IEmailValidatorService // podsustav
    {
        bool IsValidAddress(String candidate);
    }
}
