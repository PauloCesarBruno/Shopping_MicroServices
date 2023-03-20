using AutoMapper;
using GeekShopping.CartAPI.Model;

namespace GeekShopping.CartAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var MappingConfig = new MapperConfiguration(config =>
            {
                // config.CreateMap<ProductDto, Product>();
                // config.CreateMap<Product, ProductDto>();

                // Mis Correto do que o de cima
                //config.CreateMap<ProductDto, Product>().ReverseMap();

            });
            return MappingConfig;
        }
    }
}
