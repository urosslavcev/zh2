using ContactsApp_Core;

namespace ContactsApp
{
    public partial class contactsForm : Form
    {
        public contactsForm()
        {
            InitializeComponent();
        }

        private void addContactStripMenuItem_Click(object sender, EventArgs e)
        {
            using var addContactForm = new addContactForm();
            addContactForm.ShowDialog();
        }
    }
}