using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPattern;

namespace Observer
{
    class SpeedMonitor : ISpeedChanged
    {
        public const int SpeedToAlart = 30;
        public SpeedMonitor(Speedometer speed)
        {
            speed.VChanged += ValueHasChanged;
        }

        public void ValueHasChanged(object sender, EventArgs args)
        {
            Speedometer myspeed = (Speedometer)sender;
            if (myspeed.CurrentSpeed > SpeedToAlart)
            {
                Console.WriteLine("**AlERT ** Riding too fast!(" + myspeed.CurrentSpeed + ")");
            }
            else
            {
                Console.WriteLine("nice and steady......(" + myspeed.CurrentSpeed + ")");
            }
        }
    }
}
