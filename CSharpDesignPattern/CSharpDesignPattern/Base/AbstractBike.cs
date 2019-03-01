using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern
{
    public abstract class AbstractBike : IBicycle
    {
        private BikeColor _color;
        public IWheel _wheel;

        public BikeColor ColorType
        {
            get
            {
                return _color;

            }
        }
        public IWheel GetWheel
        {
            get
            {
                return _wheel;

            }
        }
        public abstract decimal price { get; }
        public AbstractBike(BikeColor color, IWheel wheel)
        {
            this._wheel = wheel;
            this._color = color;

        }
        public virtual void paint(BikeColor color)
        {
            this._color = color;
        }

        public override string ToString()
        {
            return this.GetType().Name + "Bicyle color is " + _color;
        }

        public virtual void cleanFrame()
        {
            Console.WriteLine("cleaning Frame");
        }

        public virtual void AirTire()
        {
            Console.WriteLine("Airing up Tires");
        }

        public virtual void TestRide()
        {
            Console.WriteLine("Taking bike for a test Ride.....");
        }
    }
}















