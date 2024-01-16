namespace Set1_ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int number = random.Next(1,1025);

            bool AiGhicit = false;

            int NrDeIncercari = 0;

            while (!AiGhicit)
            {   
                Console.Write("Ghiceste numarul:");
                int guess = int.Parse(Console.ReadLine());
                NrDeIncercari++;
                Console.WriteLine($"Numarul este mai mare sau egal decat {guess}?");
                if (number > guess)
                    Console.WriteLine("DA");
                else if (number < guess)
                    Console.WriteLine("NU");
                else
                {
                    Console.WriteLine($"Ai Ghicit, numarul este {number}.");
                    Console.WriteLine($"Numarul de incercari este {NrDeIncercari}.");
                    AiGhicit = true;
                }
               
            }

        }
    }
}