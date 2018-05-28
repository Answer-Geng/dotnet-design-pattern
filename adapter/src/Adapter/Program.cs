using System;
namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            (new PluggableAdapter(dog.Bark)).MakeSound();
            Console.ReadLine();
        }
    }
}
