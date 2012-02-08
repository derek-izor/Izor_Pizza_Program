using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzorPizza
{
    public class cLargePizza: cPizza
    {
        public cLargePizza()
        {
            description = "Large Pizza, ";
            this.setSize("large");
        }

        public override double cost()
        {
            return 17.00;
        }

    }
}
