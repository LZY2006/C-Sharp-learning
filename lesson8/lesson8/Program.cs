using System;
using System.Collections.Generic;

namespace lesson8
{

    class Person
    {
        public string name { get; private set; }
        public int age { get; private set; }
        public bool alive { get; private set; }

        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
            this.alive = true;
        }

        public void OneMoreYear()
        {
            this.age++;
        }

        public void die()
        {
            this.alive = false;
        }

        public void send(Publisher sender)
        {
            Console.WriteLine("{0}岁的人收到报纸", this.age);
        }

    }
    
    class Publisher
    {
        public string name { get; private set; }
        public int age { get; private set; }

        public Publisher(string name)
        {
            this.name = name;
            this.age = 0;
        }
    }

    class Program
    {

        // Func<input, output>
        // Action<input> 不返回
        // Predicate<> 返回bool
        

        //static Action<string> print = s => Console.WriteLine(s);
        //static Action<string> printf = s => Console.WriteLine(s);

        //static Action<string> print_printf = print + printf;

        static void Main(string[] args)
        {
            #region 生成人和出版社的列表
            List<Person> lPerson = new List<Person>();
            List<Publisher> lPublisher = new List<Publisher>();
            #endregion

            #region 初始化循环条件
            Random r = new Random();
            int year = 0;
            #endregion

            while (true)
            {
                var ps = new Person("#unknow", r.Next(1, 100));
                lPerson.Add(ps);

                if (year % 10 == 0)
                {
                    var pr = new Publisher("#unknow");
                    lPublisher.Add(pr);
                }

                foreach (var item in lPublisher)
                {
                    foreach (var person in lPerson)
                    {
                        if (person.alive)
                            person.send(item);
                    }
                }

                foreach (var item in lPerson)
                {
                    if (item.age >= 100)
                    {
                        item.die();
                    }
                    else
                    {
                        item.OneMoreYear();
                    }
                }

                year++;

            }

            Console.Read();

        }
    }
}
