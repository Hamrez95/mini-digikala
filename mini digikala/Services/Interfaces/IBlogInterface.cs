using mini_digikala.Models.Blog;

namespace mini_digikala.Services.Interfaces
{
    public interface IBlogInterface
    {
        #region Methods
        void AddBlog(BlogModel blog);

        void AddComment(string CommentText /* همینطوری */);

        void ShareBlog(string socialMediaName /* همینطوری */);
        

        #endregion
    }
}
