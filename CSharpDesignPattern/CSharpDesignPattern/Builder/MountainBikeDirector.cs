﻿using CSharpDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Builder
{
    public class MountainBikeDirector : BikeDirector

    {
        public override IBicycle Build(BikeBuilder builder)
        {
            builder.BuildHandleBars();
            builder.BuildWideTire();
            return builder.Bicycle;
        }
    }
}
