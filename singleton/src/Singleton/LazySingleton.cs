using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class LazySingleton
    {
        private static LazySingleton instance;
        private static readonly object syncRoot = new object();
        private LazySingleton()
        {

        }

        public static LazySingleton Instance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new LazySingleton();
                    }
                }
            }
            return instance;
        }
    }
}
