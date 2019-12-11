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

namespace Fastfood.Pages.Nhanviens
{
    public class DetailsModel : PageModel
    {
        private readonly INhanvienService _service;

        public DetailsModel(INhanvienService context)
        {
            _service = context;
        }

        public Nhanvien Nhanvien { get; set; }

        public IActionResult OnPost(int? id)
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
    }
}
