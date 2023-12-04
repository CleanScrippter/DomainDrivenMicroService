namespace Contracts.Model
{
    public class Contract
    {
        
            public Guid _id { get; set; }
            public string Name { get; set; }
            public int CountryId { get; set; }
            public List<Product> Products { get; set; }
        

        public class Element
        {
            public string _t { get; set; }
            public string Fee { get; set; }
            public object Price { get; set; }
        }

        public class Product
        {
            public string _id { get; set; }
            public List<Element> Elements { get; set; }
        }

        public class Root
        {
            public Contract Contracts { get; set; }
        }

    }
}
