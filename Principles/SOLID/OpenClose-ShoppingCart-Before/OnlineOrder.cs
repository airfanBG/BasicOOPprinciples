using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose_ShoppingCart_Before
{
    public class OnlineOrder : Order
    {
        public OnlineOrder(Cart cart)
            : base(cart)
        {
        }
    }
}
