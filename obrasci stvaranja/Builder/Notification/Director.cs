using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Notification
{
    public class Director
    {
        IBuilder builder;
        public Director(IBuilder builder) { this.builder = builder; }
        public void SetBuilder(IBuilder builder) { this.builder = builder; }
        public ConsoleNotification DefaultNotification(String author)
        {
            return builder.SetAuthor(author)
                .SetTitle("NEW MESSAGE")
                .SetText("Call me back")
                .SetTime(DateTime.Now)
                .SetLevel(Category.ALERT)
                .SetColor(ConsoleColor.Red)
                .Build();
        }
    }
}
