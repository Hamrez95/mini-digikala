#region using
using mini_digikala.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
# endregion 


namespace mini_digikala.Models.Blog
{
    public class BlogModel
    {
        #region Properties
        public int Id { get; set; }
        public string CreateDate { get; set; }
        public string Name { get; set; }
        public string Writer { get; set; }
        public string LongDescription { get; set; }
        #endregion

        //#region Methods
        //public void AddBlog(BlogModel blog)
        //{
        //    //Add blog to data base
        //}

        //public void AddComment(string CommentText /* همینطوری */)
        //{
        //    //Add comment Text to the data base
        //}
        //public void ShareBlog(string socialMediaName /* همینطوری */)
        //{
        //    //share blog with socialMedia 
        //}

        //#endregion
    }
}
