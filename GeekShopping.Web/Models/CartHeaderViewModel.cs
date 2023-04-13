﻿namespace GeekShopping.CartAPI.Data.DataTransferObjects
{
    public class CartHeaderViewModel
    {
        public long Id { get; set; }
        public string UserId { get; set; }         
        public string CouponCode { get; set; }
        public decimal PurshaseAmount { get; set; }
       
        public decimal DiscountAmount { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public DateTime DateTime { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public string ExpireMothYear { get; set; }
    }
}
