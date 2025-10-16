using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Note
{
    public class Notebook
    {
        private List<Note> notes;
        public Notebook() { this.notes = new List<Note>(); }
        public Notebook(List<Note> notes, ITheme theme)
        {
            this.notes = notes; 
            this.SetTheme(theme);
        }
        private void SetTheme(ITheme theme)
        {
            foreach (Note note in this.notes)
            {
                note.Theme = theme;
            }
        }
        public void AddNote(Note note)
        {
            this.notes.Add(note);
        }
        public void ChangeTheme(ITheme theme)
        {
            foreach (Note note in this.notes)
            {
                note.Theme = theme;
            }
        }
        public void Display()
        {
            foreach (Note note in this.notes)
            {
                note.Show();
                Console.WriteLine("\n");
            }
        }
    }
}
