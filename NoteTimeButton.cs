using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    class NoteTimeButton:UserControl
    {
        public DateTime NoteTime
        {
            set
            {
                time = value.ToShortTimeString();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            StringFormat SFormat = new StringFormat();
            SFormat.Alignment = SFormat.LineAlignment = StringAlignment.Center;
            Font f = new Font(new FontFamily("Arial"), 12);
            e.Graphics.DrawString(time, f, new SolidBrush(Color.Gray), new Rectangle(0, 0, Width, Height), SFormat);
        }

        protected override void OnLoad(EventArgs e)
        {
            Width = Height;
        }

        protected override void OnResize(EventArgs e)
        {
            Width = Height;
        }

        private string time;
    }
}
