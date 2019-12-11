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
    public class DetailsModel : PageModel
    {
        private readonly Fastfood.Data.FastfoodContext _context;

        public DetailsModel(Fastfood.Data.FastfoodContext context)
        {
            _context = context;
        }

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
    }
}
