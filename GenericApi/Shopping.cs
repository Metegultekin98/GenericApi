namespace GenericApi
{
    public class Amazon : IShopping<Amazon>
    {
        public string AddItem()
        {
            return "Added an item from Amazon";
        }
    }

    public class Trendyol : IShopping<Trendyol>
    {
        public string AddItem()
        {
            return "Added an item from Trendyol";
        }
    }

    public class N11 : IShopping<N11>
    {
        public string AddItem()
        {
            return "Added an item from N11";
        }
    }

    public class Ebay : IShopping<Ebay>
    {
        public string AddItem()
        {
            return "Added an item from Ebay";
        }
    }

    public class Hepsiburada : IShopping<Hepsiburada>
    {
        public string AddItem()
        {
            return "Added an item from Hepsiburada";
        }
    }
}
