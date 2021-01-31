using System;

namespace lesson5
{
    class Member
    {
        public Member(string name, int num)
        {
            this.name = name;
            this.num = num;
            this.likes = 0;
            this.unlikes = 0;
        }

        public void like() { this.likes++; }
        public void unlike() { this.unlikes++ ; }
        public string name { get; set; }
        public int num { get; set; }

        public int likes { get; private set; }
        public int unlikes { get; private set; }

    }


    class Program
    {
        static void Main(string[] args)
        { 


            Console.Read();
        }
    }
}
