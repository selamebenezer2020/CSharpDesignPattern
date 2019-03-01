using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPattern;

namespace Iterator
{
    public class RoadBikeRange
    {

        private IList<IBicycle> _bicycles;

        public virtual IList<IBicycle> Range
        {
            get { return _bicycles; }

        }
        public RoadBikeRange()
        {
            _bicycles = new List<IBicycle>();
            _bicycles.Add(new Touring(new Narrowheel(24)));
            _bicycles.Add(new Touring(BikeColor.Blue, new Narrowheel(24)));
            _bicycles.Add(new Touring(BikeColor.Green, new Narrowheel(26)));
            _bicycles.Add(new Vintage(new Narrowheel(24)));
            _bicycles.Add(new Vintage(BikeColor.Red, new Narrowheel(22)));


        }
        public virtual IEnumerator<IBicycle> GetEnumerator()
        {
            return _bicycles.GetEnumerator();
        }
    }

}
