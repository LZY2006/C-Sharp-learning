using System;

class Program
{

    static Action<string> print = s => Console.WriteLine(s);

    static void Main(string[] args)
    {
        print("Hello world!");

        Console.Read();
    }
}