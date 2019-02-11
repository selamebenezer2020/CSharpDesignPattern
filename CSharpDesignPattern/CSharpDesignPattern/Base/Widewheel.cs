using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern
{
    public class Widewheel : AbstractWheel

    {
        public Widewheel(int size) : base(size, true)
        { }
    }

}
