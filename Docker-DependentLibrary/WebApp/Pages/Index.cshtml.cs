using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DependentClassLib;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; } = MessageClass.Message();
        public void OnGet()
        {
          

        }
    }
}
