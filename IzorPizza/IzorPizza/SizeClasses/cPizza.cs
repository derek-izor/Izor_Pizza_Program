using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzorPizza
{
    public abstract class cPizza
    {
        public string description = ""; //description
        public static String size = ""; //size

        public virtual String getDesc()
        {
            return description;
        }

        public abstract double cost(); //Running total

        public String getSize() //Getter method for Size
        {
            return size;
        }

        public void setSize(String newSize)  //Setter Method for Size.  
        {
            size = newSize;
        }

    }
}
