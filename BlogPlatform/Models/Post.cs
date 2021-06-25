using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Display(Name = "Post Title:")]
        public string Title { get; set; }
        [Display(Name = "Post:")]
        public string Body { get; set; }
        [Display(Name = "Author:")]
        public string Author { get; set; }
        [Display(Name = "Date Posted:")]
        public DateTime PublishDate { get; set; }
        [Display(Name = "Category:")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Post()
        {

        }

        public Post(int id, int categoryId, string title, string body, string author)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
            CategoryId = categoryId;
        }
    }
}
