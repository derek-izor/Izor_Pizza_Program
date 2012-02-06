using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzorPizza
{
    public class cMedPizza: cPizza
    {
        public cMedPizza(String size)
        {
            description = "Medium Pizza";
            this.setSize(size);
        }

        public override double cost()
        {
            return 13.00;
        }

    }
}
