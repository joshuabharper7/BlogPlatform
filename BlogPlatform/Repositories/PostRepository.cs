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
        public IEnumerable<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public Post GetById(int id)
        {
            return db.Posts.Where(prop => prop.Id == id).FirstOrDefault();
        }
    }
}
