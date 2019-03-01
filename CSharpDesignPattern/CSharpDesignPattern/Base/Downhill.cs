using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern
{
    class Downhill : AbstractMountainBike
    {
        public override decimal price { get; } = 870.00m;
        public Downhill(IWheel wheel)
            : this(BikeColor.Green, wheel) { }



        public Downhill(BikeColor color, IWheel wheel)
            : base(color, wheel) { }



    }
}
