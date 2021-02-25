using System;
using System.Globalization;

namespace URI1010_VETOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split(' ');
            int codigo = int.Parse(peca1[0]);
            int qt = int.Parse(peca1[1]);
            double valor = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            string[] peca2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(peca2[0]);
            int qt2 = int.Parse(peca2[1]);
            double valor2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double soma = valor * qt + valor2 * qt2;

            Console.WriteLine("VALOR A PAGAR: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
