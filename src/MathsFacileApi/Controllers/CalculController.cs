using System.Data;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace MathsFacileApi.Controllers
{
    [Route("[controller]")]
    public class CalculController : Controller
    {
        // GET calcul/5
        [HttpGet("{value}")]
        public object Get(string value)
        {
            return "Result: " + new DataTable().Compute(value, "");
        }

        // POST /calcul
        [HttpPost]
        public object Post([FromBody] string value)
        {
            return new DataTable().Compute("Result is" + value, "");
        }
    }
}
