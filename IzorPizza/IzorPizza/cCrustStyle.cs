﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzorPizza
{
    public abstract class cCrustStyle: cPizza
    {
        public abstract override String getDesc(); //Keeps tract of Description for its subclass

    }
}
