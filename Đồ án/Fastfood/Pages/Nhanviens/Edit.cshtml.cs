using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fastfood.Data;
using Fastfood.Models;
using ApplicationCore.Interfaces;
using ApplicationCore.DTOs;
using AutoMapper;

namespace Fastfood.Pages.Nhanviens
{
    public class EditModel : PageModel
    {
        private readonly INhanvienService _service;
        private readonly IMapper _mapper;

        public EditModel(INhanvienService context)
        {
            _service = context;
        }

        [BindProperty]
        public SaveNhanvienDto Nhanvien { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

           var nhanvien= _service.GetNhanvien(id ?? default(int));

            if (nhanvien == null)
            {
                return NotFound();
            }
            Nhanvien = _mapper.Map<NhanvienDto, SaveNhanvienDto>(nhanvien);
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            

            try
            {
                _service.UpdateNhanvien(Nhanvien);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhanvienExists(Nhanvien.NhanvienId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool NhanvienExists(int id)
        {
            return _service.GetNhanvien(id) != null;
        }
    }
}
