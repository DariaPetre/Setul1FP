using System.Dynamic;
using System.Formats.Asn1;

namespace Set1_ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nr=");
            double nr = Convert.ToDouble(Console.ReadLine());

            string strNr  = Convert.ToString(nr);
            int length = strNr.Length;

            for(int i = length - 1; i >= 0; i--)
            {
                if (strNr[i] != '.')
                  Console.Write($"{strNr[i]} ");
            }

        }
    }
}