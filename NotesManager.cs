using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Form;

namespace StickyNotes
{
    static class NotesManager
    {
        static public void AddNotes()
        {
            note = new NoteTemplate();
            note.Name = NoteCollection.Count.ToString();
            note.Location = new Point(rnd.Next(10, 750), rnd.Next(10, 600));
            note.TextChange += OnTextChange;
            note.ColorPick += OnColorPicked;
            note.
Show();
        }

        static public void OpenNote(NoteTemplate note)
        {

        }

        static public void CloseNote(NoteTemplate note)
        {

        }

        internal static void GenerateNotesUC(Control.ControlCollection controls)
        {
            NoteDisplayTemplate newNoteDisplay = selectedNoteDisplayTemplate = new NoteDisplayTemplate();
            newNoteDisplay.Location = new Point(5, 0);
            newNoteDisplay.Resize += OnNewNoteDisplayTemplateResized;
            newNoteDisplay.Click += OnNewNotedClick;
            NoteCollection.Add(new KeyValuePair<NoteTemplate, NoteDisplayTemplate>(note, newNoteDisplay));
            controls.Add(newNoteDisplay);
            RelocateNotes();
        }

        private static void OnNewNotedClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OnNewNoteDisplayTemplateResized(object sender, EventArgs e)
        {
            RelocateNotes();
        }

        private static void OnColorPicked(object sender, Color e)
        {
            foreach (var Iter in NoteCollection)
            {
                if (Iter.Key == sender as NoteTemplate)
                {
                    Iter.Value.BackColor = e;
                }
            }
        }

        private static void OnTextChange(object sender, string e)
        {
            foreach(var Iter in NoteCollection)
            {
                if(Iter.Key == sender as NoteTemplate)
                {
                    Iter.Value.NoteMessage = e;
                }
            }
        }
        
        static private void RelocateNotes()
        {
            int startY = 5;
            for(int ctr= NoteCollection.Count-1; ctr>=0; ctr--)
            {
                NoteCollection[ctr].Value.Location = new Point(5, startY);
                startY += NoteCollection[ctr].Value.Height + 5;
            }
        }

        static private Random rnd = new Random();
        static private NoteTemplate note;
        static private NoteDisplayTemplate selectedNoteDisplayTemplate = new NoteDisplayTemplate();
        static private List<KeyValuePair<NoteTemplate, NoteDisplayTemplate>> NoteCollection = new List<KeyValuePair<NoteTemplate, NoteDisplayTemplate>>();
    }
}
