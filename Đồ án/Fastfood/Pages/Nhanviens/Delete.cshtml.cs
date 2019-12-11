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

namespace Fastfood.Pages.Nhanviens
{
    public class DeleteModel : PageModel
    {
        private readonly INhanvienService _service;

        public DeleteModel(INhanvienService context)
        {
            _service = context;
        }

        [BindProperty]
        public NhanvienDto Nhanvien { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _service.GetNhanvien(id ?? default(int));

            if (Nhanvien == null)
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

            _service.DeleteNhanvien(id ?? default(int));

            return RedirectToPage("./Index");
        }
    }
}
