﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPattern;


namespace Adaptor
{
    class UltraWheelAdaptor : AbstractWheel
    {
        public UltraWheelAdaptor(UltraWheel ultraWheel)
                : base(ultraWheel.WheelSize, false)
        {

        }
    }
}
