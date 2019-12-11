using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Fastfood.Data;
using Fastfood.Models;
using ApplicationCore.Interfaces;
using ApplicationCore.DTOs;

namespace Fastfood.Pages.Nhanviens
{
    public class CreateModel : PageModel
    {
        private readonly INhanvienService _service;

        public CreateModel(INhanvienService context)
        {
            _service = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SaveNhanvienDto Nhanvien { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.CreateNhanvien(Nhanvien);

            return RedirectToPage("./Index");
        }
    }
}
