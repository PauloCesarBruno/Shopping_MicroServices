using GeekShopping.CartAPI.Data.DataTransferObjects;
using GeekShopping.CartAPI.Messages;
using GeekShopping.CartAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.CartAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CartController : ControllerBase
    {
        private ICartRepository _repository;

        public CartController(ICartRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }

        [HttpGet("find-cart/{id}")]
        public async Task<ActionResult<CartDto>> FindById(string id)
        {
            var cart = await _repository.FindCartUserId(id);
            if (cart == null) return NotFound();
            return Ok(cart);
        }

        [HttpPost("add-cart")]
        public async Task<ActionResult<CartDto>> AddCart(CartDto Dto)
        {
            var cart = await _repository.SaveOrUpdateCart(Dto);
            if (cart == null) return NotFound();
            return Ok(cart);
        }

        [HttpPut("update-cart")]
        public async Task<ActionResult<CartDto>> UpdateCart(CartDto Dto)
        {
            var cart = await _repository.SaveOrUpdateCart(Dto);
            if (cart == null) return NotFound();
            return Ok(cart);
        }

        [HttpDelete("remove-cart/{id}")]
        public async Task<ActionResult<CartDto>> RemoveCart(int id)
        {
            var status = await _repository.RmoveFromCart(id);
            if (!status) return BadRequest();
            return Ok(status);
        }

        [HttpPost("apply-coupon")]
        public async Task<ActionResult<CartDto>> ApplyCoupon(CartDto Dto)
        {
            var status = await _repository.ApplyCoupon(Dto.CartHeader.UserId, Dto.CartHeader.CouponCode);
            if (!status) return NotFound();
            return Ok(status);
        }

        [HttpDelete("remove-coupon/{userId}")]
        public async Task<ActionResult<CartDto>> ApplyCoupon(string userId)
        {
            var status = await _repository.RemoveCoupon(userId);
            if (!status) return NotFound();
            return Ok(status);
        }     
        
        [HttpPost("checkout")]
        public async Task<ActionResult<CheckoutHeaderDto>> Checkout (CheckoutHeaderDto Dto) 
        {
            var cart = await _repository.FindCartUserId(Dto.UserId);
            if (cart == null) return NotFound();
            Dto.CartDetails = cart.CartDetails;

            // Lógica de comunicação com RabbitMQ


            return Ok(Dto);
        }
    }
}
