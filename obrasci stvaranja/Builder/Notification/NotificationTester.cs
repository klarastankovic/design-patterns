using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Notification
{
    public static class NotificationTester
    {
        public static void Test()
        {
            /*
            NotificationManager manager = new NotificationManager();
            ConsoleNotification notification = new ConsoleNotification("Klara", "NEW MESSAGE", "Call me back", DateTime.Now, Category.ALERT, ConsoleColor.Red);
            manager.Display(notification);
            */
            /*
            IBuilder builder = new NotificationBuilder();
            ConsoleNotification notification = builder.SetAuthor("Klara")
                .SetTitle("NEW MESSAGE")
                .SetText("Call me back")
                .SetLevel(Category.ALERT)
                .SetTime(DateTime.Now)
                .SetColor(ConsoleColor.Red)
                .Build();
            Console.WriteLine(notification.ToString());
            */
            IBuilder builder = new NotificationBuilder();
            Director director = new Director(builder);
            ConsoleNotification notificaiton = director.DefaultNotification("Klara");
            Console.WriteLine(notificaiton);
        }
    }
}
