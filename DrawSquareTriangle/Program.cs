using System;

namespace DrawSquareTriagle
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Input Length:");
            int x = Convert.ToInt32(Console.ReadLine());
            State1(x);
            Console.WriteLine();
            State2(x);
            Console.WriteLine();
            State3(x); 
            Console.WriteLine();
            State4(x);
            Console.WriteLine();

        }

        private static void State1 (int x)
        {
            int tempx=1;
            for (int i=0; i<x; i++)
            {
                for (int j = 0; j < tempx; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
                tempx++;
            }
            return;
        }

        private static void State2 (int x)
        {
            int tempx = x;
            for(int i=0; i<x;i++)
            {
                for( int j = 0; j < tempx; j++)
                {
                    Console.Write("* ");
                }
                tempx--;
                Console.Write("\n");
            }
        }

        private static void State3 (int x)
        {
            int tempx = x;
            int tempy = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < tempy; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < tempx; j++)
                {
                    Console.Write("* ");
                }
                tempx--;
                tempy++;
                Console.Write("\n");
            }
        }

        private static void State4 (int x)
        {
            int tempx = 1;
            int tempy = x;
            for (int i = 0; i < x; i++)
            {
                for (int j = 1; j < tempy; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < tempx; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
                tempx++;
                tempy--;
            }
            return;
        }
    }
}