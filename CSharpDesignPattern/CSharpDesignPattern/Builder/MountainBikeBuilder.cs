using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPattern;

namespace Builder
{
    public class MountainBikeBuilder : BikeBuilder
    {
        //class variable 
        //class object of AbstractRoadBike is assigned 
        // property of roadbike used to return an object of IBicle,this object is type of abstractroadBike that implement 
        //the Ibicle interface

        private AbstractMountainBike _mountainBikeInProgress;
        public override IBicycle Bicycle
        {
            get
            {
                return _mountainBikeInProgress;

            }
            // constractor of the class roadbikebuilder that take parmater of Abstractroadbike and 
            //assign that parameter to the class field _roadbikeinprogres

        }
        public MountainBikeBuilder(AbstractMountainBike mountainBike)
        {
            this._mountainBikeInProgress = mountainBike;
        }
        public override void BuildWideTire()
        {
            Console.WriteLine("Building MountainBike Wide Tires");

            //method 
            //public acess modifier 
            //override usded to define its behavior instead of the parent class that it extend 
            //void no return type

        }
        public override void BuildHandleBars()
        {
            Console.WriteLine("Building MountainBike HandleBars");
        }
    }
}
