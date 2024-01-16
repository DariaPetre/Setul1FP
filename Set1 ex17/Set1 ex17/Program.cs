
namespace Set1_ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            int CopiaLuia = a;

            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int CopiaLuib = b;
            while (b > 0) 
            {
                int r = a % b;
                a = b;
                b = r;
            }

            int cmmdc = a;
            int cmmmc = (CopiaLuia * CopiaLuib) / cmmdc;

            Console.WriteLine($"cmmdc={cmmdc} cmmmc={cmmmc}");
        }
    }
}