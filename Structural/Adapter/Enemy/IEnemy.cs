using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Enemy
{
    public interface IEnemy
    {
        int Shoot();
        double Hit();
        double HP { get; }
    }
}
