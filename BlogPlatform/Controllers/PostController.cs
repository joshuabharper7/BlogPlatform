using BlogPlatform.Models;
using BlogPlatform.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class PostController : Controller
    {
        public IRepository<Post> postRepo;

        public IRepository<Category> categoryRepo;
        public PostController(IRepository<Post> postRepo, IRepository<Category> categoryRepo)
        {
            this.postRepo = postRepo;
            this.categoryRepo = categoryRepo;
        }
        
        public IActionResult Index()
        {
            return View(postRepo.GetAll());
        }
        public ViewResult Details(int id)
        {
            Post myPost = postRepo.GetById(id);

            return View(myPost);
        }
        public IActionResult Create()
        {
            

            ViewBag.Categories = categoryRepo.GetAll();

            return View(new Post());
        }

        [HttpPost]
        public IActionResult Create(Post model)
        {
            model.PublishDate = DateTime.Now; 

            postRepo.Create(model);

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            ViewBag.Categories = categoryRepo.GetAll();

            Post post = postRepo.GetById(id);

            return View(post);
        }

        [HttpPost]
        public IActionResult Update(Post model)
        {
            model.PublishDate = DateTime.Now;

            postRepo.Update(model);

            //ViewBag.ResultMessage = "This post was successfully updated";

            return RedirectToAction("Details", "Post", new { id = model.Id});
        }

        public IActionResult Delete(int id)
        {
            Post post = postRepo.GetById(id);

            return View(post);
        }

        [HttpPost]
        public IActionResult Delete(Post post)
        {
            postRepo.Delete(post);

            return RedirectToAction("Index");
        }
    }
}
