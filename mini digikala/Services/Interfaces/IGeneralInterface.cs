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
    public interface IGeneralInterface<HezarChehreh>
    {
        #region Add
        void AddItem/*<HezarChehreh>*/(HezarChehreh hezarChehreh);


        //void AddItem(UserModel user);
        //void AddItem(ProductModel product);
        //void AddItem(BlogModel blog);
        #endregion

        #region Edit
        void EditItem/*<HezarChehreh>*/(HezarChehreh hezarChehreh);

        //void EditItem(UserModel user);
        //void EditItem(ProductModel product);
        //void EditItem(BlogModel blog);
        #endregion

        #region Remove
        void RemoveItem/*<HezarChehreh>*/(HezarChehreh hezarChehreh);

        //void RemoveItem(UserModel user);
        //void RemoveItem(ProductModel product);
        //void RemoveItem(BlogModel blog);
        #endregion


    }
}
