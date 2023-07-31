using mini_digikala.Models.Blog;
using mini_digikala.Services.Interfaces;

namespace mini_digikala.Services.Implementations
{
    public class BlogService : IBlogInterface

    {
        #region Methods
        public void AddBlog(BlogModel blog)
        {
            //Add blog to data base
        }

        public void AddComment(string CommentText /* همینطوری */)
        {
            //Add comment Text to the data base
        }
        public void ShareBlog(string socialMediaName /* همینطوری */)
        {
            //share blog with socialMedia 
        }

        #endregion
    }
}
