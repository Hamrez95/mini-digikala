using mini_digikala.Models.Product;
using mini_digikala.Services.Interfaces;

namespace mini_digikala.Services.Implementations
{
    public class ProductService : IProductInterface
    {
        #region Methods
        public void AddProduct(ProductModel product)
        {
            //Add Product
        }

        public void BuyProduct(int id /* همینطوری */)
        {
            //BuyProduct Product
        }
        public void AddToFavorite(int productId /* همینطوری */)
        {
            //Add to favorite
        }

        #endregion
    }
}
