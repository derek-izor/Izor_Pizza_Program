using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzorPizza
{
    public class cMedPizza: cPizza
    {
        public cMedPizza()
        {
            description = "Medium Pizza, ";
            this.setSize("medium");
        }

        public override double cost()
        {
            return 13.00;
        }

    }
}
