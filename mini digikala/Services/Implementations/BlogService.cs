using mini_digikala.Models.Blog;
using mini_digikala.Services.Interfaces;

namespace mini_digikala.Services.Implementations
{
    public class BlogService : IBlogInterface , IGeneralInterface<BlogModel>

    {
        #region CustomMethods
        //public void AddBlog(BlogModel blog)
        //{
        //    //Add blog to data base
        //}

        public void AddComment(string CommentText /* همینطوری */)
        {
            //Add comment Text to the data base
        }

        

        public void ShareBlog(string socialMediaName /* همینطوری */)
        {
            //share blog with socialMedia 
        }

        #endregion

        #region Generic Methods
        public void AddItem(BlogModel hezarChehreh)
        {
            throw new NotImplementedException();
        }

        public void EditItem(BlogModel hezarChehreh)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(BlogModel hezarChehreh)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
