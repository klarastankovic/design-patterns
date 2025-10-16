using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Note
{
    public static class NoteTester
    {
        public static void Test()
        {
            Notebook notebook = new Notebook();
            notebook.AddNote(new Note("Breakfast", "It's in the morning."));
            notebook.AddNote(new Note("Brunch", "It's between breakfast and lunch."));
            notebook.AddNote(new Note("Luncnh", "Usually around noon."));
            notebook.AddNote(new Note("Dinner", "It's in the evening."));
            IAbstractIterator iterator = notebook.GetIterator();
            for (Note note = iterator.First(); iterator.IsDone == false; note = iterator.Next())
            {
                note.Show();
            }
        }
    }
}
