using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.SequenceGenerator
{
    public interface INumberGenerator
    {
        double Generate();
    }
}
