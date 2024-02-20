namespace StickyNotes
{
    partial class NoteTemplateDropDown
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.openButton = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.deleteBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.openButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 85);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.openButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.openButton.Location = new System.Drawing.Point(3, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(190, 36);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open Note";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.deleteBtn.Location = new System.Drawing.Point(3, 45);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(190, 37);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete Note";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // NoteTemplateDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(196, 85);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteTemplateDropDown";
            this.Text = "NoteTemplateDropDown";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button openButton;
    }
}