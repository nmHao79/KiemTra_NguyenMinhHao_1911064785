using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KiemTra_NguyenMinhHao.Models;
namespace KiemTra_NguyenMinhHao.Controllers
{
    public class SinhVienController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Detail(string id)
        {
            var E_Sv = data.SinhViens.Where(m => m.MaSV == id).First();
            return View(E_Sv);
        }
        public ActionResult Edit(string id)
        {
            var SinhVienS = new List<SinhVien>();
            var E_Sv = data.SinhViens.First(m => m.MaSV == id);
            return View(E_Sv);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, SinhVien sv)
        {
            
            var ten = collection["HoTen"];
            if (string.IsNullOrEmpty(ten))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                
                sv.HoTen = ten;
                data.SinhViens.InsertOnSubmit(sv);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Create();
        }
        public ActionResult Delete(string id)
        {
            var D_Sv = data.SinhViens.First(m => m.MaSV == id);
            return View(D_Sv);
        }
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            var sv = data.SinhViens.Where(m => m.MaSV == id).First();
            data.SinhViens.DeleteOnSubmit(sv);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }
        // GET: SinhVien
        public ActionResult Index()
        {
            var E_Sv = from sv in data.SinhViens select sv;
            return View(E_Sv);
        }

    }
}