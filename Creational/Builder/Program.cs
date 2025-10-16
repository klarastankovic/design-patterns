using Builder.CarBuilder;
using Builder.Search;
using Builder.Notification;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* CarBuilderTester.Test();
            Builder.CarBuilder.CarBuilder carBuilder = new Builder.CarBuilder.CarBuilder();
            Builder.CarBuilder.Director director = new Builder.CarBuilder.Director();
            director.ConstructPorsche(carBuilder);
            Builder.CarBuilder.Car porsche = carBuilder.Build();
            Console.WriteLine(porsche);
            */
            // SearchTester.Search();
            NotificationTester.Test();
        }
    }
}
