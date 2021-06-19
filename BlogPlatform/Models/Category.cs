using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Category
    {
        public string Name { get; set; }
        public string Content { get; set; }

        public Category()
        {

        }

        public Category(string name, string content)
        {
            Name = name;
            Content = content;
        }
    }
}
