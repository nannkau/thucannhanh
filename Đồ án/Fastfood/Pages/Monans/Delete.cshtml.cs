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
    public class DeleteModel : PageModel
    {
        private readonly IMonanService _service;

        public DeleteModel(IMonanService context)
        {
            _service = context;
        }

        [BindProperty]
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

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _service.DeleteMonan(id ?? default(int));


            return RedirectToPage("./Index");
        }
    }
}
