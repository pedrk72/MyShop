using MyShop.Core.Models;
using MyShop.Data.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop2.WebIU.Controllers
{
    public class ProductCategoryManagerController : Controller
    {
        // Em vez de utilizar os repositorios especificos, utilizar um generalista
        //ProductCategoryRepository context;
        InMemoryRepository<ProductCategory> context;

        public ProductCategoryManagerController()
        {
            context = new InMemoryRepository<ProductCategory>();
        }

        // GET: ProductManager
        public ActionResult Index()
        {
            List<ProductCategory> productCategories = context.Collection().ToList();
            return View(productCategories);
        }

        public ActionResult Create()
        {
            ProductCategory productCategories = new ProductCategory();
            return View(productCategories);
        }

        [HttpPost]
        public ActionResult Create(ProductCategory productCategories)
        {
            if (ModelState.IsValid)
            {
                return View(productCategories);
            }
            else
            {
                context.Insert(productCategories);
                context.Commit();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(string Id)
        {
            ProductCategory productCategories = context.Find(Id);
            if (productCategories == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(productCategories);
            }
        }

        [HttpPost]
        public ActionResult Edit(ProductCategory productCategories, string Id)
        {
            ProductCategory productCategoriesToEdit = context.Find(Id);
            if (productCategoriesToEdit == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    return View(productCategories);
                }
                productCategoriesToEdit.Category = productCategoriesToEdit.Category;
                context.Commit();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(string Id)
        {
            ProductCategory productCategoriesToDelete = context.Find(Id);
            if (productCategoriesToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(productCategoriesToDelete);
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete(ProductCategory productCategory, string Id)
        {
            ProductCategory productCategoryToDelete = context.Find(Id);
            if (productCategoryToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                context.Delete(Id);
                context.Commit();
                return RedirectToAction("Index");
            }
        }
    }
}