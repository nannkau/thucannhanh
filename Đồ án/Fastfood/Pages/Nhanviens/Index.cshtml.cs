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

namespace Fastfood.Pages.Nhanviens
{
    public class IndexModel : PageModel
    {
        private readonly INhanvienIndexVmService _service;

        public IndexModel(INhanvienIndexVmService context)
        {
            _service = context;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }


        public NhanvienIndexVm NhanvienIndexVm { get; set; }

        public void OnGet(string searchString, int pageIndex = 1)
        {
            NhanvienIndexVm = _service.GetNhanvienListVm(searchString, pageIndex);
        }
    }
}
