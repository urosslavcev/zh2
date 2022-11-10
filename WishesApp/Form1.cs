using WishesApp_Core;
using WishesApp_Core.Controller;
using WishesApp_Core.DAO;
using WishesApp_Core.Model;

namespace WishesApp
{
    public partial class Form1 : Form


    {
        private readonly WishesController controller;
        public Form1()
        {
            InitializeComponent();
            controller = new WishesController(new WishesAdoDao());
        }

        private void addWishStripMenuItem_Click(object sender, EventArgs e)
        {
            using var addWishForm = new addWishForm(controller);
            addWishForm.ShowDialog();
        }

        private void listWishesStripMenuItem_Click(object sender, EventArgs e)
        {
            var wishes = controller.GetWishes();

            wishesGridView.DataSource = null;
            wishesGridView.DataSource = wishes;
            wishesGridView.Visible = true;

        }

        private void wishesGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(wishesGridView.CurrentRow.DataBoundItem is Wish wish))
                return;
            using var window = new addWishForm(controller, wish);
            window.ShowDialog();
        }
    }
}