using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzorPizza
{
    public class cFlatBread: cCrustStyle
    {

        cPizza thePizza;

        public cFlatBread(cPizza thePizza)
        {
            this.thePizza = thePizza;
        }

        public override string getDesc()
        {
            return thePizza.getDesc() + " Flat Bread Crust Style";
        }


        public override double cost()
        {
            double sizeCost = 2.50; //deep dish $3.00/ flatbread $2.50/ regular $1.00
            return sizeCost + thePizza.cost();
        }


    }
}
