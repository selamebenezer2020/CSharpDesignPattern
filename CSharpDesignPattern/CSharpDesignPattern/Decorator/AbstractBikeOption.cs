﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPattern;

namespace Decorator
{
    public abstract class AbstractBikeOption : AbstractBike
    {
        protected internal IBicycle decoratedBike;

        public AbstractBikeOption(IBicycle bicycle)
            : base(BikeColor.Chrome, bicycle.GetWheel)
        {
            this.decoratedBike = bicycle;
        }
    }
}
