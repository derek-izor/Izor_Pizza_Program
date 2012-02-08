using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzorPizza
{
    public class cGPepper: cTopping
    {
        cPizza thePizza;

        public cGPepper(cPizza thePizza)
        {
            this.thePizza = thePizza;
        }

        public override string getDesc()
        {
            return thePizza.getDesc() + " Green Peppers,";
        }


        public override double cost()
        {
            double sizeCost = 1.50; //meats $2 and veg $1.5
            return sizeCost + thePizza.cost();
        }

    }
}
