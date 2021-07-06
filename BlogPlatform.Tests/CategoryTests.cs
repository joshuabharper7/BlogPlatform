using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BlogPlatform.Tests
{
    public class CategoryTests
    {
        Category sut;

        [Fact]
        public void CategoryConstructor_Sets_Id_On_Category()
        {
            sut = new Category(1, "");

            Assert.Equal(1, sut.Id);
        }
        [Fact]
        public void CategoryConstructor_Sets_Name_On_Category()
        {
            sut = new Category(2,"Name");

            Assert.Equal("Name", sut.Name);
        }
    }
}
