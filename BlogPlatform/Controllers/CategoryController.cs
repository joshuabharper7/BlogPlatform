using BlogPlatform.Models;
using BlogPlatform.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class CategoryController : Controller
    {
        public IRepository<Category> categoryRepo;

        public IRepository<Post> postRepo;
        public CategoryController(IRepository<Category> categoryRepo, IRepository<Post> postRepo)
        {
            this.categoryRepo = categoryRepo;
            this.postRepo = postRepo;
        }
        public IActionResult Index()
        {
            return View(categoryRepo.GetAll());
        }
        public IActionResult Create()
        {
            return View(new Category());
        }

        [HttpPost]
        public IActionResult Create(Category model)
        {
            categoryRepo.Create(model);

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            ViewBag.Categories = categoryRepo.GetAll();

            Category category = categoryRepo.GetById(id);

            return View(category);
        }

        [HttpPost]
        public IActionResult Update(Category model)
        {
            categoryRepo.Update(model);

            ViewBag.ResultMessage = "The Category Was Successfully Updated.";

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Category category = categoryRepo.GetById(id);

            return View(category);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            categoryRepo.Delete(category);

            return RedirectToAction("Index");
        }
    }
}
