using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator7.Dal.Repository
{
    interface IShoppingCartRepository
    {
        IEnumerable<ShoppingCarts> GetAllShoppingCarts();
    }
}
