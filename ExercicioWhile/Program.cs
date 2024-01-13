using System;

namespace ExercicioWhile // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Posto Tudo Nosso, selecione o combustível que deseja abastecer: 1 - Álcool, 2 - Gasolina, 3 - Diesel ou digite 4 para finalizar. ");
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int escolha = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while(escolha != 4) {
                if(escolha == 1) {
                    alcool++;
                } else if (escolha == 2)
                {
                    gasolina++;
                }else
                {
                    diesel++;
                }

                Console.WriteLine("Caso deseje abastecer novamente, informe o número do combustível: ");
                Console.WriteLine();
                escolha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Muito Obrigado pela preferência, segue relação de abastecimentos: Álcool ({alcool}), Gasolina({gasolina}) e Diesel ({diesel}).");
        }
    }
}