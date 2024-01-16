namespace Set1_ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            float a = float.Parse(Console.ReadLine());

            Console.Write("b=");
            float b = float.Parse(Console.ReadLine());

            float aux;

            aux = a;
            a = b;
            b = aux;

            Console.WriteLine("Rezultat:");
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
        }

    }
}