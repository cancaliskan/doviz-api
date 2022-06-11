using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
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
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };
                var web = new HtmlWeb();
                _document = web.Load(BaseUrl);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception = " + e.Message);
            }
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
            var lastUpdate = DateTime.Now.ToString("HH:mm:ss");//_document.DocumentNode.SelectSingleNode(xPathForLastUpdate).InnerText;

            var prices = new BuyingAndSellingPriceModel { BuyingPrice = buyingPrice, SellingPrice = sellingPrice, LastUpdate = lastUpdate };

            return prices;
        }
    }
}
