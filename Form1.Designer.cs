namespace StickyNotes
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.notesViewPanel = new System.Windows.Forms.Panel();
            this.addButton1 = new StickyNotes.AddButton();
            this.closeButton1 = new DataGridViewPractice.CloseButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addButton1);
            this.panel1.Controls.Add(this.closeButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 50);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sticky Notes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 50);
            this.panel3.TabIndex = 2;
            // 
            // notesViewPanel
            // 
            this.notesViewPanel.AutoScroll = true;
            this.notesViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesViewPanel.Location = new System.Drawing.Point(0, 150);
            this.notesViewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.notesViewPanel.Name = "notesViewPanel";
            this.notesViewPanel.Padding = new System.Windows.Forms.Padding(5);
            this.notesViewPanel.Size = new System.Drawing.Size(450, 360);
            this.notesViewPanel.TabIndex = 3;
            // 
            // addButton1
            // 
            this.addButton1.BackColor = System.Drawing.Color.Transparent;
            this.addButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButton1.Location = new System.Drawing.Point(0, 0);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(50, 50);
            this.addButton1.TabIndex = 0;
            this.addButton1.Click += new System.EventHandler(this.OnNewNoteAdded);
            // 
            // closeButton1
            // 
            this.closeButton1.BackColor = System.Drawing.Color.Transparent;
            this.closeButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton1.Location = new System.Drawing.Point(400, 0);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(50, 50);
            this.closeButton1.TabIndex = 0;
            this.closeButton1.Click += new System.EventHandler(this.OnStickyNoteFormClosed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 510);
            this.Controls.Add(this.notesViewPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DataGridViewPractice.CloseButton closeButton1;
        private AddButton addButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel notesViewPanel;
    }
}

