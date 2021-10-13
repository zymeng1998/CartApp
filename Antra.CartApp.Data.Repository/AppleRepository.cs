using System;
using System.Collections.Generic;
using System.Text;
using Antra.CartApp.Model;
namespace Antra.CartApp.Data.Repository
{
    public class AppleRepository : IRepository<Apple>
    {
        List<Apple> cart;
        public AppleRepository()
        {
            cart = new List<Apple>();
        }
        public void AddToCart()
        {
            cart.Add(new Apple());
        }

        public int CartItemCount()
        {
            return cart.Count;
        }
    }
}
