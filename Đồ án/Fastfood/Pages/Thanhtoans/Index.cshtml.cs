using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Services;
using Fastfood.Interfaces;
using Fastfood.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fastfood.Pages.Thanhtoans
{
    public class IndexModel : PageModel
    {

        private readonly INhanvienIndexVmService NhanvienService;
        private readonly IMonanService MonanService;
        private readonly IHoadonService HoadonService;

        public IndexModel(INhanvienIndexVmService nhanvien,IMonanService monanService1, IHoadonService hoadonService1)
        {
            NhanvienService = nhanvien;
            MonanService = monanService1;
            HoadonService = hoadonService1;

        }
        [BindProperty(SupportsGet = true)]
        public string Ten { get; set; }
       
        [BindProperty]
        public Hoadon Order { get; set; }
        [BindProperty]
        public Chitiethoadon OrderDetail { get; set; }
        [BindProperty]
        public List<Item> cart { get; set; }

        public List<Monan> Products { get; set; }
        public double Total { get; set; }

        [BindProperty(SupportsGet = true)]
        public string message { get; set; }
        public NhanvienIndexVm NhanvienIndexVm { get; set; }
        public IActionResult OnGet()
        {

            NhanvienIndexVm=NhanvienService.GetTen();
             cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                Total = cart.Sum(i => i.Product.GiaBan * i.Quantity);
                return Page();
            }
            else
            {
                Total = 0;
                return Page();
            }

        }

        public IActionResult OnGetBuyNow(int id)
        {
            //lay list<Product>

            Products = MonanService.GetListMonan().ToList<Monan>();



            //lay session list<Item>
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart == null)
            {
                cart = new List<Item>();
                cart.Add(new Item
                {
                    Product = Products.Where(p => p.MonanId == id).FirstOrDefault(),
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else    //neu da ton tai item do thi chi can them 1 so luong
            {


                int index = Exists(cart, id);
                if (index == -1)  //neu chua co id trong cart thi them moi
                {
                    cart.Add(new Item
                    {
                        Product = Products.Where(p => p.MonanId == id).FirstOrDefault(),
                        Quantity = 1
                    });
                }
                else   //ton tai thi tang so luong thoi
                {
                    cart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToPage("/Thanhtoans/Index");
        }

        // xoa item trong cart

        public IActionResult OnGetDelete(int id)
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = Exists(cart, id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("/Thanhtoans/Index");
        }

        // update quantity trong session
        public IActionResult OnPostUpdate(int[] quantities)
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (var i = 0; i < cart.Count; i++)
            {
                cart[i].Quantity = quantities[i];
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("/Thanhtoans/Index");
        }

        //kiem tra id san pham da ton tai trong cart chua
        //neu ton tai thi tra ve id
        //neu khong thi tra ve -1

        private int Exists(List<Item> cart, int id)
        {
            for (var i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.MonanId == id)
                {
                    return i;
                }
            }
            return -1;
        }


        //thanhtoan
        public IActionResult OnPostThanhToan()
        {

            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (Ten != null)
            {

                HoadonService.AddOrder(Ten, Order, cart, OrderDetail);

                //xoa session
                HttpContext.Session.Remove("cart");
               
            }
            else
            {
                message = "vui lòng chọn tên nhân viên";


            }

            return Page();

        }
    }
}