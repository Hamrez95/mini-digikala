#region using
using mini_digikala.Models.Blog;
using mini_digikala.Models.Product;
using mini_digikala.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion


namespace mini_digikala.Services.Interfaces
{
    public interface IGeneralInterface<T>
    {
        #region Add
        void AddItem/*<HezarChehreh>*/(T t);


        //void AddItem(UserModel user);
        //void AddItem(ProductModel product);
        //void AddItem(BlogModel blog);
        #endregion

        #region Edit
        void EditItem/*<HezarChehreh>*/(T t);

        //void EditItem(UserModel user);
        //void EditItem(ProductModel product);
        //void EditItem(BlogModel blog);
        #endregion

        #region Remove
        void RemoveItem/*<HezarChehreh>*/(T t);

        //void RemoveItem(UserModel user);
        //void RemoveItem(ProductModel product);
        //void RemoveItem(BlogModel blog);
        #endregion


    }
}
