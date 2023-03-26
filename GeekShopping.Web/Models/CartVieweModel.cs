using GeekShopping.CartAPI.Data.DataTransferObjects;

namespace GeekShopping.Web.Models
{
    public class CartVieweModel
    {
        public CartHeaderViewModel CartHeader { get; set; }
        public IEnumerable<CartDetailViewModel> CartDetails { get; set; }
    }
}
