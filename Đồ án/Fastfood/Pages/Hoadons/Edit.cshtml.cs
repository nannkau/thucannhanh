using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fastfood.Models;
using ApplicationCore.Interfaces;
using AutoMapper;
using ApplicationCore.DTOs;

namespace Fastfood.Pages.Hoadons
{
    public class EditModel : PageModel
    {
        private readonly IHoadonService _service;
        private readonly IMapper _mapper;

        public EditModel(IHoadonService service, IMapper mapper)
        {
            _mapper = mapper;
            _service = service;
        }

        [BindProperty]
        public SaveHoadonDto Hoadon { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoadon = _service.GetHoadon(id ?? default(int));

            if (hoadon == null)
            {
                return NotFound();
            }
            Hoadon = _mapper.Map<HoadonDto, SaveHoadonDto>(hoadon);
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
                _service.UpdateHoadon(Hoadon);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoadonExists(Hoadon.HoadonId))
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

        private bool HoadonExists(int id)
        {
            return _service.GetHoadon(id) != null;
        }
    }
}
