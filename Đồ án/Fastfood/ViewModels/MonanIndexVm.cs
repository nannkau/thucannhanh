using ApplicationCore.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fastfood.ViewModels
{
    public class MonanIndexVm
    {
        public SelectList Loai { get; set; }
        public PaginatedList<MonanDto> Monans { get; set; }
    }
}