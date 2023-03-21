using GeekShopping.CartAPI.Data.DataTransferObjects;
using Microsoft.AspNetCore.Components.Web;

namespace GeekShopping.CartAPI.Repository
{
    public interface ICartRepository
    {
        Task <CartDto> FindCartUserId (string userId);
        Task <CartDto> SaveOrUpdateCart(CartDto cart);
        Task <bool> RmoveFromCart(long cartDetailsId);
        Task <bool> ApplyCoupon(string userId, string couponCode);
        Task <bool> RemoveCoupon(string userId);
        Task <bool> ClearCart(string userId);
    }
}
