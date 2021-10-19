using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json;


namespace UseJson.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGetAsync()
        {
            ////使用Json.NET vs STJ
            //var person = new { Name = "Liou", Age = 23 };
            //var json = JsonConvert.SerializeObject(person);

            //var person2person2 = JsonConvert.DeserializeObject<Person>(json);

            //return new JsonResult(json);
        }

        class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
