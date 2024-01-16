namespace Set1_ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            
            int[] a = new int[10];

            while (n > 0)
            {
                int c = n % 10;
                a[c] = 1;
                n /= 10;
            }

            int cnt = 0;
            for (int i = 0; i <= 9; i++)
            {
                if (a[i] == 1)
                    cnt++;
            }
            if (cnt == 2)
                Console.WriteLine("Numarul contine exact doua cifre care se pot repeta.");
            else
                Console.WriteLine("Numarul NU contine exact doua cifre care se pot repeta.");
            
        }
    }
}