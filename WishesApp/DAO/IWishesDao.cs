
using WishesApp_Core.Model;

namespace WishesApp_Core.DAO
{
    public interface IWishesDao
    {
        IEnumerable<Wish> GetWishes();
        bool AddWish(Wish wish);
        bool ModifyWish(Wish wish);

    }
}
