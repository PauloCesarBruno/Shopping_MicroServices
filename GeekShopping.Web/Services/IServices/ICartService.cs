using GeekShopping.CartAPI.Data.DataTransferObjects;
using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface ICartService
    {
        Task <CartVieweModel> FindCartByUserId (string userId, string token);
        Task <CartVieweModel> AddItemToCart (CartVieweModel cart,  string token);
        Task <CartVieweModel> UpdateCart (CartVieweModel cart, string token);
        Task <bool> RemoveFromCart(long cartId, string token);

        Task <bool> ApplyCpupon (CartVieweModel cart, string couponCode, string token);
        Task <bool> RemoveCoupon (string userId, string token);
        Task<bool> ClearCart(string userId, string token);

        Task <CartVieweModel> Checkout ( CartHeaderViewModel cartHeader, string token);
    }
}
