namespace Set1_ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("y1=");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("y2=");
            int y2 = int.Parse(Console.ReadLine());

            int cnt = 0;

            for(int i = y1+1; i <= y2-1; i++)
            {
                bool anBisect = DateTime.IsLeapYear(i);
                if (anBisect)
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);

        }
    }
}