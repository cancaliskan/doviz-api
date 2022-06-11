namespace DovizAPI.Helpers
{
    public static class Constants
    {
        public const string BaseUrl = "https://www.doviz.com/";

        public const string DollarXPathForBuying = "/html/body/header/div[2]/div/div[1]/div[2]/a/span[2]";
        public const string DollarXPathForSelling = "/html/body/header/div[2]/div/div[1]/div[2]/a/span[2]";
        public const string DollarXPathForLastUpdate = "//*[@id='hero']/div/div[1]/div[4]/div[1]/table/tr[1]/td[6]";

        public const string EuroXPathForBuying = "/html/body/header/div[2]/div/div[1]/div[3]/a/span[2]";
        public const string EuroXPathForSelling = "/html/body/header/div[2]/div/div[1]/div[3]/a/span[2]";
        public const string EuroXPathForLastUpdate = "//*[@id='hero']/div/div[1]/div[4]/div[1]/table/tr[2]/td[6]";

        public const string GramGoldXPathForBuying = "/html/body/header/div[2]/div/div[1]/div[1]/a/span[2]";
        public const string GramGoldXPathForSelling = "/html/body/header/div[2]/div/div[1]/div[1]/a/span[2]";
        public const string GramGoldXPathForLastUpdate = "//*[@id='hero']/div/div[1]/div[4]/div[2]/table/tr[2]/td[6]";
    }
}
