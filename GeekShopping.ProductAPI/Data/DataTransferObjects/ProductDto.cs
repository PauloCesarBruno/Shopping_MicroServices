using System.ComponentModel.DataAnnotations;

namespace GeekShopping.ProductAPI.Data.DataTransferObjects
{
    public class ProductDto
    {      
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }           
        public string CategoryName { get; set; }        
        public string ImagemUrl { get; set; }
    }
}
