using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPattern;

namespace Decorator
{
    public class WhiteTireOptions : AbstractBikeOption
    {
        public override decimal price
        {
            get { return decoratedBike.price + 80.00m; }
        }
        public WhiteTireOptions(IBicycle bicycle)
            : base(bicycle) { }
    }
}
