using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace commerce.Controllers
{
    [Route("api/[Controller]")]
    public class CustomersController : ControllerBase
    {
        
        //post
        [HttpPost]
        public IActionResult Post([FromBody] Request.BasketQuantity request)
        {
            var basketQuantity = request.basketQuantity;

            return Ok(Response);

            if (basketQuantity < 5)
            {
                return Ok("daha fazla ürün eklemelisiniz");
            }
            else {
                return Ok("success");

            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Models.BasketProduct basketProduct)
        {
            var basketAmount = basketProduct.Amount;
            if (basketAmount >= 100 && basketAmount <= 1000)
            {
                return Ok("succes");
            }
            else
            {
                return Ok("lütfen 100'den büyük 1000'den büyük bi tutara tamamlayınız");
            }
        }
    }
}
