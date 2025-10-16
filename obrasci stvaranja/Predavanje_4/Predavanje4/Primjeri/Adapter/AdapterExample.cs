using Primjeri.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjeri.Adapter
{
    class AdapterExample : IExample
    {
        public string Name
        {
            get
            {
                return this.ToString();
            }
        }

        public void Run()
        {
            RoundHole roundHole = new RoundHole(5);
            RoundPeg roundPeg = new RoundPeg(5);
            SquarePeg smallSquarePeg = new SquarePeg(2);
            SquarePeg largeSquarePeg = new SquarePeg(20);
            // roundHole.fits(smallSquarePeg); // Error!

            List<RoundPeg> pegs = new List<RoundPeg>(){
                roundPeg,
                new SquarePegAdapter(smallSquarePeg),
                new SquarePegAdapter(largeSquarePeg)
            };

            Console.WriteLine("Hole radius is: " + roundHole.GetRadius());
            foreach (RoundPeg peg in pegs)
            {
                Console.Write("The peg with radius " + peg.GetRadius() + " ");
                if (roundHole.willFit(peg))
                {
                    Console.WriteLine("fits!");
                }
                else
                {
                    Console.WriteLine("does not fit...");
                }
            }
        }
    }
}
