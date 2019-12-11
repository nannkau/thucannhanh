using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fastfood.Models;
using Fastfood.Interfaces;
using Fastfood.ViewModels;
using ApplicationCore.Interfaces;

namespace Fastfood.Pages.Hoadons
{
    public class IndexModel : PageModel
    {
        private readonly IHoadonIndexVmService _service;

        public IndexModel(IHoadonIndexVmService context)
        {
            _service = context;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }



        public HoadonIndexVm HoadonIndexVm { get; set; }

        public void OnGet(string searchString, int pageIndex = 1)
        {
            HoadonIndexVm = _service.GetHoadonListVm(searchString, pageIndex);
        }
    }
}
