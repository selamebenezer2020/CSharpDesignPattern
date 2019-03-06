using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;
namespace CSharpDesignPattern
{
    public abstract class AbstractWheel : IWheel
    {
        private int _size;
        private bool _isWide;
        private Spokes _Spokes;
        private Bearings _bearings;

        public int size
        {
            get
            {
                return _size;
            }
        }
        public bool isWide
        {
            get
            {
                return _isWide;
            }
        }

        public AbstractWheel(int size, bool isWide)
        {
            this._size = size;
            this._isWide = isWide;
            _Spokes = new Spokes();
            _bearings = new Bearings();
        }

        public virtual void AcceptVisitor(IWheelVisitor visitor)
        {
            _Spokes.AcceptVisitor(visitor);
            _bearings.AcceptVisitor(visitor);
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return this.GetType().Name + "with a wheel size of " + _size + "inches";
        }



    }
}
