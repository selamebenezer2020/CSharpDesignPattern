using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractBikeFactory
    {
        //create method has no return
        public abstract IBikeFrame CreateBikeFrame();
        public abstract IBikeSeat CreateBikeSeat();

    }
}
