namespace Set1_ex5
{
    internal class Program
    {   //a k cifra din nr n 
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n=int.Parse(Console.ReadLine());

            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());

            while (k > 1)
            {
                k--;
                n /= 10;
            }
            Console.WriteLine($"{n % 10}");

        }
    }
}