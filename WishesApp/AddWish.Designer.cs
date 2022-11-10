namespace WishesApp_Core
{
    partial class addWishForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.wishNameTextBox = new System.Windows.Forms.TextBox();
            this.wishNameLabel = new System.Windows.Forms.Label();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ageLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(40, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(85, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(172, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // wishNameTextBox
            // 
            this.wishNameTextBox.Location = new System.Drawing.Point(85, 117);
            this.wishNameTextBox.Name = "wishNameTextBox";
            this.wishNameTextBox.Size = new System.Drawing.Size(172, 23);
            this.wishNameTextBox.TabIndex = 3;
            // 
            // wishNameLabel
            // 
            this.wishNameLabel.AutoSize = true;
            this.wishNameLabel.Location = new System.Drawing.Point(12, 117);
            this.wishNameLabel.Name = "wishNameLabel";
            this.wishNameLabel.Size = new System.Drawing.Size(68, 15);
            this.wishNameLabel.TabIndex = 2;
            this.wishNameLabel.Text = "Wish Name";
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Location = new System.Drawing.Point(86, 75);
            this.ageNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ageNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(171, 23);
            this.ageNumericUpDown.TabIndex = 4;
            this.ageNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(52, 77);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(28, 15);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "Age";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(29, 165);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(51, 15);
            this.amountLabel.TabIndex = 6;
            this.amountLabel.Text = "Amount";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(86, 163);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            9001,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(171, 23);
            this.amountNumericUpDown.TabIndex = 7;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(40, 220);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 27);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Location = new System.Drawing.Point(149, 220);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 27);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addWishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 279);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.ageNumericUpDown);
            this.Controls.Add(this.wishNameTextBox);
            this.Controls.Add(this.wishNameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "addWishForm";
            this.Text = "Add Wish";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox wishNameTextBox;
        private Label wishNameLabel;
        private NumericUpDown ageNumericUpDown;
        private Label ageLabel;
        private Label amountLabel;
        private NumericUpDown amountNumericUpDown;
        private Button cancelButton;
        private Button addButton;
    }
}