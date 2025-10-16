using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DataProvider
{
    public interface Logger //observer
    {
        void Log(SimpleSystemDataProvider provider);
    }
}
