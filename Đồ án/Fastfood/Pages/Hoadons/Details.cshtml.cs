using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fastfood.Models;
using ApplicationCore.Interfaces;
using ApplicationCore.DTOs;

namespace Fastfood.Pages.Hoadons
{
    public class DetailsModel : PageModel
    {
        private readonly IHoadonService _service;

        public DetailsModel(IHoadonService context)
        {
            _service = context;
        }

        public HoadonDto Hoadon { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hoadon = _service.GetHoadon(id ?? default(int));

            if (Hoadon == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
