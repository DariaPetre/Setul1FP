using System;
namespace Set1_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*******~  y este an bisect?  ~******
            Console.Write("y=");
           int y = Convert.ToInt32(Console.ReadLine());
           
            if (esteBisect(y))
                Console.WriteLine("y este an bisect.");
            else
                Console.WriteLine("y NU este an bisect.");

        }

        private static bool esteBisect(int y)
        {
            if((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
                return true;
            else
                return false;
        }
    }
}
