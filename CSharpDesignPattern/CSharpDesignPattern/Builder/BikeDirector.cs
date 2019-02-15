using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPattern;

namespace Builder
{
    public abstract class BikeDirector
    {
        //public acess modifier
        //abstract -requires child clases to implenent
        //IBicle  return type of method 
        //BikeBuilder- method parameter obj
        //bilder- method parameter obj variable
        public abstract IBicycle Build(BikeBuilder builder);
    }
}
