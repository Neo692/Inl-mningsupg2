using System;

namespace Inlämningsupg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin i meter?");
            int Elin = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt hoppade Alma i meter?");
            int Alma = int.Parse(Console.ReadLine());

            int svar = Elin - Alma;
            Console.WriteLine("Elin hoppade " + svar + " meter högre än Alma");
        }
    }
}
