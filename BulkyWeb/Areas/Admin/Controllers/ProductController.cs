using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Product> productList = _unitOfWork.Product.GetAll().ToList();
            return View(productList);
        }
        //Get Create Method
        public IActionResult Create()
        {
            return View();
        }
        //POST Create Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product Product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Add(Product);
                _unitOfWork.Save();
                TempData["success"] = "Product Created Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(Product);

        }
        //Get Edit Method
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product? Product = _unitOfWork.Product.Get(c => c.Id == id);
            if (Product == null)
            {
                return NotFound();
            }
            return View(Product);
        }
        //POST Edit Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product Product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Update(Product);
                _unitOfWork.Save();
                TempData["success"] = "Product Updated Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(Product);
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
