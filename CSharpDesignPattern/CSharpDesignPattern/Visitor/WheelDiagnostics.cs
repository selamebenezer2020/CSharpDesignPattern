using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPattern;

namespace Visitor
{
    public class WheelDiagnostics : IWheelVisitor
    {
        public void Visit(IWheel wheel)
        {
            Console.WriteLine("Diagnostics the wheel");
        }

        public void Visit(Spokes spokes)
        {
            Console.WriteLine("Diagnosing the Spokes");
        }

        public void Visit(Bearings bearings)
        {
            Console.WriteLine("Diagnosing the bearing");
        }
    }
}
