using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    public partial class NoteTemplate : Form
    {
        public NoteTemplate()
        {
            InitializeComponent();
            InitializeNoteTemplate();
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
            }
        }

        public event EventHandler<string> TextChange;
        public event EventHandler<Color> ColorPick;

        private void OnNoteTemplateClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnMoreOptionClicked(object sender, EventArgs e)
        {
            editOption1.SuspendLayout();
            editPanelTimer.Start();
        }

        private void OnBoldStyleClicked(object sender, EventArgs e)
        {
            isBold = !isBold;
            if(noteTemplateTextBox.Text!=null)
            {
                if (isBold)
                {
                    noteTemplateTextBox.SelectionFont = new Font(noteTemplateTextBox.Font, noteTemplateTextBox.SelectionFont.Style ^ FontStyle.Bold);
                    currentBold.Add(noteTemplateTextBox.Text.Length);
                }
                else
                {
                    noteTemplateTextBox.SelectionFont = new Font(noteTemplateTextBox.Font, noteTemplateTextBox.SelectionFont.Style ^ FontStyle.Bold);
                    currentBold.Add(noteTemplateTextBox.Text.Length - 1);
                    BoldCollection.Add(currentBold);
                    currentBold = new List<int>();
                }
            }
        }

        private void OnItalicStyleClicked(object sender, EventArgs e)
        {
            isItalic = !isItalic;
            if (noteTemplateTextBox.Text != null)
            {
                if (isItalic)
                {
                    noteTemplateTextBox.SelectionFont = new Font(noteTemplateTextBox.Font, noteTemplateTextBox.SelectionFont.Style ^ FontStyle.Italic);
                    currentItalic.Add(noteTemplateTextBox.Text.Length);
                }
                else
                {
                    noteTemplateTextBox.SelectionFont = new Font(noteTemplateTextBox.Font, noteTemplateTextBox.SelectionFont.Style ^ FontStyle.Italic);
                    currentBold.Add(noteTemplateTextBox.Text.Length - 1);
                    BoldCollection.Add(currentBold);
                    currentBold = new List<int>();
                }
            }
        }

        private void OnUnderLineStyleClicked(object sender, EventArgs e)
        {
            isUnderlined = !isUnderlined;
            if (noteTemplateTextBox.Text != null)
            {
                if (isUnderlined)
                {
                    noteTemplateTextBox.SelectionFont = new Font(noteTemplateTextBox.Font, noteTemplateTextBox.SelectionFont.Style ^ FontStyle.Underline);
                    currentUnderLine.Add(noteTemplateTextBox.Text.Length);
                }
                else
                {
                    noteTemplateTextBox.SelectionFont = new Font(noteTemplateTextBox.Font, noteTemplateTextBox.SelectionFont.Style ^ FontStyle.Underline);
                    currentBold.Add(noteTemplateTextBox.Text.Length - 1);
                    BoldCollection.Add(currentBold);
                    currentBold = new List<int>();
                }
            }
        }

        private void OnNoteTemplatePaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle rectangle = new Rectangle(1, 1, this.Width - 2, this.Height - 2);
            FillRoundRectangle(e.Graphics, rectangle, b, 15);
        }

        private static GraphicsPath GetRoundRectangle(Rectangle rectangle, int r)
        {
            int l = 2 * r;
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            gp.AddLine(new Point(rectangle.X + r, rectangle.Y), new Point(rectangle.Right - r, rectangle.Y));
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Y, l, l), 270F, 90F);

            gp.AddLine(new Point(rectangle.Right, rectangle.Y + r), new Point(rectangle.Right, rectangle.Bottom - r));
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Bottom - l, l, l), 0F, 90F);

            gp.AddLine(new Point(rectangle.Right - r, rectangle.Bottom), new Point(rectangle.X + r, rectangle.Bottom));
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Bottom - l, l, l), 90F, 90F);

            gp.AddLine(new Point(rectangle.X, rectangle.Bottom - r), new Point(rectangle.X, rectangle.Y + r));
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Y, l, l), 180F, 90F);
            gp.CloseAllFigures();
            return gp;
        }

        private void FillRoundRectangle(Graphics g, Rectangle rectangle, Brush b, int r)
        {
            g.FillPath(b, GetRoundRectangle(rectangle, r));
            Pen p = new Pen(Color.Black, 3);
            p.DashStyle = DashStyle.Solid;
            g.DrawPath(p, GetRoundRectangle(rectangle, r));
        }

        private void NoteTemplate_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.FromArgb(1, 1, 1);
            this.BackColor = Color.FromArgb(1, 1, 1);
        }

        private void panel4_Resize(object sender, EventArgs e)
        {

        }

        private void InitializeNoteTemplate()
        {
            editPanelTimer.Interval = 1;
            editPanelTimer.Tick += editPanelMovement;
            b = new SolidBrush(Color.LightBlue);
            noteTemplateTextBox.BackColor = Color.SkyBlue;
            editPanel.Width = 0;
        }

        private void editPanelMovement(object sender, EventArgs e)
        {
            if(!editOptionDisplayed)
            {
                editPanel.Width += 10;
                if(editPanel.Width > 75)
                {
                    editPanel.Width = 75;
                    editOptionDisplayed = !editOptionDisplayed;
                    editPanelTimer.Stop();
                    editOption1.ResumeLayout();
                }
            }
            else
            {
                if (editPanel.Width - 10 < 0)
                {
                    editPanel.Width = 0;
                    editOptionDisplayed = !editOptionDisplayed;
                    editPanelTimer.Stop();
                    editOption1.ResumeLayout();
                }
                else
                    editPanel.Width -= 10;
            }
        }

        private void OnColorPicked(object sender, Color e)
        {
            b = new SolidBrush(e);
            editPanelTimer.Start();
            int R = e.R, G = e.G, B = e.B;
            if(R-15>=0)
            {
                R -= 10;
            }
            if(G+15<=255)
            {
                G -= 10;
            }
            if(B+15<=255)
            {
                B -= 15;
            }
            noteTemplateTextBox.BackColor = Color.FromArgb(R, G, B);
            this.Invalidate();
            ColorPick?.Invoke(this, noteTemplateTextBox.BackColor);
        }

        private void OnNoteClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnNoteStylePaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black), new Point(0, 0), new Point(Width, 0));
        }

        private void OnDeleteOptionClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void noteTemplateTextBox_TextChanged(object sender, EventArgs e)
        {
            TextChange?.Invoke(this, noteTemplateTextBox.Text);
        }

        private bool isBold = false, isItalic = false, isUnderlined = false;

        private List<int> currentBold = new List<int>();
        private List<int> currentItalic = new List<int>();
        private List<int> currentUnderLine = new List<int>();

        private List<List<int>> BoldCollection = new List<List<int>>();
        private List<List<int>> ItalicCollection = new List<List<int>>();
        private List<List<int>> UnderlineCollection = new List<List<int>>();

        private bool editOptionDisplayed = false;
        private string noteMessage;
        private Timer editPanelTimer = new Timer();
        private Brush b;
    }
}
