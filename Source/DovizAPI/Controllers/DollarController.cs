using Microsoft.AspNetCore.Mvc;
using DovizAPI.Models;
using static DovizAPI.Helpers.Constants;

namespace DovizAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DollarController : BaseController
    {
        [HttpGet]
        public string Get()
        {
            return FillModel(new DollarModel(), DollarXPathForBuying, DollarXPathForSelling, DollarXPathForLastUpdate);
        }
    }
}