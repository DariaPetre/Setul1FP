namespace Set1_ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());

            if(a > b)
                (a, b) = (b, a);
            if(a>c)
                (a, c) = (c, a);
            if (b > c)
                (b, c) = (c, b);

            Console.WriteLine($"{a} {b} {c}");

        }
    }
}