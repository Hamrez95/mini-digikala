using mini_digikala.Models.User;
using mini_digikala.Services.Interfaces;

namespace mini_digikala.Services.Implementations
{
    public class UserService : IUserInterface , IGeneralInterface<UserModel>
    {
        
        #region CustomMethods
        public void AddUser(UserModel user)
        {
            //Add user to data base
        }

        public void ChargeWallet(int price /* همینطوری */)
        {
            //Charge User Wallet
        }


        #endregion

        #region Methods
        public void AddItem(UserModel hezarChehreh)
        {
            throw new NotImplementedException();
        }
        public void EditItem(UserModel hezarChehreh)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(UserModel hezarChehreh)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
