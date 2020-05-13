using Microsoft.AspNetCore.Mvc;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using kendo_grid_api.Models;

namespace kendo_grid_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GridController : Controller
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mid", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        [HttpGet]
        public JsonResult GetProducts([DataSourceRequest] DataSourceRequest request)
        {
            // ToDataSourceResult works with IQueryable and thus Entity Framework could be used as a source
            // instead of an in-memory list.
            using (var dB = new GCNContext())
            {

                return Json(dB.ItemizedStatement.ToDataSourceResult(request));
            }
        }
    }
}
