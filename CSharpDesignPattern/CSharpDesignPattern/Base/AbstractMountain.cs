﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern
{
    public abstract class AbstractMountainBike : AbstractBike
    {
        public override decimal price { get; } = 740.00m;
        public AbstractMountainBike(IWheel wheel)
            : this(BikeColor.Chrome, wheel)
        {

        }
        public AbstractMountainBike(BikeColor color, IWheel wheel)
            : base(color, wheel)
        {

        }
    }
}
