using mini_digikala.Models.Product;

namespace mini_digikala.Services.Interfaces
{
    public interface IProductInterface
    {
        #region Methods
        void AddProduct(ProductModel product);

        void BuyProduct(int id /* همینطوری */);

        void AddToFavorite(int productId /* همینطوری */);
        

        #endregion
    }
}
