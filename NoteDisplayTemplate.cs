using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    public partial class NoteDisplayTemplate : UserControl
    {
        public DateTime NoteTime
        {
            set
            {
                noteTimeButton1.NoteTime = value;
            }
        }

        public string NoteMessage
        {
            get
            {
                return noteMessage;
            }

            set
            {
                noteMessage = value;
                SeperateWords();
                generatedMessage = GenerateContent(noteMessagePanel.CreateGraphics());
                if (noteMessagePanel.CreateGraphics().MeasureString(generatedMessage, noteMessageFont).Height<120)
                {
                    this.Height = (int)noteMessagePanel.CreateGraphics().MeasureString(generatedMessage, noteMessageFont).Height+30;
                }
                noteMessagePanel.Invalidate();
            }
        }


        private void SeperateWords()
        {
            if (noteMessage == null)
                return;

            words = new List<string>();
            string currentWord = "";
            for (int ctr = 0; ctr < noteMessage.Length; ctr++)
            {
                if (noteMessage[ctr] == ' ' && currentWord != "")
                {
                    words.Add(currentWord);
                    currentWord = "";
                }
                else
                {
                    currentWord += noteMessage[ctr];
                }
            }

            if (currentWord != "")
            {
                words.Add(currentWord);
                currentWord = "";
            }
        }

        private string GenerateContent(Graphics g)
        {
            string actualContent = "", singleLineContent = "";
            foreach (string Iter in words)
            {
                if (g.MeasureString(Iter, noteMessageFont).Width >= noteMessagePanel.Width)
                {
                    if (singleLineContent != "")
                    {
                        actualContent += singleLineContent + "\n";
                    }
                    float y = g.MeasureString(Iter, noteMessageFont).Width;
                    int x = (int)(Iter.Length / (y / noteMessagePanel.Width));
                    actualContent += Iter.Substring(0, x) + "\n";
                    singleLineContent = Iter.Substring(x) + " ";
                }
                else if (g.MeasureString(singleLineContent + Iter + " ", noteMessageFont).Width >= noteMessagePanel.Width)
                {
                    actualContent += singleLineContent + "\n";
                    singleLineContent = Iter + " ";
                }
                else
                {
                    singleLineContent += Iter + " ";
                }
            }
            if (singleLineContent != "")
                actualContent += singleLineContent;

            return actualContent;
        }

        public NoteDisplayTemplate()
        {
            InitializeComponent();
        }

        private void OnNoteMessagePanel(object sender, PaintEventArgs e)
        {
            SFormat = new StringFormat();
            SFormat.Alignment = StringAlignment.Near;
            SFormat.LineAlignment = StringAlignment.Near;
            e.Graphics.DrawString(generatedMessage, noteMessageFont, noteMessageBrush, new Rectangle(0,0,Width, Height), SFormat);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
           
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
           
        }
        private void OnNoteDisplayTemplateEnter(object sender, EventArgs e)
        {
            noteTimeButton1.Visible = false;
            moreOptionButton1.Visible = true;
            moreOptionButton1.BringToFront();

        }

        private void OnNoteDisplayTemplateLeave(object sender, EventArgs e)
        {
            noteTimeButton1.Visible = true;
            moreOptionButton1.Visible = false;
            noteTimeButton1.BringToFront();
        }

        private string noteMessage = "";
        private string generatedMessage = "";
        private List<string> words = new List<string>();
        private StringFormat SFormat = new StringFormat();
        private Font noteMessageFont = new Font(new FontFamily("Arial"), 16);
        private Brush noteMessageBrush = new SolidBrush(Color.Black);

        private void NoteDisplayTemplate_Load(object sender, EventArgs e)
        {
            Width = Parent.Width - 10;
            Height = 70;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
        private void OnMoreOptionClicked(object sender, EventArgs e)
        {
            
        }

        private void moreOptionButton1_MouseDown(object sender, MouseEventArgs e)
        {
            var Pt = moreOptionButton1.PointToScreen(e.Location);

            NoteTemplateDropDown newNoteTemplateDropDown = new NoteTemplateDropDown();
            newNoteTemplateDropDown.StartPosition = FormStartPosition.Manual;
            newNoteTemplateDropDown.Location = Pt;
            newNoteTemplateDropDown.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }
    }
}
