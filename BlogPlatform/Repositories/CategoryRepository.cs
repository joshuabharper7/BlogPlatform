using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        public BlogContext db;
        public CategoryRepository(BlogContext db)
        {
            this.db = db;
        }
        public void Create(Category obj)
        {
            db.Categories.Add(obj);

            db.SaveChanges();
        }

        public void Delete(Category obj)
        {
            db.Categories.Remove(obj);

            db.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.Where(c => c.Id == id).FirstOrDefault();
        }

        public IEnumerable<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetPosts()
        {
            throw new NotImplementedException();
        }

        public void Update(Category obj)
        {
            db.Categories.Update(obj);

            db.SaveChanges();
        }
    }
}
