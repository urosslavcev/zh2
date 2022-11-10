namespace ContactsApp_Core
{
    partial class addContactForm
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
            this.ageLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(67, 14);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(194, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(12, 65);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(28, 15);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Age";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(67, 98);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(194, 23);
            this.addressTextBox.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 106);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(49, 15);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(12, 145);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 15);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone";
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Location = new System.Drawing.Point(67, 57);
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(194, 23);
            this.ageNumericUpDown.TabIndex = 8;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(41, 195);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Location = new System.Drawing.Point(166, 196);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(67, 137);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(194, 23);
            this.phoneTextBox.TabIndex = 11;
            // 
            // addContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 247);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.ageNumericUpDown);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "addContactForm";
            this.Text = "Add Contact";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label ageLabel;
        private TextBox addressTextBox;
        private Label addressLabel;
        private Label phoneLabel;
        private NumericUpDown ageNumericUpDown;
        private Button cancelButton;
        private Button addButton;
        private TextBox phoneTextBox;
    }
}