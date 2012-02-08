using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzorPizza
{
    public class cMballs: cTopping
    {
        cPizza thePizza;

        public cMballs(cPizza thePizza)
        {
            this.thePizza = thePizza;
        }

        public override string getDesc()
        {
            return thePizza.getDesc() + " Meat Balls, ";
        }


        public override double cost()
        {
            double sizeCost = 2.00; //meats $2 and veg $1.5
            return sizeCost + thePizza.cost();
        }

    }
}
