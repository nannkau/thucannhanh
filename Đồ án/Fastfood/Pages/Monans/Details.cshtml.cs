using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fastfood.Data;
using Fastfood.Models;
using ApplicationCore.Interfaces;
using ApplicationCore.DTOs;

namespace Fastfood.Pages.Monans
{
    public class DetailsModel : PageModel
    {
        private readonly IMonanService  _service;

        public DetailsModel(IMonanService context)
        {
            _service = context;
        }

        public MonanDto Monan { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Monan = _service.GetMonan(id ?? default(int));

            if (Monan == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
