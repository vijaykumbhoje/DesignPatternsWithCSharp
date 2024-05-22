using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private int counter = 0;
        private static Singleton singleton = null;

        private static readonly object obj = new object();

        private Singleton() 
        {
            counter++;
            Console.WriteLine(counter);
        }

        public static Singleton GetInstance()
        {
            if (singleton == null)
            {
                lock (obj)
                {
                    if (singleton == null)
                    {
                        singleton = new Singleton();
                    }
                }
            }
            return singleton;
        }
    }
}
