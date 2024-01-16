using System;
namespace Set1_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //*******~  y este an bisect?  ~******
           int y = Convert.ToInt32(Console.ReadLine());
            bool anBisect = DateTime.IsLeapYear(y);
            if (anBisect)
            {
                Console.WriteLine("y este an bisect.");
            }
            else
            {
                Console.WriteLine("y NU este an bisect.");
            }

        }
    }
}