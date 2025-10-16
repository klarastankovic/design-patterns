using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Round
{
    public static class RoundTester
    {
        public static void Test()
        {
            RoundHole roundHole = new RoundHole(5);
            RoundPeg roundPeg = new RoundPeg(5);
            SquarePeg smallSquarePeg = new SquarePeg(2);
            SquarePeg largeSquarePeg = new SquarePeg(20);
            List<IRound> pegs = new List<IRound>()
            {
                roundPeg,
                new SquarePegAdapter(smallSquarePeg),
                new SquarePegAdapter(largeSquarePeg)
            };
            Console.WriteLine("Hole radius is: " + roundHole.GetRadius());
            foreach (IRound peg in pegs)
            {
                Console.Write("The peg with radius " + peg.GetRadius() + " ");
                if (roundHole.WillFit(peg)) { Console.WriteLine("fits!"); }
                else { Console.WriteLine("does not fit..."); }
            }
        }
    }
}
