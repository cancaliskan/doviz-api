namespace DovizAPI.Models
{
    public class BaseCurrencyModel
    {
        public string ISOCode { get; set; }
        public string BuyingPrice { get; set; }
        public string SellingPrice { get; set; }
        public string UpdateTime { get; set; }
    }
}