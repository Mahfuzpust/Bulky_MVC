using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Bulky.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;

        }
        public IActionResult Index()
        {
            List<Product> productList = _unitOfWork.Product.GetAll().ToList();
            
            return View(productList);
        }
        //Get Create Method
        public IActionResult Upsert(int? id)
        {
            ProductVM productVM = new()
            {
                CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString(),
                }),
                Product = new Product()
            };
            if(id == null || id == 0)
            {
                //Create
                return View(productVM);
            }
            else
            {
                //Update
                productVM.Product = _unitOfWork.Product.Get(u=>u.Id==id);
                return View(productVM);
            }
        }

        //POST Create Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ProductVM productVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"images\product");

                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    productVM.Product.ImageUrl = @"\images\product\" + fileName;
                }
                _unitOfWork.Product.Add(productVM.Product);
                _unitOfWork.Save();
                TempData["success"] = "Product Created Successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                productVM.CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString(),
                });
                return View(productVM);
            }
        }

        //Delete GET Method
        public IActionResult Delete(int? id, Product Product)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product? obj = _unitOfWork.Product.Get(c => c.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //Delete Post Method 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Product Product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Remove(Product);
                _unitOfWork.Save();
                TempData["success"] = "Product Deleted Successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(Product);
            }
        }
    }
}
