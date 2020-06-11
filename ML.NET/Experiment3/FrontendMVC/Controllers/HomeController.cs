using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FrontendMVC.Models;
using SampleClassification.Model;

namespace FrontendMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/ml")]
        public IActionResult Post([FromBody]Tweet tweet)
        {
            if (tweet == null)
            {
                return NotFound();
            }

            var input = new ModelInput();
            input.Tweet = tweet.TweetContent;
            ModelOutput result = ConsumeModel.Predict(input);

            return Content(result.Score[1].ToString());
        }

    }
}
