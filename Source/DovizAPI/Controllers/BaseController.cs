using System;

using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

using DovizAPI.Models;
using static DovizAPI.Helpers.Constants;

namespace DovizAPI.Controllers
{
    public class BaseController : Controller
    {
        private static HtmlDocument _document;
        public BaseController()
        {
            var web = new HtmlWeb();
            _document = web.Load(BaseUrl);
        }

        protected static string FillModel(BaseCurrencyModel model, string xPathForBuying, string xPathForSelling, string xPathForLastUpdate)
        {
            var prices = GetBuyingAndSellingPrice(xPathForBuying, xPathForSelling, xPathForLastUpdate);

            model.BuyingPrice = prices.BuyingPrice;
            model.SellingPrice = prices.SellingPrice;
            model.UpdateTime = prices.LastUpdate;

            return JsonConvert.SerializeObject(model);
        }

        protected static BuyingAndSellingPriceModel GetBuyingAndSellingPrice(string xPathForBuying, string xPathForSelling, string xPathForLastUpdate)
        {
            var buyingPrice = _document.DocumentNode.SelectSingleNode(xPathForBuying).InnerText;
            var sellingPrice = _document.DocumentNode.SelectSingleNode(xPathForSelling).InnerText;
            var lastUpdate = _document.DocumentNode.SelectSingleNode(xPathForLastUpdate).InnerText;

            var prices = new BuyingAndSellingPriceModel { BuyingPrice = buyingPrice, SellingPrice = sellingPrice, LastUpdate = lastUpdate };

            return prices;
        }
    }
}