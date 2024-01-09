using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Basic
{
    public class Singleton
    {
        private static Singleton instance;
        public Singleton()
        {
            
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        // Other methods or properties of the Singleton class can be added here.
    }
}
