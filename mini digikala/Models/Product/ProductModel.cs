namespace mini_digikala.Models.Product
{
    public class ProductModel
    {
        #region Properties
        public int Id { get; set; }
        public string CreateDate { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        #endregion

        //#region Methods
        //public void AddProduct(ProductModel product)
        //{
        //    //Add Product
        //}

        //public void BuyProduct(int id /* همینطوری */)
        //{
        //    //BuyProduct Product
        //}
        //public void AddToFavorite(int productId /* همینطوری */)
        //{
        //    //Add to favorite
        //}

        //#endregion
    }
}
