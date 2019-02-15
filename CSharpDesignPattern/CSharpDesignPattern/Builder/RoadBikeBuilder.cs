using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPattern;

namespace Builder
{
    public class RoadBikeBuilder : BikeBuilder
    {
        //class variable 
        //class object of AbstractRoadBike is assigned 
        private AbstractRoadBike _roadBikeInProgress;
        // property of roadbike used to return an object of IBicle,this object is type of abstractroadBike that implement 
        //the Ibicle interface


        public override IBicycle Bicycle
        {
            get
            {
                return _roadBikeInProgress;

            }
            // constractor of the class roadbikebuilder that take parmater of Abstractroadbike and 
            //assign that parameter to the class field _roadbikeinprogres

        }
        public RoadBikeBuilder(AbstractRoadBike roadBike)
        {
            this._roadBikeInProgress = roadBike;
        }
        public override void BuildStreetTires()
        {
            Console.WriteLine("Building RoadBike Street Tires");

            //method 
            //public acess modifier 
            //override usded to define its behavior instead of the parent class that it extend 
            //void no return type

        }
        public override void BuildHandleBars()
        {
            Console.WriteLine("Building RoadBike HandleBars");
        }
    }
}
