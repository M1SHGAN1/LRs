using System;

namespace Mishgan1
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck1 = new MallardDuck();
            RedHeadDuck duck2 = new RedHeadDuck();

            Duck[] stringArray = new Duck[] { duck1, duck2 };
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i].Display());
                Console.WriteLine(stringArray[i].Swim());
                Console.WriteLine(stringArray[i].Quack());
            }
            Console.ReadKey();


        }
    }

    abstract class Duck
    {
        public string Quack()
        {
            return "Quack" + this.GetType();
        }

        public string Swim()
        {
            return "Swim" + this.GetType();
        }
        public abstract string Display();

    }

    class MallardDuck : Duck
    {
        public override string Display()
        {
            return "Display" + this.GetType();
        }
    }

    class RedHeadDuck : Duck
    {
        public override string Display()
        {
            return "Display" + this.GetType();
        }

    }
}
