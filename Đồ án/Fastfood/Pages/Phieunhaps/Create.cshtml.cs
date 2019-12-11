using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Fastfood.Data;
using Fastfood.Models;

namespace Fastfood.Pages.Phieunhaps
{
    public class CreateModel : PageModel
    {
        private readonly Fastfood.Data.FastfoodContext _context;

        public CreateModel(Fastfood.Data.FastfoodContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Chitietphieunhap Chitietphieunhap { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Chitietphieunhap.Add(Chitietphieunhap);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
