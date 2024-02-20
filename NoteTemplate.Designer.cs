namespace StickyNotes
{
    partial class NoteTemplate
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.addButton1 = new StickyNotes.AddButton();
            this.moreOptionButton1 = new StickyNotes.MoreOptionButton();
            this.closeButton1 = new DataGridViewPractice.CloseButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.styleButton3 = new StickyNotes.StyleButton();
            this.styleButton2 = new StickyNotes.StyleButton();
            this.styleButton1 = new StickyNotes.StyleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.noteTemplateTextBox = new System.Windows.Forms.RichTextBox();
            this.editPanel = new System.Windows.Forms.Panel();
            this.editOption1 = new StickyNotes.EditOption();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.addButton1);
            this.panel1.Controls.Add(this.moreOptionButton1);
            this.panel1.Controls.Add(this.closeButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 35);
            this.panel1.TabIndex = 0;
            // 
            // addButton1
            // 
            this.addButton1.BackColor = System.Drawing.Color.Transparent;
            this.addButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButton1.Location = new System.Drawing.Point(0, 0);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(35, 35);
            this.addButton1.TabIndex = 2;
            // 
            // moreOptionButton1
            // 
            this.moreOptionButton1.BackColor = System.Drawing.Color.Transparent;
            this.moreOptionButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.moreOptionButton1.Location = new System.Drawing.Point(421, 0);
            this.moreOptionButton1.Name = "moreOptionButton1";
            this.moreOptionButton1.Size = new System.Drawing.Size(35, 35);
            this.moreOptionButton1.TabIndex = 1;
            this.moreOptionButton1.Click += new System.EventHandler(this.OnMoreOptionClicked);
            // 
            // closeButton1
            // 
            this.closeButton1.BackColor = System.Drawing.Color.Transparent;
            this.closeButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton1.Location = new System.Drawing.Point(456, 0);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(35, 35);
            this.closeButton1.TabIndex = 0;
            this.closeButton1.Click += new System.EventHandler(this.OnNoteTemplateClosed);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.styleButton3);
            this.panel2.Controls.Add(this.styleButton2);
            this.panel2.Controls.Add(this.styleButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 371);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 34);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.OnNoteStylePaint);
            // 
            // styleButton3
            // 
            this.styleButton3.BackColor = System.Drawing.Color.Transparent;
            this.styleButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.styleButton3.Location = new System.Drawing.Point(68, 0);
            this.styleButton3.Name = "styleButton3";
            this.styleButton3.Size = new System.Drawing.Size(34, 34);
            this.styleButton3.StyleIconText = "U";
            this.styleButton3.TabIndex = 2;
            this.styleButton3.Click += new System.EventHandler(this.OnUnderLineStyleClicked);
            // 
            // styleButton2
            // 
            this.styleButton2.BackColor = System.Drawing.Color.Transparent;
            this.styleButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.styleButton2.Location = new System.Drawing.Point(34, 0);
            this.styleButton2.Name = "styleButton2";
            this.styleButton2.Size = new System.Drawing.Size(34, 34);
            this.styleButton2.StyleIconText = "I";
            this.styleButton2.TabIndex = 1;
            this.styleButton2.Click += new System.EventHandler(this.OnItalicStyleClicked);
            // 
            // styleButton1
            // 
            this.styleButton1.BackColor = System.Drawing.Color.Transparent;
            this.styleButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.styleButton1.Location = new System.Drawing.Point(0, 0);
            this.styleButton1.Name = "styleButton1";
            this.styleButton1.Size = new System.Drawing.Size(34, 34);
            this.styleButton1.StyleIconText = "B";
            this.styleButton1.TabIndex = 0;
            this.styleButton1.Click += new System.EventHandler(this.OnBoldStyleClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.noteTemplateTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 336);
            this.panel3.TabIndex = 2;
            // 
            // noteTemplateTextBox
            // 
            this.noteTemplateTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.noteTemplateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTemplateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteTemplateTextBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTemplateTextBox.Location = new System.Drawing.Point(0, 0);
            this.noteTemplateTextBox.Name = "noteTemplateTextBox";
            this.noteTemplateTextBox.Size = new System.Drawing.Size(491, 336);
            this.noteTemplateTextBox.TabIndex = 0;
            this.noteTemplateTextBox.Text = "";
            this.noteTemplateTextBox.TextChanged += new System.EventHandler(this.noteTemplateTextBox_TextChanged);
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.Transparent;
            this.editPanel.Controls.Add(this.editOption1);
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.editPanel.Location = new System.Drawing.Point(496, 5);
            this.editPanel.Margin = new System.Windows.Forms.Padding(0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(75, 405);
            this.editPanel.TabIndex = 3;
            // 
            // editOption1
            // 
            this.editOption1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editOption1.Location = new System.Drawing.Point(0, 0);
            this.editOption1.Margin = new System.Windows.Forms.Padding(0);
            this.editOption1.Name = "editOption1";
            this.editOption1.Size = new System.Drawing.Size(75, 405);
            this.editOption1.TabIndex = 0;
            this.editOption1.ColorPick += new System.EventHandler<System.Drawing.Color>(this.OnColorPicked);
            this.editOption1.DeleteOptionClick += new System.EventHandler(this.OnDeleteOptionClicked);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(491, 405);
            this.panel5.TabIndex = 4;
            // 
            // NoteTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 415);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.editPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteTemplate";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NoteTemplate";
            this.Load += new System.EventHandler(this.NoteTemplate_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnNoteTemplatePaint);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.editPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox noteTemplateTextBox;
        private DataGridViewPractice.CloseButton closeButton1;
        private MoreOptionButton moreOptionButton1;
        private AddButton addButton1;
        private StyleButton styleButton3;
        private StyleButton styleButton2;
        private StyleButton styleButton1;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Panel panel5;
        private EditOption editOption1;
    }
}