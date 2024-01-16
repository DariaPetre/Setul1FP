
namespace Set1_ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            int FactorPrim = 2;

            while (n > 1) 
            {
                int exponent = 0;
                while ( n % FactorPrim == 0 )
                {
                    exponent++;
                    n /= FactorPrim;
                }

                if ( exponent != 0 )
                   Console.Write($"{FactorPrim}^{exponent}");

                if (n > 1 && exponent !=0 ) Console.Write("x");

                FactorPrim++;
                
            }
        }
    }
}