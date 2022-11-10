namespace ContactsApp
{
    partial class contactsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addContactStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listContactsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactStripMenuItem,
            this.listContactsStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addContactStripMenuItem
            // 
            this.addContactStripMenuItem.Name = "addContactStripMenuItem";
            this.addContactStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.addContactStripMenuItem.Text = "Add Contact";
            this.addContactStripMenuItem.Click += new System.EventHandler(this.addContactStripMenuItem_Click);
            // 
            // listContactsStripMenuItem
            // 
            this.listContactsStripMenuItem.Name = "listContactsStripMenuItem";
            this.listContactsStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.listContactsStripMenuItem.Text = "List Contacts";
            // 
            // contactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "contactsForm";
            this.Text = "Contacts App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addContactStripMenuItem;
        private ToolStripMenuItem listContactsStripMenuItem;
    }
}