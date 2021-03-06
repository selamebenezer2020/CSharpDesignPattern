﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern
{
    class Touring : AbstractRoadBike
    {
        public override decimal price { get; } = 570.00m;
        public Touring(IWheel wheel)
           : this(BikeColor.Blue, wheel) { }



        public Touring(BikeColor color, IWheel wheel)
            : base(color, wheel) { }


    }
}

