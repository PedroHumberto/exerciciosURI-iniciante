/*Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. 
A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:
se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES

Entrada
A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).

Saída
Imprima todas as classificações do triângulo especificado na entrada.
*/

using System;

namespace URI1045
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] triangulo = Console.ReadLine().Split(' ');
            float n1, n2, n3, A, B, C;

            n1 = float.Parse(triangulo[0]);
            n2 = float.Parse(triangulo[1]);
            n3 = float.Parse(triangulo[2]);

            if (n1 > n2 && n1 > n3)
            {   
                // "A" tem de ser o maior lador, neste caso o "if" e "else" entra para decidir qual sera o valor atribuido B ou C
                A = n1;
                if (n2 > n3)
                {
                    B = n2;
                    C = n3;

                }

                else
                {
                    B = n3;
                    C = n2;
                }

            }
            else if (n2 > n3)
            {   
                A = n2;
                if (n1 > n3)
                {
                    B = n1;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n1;
                }
            }
            else
            {
                A = n3;
                if (n1 > n2)
                {
                    B = n1;
                    C = n2;

                }
                else
                {
                    B = n2;
                    C = n1;
                }
            }



            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                // Teste de 3 possibilidades referente ao angulo
                if (Math.Pow(A,2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                // Teste equilatero ou isoceles
                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");

                }

<<<<<<< HEAD

=======
>>>>>>> 00ac79b91eef7e40e0a1345dee9aa94db458e7f5
            }
        }
    }
}
