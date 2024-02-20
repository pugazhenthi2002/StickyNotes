using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnNewNoteAdded(object sender, EventArgs e)
        {
            NotesManager.AddNotes();
            NotesManager.GenerateNotesUC(notesViewPanel.Controls);
        }

        private void OnStickyNoteFormClosed(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
