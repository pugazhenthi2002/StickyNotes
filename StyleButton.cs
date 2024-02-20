using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    class StyleButton:UserControl
    {
        public string StyleIconText
        {
            get
            {
                return iconText;
            }

            set
            {
                iconText = value.ToString();

                if(value=="B")
                {
                    font = new Font(new FontFamily("Arial"), 16, FontStyle.Bold);
                }
                else if(value=="I")
                {
                    font = new Font(new FontFamily("Times New Roman"), 16, FontStyle.Italic);
                }
                else
                {
                    font = new Font(new FontFamily("Arial"), 16, FontStyle.Underline);
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            StringFormat SFormat = new StringFormat();
            SFormat.Alignment = SFormat.LineAlignment = StringAlignment.Center;
            Graphics g = e.Graphics;
            g.DrawString(iconText, font, brush, new Rectangle(0, 0, Width, Height), SFormat);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            brush = new SolidBrush(Color.Gray);
            this.Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            brush = new SolidBrush(Color.Black);
            this.Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            Width = Height;
            this.Invalidate();
        }

        protected override void OnLoad(EventArgs e)
        {
            Width = Height;
            DoubleBuffered = true;
            BackColor = Color.Transparent;
        }

        private string iconText;
        private Font font;
        private Brush brush = new SolidBrush(Color.Gray);
    }
}
