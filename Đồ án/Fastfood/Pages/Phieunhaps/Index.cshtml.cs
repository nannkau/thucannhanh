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
    public class IndexModel : PageModel
    {
        private readonly Fastfood.Data.FastfoodContext _context;

        public IndexModel(Fastfood.Data.FastfoodContext context)
        {
            _context = context;
        }

        public IList<Chitietphieunhap> Chitietphieunhap { get;set; }

        public async Task OnGetAsync()
        {
            Chitietphieunhap = await _context.Chitietphieunhap.ToListAsync();
        }
    }
}
