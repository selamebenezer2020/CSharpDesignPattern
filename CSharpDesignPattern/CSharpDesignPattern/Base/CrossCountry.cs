﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern
{
    class CrossCountry : AbstractMountainBike
    {
        public override decimal price { get; } = 850.00m;
        public CrossCountry(IWheel wheel)
                    : this(BikeColor.Black, wheel)
        {

        }
        public CrossCountry(BikeColor color, IWheel wheel)
            : base(color, wheel)
        {

        }
    }
}
