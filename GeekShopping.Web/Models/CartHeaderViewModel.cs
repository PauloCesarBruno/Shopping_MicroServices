namespace GeekShopping.CartAPI.Data.DataTransferObjects
{
    public class CartHeaderViewModel
    {
        public long Id { get; set; }
        public string UserId { get; set; }         
        public string CouponCode { get; set; }
        public decimal PurshaseAmount { get; set; }
    }
}
