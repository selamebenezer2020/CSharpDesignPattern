using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MountainBikeFactory : AbstractBikeFactory
    {
        public override IBikeFrame CreateBikeFrame()
        {
            return new MountainFrame();
        }

        public override IBikeSeat CreateBikeSeat()
        {
            return new MountainSeat();
        }
    }
}
