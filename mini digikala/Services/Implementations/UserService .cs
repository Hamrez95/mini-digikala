using mini_digikala.Models.User;
using mini_digikala.Services.Interfaces;

namespace mini_digikala.Services.Implementations
{
    public class UserService : IUserInterface
    {
        #region Methods
        public void AddUser(UserModel user)
        {
            //Add user to data base
        }

        public void ChargeWallet(int price /* همینطوری */)
        {
            //Charge User Wallet
        }
    }
}
