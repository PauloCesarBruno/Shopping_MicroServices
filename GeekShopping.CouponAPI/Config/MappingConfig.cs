using AutoMapper;
using GeekShopping.CouponAPI.Data.DataTransferObjects;
using GeekShopping.CouponAPI.Model;

namespace GeekShopping.CoupontAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var MappingConfig = new MapperConfiguration(config =>
            {               
                config.CreateMap<CouponDto, Coupon>().ReverseMap();  
            });
            return MappingConfig;
        }
    }
}
