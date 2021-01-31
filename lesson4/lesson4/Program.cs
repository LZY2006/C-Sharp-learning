using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace lesson4
{
    class Program
    {
        static bool lAdd(List<int> nums, int num, out List<int> result)
        {
            nums.Add(num);
            result = nums;
            return true;
        }

        static int Max(List<int> list)
        {
            int max = list[0];
            foreach(var i in list)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a; a = b; b = temp;
        }

        static int Sum(params int[] nums)
        {
            var sum = 0;
            foreach(var i in nums)
            {
                sum += i;
            }
            return sum;
        }

        static long Fib(long n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                var result = 1;
                for (var i = 2; i <= n; i++)
                {
                    result += i;
                }
                return result;
                //return Fib(n - 1) + Fib(n - 2);
            }
        }

        static long GetFileCount(string path)
        {
            long count = 0;
           
            var files = Directory.GetFiles(path);

            //foreach(var each in files)
            //{
            //    Console.WriteLine(each);
            //}

            var num_files = files.Length;
            count += num_files;

            try
            {
                var dirs = Directory.GetDirectories(path);
                foreach (var each in dirs)
                {
                    // Console.WriteLine(each);
                    count += GetFileCount(each);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            return count;
            
        }

        static int Main(string[] args)
        {

            foreach(var arg in args)
            {
                Console.WriteLine(arg);
            }


            Console.Read();

            return 0;
        }

    }
}
