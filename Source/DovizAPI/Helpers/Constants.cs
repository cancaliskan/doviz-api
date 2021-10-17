namespace DovizAPI.Helpers
{
    public static class Constants
    {
        public const string BaseUrl = "https://canlidoviz.com/";

        public const string DollarXPathForBuying = "//*[@id='hero']/div/div[1]/div[4]/div[1]/table/tr[1]/td[3]";
        public const string DollarXPathForSelling = "//*[@id='hero']/div/div[1]/div[4]/div[1]/table/tr[1]/td[4]";
        public const string DollarXPathForLastUpdate = "//*[@id='hero']/div/div[1]/div[4]/div[1]/table/tr[1]/td[6]";

        public const string EuroXPathForBuying = "//*[@id='hero']/div/div[1]/div[4]/div[1]/table/tr[2]/td[3]";
        public const string EuroXPathForSelling = "//*[@id='hero']/div/div[1]/div[4]/div[1]/table/tr[2]/td[4]";
        public const string EuroXPathForLastUpdate = "//*[@id='hero']/div/div[1]/div[4]/div[1]/table/tr[2]/td[6]";

        public const string GramGoldXPathForBuying = "//*[@id='hero']/div/div[1]/div[4]/div[2]/table/tr[2]/td[3]";
        public const string GramGoldXPathForSelling = "//*[@id='hero']/div/div[1]/div[4]/div[2]/table/tr[2]/td[4]";
        public const string GramGoldXPathForLastUpdate = "//*[@id='hero']/div/div[1]/div[4]/div[2]/table/tr[2]/td[6]";
    }
}