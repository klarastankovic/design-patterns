using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Rentable
{
    public interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
