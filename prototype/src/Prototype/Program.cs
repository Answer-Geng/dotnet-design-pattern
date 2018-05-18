using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager colorManager = new ColorManager();

            //向原型管理器注册原型
            colorManager["red"] = new Color(255, 0, 0);
            colorManager["green"] = new Color(0, 255, 0);
            colorManager["yellow"] = new Color(0, 0, 255);

            //创建实例
            Color red = colorManager["red"].Clone() as Color;

            //动态注册原型
            Console.WriteLine("Start to register prototype : ");
            Console.WriteLine("Key : ");
            string key = Console.ReadLine();
            Console.WriteLine("RGB[example:255,54,0]:");
            string[] input = Console.ReadLine().Split(',');
            int[] rgb = Array.ConvertAll<string, int>(input, p => int.Parse(p));
            colorManager[key] = new Color(rgb[0], rgb[1], rgb[2]);
            Color myColor = colorManager[key].Clone() as Color;

            Console.ReadLine();
        }
    }
}
