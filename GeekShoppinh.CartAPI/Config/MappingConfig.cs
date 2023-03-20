using AutoMapper;
using GeekShopping.CartAPI.Data.DataTransferObjects;
using GeekShopping.CartAPI.Model;

namespace GeekShopping.CartAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var MappingConfig = new MapperConfiguration(config =>
            {               
                config.CreateMap<ProductDto, Product>().ReverseMap();
                config.CreateMap<CartHeaderDto, CartHeader>().ReverseMap();
                config.CreateMap<CartDetailDto, CartDetail>().ReverseMap();
                config.CreateMap<CartDto, Cart>().ReverseMap();

            });
            return MappingConfig;
        }
    }
}
