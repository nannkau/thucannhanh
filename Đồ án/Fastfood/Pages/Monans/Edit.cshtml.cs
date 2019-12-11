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
using AutoMapper;
using ApplicationCore.DTOs;

namespace Fastfood.Pages.Monans
{
    public class EditModel : PageModel
    {
        private readonly IMonanService _service;
        private readonly IMapper _mapper;

        public EditModel(IMonanService context,IMapper mapper)
        {
            _mapper = mapper;
            _service = context;
        }

        [BindProperty]
        public SaveMonanDto Monan { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var monan = _service.GetMonan(id ?? default(int));

            if (monan == null)
            {
                return NotFound();
            }

            Monan = _mapper.Map<MonanDto, SaveMonanDto>(monan);

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
                _service.UpdateMonan(Monan);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonanExists(Monan.MonanId))
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

        private bool MonanExists(int id)
        {
            return _service.GetMonan(id) != null;
        }
    }
}
