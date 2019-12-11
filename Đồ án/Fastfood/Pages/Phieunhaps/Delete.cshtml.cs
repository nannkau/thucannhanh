using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fastfood.Data;
using Fastfood.Models;

namespace Fastfood.Pages.Phieunhaps
{
    public class DeleteModel : PageModel
    {
        private readonly Fastfood.Data.FastfoodContext _context;

        public DeleteModel(Fastfood.Data.FastfoodContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Chitietphieunhap = await _context.Chitietphieunhap.FindAsync(id);

            if (Chitietphieunhap != null)
            {
                _context.Chitietphieunhap.Remove(Chitietphieunhap);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
