using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GraniteHouse.Data;
using GraniteHouse.Models.ViewModel;
using GraniteHouse.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GraniteHouse.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.SuperAdminUser)]
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly HostingEnvironment _hostingEnvironment;
        [BindProperty]
        public ProductViewModel ProductsVM { get; set; }
        public SD SD { get; set; }
        public ProductController(ApplicationDbContext db, HostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
            ProductsVM = new ProductViewModel()
            {
                producttype = _db.ProductTypes,
                specialtags = _db.SpecialTags,
                products = new Models.Product()
            };

        }
        public async Task<IActionResult> Index()
        {
            var products = _db.Products.Include(m => m.productTypes).Include(m => m.specialtags);
            return View(await products.ToListAsync());
        }   

        public IActionResult Create()
        {
            return View(ProductsVM);
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePost()
        {
            if (!ModelState.IsValid)
            {
                return View(ProductsVM);
            }

            _db.Add(ProductsVM.products);
            await _db.SaveChangesAsync();

            //image is being saved

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var productsFromDB = _db.Products.Find(ProductsVM.products.Id);

            if(files.Count != 0)
            {
                //Image has been uploaded
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extensions = Path.GetExtension(files[0].FileName);

                using(var fileStream=new FileStream(Path.Combine(uploads,ProductsVM.products.Id.ToString()+extensions), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                productsFromDB.Image = @"\" + SD.ImageFolder + @"\" + ProductsVM.products.Id + extensions;
            }
            else
            {
                //Image hasn't been uploaded
                var uploads = Path.Combine(webRootPath, SD.ImageFolder + @"\" + SD.DefaultProductImage);
                System.IO.File.Copy(uploads, webRootPath + @"\" + SD.ImageFolder + @"\" + ProductsVM.products.Id + ".jpg");
                productsFromDB.Image = @"\" + webRootPath + @"\" + SD.ImageFolder + @"\" + ProductsVM.products.Id + ".jpg";
            }
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductsVM.products = await _db.Products
                .Include(m => m.productTypes)
                .Include(m => m.specialtags)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (ProductsVM.products == null)
            {
                return NotFound();
            }
            return View(ProductsVM);
        }

        //Post: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;

                var productFromDB = await _db.Products.Where(m => m.Id == id).FirstOrDefaultAsync();

                if (files.Count > 0 && files[0] != null)
                {
                    //When user uploads a new file
                    var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                    var extension_new = Path.GetExtension(files[0].FileName);
                    var extension_old = Path.GetExtension(productFromDB.Image);

                    if (System.IO.File.Exists(Path.Combine(uploads, productFromDB.Id + extension_old)))
                    {
                        System.IO.File.Delete(Path.Combine(uploads, productFromDB.Id + extension_old));
                    }

                    using (var fileStream = new FileStream(Path.Combine(uploads, ProductsVM.products.Id.ToString() + extension_new), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }

                    ProductsVM.products.Image = @"\" + SD.ImageFolder + @"\" + ProductsVM.products.Id + extension_new;
                }

                if (ProductsVM.products.Image != null)
                {
                    productFromDB.Image = ProductsVM.products.Image;
                }

                productFromDB.Name = ProductsVM.products.Name;
                productFromDB.Price = ProductsVM.products.Price;
                productFromDB.Available = ProductsVM.products.Available;
                productFromDB.ProductTypeId = ProductsVM.products.ProductTypeId;
                productFromDB.SpecialTagId = ProductsVM.products.SpecialTagId;
                productFromDB.ShadeColor = ProductsVM.products.ShadeColor;

                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(ProductsVM);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductsVM.products = await _db.Products.Include(m => m.productTypes).Include(m => m.specialtags).SingleOrDefaultAsync(m => m.Id == id);
            if (ProductsVM.products == null)
            {
                return NotFound();


            }
            return View(ProductsVM);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductsVM.products = await _db.Products.Include(m => m.productTypes).Include(m => m.specialtags).SingleOrDefaultAsync(m => m.Id == id);
            if (ProductsVM.products == null)
            {
                return NotFound();

            }
            return View(ProductsVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            if (id == null)
            {
                return NotFound();
            }
            var prodcutFromDB = await _db.Products.Include(m => m.productTypes).Include(m => m.specialtags).SingleOrDefaultAsync(m => m.Id == id);
            if (prodcutFromDB == null)
            {
                return NotFound();
            }
            var uploads = Path.Combine(webRootPath, SD.ImageFolder);
            //var extension = Path.GetExtension(files[0].FileName);
            var extension = Path.GetExtension(prodcutFromDB.Image);
            if (System.IO.File.Exists(Path.Combine(uploads, prodcutFromDB.Id + extension)))
            {
                System.IO.File.Delete(Path.Combine(uploads, prodcutFromDB.Id + extension));
            }
            _db.Products.Remove(prodcutFromDB);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}