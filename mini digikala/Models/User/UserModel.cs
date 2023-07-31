using mini_digikala.Models.Product;

namespace mini_digikala.Models.User
{
    public class UserModel
    {
        #region Properties
        public int Id { get; set; }
        public string CreateDate { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        #endregion

        //#region Methods
        //public void AddUser(UserModel user)
        //{
        //    //Add user to data base
        //}

        //public void ChargeWallet(int price /* همینطوری */)
        //{
        //    //Charge User Wallet
        //}
        
        //#endregion
    }
}
