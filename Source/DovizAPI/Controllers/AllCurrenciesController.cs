using DovizAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static DovizAPI.Helpers.Constants;

namespace DovizAPI.Controllers
{
    [Route("")]
    [Route("[controller]")]
    [ApiController]
    public class AllCurrenciesController : BaseController
    {
        [HttpGet]
        public string Get()
        {
            #region Dollar Process

            var dollarInfo = FillModel(new DollarModel(), DollarXPathForBuying, DollarXPathForSelling, DollarXPathForLastUpdate);
            var dollarModel = JsonConvert.DeserializeObject<DollarModel>(dollarInfo);

            #endregion

            #region EuroProcess

            var euroInfo = FillModel(new EuroModel(), EuroXPathForBuying, EuroXPathForSelling, EuroXPathForLastUpdate);
            var euroModel = JsonConvert.DeserializeObject<EuroModel>(euroInfo);

            #endregion

            #region Gram Gold Process

            var gramGoldInfo = FillModel(new GramGoldModel(), GramGoldXPathForBuying, GramGoldXPathForSelling, GramGoldXPathForLastUpdate);
            var gramGoldModel = JsonConvert.DeserializeObject<GramGoldModel>(gramGoldInfo);

            #endregion

            var allCurrencies = new AllCurrenciesModel
            {
                Dollar = dollarModel,
                Euro = euroModel,
                GramGold = gramGoldModel
            };

            return JsonConvert.SerializeObject(allCurrencies);
        }
    }
}