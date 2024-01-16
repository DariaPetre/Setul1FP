namespace Set1_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            float a = float.Parse(Console.ReadLine());

            Console.Write("b=");
            float b = float.Parse(Console.ReadLine());

            Console.Write("c=");
            float c = float.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine("Valorile a,b,c pot reprezenta lungimile laturilor unui triunghi.");
            }
            else
            {
                Console.WriteLine("Valorile a,b,c NU pot reprezenta lungimile laturilor unui triunghi.");
            }
        }
    }
}