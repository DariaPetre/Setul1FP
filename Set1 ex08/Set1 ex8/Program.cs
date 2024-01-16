namespace Set1_ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            float a = float.Parse(Console.ReadLine());

            Console.Write("b=");
            float b = float.Parse(Console.ReadLine());

            (a, b) = (b, a);
            Console.WriteLine("Rezultat:");
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
        }
    }
}