using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Arquitetura.Presentation.ASPNETMVC.CategoryService;

namespace Arquitetura.Presentation.ASPNETMVC.Controllers
{
    public class CategoryController : Controller
    {
        #region Properties
        private static ICategoryService CategoryService { get; set; }
        #endregion

        #region Constructors
        static CategoryController()
        {
            CategoryService = new CategoryServiceClient();
        }
        #endregion

        public ActionResult Index()
        {
            return RedirectToAction("Categories");
        }

        public ActionResult Categories()
        {
            var categories = CategoryService.GetAllCategories();

            return View(categories);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                CategoryService.AddCategory(category);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            Category category = CategoryService.FindCategoryById(id);

            return View(category);
        }

        public ActionResult Edit(int id)
        {
            Category category = CategoryService.FindCategoryById(id);

            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(int id, Category category)
        {
            try
            {
                category.CategoryID = id;

                CategoryService.UpdateCategory(category);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            Category category = new Category()
                                    {
                                        CategoryID = id
                                    };

            CategoryService.DeleteCategory(category);

            return RedirectToAction("Index");
        }

    }

}
