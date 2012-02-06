using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzorPizza
{
    public class cSmallPizza: cPizza
    {
        public cSmallPizza(String size)
        {
            description = "Small Pizza";
            this.setSize(size);
        }

        public override double cost()
        {
            return 10.50;
        }

    }
}
