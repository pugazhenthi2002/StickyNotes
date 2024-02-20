namespace StickyNotes
{
    partial class NoteDisplayTemplate
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.noteMessagePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noteTimeButton1 = new StickyNotes.NoteTimeButton();
            this.moreOptionButton1 = new StickyNotes.MoreOptionButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteMessagePanel
            // 
            this.noteMessagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteMessagePanel.Location = new System.Drawing.Point(0, 30);
            this.noteMessagePanel.Name = "noteMessagePanel";
            this.noteMessagePanel.Padding = new System.Windows.Forms.Padding(5);
            this.noteMessagePanel.Size = new System.Drawing.Size(529, 40);
            this.noteMessagePanel.TabIndex = 0;
            this.noteMessagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnNoteMessagePanel);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.noteTimeButton1);
            this.panel2.Controls.Add(this.moreOptionButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 30);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // noteTimeButton1
            // 
            this.noteTimeButton1.BackColor = System.Drawing.Color.Violet;
            this.noteTimeButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.noteTimeButton1.Location = new System.Drawing.Point(469, 0);
            this.noteTimeButton1.Name = "noteTimeButton1";
            this.noteTimeButton1.Size = new System.Drawing.Size(30, 30);
            this.noteTimeButton1.TabIndex = 1;
            // 
            // moreOptionButton1
            // 
            this.moreOptionButton1.BackColor = System.Drawing.Color.Transparent;
            this.moreOptionButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.moreOptionButton1.Location = new System.Drawing.Point(499, 0);
            this.moreOptionButton1.Name = "moreOptionButton1";
            this.moreOptionButton1.Size = new System.Drawing.Size(30, 30);
            this.moreOptionButton1.TabIndex = 0;
            this.moreOptionButton1.Click += new System.EventHandler(this.OnMoreOptionClicked);
            this.moreOptionButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moreOptionButton1_MouseDown);
            // 
            // NoteDisplayTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.noteMessagePanel);
            this.Controls.Add(this.panel2);
            this.Name = "NoteDisplayTemplate";
            this.Size = new System.Drawing.Size(529, 70);
            this.Load += new System.EventHandler(this.NoteDisplayTemplate_Load);
            this.MouseEnter += new System.EventHandler(this.OnNoteDisplayTemplateEnter);
            this.MouseLeave += new System.EventHandler(this.OnNoteDisplayTemplateLeave);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel noteMessagePanel;
        private System.Windows.Forms.Panel panel2;
        private NoteTimeButton noteTimeButton1;
        private MoreOptionButton moreOptionButton1;
    }
}
