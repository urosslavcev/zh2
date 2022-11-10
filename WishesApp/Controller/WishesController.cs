using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WishesApp_Core.DAO;
using WishesApp_Core.Model;

namespace WishesApp_Core.Controller
{
    public class WishesController
    {
        private readonly IWishesDao dao;

        public WishesController(IWishesDao dao)
        {
            this.dao = dao;
        }

        public IEnumerable<Wish> GetWishes()
        {
            return dao.GetWishes();
        }

        public bool ModifyWish(Wish wish)
        {
            return dao.ModifyWish(wish);
        }

        public bool AddWish(Wish wish)
        {
            return dao.AddWish(wish);
        }

     
    }
}
