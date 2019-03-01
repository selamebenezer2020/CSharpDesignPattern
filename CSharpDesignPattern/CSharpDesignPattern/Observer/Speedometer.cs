using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPattern;

namespace Observer
{
    class Speedometer
    {
        public EventHandler VChanged;
        private int _CurrentSpeed;
        public int CurrentSpeed
        {
            set
            {
                this._CurrentSpeed = value;
                onValueChanged();

            }
            get
            {
                return _CurrentSpeed;
            }
        }
        public Speedometer() { _CurrentSpeed = 0; }
        protected void onValueChanged()
        {
            if (VChanged != null)
            {
                VChanged(this, EventArgs.Empty);
            }
        }
    }
}
