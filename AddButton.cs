using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    class AddButton:UserControl
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(pen, new Point(Width / 2, Height / 5), new Point(Width / 2, Height * 4 / 5));
            g.DrawLine(pen, new Point(Width / 5, Height / 2), new Point(Width * 4 / 5, Height / 2));
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            pen = new Pen(Color.Gray, 2);
            this.Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            pen = new Pen(Color.Black, 2);
            this.Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            Width = Height;
            this.Invalidate();
        }

        protected override void OnLoad(EventArgs e)
        {
            DoubleBuffered = true;
            BackColor = Color.Transparent;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.Name = "AddButton";
            this.ResumeLayout(false);

        }


        private Pen pen = new Pen(Color.Gray, 2);
    }
}
