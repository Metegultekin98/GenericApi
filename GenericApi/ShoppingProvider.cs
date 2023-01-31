namespace GenericApi
{
    public class ShoppingProvider : IShoppingProvider
    {
        private readonly IServiceProvider _serviceProvider;

        public ShoppingProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task<IShopping> GetShoppingAsync(string name)
        {
            var shoppings = await GetShoppings();
            return shoppings.FirstOrDefault(w => w.GetType().Name.ToLower() == name) ?? null;
        }

        public async Task<IEnumerable<IShopping>> GetShoppings()
        {
            return _serviceProvider.GetServices<IShopping>();
        }
    }
}
