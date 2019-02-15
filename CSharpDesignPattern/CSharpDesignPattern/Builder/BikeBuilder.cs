using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPattern;// we need acess to this namespace

namespace Builder
{
    public abstract class BikeBuilder
    {
        //property of IBicycle called bicyle
        public abstract IBicycle Bicycle { get; }

        //virtual keyword used to optionally override in child class and void means no return type

        public virtual void BuildStreetTires() { }
        public virtual void BuildWideTire() { }
        public virtual void BuildHandleBars() { }




    }
}
