using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Note
{
    public class ReminderNote : Note // prilagodjena apsstrakcija
    {
        public ReminderNote(string message, ITheme theme) : base(message, theme) { }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("REMINDER: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}
