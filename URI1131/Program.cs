using System;

namespace URI1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int grenais, empate, vitinter, vitgremio;

            vitgremio = 0; 
            vitinter = 0;
            empate = 0;
            grenais = 1;
            while (grenais == 1) {
                string[] vet = Console.ReadLine().Split(' ');
                int golinter = int.Parse(vet[0]);
                int golgremio = int.Parse(vet[1]);
                

                if (golgremio > golinter) {
                    vitgremio += 1;
                }
                else if (golinter > golgremio) {
                    vitinter += 1; 
                }
                else {
                    empate += 1;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                grenais = int.Parse(Console.ReadLine());
            }
            int total = vitgremio + vitinter + empate;

            Console.WriteLine(total + " grenais");
            Console.WriteLine("Inter: " + vitinter);
            Console.WriteLine("Gremio: " + vitgremio);
            Console.WriteLine("Empates: " + empate);
            if (vitinter > vitgremio) {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitgremio > vitinter) {
                Console.WriteLine("Gremio venceu mais");
            }
            else if (vitgremio == vitinter) {
                Console.WriteLine("Nao houve vencedor");

            }

        }
    }
}
