namespace Set1_ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());  
            
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            uint cnt = 0;
            for(int i=a; i<=b; i++) 
            { 
              if(i % n == 0) cnt++;  
            }

            Console.WriteLine($"{cnt} numere din intervalul [a,b] sunt divizibile cu n.");

        }
    }
}