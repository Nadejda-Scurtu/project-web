using eUseControl.BusinessLogic.Core;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.Products;
using eUseControl.Domain.Entities.Response;
using eUseControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic.Services
{
    public class CartService : CartApi, ICart
    {
        public ServiceResponse ValidateAddToCart(Product item, int userId)
        {
            return ReturnAddToCart(item, userId);
        }

        public ServiceResponse ValidateDeleteFromCart(Product item, int userId)
        {
            return ReturnDeleteFromCart(item, userId);
        }

        public List<Cart> GetCartItemList(User user)
        {
            return AllCartItems(user);
        }
    }
}
