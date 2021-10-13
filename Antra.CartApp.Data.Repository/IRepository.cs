using System;
using System.Collections.Generic;
using System.Text;

namespace Antra.CartApp.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        void AddToCart();
        int CartItemCount();
    }
}
