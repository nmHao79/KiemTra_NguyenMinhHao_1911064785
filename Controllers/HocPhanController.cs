using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KiemTra_NguyenMinhHao.Models;

namespace KiemTra_NguyenMinhHao.Controllers
{
    public class HocPhanController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        // GET: HocPhan
        public ActionResult Index()
        {
            var E_Hp = from hp in data.HocPhans select hp;
            return View(E_Hp);
        }
    }
}