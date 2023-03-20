using GeekShopping.CartAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CartAPI.Data.DataTransferObjects
{
    public class CartHeaderDto
    {
        public long Id { get; set; }
        public string UserId { get; set; }         
        public string CouponCode { get; set; }
    }
}
