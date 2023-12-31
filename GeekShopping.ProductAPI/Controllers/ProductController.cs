﻿using GeekShopping.ProductAPI.Data.DataTransferObjects;
using GeekShopping.ProductAPI.Repository;
using GeekShopping.ProductAPI.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {   // Se for nulo (??) dispara exeption.
            _repository= repository ?? throw new 
                ArgumentNullException(nameof(repository));
        }

        [HttpGet] // FindAll Permite a não autenticação por isso foi retirado o [Athorize].
        public async Task<ActionResult<IEnumerable<ProductDto>>> FindAll()
        {
            var products = await _repository.FindAll();              
            return Ok(products);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<ProductDto>> FindById(long id)
        {
            var product = await _repository.FindById(id);
            if (product.Id <= 0) return NotFound("Produto " + id + " não foi encontrado !!!");
            return Ok(product);

        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ProductDto>> Create([FromBody]ProductDto dto)
        {
            if (dto == null) return BadRequest("Requisição feita de modo equivocado !");
            var product = await _repository.Create(dto);
            return Ok(product);

        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<ProductDto>> Updade([FromBody] ProductDto dto)
        {
            if (dto == null) return BadRequest("Requisição feita de modo equivocado !");
            var product = await _repository.Update(dto);
            return Ok(product);

        }

        [HttpDelete("{id}")]
        [Authorize(Roles = Role.Admin)]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            // Se o status for false -> " if (!status)  "
            if (!status) return BadRequest("Produto " + id + " não foi encontrado !!!");
            return Ok(status);
        }
    }
}
