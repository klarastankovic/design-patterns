using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.MapCoordinate
{
    public class MapCoordinate
    {
        double x, y;
        public MapCoordinate (double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double EuclideanDistanceTo(MapCoordinate coordinate)
        {
            return Math.Sqrt(SumSquaredDifferences(coordinate));
        }
        public double SumSquaredDifferences(MapCoordinate coordinate)
        {
            double differenceX = this.x - coordinate.x;
            double differenceY = this.y - coordinate.y;
            return Math.Pow(differenceX, 2) + Math.Pow(differenceY, 2);
        }
        public static MapCoordinate FromCartesian(double x, double y) // staticka metoda stvaranja (!= metoda tvornica)
        {
            return new MapCoordinate(x, y);
        }
        public static MapCoordinate FromPolarInRadians(double distance, double angle) // staticka metoda stvaranja
        {
            double x = distance * Math.Cos(angle);
            double y = distance * Math.Sin(angle);
            return new MapCoordinate(x, y);
        }
    }
}
