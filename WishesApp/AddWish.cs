
using WishesApp_Core.Controller;
using WishesApp_Core.Model;

namespace WishesApp_Core
{
    public partial class addWishForm : Form
    {
        WishesController controller;
        private Wish wish;
        private readonly int wishID;
        private readonly bool IsModification = false;
        public addWishForm(WishesController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        public addWishForm(WishesController controller, Wish wish) : this(controller)
        {
            wishID = wish.ID;
            nameTextBox.Text = wish.Name;
            wishNameTextBox.Text = wish.WishName;
            ageNumericUpDown.Value = wish.Age;
            amountNumericUpDown.Value = wish.Amount;
            addButton.Text = "Modify";
            IsModification = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int age = (int)ageNumericUpDown.Value;
            string wishname = wishNameTextBox.Text;
            int amount = (int)amountNumericUpDown.Value;
            if (name == string.Empty || wishname == string.Empty)
                return; // + hiba kiírása
            Wish wish = new Wish
            {
                Name = name,
                Age = age,
                WishName = wishname,
                Amount = amount
            };

            if (IsModification)
            {
                wish.ID = wishID;
                controller.ModifyWish(wish);
            }
            else
            {
                controller.AddWish(wish);
            }

        }
    }
}
