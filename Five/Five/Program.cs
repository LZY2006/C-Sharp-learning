using System;
using System.Diagnostics;

namespace Five
{

    public class Surface
    {

        public int[,] array { get;  set; }
        public int width { get; set; }
        public int height { get; set; }
        public int next { get; set; }

        public Surface(int width, int height)
        {
            this.array = new int[width, height];
            this.width = width;
            this.height = height;

            this.next = 2;

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    this.array[i, j] = 0;
        }

        public void print()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(this.array[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void White(int x, int y)
            //白色是1， 黑色是2
        {
            try
            {
                Debug.Assert(this.array[x, y] == 0);
                Debug.Assert(this.next == 1);
            }
            catch (System.IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            this.array[x, y] = 1;

            this.next = 2;
        }
        public void Black (int x, int y)
        //白色是1， 黑色是2
        {
            try
            {
                Debug.Assert(this.array[x, y] == 0);
                Debug.Assert(this.next == 2);
            }
            catch (System.IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            this.array[x, y] = 2;

            this.next = 1;

        }

        public int CheckForWin()
            // 白色是1，黑色是2，没有是0
        {
            // 0 0 0 0 
            for (int i = 0; i < this.width; i++)
            {
                for (int j = 0; (j + 3) <= this.height; j++)
                {
                    if (this.array[i, j + 0] != 0 &&
                        this.array[i, j + 1] != 0 &&
                        this.array[i, j + 2] != 0)
                        if (this.array[i, j + 0] ==
                        this.array[i, j + 1] && this.array[i, j + 1] ==
                        this.array[i, j + 2])
                            return this.array[i, j + 0];

                }
            }
            for (int j = 0; j < this.width; j++)
            {
                for (int i = 0; (i + 3) <= this.height; i++)
                {
                    if (this.array[i + 0, j ] != 0 &&
                        this.array[i + 1, j ] != 0 &&
                        this.array[i + 2, j ] != 0)
                        if (this.array[i + 0, j] ==
                        this.array[i + 1, j ] && this.array[i + 1, j ] ==
                        this.array[i + 2, j ])
                            return this.array[i, j + 0];

                }
            }

            return 0;
        }


    }

    class Program
    {

        static void AutoPlay(Surface sur, bool isWhite, bool isWhiteBase, int x, int y, out int X, out int Y)
        {

            if (isWhite)
                sur.White(x, y);
            else
                sur.Black(x, y);

            int outX, outY;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (sur.array[i, j] == 0)
                    {
                        
                        AutoPlay(sur, !isWhite, isWhite, i, j,out outX, out outY);
                        if (outX != -1)
                        {
                            X = x;
                            Y = y;
                            // Console.WriteLine("return");
                            return;
                        }
                    }
                }
            }

            int N;
            if (isWhite)
                N = 2;
            else
                N = 1;

            

            if (sur.CheckForWin() == N)
            {
                X = x;
                Y = y;
                // Console.WriteLine("below");
                // Console.WriteLine("{0} {1}", x, y);
                sur.print();
            }
            else
            {
                X = -1;
                Y = -1;
            }
        }

        static void Main(string[] args)
        {
            Surface x = new Surface(4, 4);

            x.Black(0,0);

            x.print();

            int px, py;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    AutoPlay(x, true, true, i,j,out px,out py);
                    if (px != -1)
                    {
                        goto b;
                    }
                }
            }
            b:;
            Console.Write(px);
            Console.Write(" ");
            Console.Write(py);

            Console.Read();
        }
    }
}
