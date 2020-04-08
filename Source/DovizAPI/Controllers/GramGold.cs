using DovizAPI.Models;
using Microsoft.AspNetCore.Mvc;
using static DovizAPI.Helpers.Constants;

namespace DovizAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GramGold : BaseController
    {
        [HttpGet]
        public string Get()
        {
            return FillModel(new GramGoldModel(), GramGoldXPathForBuying, GramGoldXPathForSelling, GramGoldXPathForLastUpdate);
        }
    }
}