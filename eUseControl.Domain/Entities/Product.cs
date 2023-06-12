using eUseControl.Domain.Enums;

namespace eUseControl.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public float RegularPrice { get; set; }
        public float PromotionalPrice { get; set; }
        public string Category { get; set; }
        public string Tags { get; set; }
        public string Image0 { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public CurrencyType Currency { get; set; }
        public ProductSize Size { get; set; }

        public string GetImageById(int id)
        {
            switch (id)
            {
                case 0: return Image0;
                case 1: return Image1;
                case 2: return Image2;
                default: return "";
            }
        }
    }
}
