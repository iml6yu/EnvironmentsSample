using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace EnvironmentsSample.Pages
{
    public class IndexModel : PageModel
    {
        public string Evn = "";
        public IndexModel()
        {
            Evn = Startup.Configuration["Evn"];
        }
        public void OnGet()
        {

        }
    }
}
