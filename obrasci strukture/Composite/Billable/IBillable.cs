using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Billable
{
    public interface IBillable // komponenta
    {
        double Price { get; }
        string Description(int depth = 0);
    }
}
