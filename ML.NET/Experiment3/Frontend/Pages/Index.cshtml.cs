using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SampleClassification.Model;

namespace Frontend.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost(string? tweet)
        {
            if (tweet == null)
            {
                return NotFound();
            }

            var input = new ModelInput();
            input.Tweet = tweet;
            ModelOutput result = ConsumeModel.Predict(input);

            return Content(result.Score[1].ToString());
        }
    }
}
