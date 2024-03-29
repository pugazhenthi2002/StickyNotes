﻿using System;
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
    public partial class NoteTemplateDropDown : Form
    {
        public NoteTemplateDropDown()
        {
            InitializeComponent();
        }

        public NoteTemplate note = new NoteTemplate();

        private void openButton_Click(object sender, EventArgs e)
        {
            NotesManager.OpenNote(note);
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            NotesManager.CloseNote(note);
        }
    }
}
