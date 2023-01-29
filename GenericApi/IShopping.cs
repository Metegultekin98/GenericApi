namespace GenericApi
{
    public interface IShopping<T> where T : class
    {
        string AddItem();
    }
}
