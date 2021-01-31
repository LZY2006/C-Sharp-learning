using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // double数据类型：16位小数
            double num1 = 3.14159265358979;
            Console.WriteLine("num1={0}",num1);
            // Console.Read();

            // decimal数据类型：金融
            decimal num2 = 12345678987654321;
            Console.WriteLine("num2={0}",num2);

            // int数据类型：整数
            int num3 = 0xff;
            Console.WriteLine("num3={0}", num3);

            // string：字符串
            // char：字符
            string str = "abcdefg";
            char chr = 'a';
            Console.WriteLine("str={0}, chr={1}", str, chr);

            // \a 响铃
            // Console.WriteLine("\a");

            // 用“@”来忽略转义符，用于路径
            Console.WriteLine(@"C:\abc\abc");

            // 转大写
            str = str.ToUpper();
            Console.WriteLine(str);

            // 转换数据类型
            long num4 = 1234567890987654;
            int num5 = 1;
            num5 = (int)num4;
            Console.WriteLine(num4);

            num5 = int.MaxValue;
            Console.WriteLine(num5);

            int num6;
            //checked {
                num6 = num5 + 1;
            //}
            
            Console.WriteLine(num6);

            var sa = Console.ReadLine();
            var sb = Console.ReadLine();

            int ia,ib;
            int.TryParse(sa, out ia);
            int.TryParse(sb, out ib);
            int ic = ia + ib;
            Console.WriteLine(ic);
            Console.WriteLine(ic.ToString());

            // 暂停程序
            Console.Read();
        }
    }
}
