using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyerService.Models;
using BuyerService.Repositories;

namespace BuyerService.Repositories
{
    public class BuyerRepository:IBuyerRepository
    {
        private readonly BuyerContext _context;
        public BuyerRepository(BuyerContext context)
        {
            _context = context;
        }

        public void AddToCart(Cart cart)
        {
            throw new NotImplementedException();
        }
        public void BuyItem(Purchasehistory purchase)
        {
            throw new NotImplementedException();
        }

        public bool CheckCartItem(int buyerid, int itemid)
        {
            throw new NotImplementedException();
        }

        public void DeleteCart(string cartid)
        {
            throw new NotImplementedException();
        }

        public void EditProfile(Buyer buyer)
        {
            throw new NotImplementedException();
        }

        public Cart GetCartItem(int cartid)
        {
            throw new NotImplementedException();
        }

        public List<Cart> GetCarts(string bid)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public int GetCount(int bid)
        {
            throw new NotImplementedException();
        }

        public List<Items> GetItems()
        {
            throw new NotImplementedException();
        }

        public Buyer GetProfile(int bid)
        {
            throw new NotImplementedException();
        }

        public Purchasehistory GetpurchaseHistory(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubCategory> GetSubCategories(int cid)
        {
            throw new NotImplementedException();
        }

        public List<Items> Items(int price, int price1)
        {
            throw new NotImplementedException();
        }

        public List<Purchasehistory> Purchase(int bid)
        {
            throw new NotImplementedException();
        }

        public List<Items> Search(string itemname)
        {
            throw new NotImplementedException();
        }

        public List<Items> SearchItemByCategory(string cname)
        {
            throw new NotImplementedException();
        }

        public List<Items> SearchItemBySubCategory(string suname)
        {
            throw new NotImplementedException();
        }
    }
}
