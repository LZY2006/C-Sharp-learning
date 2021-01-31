using System;

namespace lesson6
{

    interface IFly
    {
        void fly();
    }

    abstract class Animal
    {
        public Animal(string name)
        {
            this.name = name;
        }
        public string name { get; set; }
        public int age { get; set; }

        public abstract void shout();
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override void shout()
        {
            Console.WriteLine("Wolf.");
        }
    }

    class Fly : Animal, IFly
    {
        public Fly(string name) : base(name) { }
        public void fly()
        {
            Console.WriteLine("我会飞！！！");
        }

        public override void shout()
        {
            Console.WriteLine("嗡嗡嗡");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var fly = new Fly("张三");
            fly.fly();

            Console.Read();
        } 
    }
}
