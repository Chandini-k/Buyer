using UserService.Models;

namespace UserService.Repositories
{
    public interface IUserRepository
    {
        public void BuyerRegister(Buyer buyer);
        public Buyer ValidateBuyer(string uname, string pwd);
    }
}
