using BlogPlatform.Extensions;
using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        public BlogContext db;

        public PostRepository(BlogContext db)
        {
            this.db = db;
        }

        public void Create(Post obj)
        {
            db.Posts.Add(obj);
            db.SaveChanges();
        }

        public void Delete(Post obj)
        {
            db.Posts.Remove(obj);

            db.SaveChanges();
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public Post GetById(int id)
        {
            return db.Posts.Where(p => p.Id == id).FirstOrDefault();
        }

        public Post GetByName(string name)
        {
            return db.Posts.Where(c => c.Title == name).FirstOrDefault();
        }

        public IEnumerable<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return db.Categories.Find(id);
        }

        public IEnumerable<Post> GetPosts()
        {
            return db.Posts.ToList();
        }

        public void Update(Post obj)
        {
            db.Posts.Update(obj);

            db.SaveChanges();
        }

        Category ISelectList.GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
