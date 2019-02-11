﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern
{
    public abstract class AbstractRoadBike : AbstractBike
    {
        public AbstractRoadBike(IWheel wheel)
            : this(BikeColor.Chrome, wheel)
        {

        }
        public AbstractRoadBike(BikeColor color, IWheel wheel)
            : base(color, wheel)
        {

        }
    }
}
