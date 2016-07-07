using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    interface Animal
    {
        void SaySomething();
    }

    public class Cat : Animal
    {
        public void SaySomething()
        {
            Console.WriteLine("Miao..");
        }
    }


    public class Dog : Animal
    {
        public void SaySomething()
        {
            Console.WriteLine("Woef..");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            Animal dog = new Dog();

            Animal[] AnimalArray = { cat, dog };
            loopThroughAnimals(AnimalArray);
            Console.ReadLine();

        }

        static void loopThroughAnimals(Animal[] AnimalArray)
        {
            for (int i = 0; i < AnimalArray.Length; i++)
            {
                AnimalArray[i].SaySomething();
            }

        }
    }
}
