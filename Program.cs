using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumb = 5;
            int secNumb = 10;

            int sum = Getsum(firstNumb, secNumb);

            Console.WriteLine(sum);

        }

        private static int Getsum(int first, int sec)
        {
            return first + sec;
        }

        //Methods we reuse the code, make the code better readable, 
        // better maitainability, devide the big problem into small
        // problems.
    }
}
