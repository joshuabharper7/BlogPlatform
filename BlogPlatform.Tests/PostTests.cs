using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ReviewsSite.Tests
{
    public class PostTests
    {
        Post sut;

        [Fact]
        public void PostConstructor_Sets_Id_On_Product()
        {
            sut = new Post(1, 2, "", "", "");

            Assert.Equal(1, sut.Id);
        }
        [Fact]
        public void PostConstructor_Sets_CategoryId_On_Product()
        {
            sut = new Post(1, 2, "", "", "");

            Assert.Equal(2, sut.CategoryId);
        }
        [Fact]
        public void PostConstructor_Sets_Title_On_Product()
        {
            sut = new Post(1, 2, "Test", "", "");

            Assert.Equal("Test", sut.Title);
        }
        [Fact]
        public void PostConstructor_Sets_Body_On_Product()
        {
            sut = new Post(1, 2, "", "Body", "");

            Assert.Equal("Body", sut.Body);
        }
        [Fact]
        public void PostConstructor_Sets_Author_On_Product()
        {
            sut = new Post(1, 2, "", "Author", "");

            Assert.Equal("Author", sut.Author);
        }

    }
}
