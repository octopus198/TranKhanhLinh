using TranKhanhLinh.Models.DanhSach;
using Microsoft.AspNetCore.Mvc;

namespace TranKhanhLinh.Controllers
{
    public class DanhSachController : Controller
    {
        public static List<ModelDanhSach> sanpham = new List<ModelDanhSach>();
        public IActionResult Index(bool? check = false)
        {
            if((bool)check)
            {
                sanpham.Clear();
            }
            else
            {
                return View(sanpham.ToList());
            } 
            return View();
              
          
        }

        [HttpPost]
        public IActionResult Index(string tensanpham, int soluong, int dongia, int giamgia)
        {
            var sanphamnhap = new ModelDanhSach(tensanpham, soluong, dongia, giamgia);
            sanpham.Add(sanphamnhap);
            return View(sanpham);
        }

        public IActionResult xoaSanPham(int sothutu)
        {
            sanpham.RemoveAt(sothutu - 1);
            return RedirectToAction("Index", "Home");
        }
    }
}
