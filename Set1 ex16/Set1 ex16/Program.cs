using System.Threading.Tasks.Dataflow;

namespace Set1_ex16
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

            Console.Write("d=");
            int d = int.Parse(Console.ReadLine());

            Console.Write("e=");
            int e = int.Parse(Console.ReadLine());

            if(a > b) (a, b) = (b, a);
            if(a > c) (a, c) = (c, a);
            if(a > d) (a, d) = (d, a);
            if(a > e) (a, e) = (e, a);
            if(b > c) (b, c) = (c, b);
            if(b > d) (b, d) = (d, b);
            if(b > e) (b, e) = (e, b);
            if(c > d) (c, d) = (d, c);
            if(c > e) (c, e) = (e, c);
            if(d > e) (d, e) = (e, d);

            Console.WriteLine($"{a} {b} {c} {d} {e}");


        }
    }
}