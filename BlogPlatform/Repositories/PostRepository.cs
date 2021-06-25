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
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public Post GetById(int id)
        {
            return db.Posts.Where(p => p.Id == id).FirstOrDefault();
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
            throw new NotImplementedException();
        }

        public void Update(Post obj)
        {
            db.Posts.Update(obj);

            db.SaveChanges();
        }
    }
}
