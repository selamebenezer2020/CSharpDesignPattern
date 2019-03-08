using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;
using Singlton;
using Adaptor;
using Decorator;
using Facade;
using Iterator;
using System.Collections;
using Observer;
using Visitor;

namespace CSharpDesignPattern
{
    class Program
    {
        public delegate void Tryon(string type);

        static void Main(string[] args)
        {

            //SingltonPatternDemo();
            //AbstractFactoryDemo();
            // BuilderPatterDemo();
            // AdaptorPatternDemo();
            //DecoratorPatternDemo();
            // FacadePatternDemo();
            //IteratorPatternDemo();
            //IteratorPatternDemo2();
            // observerPatternDemo();
            // VisitorPatternDemo();


        }


        private static void VisitorPatternDemo()
        {
            IWheel wheel = new Narrowheel(24);
            wheel.AcceptVisitor(new WheelDiagnostics());
            wheel.AcceptVisitor(new WheelInventory());
        }
        private static void observerPatternDemo()
        {
            Speedometer myspeedometer = new Speedometer();
            SpeedMonitor monitor = new SpeedMonitor(myspeedometer);
            GearBox gearbox = new GearBox(myspeedometer);

            myspeedometer.CurrentSpeed = 10;
            myspeedometer.CurrentSpeed = 20;
            myspeedometer.CurrentSpeed = 25;
            myspeedometer.CurrentSpeed = 30;
            myspeedometer.CurrentSpeed = 35;


        }
        private static void IteratorPatternDemo2()
        {
            Console.WriteLine("=== Road Bikes ===");
            RoadBikeRange roadrange = new RoadBikeRange();
            foreach (IBicycle bicycle in roadrange.Range)
            {
                Console.WriteLine(bicycle);
            }
        }
        private static void IteratorPatternDemo()
        {
            Console.WriteLine("=== Road Bikes ===");
            RoadBikeRange roadrange = new RoadBikeRange();
            Printiterator(roadrange.GetEnumerator());


            Console.WriteLine("===Mountain Bikes===");
            MountainBikeRange mountainrange = new MountainBikeRange();
            foreach (IBicycle bicycle in mountainrange.Range)
            {
                Console.WriteLine(bicycle);
            }
        }

        private static void Printiterator(IEnumerator iter)
        {
            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
        }
        private static void FacadePatternDemo()
        {
            BikeFacade facade = new BikeFacade();
            facade.PrepareForSale(new Downhill(BikeColor.Red, new Widewheel(20)));

        }
        private static void DecoratorPatternDemo()
        {
            //standard touring bike
            IBicycle myTourBike = new Touring(new Narrowheel(24));
            Console.WriteLine(myTourBike);

            //Touring bike withcustom grip
            myTourBike = new CustomGripOption(myTourBike);
            Console.WriteLine(myTourBike);

            //touring bike with Leatherseat
            myTourBike = new LeatherSheetOption(myTourBike);
            Console.WriteLine(myTourBike);

        }

        private static void AdaptorPatternDemo()
        {
            IList<IWheel> wheel = new List<IWheel>();
            wheel.Add(new Narrowheel(24));
            wheel.Add(new Widewheel(24));
            wheel.Add(new Narrowheel(26));
            wheel.Add(new UltraWheelAdaptor(new UltraWheel(28)));


            foreach (IWheel Wheel in wheel)
            {
                Console.WriteLine(Wheel);
            }


        }

        private static void SingltonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine("next serial" + generator.NextSerial);
            Console.WriteLine("next serial" + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("next serial" + generator.NextSerial);

        }



        private static void BuilderPatterDemo()
        {
            AbstractMountainBike mountainBike = new Downhill(BikeColor.Green, new Widewheel(24));
            BikeBuilder builder = new MountainBikeBuilder(mountainBike);//builde object
            BikeDirector director = new MountainBikeDirector();// diector object
            IBicycle bicycle = director.Build(builder);// interface object
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
