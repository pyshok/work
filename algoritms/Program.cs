using System;

namespace algoritms
{
    class Program
    {
        //finding factorial by recursive method
        static int Factorial(int x){
            if (x==0){
                return 1;
            }
            else {
                return x * Factorial(x-1);
            }
        }
         //finding factorial by an interactive method
        static int Fac(int x){
            int res = 1;
            for (int i = 1; i <= x; i++)
            {
                 res = i*res;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fac(6));
            Console.WriteLine(Factorial(6));
            Console.WriteLine("Hello World!");
        }
    }
}
