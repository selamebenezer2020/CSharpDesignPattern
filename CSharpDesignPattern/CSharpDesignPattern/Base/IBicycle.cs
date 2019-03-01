using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern
{
    public interface IBicycle
    {
        IWheel GetWheel { get; }
        BikeColor ColorType { get; }

        decimal price { get; }
        void paint(BikeColor color);
        void cleanFrame();
        void AirTire();
        void TestRide();
    }
}
