using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzorPizza
{
    public class cDeepDish: cCrustStyle
    {

        cPizza thePizza;

        public cDeepDish(cPizza thePizza)
        {
            this.thePizza = thePizza;
        }

        public override string getDesc()
        {
            return thePizza.getDesc() + " Deep Dish, ";
        }


        public override double cost()
        {
            double sizeCost = 3.00; //deep dish $3.00/ flatbread $2.50/ regular $1.00
            return sizeCost + thePizza.cost();
        }


    }
}
