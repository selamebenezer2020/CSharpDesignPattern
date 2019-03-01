using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton
{
    public class SerialNumberGenerator
    {
        //private -acess modifier that restrict access to the class only
        //static - no instance of this variable are created its olnly1 
        //violtile= refer MS document

        private static volatile SerialNumberGenerator instance;// class name variable

        private static object synchronizationRoot = new object();

        private int _count = 12345;//serial number

        public static SerialNumberGenerator Instance //
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        }
                    }



                }
                return instance;
            }
        }
        private SerialNumberGenerator() { }
        public int NextSerial
        {
            get { return ++_count; }
        }
    }
}
