using System;
using System.Linq;
using UserService.Models;

namespace UserService.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly BuyerContext _context;
        public UserRepository(BuyerContext context)
        {
            _context = context;
        }

        public void BuyerRegister(Buyer buyer)
        {
            _context.Add(buyer);
            _context.SaveChanges();
        }

        public Buyer ValidateBuyer(string uname, string pwd)
        {

            Buyer b = _context.Buyer.SingleOrDefault(e => e.Username == uname && e.Password == pwd);
            if(b.Username==uname && b.Password == pwd)
            {
                return b;
            }
            else
            {
                Console.WriteLine("not avalid user");
                return b;
            }
           

        }
    }
}
