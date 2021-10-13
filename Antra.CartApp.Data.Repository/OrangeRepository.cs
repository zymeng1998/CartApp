using System;
using System.Collections.Generic;
using System.Text;
using Antra.CartApp.Model;

namespace Antra.CartApp.Data.Repository
{
    public class OrangeRepository : IRepository<Orange>
    {
        List<Orange> cart;
        public OrangeRepository() {
            cart = new List<Orange>();
        }
        public void AddToCart()
        {
            cart.Add(new Orange());
        }

        public int CartItemCount()
        {
            return cart.Count;
        }
    }
}
