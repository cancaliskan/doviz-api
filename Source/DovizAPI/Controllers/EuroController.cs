using DovizAPI.Models;
using Microsoft.AspNetCore.Mvc;
using static DovizAPI.Helpers.Constants;

namespace DovizAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EuroController : BaseController
    {
        [HttpGet]
        public string Get()
        {
            return FillModel(new EuroModel(), EuroXPathForBuying, EuroXPathForSelling, EuroXPathForLastUpdate);
        }
    }
}