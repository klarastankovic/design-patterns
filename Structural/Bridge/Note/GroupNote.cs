using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Note
{
    public class GroupNote : Note
    {
        private List<string> people;
        public GroupNote(string message, ITheme theme, List<string> people) : base(message, theme)
        {
            this.people = people;
        }
        public void AddPeople(string name)
        {
            people.Add(name);
        }
        public void RemovePeople(string name)
        {
            people.Remove(name);
        }
        public override void Show()
        {
            this.ChangeColor();
            Console.Write(string.Join(", ", people) + "\n");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}
