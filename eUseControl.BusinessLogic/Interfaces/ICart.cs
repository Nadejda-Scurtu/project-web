using eUseControl.Domain.Entities.Products;
using eUseControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entities.Response;

namespace eUseControl.BusinessLogic.Interfaces
{
    public interface ICart
    {
        ServiceResponse ValidateAddToCart(Product item, int userId);
        ServiceResponse ValidateDeleteFromCart(Product item, int userId);
        List<Cart> GetCartItemList(User user);
    }
}
