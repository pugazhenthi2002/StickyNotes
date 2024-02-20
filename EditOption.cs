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
    public partial class EditOption : UserControl
    {
        public EditOption()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        public event EventHandler<Color> ColorPick;
        public event EventHandler DeleteOptionClick;

        private void OnColorPanelClicked(object sender, EventArgs e)
        {
            ColorPick?.Invoke(this, (sender as Panel).BackColor);
        }

        private void OnDeleteOptionClicked(object sender, EventArgs e)
        {
            DeleteOptionClick?.Invoke(this, e);
        }
    }
}
