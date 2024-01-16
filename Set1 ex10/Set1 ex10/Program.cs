namespace Set1_ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(prim(n)) 
            {
                Console.WriteLine("n este prim.");
            }
            else
            {
                Console.WriteLine("n NU este prim.");
            }
           

        }
        static bool prim(int n)
        {
            if (n == 0 || n == 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}