using Microsoft.AspNetCore.Mvc;

namespace GenericApi.Controllers
{
    [ApiController]
    [Route("api/shopping")]
    public class ShoppingController : ControllerBase
    {
        private readonly IShoppingProvider _provider;

        public ShoppingController(IShoppingProvider provider)
        {
            _provider = provider;
        }

        [HttpGet]
        [Route("{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var provider = await _provider.GetShoppingAsync(name);

            if (provider is not null)
                return new OkObjectResult(new JsonResult(provider.AddItem()));
            return NotFound();
        }
    }
}
