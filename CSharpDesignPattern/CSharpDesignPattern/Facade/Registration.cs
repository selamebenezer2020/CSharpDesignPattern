﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPattern;

namespace Facade
{
    public class Registration
    {
        private IBicycle _bicycle;
        public Registration(IBicycle bicycle)
        {
            this._bicycle = bicycle;

        }
        public void AllocateBikeNumber()
        {
            Console.WriteLine("Allocating Bike number");
        }
    }
}
