using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_training
{
    internal interface CRemoving
    {
        public void RemoveFromCart(Product product);
    }
    // seperate AddToChart and RemoveFromChart (interface segregation)
}
