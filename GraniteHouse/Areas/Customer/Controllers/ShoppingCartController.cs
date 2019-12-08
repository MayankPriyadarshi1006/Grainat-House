using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraniteHouse.Data;
using GraniteHouse.Extensions;
using GraniteHouse.Models;
using GraniteHouse.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GraniteHouse.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ShoppingCartController : Controller
    {

        private readonly ApplicationDbContext _db;
        [BindProperty]
        public ShoppingCartViewModel ShoppinCartVM { get; set; }
        public ShoppingCartController(ApplicationDbContext db)
        {
            _db = db;
            ShoppinCartVM = new ShoppingCartViewModel();
            //{
            //    Products = new List<Product>(),               
            //    Appointments = new Models.Appointments()
            //};
        }
        public IActionResult Index()
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            if (lstShoppingCart != null)
            {
                if (lstShoppingCart.Count > 0)
                {
                    var xx = _db.Products.Include(m => m.productTypes).Include(m => m.specialtags).Where(x => lstShoppingCart.Contains(x.Id)).ToList();
                    ShoppinCartVM.Products = xx;
                    //foreach (int id in lstShoppingCart)
                    //{
                    //    Product prod= _db.Products.Include(m => m.productTypes).Include(m => m.specialtags).Where(m => m.Id == id).FirstOrDefault();
                    //    ShoppinCartVM.Products.Add(prod);
                    //}
                }
            }
            return View(ShoppinCartVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> remove(int id)
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            if (lstShoppingCart.Contains(id))
            {
                lstShoppingCart.Remove(id);
            }
            HttpContext.Session.Set<List<int>>("ssShoppingCart", lstShoppingCart);
            return RedirectToAction(nameof(Index));

        }

        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public IActionResult PostIndex()
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            var appointments = ShoppinCartVM.Appointments;
            appointments.AppointmentDate.AddHours(appointments.AppointmentTime.Hour);
            appointments.AppointmentDate.AddHours(appointments.AppointmentTime.Minute);
            _db.Appointments.Add(appointments);
            _db.SaveChanges();

            var appointmentId = appointments.Id;

            foreach(int productId in lstShoppingCart)
            {
                _db.ProdutSelectedForAppointment.Add(new ProdutSelectedForAppointment()
                {
                    AppointmentId = appointmentId,
                    ProductId = productId
                });
            }
            HttpContext.Session.Set("ssShoppingCart", lstShoppingCart);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult AppoitmentConfirmation(int Id)
        {
            ShoppinCartVM.Appointments = _db.Appointments.Find(Id);
            var productList = _db.ProdutSelectedForAppointment.Where(x => x.Appointments.Id == Id).ToList();
            foreach (ProdutSelectedForAppointment p in productList)
            {
                ShoppinCartVM.Products.Add(_db.Products.Include(x => x.productTypes).Include(x => x.specialtags).FirstOrDefault(x => x.Id == p.ProductId));
            }
            return View(ShoppinCartVM);
        }
    }

    


}