namespace Set1_ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            int copiaLuiN = n;
           
            int nr = 0;

            while( copiaLuiN > 0 )
            {
                int c = copiaLuiN % 10;
                copiaLuiN /= 10;
                nr = nr * 10 + c;
                
            }
             
            if ( nr == n)
            {
                Console.WriteLine("n este palindrom.");
            }
            else
            {
                Console.WriteLine("n NU este palindrom.");
            }
        }
    }
}