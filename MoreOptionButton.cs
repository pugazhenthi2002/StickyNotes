using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    class MoreOptionButton:UserControl
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(brush, new Rectangle(Width / 2 - (Width / 20), Height / 2 - (Width / 20), Width / 10, Height / 10));
            g.FillRectangle(brush, new Rectangle(Width / 4 - (Width / 20), Height / 2 - (Height / 20), Width / 10, Height / 10));
            g.FillRectangle(brush, new Rectangle(Width * 3 / 4 - (Width / 20), Height / 2 - (Height / 20), Width / 10, Height / 10));
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MoreOptionButton
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "MoreOptionButton";
            this.ResumeLayout(false);

        }


        private Brush brush = new SolidBrush(Color.Gray);
        
    }
}
