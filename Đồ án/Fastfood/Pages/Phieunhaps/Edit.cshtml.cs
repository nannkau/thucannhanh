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

namespace Fastfood.Pages.Phieunhaps
{
    public class EditModel : PageModel
    {
        private readonly Fastfood.Data.FastfoodContext _context;

        public EditModel(Fastfood.Data.FastfoodContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Chitietphieunhap Chitietphieunhap { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Chitietphieunhap = await _context.Chitietphieunhap.FirstOrDefaultAsync(m => m.ChitietphieunhapId == id);

            if (Chitietphieunhap == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Chitietphieunhap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChitietphieunhapExists(Chitietphieunhap.ChitietphieunhapId))
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

        private bool ChitietphieunhapExists(int id)
        {
            return _context.Chitietphieunhap.Any(e => e.ChitietphieunhapId == id);
        }
    }
}
