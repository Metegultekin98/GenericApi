namespace GenericApi
{
    public class Amazon : IShopping
    {
        public string AddItem()
        {
            return "Added an item from Amazon";
        }
    }

    public class Trendyol : IShopping
    {
        public string AddItem()
        {
            return "Added an item from Trendyol";
        }
    }

    public class N11 : IShopping
    {
        public string AddItem()
        {
            return "Added an item from N11";
        }
    }

    public class Ebay : IShopping
    {
        public string AddItem()
        {
            return "Added an item from Ebay";
        }
    }

    public class Hepsiburada : IShopping
    {
        public string AddItem()
        {
            return "Added an item from Hepsiburada";
        }
    }
}
