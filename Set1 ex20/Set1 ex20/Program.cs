namespace fractie
{
    internal class Program
    {
        /// <summary>
        /// Afisati fractia m/n in format zecimal, 
        /// cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3)
        /// </summary>

        /*     Parte Intreaga:0
                  13 / 30 = 0 (r 13)

               Parte fractionara:4(3)
                  r * 10 / numitor
                  130 / 30 = 4 r 10
                  100 / 30 = 3 r 10
                  100 / 30 = 3 r 10 

         */


        static void Main(string[] args)
        {
            Console.Write("Introduceti numaratorul fractiei:");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Introduceti numitorul fractiei:");
            int n = int.Parse(Console.ReadLine());


            int parteIntreaga = m / n;
            int parteFractionara = m % n;
            Console.Write($"{parteIntreaga},");


            int cifra, rest;

            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();

            resturi.Add(parteFractionara);

            bool periodic = false;


            do
            {
                cifra = parteFractionara * 10 / n;
                cifre.Add(cifra);

                rest = parteFractionara * 10 % n;
                if (!resturi.Contains(rest))//daca se intalneste un rest egal cu un rest anetrior atunci fractia este periodica
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFractionara = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }

        }

    }
}