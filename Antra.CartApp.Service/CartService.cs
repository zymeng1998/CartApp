using System;
using System.Collections.Generic;
using System.Text;
using Antra.CartApp.Model;
using Antra.CartApp.Data.Repository;
using System.Globalization;

namespace Antra.CartApp.Service
{
    public class CartService
    {
        IRepository<Apple> apples;
        IRepository<Orange> oranges;
        public CartService()
        {
            apples = new AppleRepository();
            oranges = new OrangeRepository();
        }
        public void AddApple()
        {
            apples.AddToCart();
        }

        public void AddOrange()
        {
            oranges.AddToCart();
        }
        public string checkout()
        {
            int appleCount = apples.CartItemCount();
            int orangeCount = oranges.CartItemCount();

            int appleBill = (appleCount / 2) * 45 + (appleCount % 2) * 45;
            int orangeBill = (orangeCount / 3) * 2 * 65 + (orangeCount % 3) * 65;
            double bill = appleBill + orangeBill;
            double real_bill = bill / 100.00;
            StringBuilder sb = new StringBuilder();
            sb.Append("$").Append(real_bill.ToString("0.00", new CultureInfo("en-US", false)));
           
            return sb.ToString();
        }
    }
}
