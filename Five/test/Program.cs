using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new int[4, 4];

            var n = 0;
            for (int i = 0; i<4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    x[i, j] = n;
                    n++;
                }
            }

            Console.WriteLine();

            Console.Read();
        }
    }
}
