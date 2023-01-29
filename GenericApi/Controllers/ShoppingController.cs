using Microsoft.AspNetCore.Mvc;

namespace GenericApi.Controllers
{
    [ApiController]
    [Route("api/shopping")]
    public class ShoppingController : ControllerBase
    {

        private readonly IShopping<Amazon> _amazon;
        private readonly IShopping<Trendyol> _trendyol;
        private readonly IShopping<N11> _n11;
        private readonly IShopping<Ebay> _ebay;
        private readonly IShopping<Hepsiburada> _hepsiburada;

        public ShoppingController(IShopping<Amazon> amazon, IShopping<Trendyol> trendyol, IShopping<N11> n11, IShopping<Ebay> ebay, IShopping<Hepsiburada> hepsiburada)
        {
            _amazon = amazon;
            _trendyol = trendyol;
            _n11 = n11;
            _ebay = ebay;
            _hepsiburada = hepsiburada;
        }

        [HttpGet]
        [Route("{name}")]
        public IActionResult GetByName(string name)
        {
            return name switch
            {
                "amazon" => new OkObjectResult(new JsonResult(_amazon.AddItem())),
                "trendyol" => new OkObjectResult(new JsonResult("message: " + _trendyol.AddItem())),
                "n11" => new OkObjectResult(new JsonResult("message: " + _n11.AddItem())),
                "ebay" => new OkObjectResult(new JsonResult("message: " + _ebay.AddItem())),
                "hepsiburada" => new OkObjectResult(new JsonResult("message: " + _hepsiburada.AddItem())),
                _ => NotFound(),
            };
        }
    }
}
