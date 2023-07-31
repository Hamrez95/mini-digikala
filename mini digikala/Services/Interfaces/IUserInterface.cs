using mini_digikala.Models.User;

namespace mini_digikala.Services.Interfaces
{
    public interface IUserInterface
    {
        #region Method
        void AddUser(UserModel user);
        void ChargeWallet(int price /* همینطوری */);
        #endregion


    }
}
