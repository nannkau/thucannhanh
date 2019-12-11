using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fastfood.Data;
using Fastfood.Models;
using Fastfood.Interfaces;
using Fastfood.ViewModels;

namespace Fastfood.Pages.Monans
{
    public class IndexModel : PageModel
    {
        private readonly IMonanIndexVmService _service;

        public IndexModel(IMonanIndexVmService service)
        {
            _service = service;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Loai { get; set; }

        public MonanIndexVm MonanIndexVm { get; set; }


        public void OnGet(string searchString, int pageIndex = 1)
        {
            MonanIndexVm = _service.GetMonanListVm(SearchString, Loai, pageIndex);
        }
    }
}
