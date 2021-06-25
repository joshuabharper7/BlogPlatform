﻿using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Extensions
{
    public interface ISelectList
    {
        IEnumerable<Post> GetPosts();
        IEnumerable<Category> GetCategories();
        Category GetCategoryById(int id);
    }
}
