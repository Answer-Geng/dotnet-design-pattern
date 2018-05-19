using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        //静态变量instance保存唯一实例
        private static Singleton instance;

        //私有化构造函数，保证唯一实例的受控访问
        private Singleton()
        {

        }

        //提供访问该实例的静态方法
        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
