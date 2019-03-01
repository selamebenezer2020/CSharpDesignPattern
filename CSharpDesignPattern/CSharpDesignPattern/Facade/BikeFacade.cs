﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPattern;

namespace Facade
{
    public class BikeFacade
    {
        public void PrepareForSale(IBicycle bicycle)
        {
            Registration reg = new Registration(bicycle);
            reg.AllocateBikeNumber();

            Documentation.PrintBrochure(bicycle);

            bicycle.cleanFrame();
            bicycle.AirTire();
            bicycle.TestRide();
        }
    }
}
