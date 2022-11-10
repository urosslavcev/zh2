namespace WishesApp
{
    partial class Form1
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
            this.addWishStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listWishesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishesGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wishesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWishStripMenuItem,
            this.listWishesStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addWishStripMenuItem
            // 
            this.addWishStripMenuItem.Name = "addWishStripMenuItem";
            this.addWishStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.addWishStripMenuItem.Text = "Add Wish";
            this.addWishStripMenuItem.Click += new System.EventHandler(this.addWishStripMenuItem_Click);
            // 
            // listWishesStripMenuItem
            // 
            this.listWishesStripMenuItem.Name = "listWishesStripMenuItem";
            this.listWishesStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.listWishesStripMenuItem.Text = "List Wishes";
            this.listWishesStripMenuItem.Click += new System.EventHandler(this.listWishesStripMenuItem_Click);
            // 
            // wishesGridView
            // 
            this.wishesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wishesGridView.Location = new System.Drawing.Point(14, 32);
            this.wishesGridView.Name = "wishesGridView";
            this.wishesGridView.RowTemplate.Height = 25;
            this.wishesGridView.Size = new System.Drawing.Size(774, 406);
            this.wishesGridView.TabIndex = 1;
            this.wishesGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.wishesGridView_CellMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wishesGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Wishes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wishesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addWishStripMenuItem;
        private ToolStripMenuItem listWishesStripMenuItem;
        private DataGridView wishesGridView;
    }
}