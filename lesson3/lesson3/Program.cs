using System;

namespace lesson3
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 膜运算（不是）
            int a = 10 % 3;
            Console.WriteLine(a);


            // 常量
            const int b = 233;
            // b = 666;
            Console.WriteLine(b);


            // 判断分支
            Console.Write("输入a:");
            string x = Console.ReadLine();
            Console.Write("输入b:");
            string y = Console.ReadLine();

            int na, nb;
            if (!int.TryParse(x, out na))
            {
                Console.WriteLine("Error.");
                Console.Read();
                return;
            }
            if (!int.TryParse(y, out nb))
            {
                Console.WriteLine("Error.");
                Console.Read();
                return;
            }

            Console.WriteLine("a+b={0}",na+nb);

            // 判断分支
            if (na > 10)
            {
                Console.WriteLine("a > 10");
            }
            else if (na == 10)
            {
                Console.WriteLine("a == 10");
            }
            else
            {
                Console.WriteLine("a < 10");
            }
            // switch分支
            switch (a)
            {
                case 1: Console.WriteLine("数字 1");break;
                case 2: Console.WriteLine("数字 2"); break;
                default: Console.WriteLine("#unknow");break;
            }

            // 输入
            Console.Read();
        }
    }
}
