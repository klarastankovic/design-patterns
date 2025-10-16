namespace Primjeri.Adapter
{
    public class RoundHole
    {
        private double radius;

        public RoundHole(double radius) { this.radius = radius; }
        public double GetRadius() { return radius; }
        public bool willFit(RoundPeg peg)
        {
            bool result = (this.GetRadius() >= peg.GetRadius());
            return result;
        }
    }
}
