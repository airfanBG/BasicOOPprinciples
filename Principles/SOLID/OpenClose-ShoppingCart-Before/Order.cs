using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose_ShoppingCart_Before
{
    public abstract class Order
    {
        protected readonly Cart Cart;

        protected Order(Cart cart)
        {
            this.Cart = cart;
        }

        public virtual void Checkout()
        {
            // log the order in the database
        }
    }
}
