using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Note
{
    public static class NoteTester
    {
        public static void Test()
        {
            /*
            ITheme lightTheme = new LightTheme();
            string message = "Meeting Monday 1 p.m.";
            Note reminderNote = new ReminderNote(message, lightTheme);
            reminderNote.Show();

            ITheme darkTheme = new DarkTheme();
            message = "Meeting Monday 1 p.m.";
            reminderNote = new ReminderNote(message, darkTheme);
            reminderNote.Show();
            */
            /*
            ITheme lightTheme = new LightTheme();
            string message = "Meeting Monday 1 p.m.";
            List<string> people = new List<string>()
            {
                "Klara", "Lucija", "Iva"
            };
            GroupNote groupNote = new GroupNote(message, lightTheme, people);
            groupNote.AddPeople("Klara");
            groupNote.Show();
            */

            ITheme lightTheme = new LightTheme();
            ITheme darkTheme = new DarkTheme();
            string message = "Meeting Monday 1 p.m.";
            List<string> people = new List<string>()
            {
                "Klara", "Lucija", "Iva"
            };
            Note reminderNote = new ReminderNote(message, lightTheme);
            GroupNote groupNote = new GroupNote(message, lightTheme, people);
            Notebook notebook = new Notebook();
            notebook.AddNote(reminderNote);
            notebook.AddNote(groupNote);
            notebook.Display();
            notebook.ChangeTheme(darkTheme);
            notebook.Display();
            
            List<Note> notes = new List<Note>() { reminderNote, groupNote };
            Notebook notebook2 = new Notebook(notes, darkTheme);
            notebook2.Display();
        }
    }
}
