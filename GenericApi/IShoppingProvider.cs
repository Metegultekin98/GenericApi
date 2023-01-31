namespace GenericApi
{
    public interface IShoppingProvider
    {
        Task<IEnumerable<IShopping>> GetShoppings();
        Task<IShopping> GetShoppingAsync(string name);
    }
}
