using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzorPizza
{
    public class cLargePizza: cPizza
    {
        public cLargePizza(String size)
        {
            description = "Large Pizza";
            this.setSize(size);
        }

        public override double cost()
        {
            return 17.00;
        }

    }
}
