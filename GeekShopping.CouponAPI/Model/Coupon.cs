using GeekShopping.CouponAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CouponAPI.Model
{
    [Table("coupon")]
    public class Coupon : BaseEntity  
    {                                  

        [Column("coupon-code")]
        [Required]
        [StringLength(30)]
        public string CouponCode { get; set; }

        [Column("discount-amount")]
        [Required]
        [DataType(DataType.Currency)]
        public decimal DiscountAmount { get; set; }
    }
}
