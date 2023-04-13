using GeekShopping.CouponAPI.Data.DataTransferObjects;

namespace GeekShopping.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task <CouponDto> GetCouponByCouponCode(string couponCode);
    }
}
