using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;

namespace CSharpDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryDemo();
            BuilderPatterDemo();
        }

        private static void BuilderPatterDemo()
        {
            AbstractMountainBike mountainBike = new Downhill(BikeColor.Green, new Widewheel(24));
            BikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
        }

        private static void AbstractFactoryDemo()
        {
            //parent calss object instance is created by its child class.
            //the parent class can olny see method that is created that its child us. any child types
            //created can not be seen unless it was first created by the parent.



            AbstractBikeFactory factory = new RoadBikeFactory();
            IBikeFrame bikeFrame = factory.CreateBikeFrame();
            //create bike seat method of factory object @return IBikeseat to object bikeseat
            //create the Bike part


            IBikeSeat bikeSeat = factory.CreateBikeSeat();
            //create Bikeseat method of factory object @return IBikeseat to object bikeseat

            // shaow what we created and interface object calls the property Bikeseatparts 
            //bikeseat was created from the class roadseat
            //the propeerty of bikeseatparts uses the get to return the string value from roadseat.
            Console.WriteLine(bikeFrame.BikeFrameParts);// this is properties
            Console.WriteLine(bikeSeat.BikeSeatParts);


        }
    }
}
