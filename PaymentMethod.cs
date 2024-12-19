using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_training
{
    internal interface PaymentMethod
    {
        public void Pay();
        public string GetName();
    }
}
